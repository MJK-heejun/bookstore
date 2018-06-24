angular.module('bookstore', ['ui.bootstrap','ui.utils','ui.router','ngAnimate', 'ngMaterial', 'doowb.angular-pusher']);

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

})

.config(['PusherServiceProvider',
  function(PusherServiceProvider) {
    PusherServiceProvider
    .setToken('a29d983b9d414e97155c')
    .setOptions({});
  }
])

.controller('bookstoreController', ['$scope', '$rootScope', '$mdDialog',
    function($scope, $rootScope, $mdDialog) {

        $rootScope.isLoggedIn = true;

        $scope.$on("loginEvent", function() {
            $rootScope.isLoggedIn = true;
        });


            



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

