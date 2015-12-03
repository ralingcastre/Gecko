(function (window) {
    'use strict';

    angular.module(window.QRAPP.appId)
        .factory('UserService', function ($resource) {
        return $resource('/users/:user', {user: "@user"});
    });

}(window));