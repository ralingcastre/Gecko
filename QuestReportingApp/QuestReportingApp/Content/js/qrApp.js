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

        // use html5 mode
        if (window.history && window.history.pushState) {
            $locationProvider.html5Mode(true);
        }
    }])
    .controller('dashboardCtrl', ['$scope', function ($scope) {

        $scope.greeting = 'Hi FirstName'; // replace this with logged in user first name

        // on view ready
        $scope.$on('$viewContentLoaded', function () {
            $('#side-menu').metisMenu();
        });

    }]);