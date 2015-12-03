(function (window) {
'use strict';

angular.module(window.QRAPP.appId)
    .controller('dashboardCtrl', ['$scope', function ($scope) {

        $scope.greeting = 'Hi FirstName'; // replace this with logged in user first name

        // on view ready
        $scope.$on('$viewContentLoaded', function () {
            $('#side-menu').metisMenu();
        });

    }]);

}(window));