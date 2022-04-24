var State;
(function (State) {
    State[State["Active"] = 0] = "Active";
    State[State["InActive"] = 1] = "InActive";
    State[State["Deleted"] = 2] = "Deleted";
    State[State["Postponed"] = 3] = "Postponed";
})(State || (State = {}));
var Test1 = /** @class */ (function () {
    function Test1() {
    }
    Test1.prototype.show = function () {
        var data = Object.keys(State);
        data.forEach(function (e) {
            console.log(e);
        });
        alert("Done");
    };
    return Test1;
}());
