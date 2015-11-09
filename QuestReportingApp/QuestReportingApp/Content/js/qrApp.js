(function (window) {
'use strict';

// create namespace
window.QRAPP = window.QRAPP || {};

window.QRAPP.appId = 'qrApp';

// Declare app level module and route config
angular.module(window.QRAPP.appId, ['ngRoute']).
    config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

        $routeProvider
            .when('/', {
                templateUrl: 'views/dashboard.html',
                controller: 'dashboardCtrl'
            })
            .when('/students/add', {
                templateUrl: 'views/addStudent.html',
                controller: 'studentsdCtrl'
            })
            .otherwise({ redirectTo: '/' });

        /*
        // use html5 mode
        if (window.history && window.history.pushState) {
           $locationProvider.html5Mode(true);
        }
        */
    }]);

}(window));