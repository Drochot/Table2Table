// Initializes _Layout.cshtml navigation menu
document.addEventListener('DOMContentLoaded', function () {
    var elems = document.querySelectorAll('.sidenav');
    var instances = M.Sidenav.init(elems, {});
});

// Initializes Home/Index.cshtml carousel
document.addEventListener('DOMContentLoaded', function () {
    var elems = document.querySelectorAll('.carousel');
    var instances = M.Carousel.init(elems, {
        "fullWidth": true,
        "indicators": true
    });
});
