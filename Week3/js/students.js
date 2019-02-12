function initializeStudents() {
    var data = getTestStudents();
    displayStudents(data.students);
}

function getTestStudents() {
    return JSON.parse(testStudents);
}

function displayStudents(students) {

    for(i = 0; i < students.length; i++) {

        console.log('Student ID: ' + students[i].studentID);
        
        var studentID = students[i].studentID;
        var email = students[i].email;
        var markup = "<tr><td>" + studentID + "</td><td>" + email + "</td></tr>";

        $("table tbody").append(markup);
    }
}

var testStudents = '{"students": [{"studentID": "58412569","email": "lisa.simpson@oit.edu"},{"studentID": "41256325","email": "bart.simpson@oit.edu"},{"studentID": "85796554","email": "marge.simpson@oit.edu"},{"studentID": "85457324","email": "home.simpson@oit.edu"},{"studentID": "65874521","email": "maggie.simpson@oit.edu"}]}'
