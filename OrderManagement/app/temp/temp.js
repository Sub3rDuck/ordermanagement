'use strict';

$.ajax({
    url: 'http://localhost:52891/api/customer/getfirst?name=sally',
    success: function() {
        console.log('Success');
    },
    error: function() {
        console.log('Failed');
    }
});