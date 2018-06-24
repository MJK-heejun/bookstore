angular.module('bookstore').directive('header', function() {

    var headerCtrl = function($scope, $rootScope){

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
