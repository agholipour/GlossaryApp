var glossaryAltering = function () {

    var _editUrl="";
    var _deleteUrl = "";

    var init = function (editUrl, deleteUrl) {

        _editUrl = editUrl;
        _deleteUrl =  deleteUrl;

        $(".delete").click(function () {
            var buttonClicked = this;
            BootstrapDialog.show({
                title: 'Delete Term',
                message: 'Are you sure about deleting item?',
                buttons: [{
                    label: 'Delete',
                    cssClass: 'btn-danger',
                    action: function (dialog) {
                        var id = $(buttonClicked).attr('data-id');
                        $.ajax({
                            url: _deleteUrl +"/"+ id,
                            type: "Post", 
                            contentType: "application/json",
                            success: function () {
                                buttonClicked.closest('tr').remove();
                            },
                            error: function () {
                            }
                        });
                        dialog.close();
                    }
                }, {
                    label: 'Close',
                    action: function (dialog) {
                        dialog.close();
                    }
                }]
            });
        });

        
    };
   

    return {
        init: init
    }
}();