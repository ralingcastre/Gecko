(function (window) {
    'use strict';

    angular.module(window.QRAPP.appId)
        .controller('publicHomeCtrl', ['$scope', function ($scope) {
            $scope.greeting = 'Hello!';

        }]);

}(window));