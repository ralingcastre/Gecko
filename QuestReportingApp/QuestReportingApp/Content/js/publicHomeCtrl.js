(function (window) {
    'use strict';

    // mainCtrl
    angular.module(window.QRAPP.appId)
        .controller('publicHomeCtrl', ['$scope', function ($scope) {
            var $win,
                winWidth,
                $body,
                $loginBox;

            $scope.greeting = 'Hello!';

            angular.element(document).ready(function () {
                $win = $(window);
                winWidth = $win.width();
                $loginBox = $('#loginBox');
                $body = $('body');
                // setup style for animation
                $body.css('maxWidth', winWidth);

                setTimeout(function () {
                    $loginBox
                        .addClass('show bounceInRight')
                        .one('webkitAnimationEnd oanimationend msAnimationEnd animationend', function (e) {
                            $body.css('maxWidth', ''); // remove inline style
                        });
                }, 1000);
            });

        }]);

}(window));