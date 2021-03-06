$(document).ready(function () 
{
    $('#registerFormId').validate({
        errorClass: 'help-block animation-slideDown', // You can change the animation class for a different entrance animation - check animations page
        errorElement: 'div',
        errorPlacement: function (error, e) {
            e.parents('.form-group > div').append(error);
        },
        highlight: function (e) {
  
            $(e).closest('.form-group').removeClass('has-success has-error').addClass('has-error');
            $(e).closest('.help-block').remove();
        },
        success: function (e) {
            e.closest('.form-group').removeClass('has-success has-error');
            e.closest('.help-block').remove();
        },
        rules: {
            'EmailAddress' : {
                required:
                    function () {
                        //returns true if phone is empty   
                        return !$("#TelephoneNumber").val();
                    }
            },
            'TelephoneNumber': {
                required:
                    function () {
                        //returns true if email is empty
                        return !$("#EmailAddress").val();
                    }
            }
            
        },
        messages: {
            'EmailAddress': 'Email is required if no phone number is given.',
            'TelephoneNumber': 'A phone number is required if no phone email is given.'
        }
    });
});