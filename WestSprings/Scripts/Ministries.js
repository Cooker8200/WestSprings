console.log("Ministries Script");

$(document).ready(function () {
    $("#ministries_kids").click(function () {
        window.scroll(0, findPos(document.getElementById('kids')));
    })
})