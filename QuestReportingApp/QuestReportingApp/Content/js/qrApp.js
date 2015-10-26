'use strict';

// Declare app level module and route config
angular.module('qrApp', [ 'ngRoute']).
    config(['$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'views/login.html',
                controller: 'mainCtrl'
            })
            .otherwise({ redirectTo: '/' });
    }])
    .controller('mainCtrl', ['$scope', function ($scope) {
        $scope.greeting = 'Hola!';
    }]);