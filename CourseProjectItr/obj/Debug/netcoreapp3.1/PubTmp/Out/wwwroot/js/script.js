﻿var values = [];

function addAllItem() {
    var parent = document.getElementById('checkAll');
    var users = document.getElementsByTagName('input');

    if (parent.checked === true) {
        for (var i = 0; i < users.length; i++) {
            if (users[i].type == "checkbox" && users[i].name == "users" && users[i].checked == false) {
                users[i].checked = true;
            }
        }
    }
    else if (parent.checked === false) {
        for (var i = 0; i < users.length; i++) {
            if (users[i].type == "checkbox" && users[i].name == "users" && users[i].checked == true) {
                users[i].checked = false;
            }
        }
    }
}
function sendDataUn() {
    var parent = document.getElementById('checkAll');
    var users = document.getElementsByTagName('input');

    for (var i = 0; i < users.length; i++) {
        if (users[i].type == "checkbox" && users[i].name == "users" && users[i].checked == true) {
            users[i].checked = false;
            values.push(users[i].id);
            let json = JSON.stringify(values);
            fetch('/Admin/Unblock', {
                method: 'POST',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                body: json
            })
            if (parent.checked === true) {
                parent.checked = false;
            }
        }
        values = [];
    }
}

function sendDataAd() {
    var parent = document.getElementById('checkAll');
    var users = document.getElementsByTagName('input');

    for (var i = 0; i < users.length; i++) {
        if (users[i].type == "checkbox" && users[i].name == "users" && users[i].checked == true) {
            users[i].checked = false;
            values.push(users[i].id);
            let json = JSON.stringify(values);
            fetch('/Admin/AdminRole', {
                method: 'POST',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                body: json
            })
            if (parent.checked === true) {
                parent.checked = false;
            }
        }
        values = [];
    }
}

function sendDataB() {
    var parent = document.getElementById('checkAll');
    var users = document.getElementsByTagName('input');

    for (var i = 0; i < users.length; i++) {
        if (users[i].type == "checkbox" && users[i].name == "users" && users[i].checked == true) {
            users[i].checked = false;
            values.push(users[i].id);
            let json = JSON.stringify(values);
            fetch('/Admin/Block', {
                method: 'POST',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                body: json
            })
            if (parent.checked === true) {
                parent.checked = false;
            }
        }
        values = [];
    }
}
function sendDataD() {
    var parent = document.getElementById('checkAll');
    var users = document.getElementsByTagName('input');

    for (var i = 0; i < users.length; i++) {
        if (users[i].type == "checkbox" && users[i].name == "users" && users[i].checked == true) {
            users[i].checked = false;
            values.push(users[i].id);
            let json = JSON.stringify(values);
            fetch('/Account/Delete', {
                method: 'POST',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                body: json
            })
            if (parent.checked === true) {
                parent.checked = false;
            }
        }
        values = [];
    }
}
