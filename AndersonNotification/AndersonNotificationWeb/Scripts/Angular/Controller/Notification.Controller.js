(function () {
    'use strict';

    angular
        .module('App')
        .controller('NotificationController', NotificationController);

    NotificationController.$inject = ['$filter', '$window', 'NotificationService'];

    function NotificationController($filter, $window, NotificationService) {
        var vm = this;

        vm.Notifications = [];

        vm.GoToUpdatePage = GoToUpdatePage;
        vm.Initialise = Initialise;

        vm.Delete = Delete;

        function GoToUpdatePage(notificationId) {
            $window.location.href = '../Notification/Update/' + notificationId;
        }

        function Initialise() {
            Read();
        }

        function Read() {
            NotificationService.Read()
                .then(function (response) {
                    vm.Notifications = response.data;
                })
                .catch(function (data, status) {
                    new PNotify({
                        title: status,
                        text: data,
                        type: 'error',
                        hide: true,
                        addclass: "stack-bottomright"
                    });
                });
        }
    }
})();