$(document).ready(function() {
    $('#tblCategoryList').dataTable();
    
    $('#tblCategoryList').removeClass('display').addClass('table table-striped table-bordered');

    $("#tblCategoryList_wrapper input[type=search]").css("width", "auto");
});