'use strict';

// Declare app level module and route config
angular.module('qrApp', [ 'ngRoute']).
    config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
        
        $routeProvider
            .when('/', {
                templateUrl: 'views/dashboard.html',
                controller: 'dashboardCtrl'
            })
            .otherwise({ redirectTo: '/' });

        if (window.history && window.history.pushState) {
            $locationProvider.html5Mode(true);
        }
    }])
    .controller('dashboardCtrl', ['$scope', function ($scope) {
        $scope.greeting = 'Hola!';
    }]);