angular.module('bookstore', ['ui.bootstrap','ui.utils','ui.router','ngAnimate', 'ngMaterial']);

angular.module('bookstore').config(function($stateProvider, $urlRouterProvider) {

    /* Add New States Above */
    $urlRouterProvider.otherwise('/home');

});

angular.module('bookstore').run(function($rootScope) {

    $rootScope.safeApply = function(fn) {
        var phase = $rootScope.$$phase;
        if (phase === '$apply' || phase === '$digest') {
            if (fn && (typeof(fn) === 'function')) {
                fn();
            }
        } else {
            this.$apply(fn);
        }
    };

}).controller('bookstoreController', ['$scope', '$rootScope', '$mdDialog',
    function($scope, $rootScope, $mdDialog) {

        $rootScope.isLoggedIn = false;


        //md modal dialog
        $rootScope.popup = function(title, content) {
            $mdDialog.show(
                $mdDialog.alert()
                .title(title)
                .content(content)
                .ok('OK'));
        };
        $rootScope.confirmPopup = function(title, content, ok, cancel) {
            var confirm = $mdDialog.confirm()
                .title(title)
                .content(content)
                .ok(ok ? ok : 'Ok')
                .cancel(cancel ? cancel : 'Cancel');
            return $mdDialog.show(confirm);
        };

    }
]);

