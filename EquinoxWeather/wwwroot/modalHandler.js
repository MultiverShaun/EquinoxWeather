window.modalHandler = {
    initialize: function (elementId) {
        var myModal = document.getElementById(elementId);

        if (myModal) {
            myModal.addEventListener('hidden.bs.modal', function () {
                location.reload();
            });
        }
    }
};
