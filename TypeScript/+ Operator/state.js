var Test1 = /** @class */ (function () {
    function Test1() {
    }
    Test1.prototype.show = function () {
        var p = "0";
        console.log(typeof p);
        console.log(typeof +p);
        alert("Done");
    };
    return Test1;
}());
