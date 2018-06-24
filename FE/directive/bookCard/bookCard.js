angular.module('bookstore').directive('bookCard', function() {

    var bookCardCtrl = function($scope, $rootScope){
        $scope.currentBook = angular.copy($scope.book);
        $scope.getGenreName = function(genreEnum){ //enum translate
            switch(genreEnum) {
                case 0:
                    return "Any";
                case 1:
                    return "Romance";
                case 2:
                    return "Mystery";
                case 3:
                    return "Travel";
                case 4:
                    return "History";
                case 5:
                    return "Comics";
                case 6:
                    return "Fantasy";
                case 7:
                    return "Poetry";
                case 8:
                    return "Action";                   
                case 9:
                    return "Fiction";                                                                                                                         
                default:
                    return "unknown";  
            }
        };
    };

    return {
        restrict: 'E',
        replace: true,
        scope: {
            book: "="
        },
        controller: bookCardCtrl,
        templateUrl: 'directive/bookCard/bookCard.html',
        link: function(scope, element, attrs, fn) {


        }
    };
});
