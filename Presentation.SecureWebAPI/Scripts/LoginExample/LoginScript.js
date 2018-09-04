function LogIn() {
    $.post('/token', {
        'userName': 'daniel.carbajal@pucp.edu.pe',
        'password': '96066lopeZ!',
        'grant_type': 'password'
    })
        .then((data) => {
            localStorage.setItem('access_token', data.access_token)
        })
}

function SetUpGlobalHeader() {
    $.ajaxSetup({
        beforeSend: function (xhr) {
            xhr.setRequestHeader('Authorization', 'bearer ' + localStorage.getItem('access_token'));
        }
    });
}

function GetAuthorizeData() {
    $.get('api/values').then(valor => console.log(valor));
}

