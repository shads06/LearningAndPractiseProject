enum State{
    Active = 0,
    InActive = 1,
    Deleted = 2,
    Postponed = 3
}

class Test1{
    show(){
        var data = Object.keys(State);
        data.forEach(e => {
            console.log(e);
        });
        alert("Done");
    }
}