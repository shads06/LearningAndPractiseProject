var labels = [];
var datasets = [];

var ctx = document.getElementById('myChart');

// IMPLEMENTATION 1
// var subjects = ["Hindi", "English", "Maths", "Science", "Arts", "Computers", "Spanish"];
// labels = subjects;
// var marks = [
//     {
//         name: "Aman",
//         marks: [90, 83, 71, 1, 39, 60, 34]
//     },
//     {
//         name: "Ashish",
//         marks: [5, 54, 27, 11, 62, 21, 82]
//     },
//     {
//         name: "Manisha",
//         marks: [26,59,58,78,31,94,73]
//     },
//     {
//         name: "Rashmi",
//         marks: [90,61,31,5,74,77,95]
//     },
//     {
//         name: "Abhishek",
//         marks: [85,6,48,20,4,57,61]
//     }
// ]
// datasets = marks;
// const myChart = new Chart(ctx, {
//     type: "bar",
//     data: {
//         labels: labels,
//         datasets: [
//             {
//                 data: datasets[0].marks,
//                 label: datasets[0].name,
//                 backgroundColor: 'rgb(255, 99, 132)',
//                 borderColor: 'rgb(245, 245, 245)'
//             },
//             {
//                 data: datasets[1].marks,
//                 label: datasets[1].name,
//                 backgroundColor: 'rgb(123, 245, 99)',
//                 borderColor: 'rgb(245, 245, 245)'
//             },
//             {
//                 data: datasets[2].marks,
//                 label: datasets[2].name,
//                 backgroundColor: 'rgb(45, 23, 99)',
//                 borderColor: 'rgb(245, 245, 245)'
//             },
//             {
//                 data: datasets[3].marks,
//                 label: datasets[3].name,
//                 backgroundColor: 'rgb(110, 05, 150)',
//                 borderColor: 'rgb(245, 245, 245)'
//             },
//             {
//                 data: datasets[4].marks,
//                 label: datasets[4].name,
//                 backgroundColor: 'rgb(5, 125, 234)',
//                 borderColor: 'rgb(245, 245, 245)'
//             },
//         ]
//     }
// });











// IMPLEMENTATION 2
// var subjects = ["Hindi", "English", "Maths", "Science", "Arts", "Computers", "Spanish"];
// labels = subjects;
// var marks = [
//     {
//         name: "Unit Test 2",
//         marks: [90, 83, 71, 1, 39, 60, 34]
//     },
//     {
//         name: "Unit Test 1",
//         marks: [5, 54, 27, 11, 62, 21, 82]
//     },
// ]
// datasets = marks;

// const myChart = new Chart(ctx, {
//     type: "bar",
//     data: {
//         labels: labels,
//         datasets: [
//             {
//                 data: datasets[0].marks,
//                 label: datasets[0].name,
//                 backgroundColor: 'rgb(255, 99, 132)',
//                 borderColor: 'rgb(75, 192, 192)',
//                 fill: true
//             },
//             {
//                 data: datasets[1].marks,
//                 label: datasets[1].name,
//                 backgroundColor: 'rgb(123, 245, 99)',
//                 borderColor: 'rgb(5, 125, 234)',
//                 tension: 0.1,
//                 fill: true
//             },
//         ]
//     }
// });








// IMPLEMENTATION 3
var overs = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];
labels = overs;
var teamsScore = [
    {
        teamName: "India",
        runs: [4,13,28,44,53,63,96,103,105,120,161,165,172,182,222,227,252,258,283,284]
    },
    {
        teamName: "Australia",
        runs: [5,17,19,27,31,48,55,69,70,71,123,133,172,173,210,215,239,243,249,278]
    }
];
datasets = teamsScore;

const myChart = new Chart(ctx, {
    type: "line",
    data: {
        labels: labels,
        datasets: [
            {
                data: datasets[0].runs,
                label: datasets[0].teamName,
                //backgroundColor: 'rgb(255, 99, 132)',
                borderColor: 'rgb(0, 0, 255)',
                fill: false,
                borderWidth: 10
            },
            {
                data: datasets[1].runs,
                label: datasets[1].teamName,
                //backgroundColor: ['rgb(123, 245, 99)', 'rgb(245, 132, 0)', 'rgb(19, 134, 99)', 'rgb(50, 123, 0)' ],
                borderColor: 'rgb(255, 255, 0)',
                tension: 0.1,
                fill: false,
                borderWidth: 10
            },
        ]
    },
    options: {
        responsive: true,
        layout: {
            padding: {
                top: 0,
                right: 0,
                bottom: 0,
                left: 70
            }
        },
        plugins: {
            title: {
                display: true,
                text: "India vs Australia T20 World Cup 2022"
            },
            legend: {
                display: true,
                position: "bottom",
                align: "end",
                labels: {
                    fontSize: 40,
                    fontColor: "red",
                    boxWidth: 20
                }
            },
            subtitle: {
                display: true,
                text: "Runrate"
            },
        },
        animations: {
            tension: {
                duration: 1000,
                easing: 'linear',
                from: 1,
                to: 0,
                loop: true
              }
        },
        //events: ["click"],
        onClick: function(){
            alert("Hello India");
        },
        // onHover: function(){
        //     alert("India is winning");
        // }
    },
});












// const labels = [
//     'January',
//     'February',
//     'March',
//     'April',
//     'May',
//     'June',
//   ];

//   const data = {
//     labels: labels,
//     datasets: [{
//       label: 'My First dataset',
//       backgroundColor: 'rgb(255, 99, 132)',
//       borderColor: 'rgb(255, 99, 132)',
//       data: [0, 10, 5, 2, 20, 30, 45],
//     }]
//   };

//   const config = {
//     type: 'line',
//     data: data,
//     options: {}
//   };


//   const myChart = new Chart(
//     document.getElementById('myChart'),
//     config
//   );