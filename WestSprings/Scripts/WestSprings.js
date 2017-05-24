console.log('Ready');

$("#slideshow > div:gt(0)").hide();

setInterval(function () {
    $('#slideshow > div:first')
      .fadeOut(1000)
      .next()
      .fadeIn(1000)
      .end()
      .appendTo('#slideshow');
}, 5000);

function parallax() {
    var scrolled = $(window).scrollTop();
    $('#background').css('top', -(scrolled * 2) + 'px');
    $('#programs').css('top', -(scrolled * 0.2) + 'px')
}

$(window).scroll(function (e) {
    parallax();
})  