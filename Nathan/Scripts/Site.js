$(function () {
    $('#form').submit(function () {
        if ($(this).valid()) {
            $('input[type=submit]', this).attr('disabled', 'disabled');
        } else {
            $(this).validate();
        }
    });
})