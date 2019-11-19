// Turn off ESLint (Windows): Tools - Options - Text Editor - Javascript - Linting
$(function () {
    getProducts()
    function getProducts() {
        var id = $('#product_rows').data('id');
        var discontinued = $('#Discontinued').prop('checked') ? "" : "/discontinued/false";
        var allProducts = [];
        var allProductStocks = [];
        var randomColors = [];
        $.getJSON({
            url: "../../api/category/" + id + "/product" + discontinued,
            success: function (response, textStatus, jqXhr) {
                //console.log(response);
                $('#product_rows').html("");

                for (var i = 0; i < response.length; i++) {
                    var css = response[i].discontinued ? " class=\"discontinued\"" : "";
                    var row = "<tr" + css + " data-id=\"" + response[i].productId + "\" data-name=\"" + response[i].productName + "\" data-price=\"" + response[i].unitPrice + "\">"
                        + "<td>" + response[i].productName + "</td>"
                        + "<td class=\"text-right\">$" + response[i].unitPrice.toFixed(2) + "</td>"
                        + "<td class=\"text-right\">" + response[i].unitsInStock + "</td>"
                        + "</tr>";
                    $('#product_rows').append(row);
                    allProducts[i] = response[i].productName;
                    allProductStocks[i] = response[i].unitsInStock;

                    var r = Math.floor(Math.random() * 255);
                    var g = Math.floor(Math.random() * 255);
                    var b = Math.floor(Math.random() * 255);
                    color = 'rgb(' + r + ', ' + g + ', ' + b + ')';
                    randomColors[i] = color;
                }

                var ctx = document.getElementById('myChart').getContext('2d');
                var myChart = new Chart(ctx, {
                    type: 'pie',
                    data: {
                        labels: allProducts,
                        datasets: [{
                            label: 'Product',
                            data: allProductStocks,
                            fill: false,
                            borderWidth: 1
                        }]
                    },
                    options: {
                        title: {
                            display: true,
                            text: 'Unit Stock Distribution',
                            fontSize: 20
                        },
                        plugins: {
                            colorschemes: {
                                scheme: 'brewer.RdYlBu10'
                            }
                        }
                    }
                });
            },
            error: function (jqXHR, textStatus, errorThrown) {
                // log the error to the console
                console.log("The following error occured: " + textStatus, errorThrown);
            }
        });
        console.log(allProducts);
    }

    $('#CategoryId').on('change', function () {
        clearCharty();
        $('#product_rows').data('id', $(this).val());
        getProducts();
    });

    $('#Discontinued').on('change', function () {
        getProducts();
    });

    // delegated event listener
    $('#product_rows').on('click', 'tr', function () {
        // make sure a customer is logged in
        if ($('#User').data('customer').toLowerCase() == "true") {
            $('#ProductId').html($(this).data('id'));
            $('#ProductName').html($(this).data('name'));
            $('#UnitPrice').html($(this).data('price').toFixed(2));
            // calculate and display total in modal
            $('#Quantity').change();
            $('#cartModal').modal();
        } else {
            toast("Access Denied", "You must be signed in as a customer to access the cart.");
        }
    });

    // update total when cart quantity is changed
    $('#Quantity').change(function () {
        var total = parseInt($(this).val()) * parseFloat($('#UnitPrice').html());
        $('#Total').html(numberWithCommas(total.toFixed(2)));
    });

    // function to display commas in number
    function numberWithCommas(x) {
        return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
    }

    $('#addToCart').on('click', function () {
        $('#cartModal').modal('hide');
        // AJAX to update database
        $.ajax({
            headers: { "Content-Type": "application/json" },
            url: "../../api/addtocart",
            type: 'post',
            data: JSON.stringify({
                "id": $('#ProductId').html(),
                "email": $('#User').data('email'),
                "qty": $('#Quantity').val()
            }),
            success: function (response, textStatus, jqXhr) {
                // success
                toast("Product Added", response.product.productName + " successfully added to cart.");
            },
            error: function (jqXHR, textStatus, errorThrown) {
                // log the error to the console
                toast("Error", "Please try again later.");
                console.log("The following error occured: " + jqXHR.status, errorThrown);
            }
        });
    });

    function toast(header, message) {
        $('#toast_header').html(header);
        $('#toast_body').html(message);
        $('#cart_toast').toast({ delay: 2500 }).toast('show');
    }

    //function to clear the canvas
    function clearCharty() {
        $('.chart-container').html('<canvas id="myChart" width="400" height="400"></canvas>')
    }
});