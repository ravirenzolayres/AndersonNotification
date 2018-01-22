(function () {
    'use strict';

    angular
        .module('App')
        .factory('NotificationService', NotificationService);

    NotificationService.$inject = ['$http'];

    function NotificationService($http) {
        return {
            Read: Read,
        }

        function Read() {
            return $http({
                method: 'POST',
                url: '/Notification/Read',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
            });
        }
    }
})();