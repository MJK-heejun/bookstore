angular.module('bookstore').directive('header', function() {

    var headerCtrl = function($scope, $rootScope){
        $scope.login = function(){
            $rootScope.username = "employee";
            $rootScope.token = "tpAxQU0qsudAHYKA4jhhccg24rLTL2phVoTULYU5KbpjxcC574ehLgxriIDzjqPAe7OtfZZezmGaW8E2YQWRXiFP1CMcvvVuwZf";
            $rootScope.isLoggedIn = true;
            $rootScope.popup("You are logged in", "you are logged in as an employee for the demo purpose...");
        };
        $scope.logout = function(){
            $rootScope.username = null;
            $rootScope.token = null;
            $rootScope.isLoggedIn = false;
            $rootScope.popup("You are logged out", "");
        };
    };

    return {
        restrict: 'E',
        replace: true,
        scope: {

        },
        controller: headerCtrl,
        templateUrl: 'directive/header/header.html',
        link: function(scope, element, attrs, fn) {


        }
    };
});
