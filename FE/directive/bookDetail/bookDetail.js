angular.module('bookstore').directive('bookDetail', function() {

    var bookDetailCtrl = function($scope, $rootScope, bookService){

        $scope.updateBook = function(){
            var message = $scope.currentBook.id ? "update the book?" : "create the book?";
            var promise = $scope.currentBook.id ? bookService.updateBook : bookService.createBook;

            $rootScope.confirmPopup(message,"").then(function(){
                promise($scope.currentBook, $scope.currentBook.id).then(function(response) {
                            $scope.deselectBook();
                            $rootScope.popup("Successful", "");
                        }, function(response) {
                            $rootScope.popup("Error", response.data);
                    });
            });
        };

        $scope.deleteBook = function(){
            if(!$scope.currentBook.id){
                return;
            }
            $rootScope.confirmPopup("Delete the book?","").then(function(){
                bookService.deleteBook($scope.currentBook.id)
                    .then(function(response) {
                            $scope.deselectBook();
                            $rootScope.popup("Deleted", "");
                        }, function(response) {
                            $rootScope.popup("Error", response.data);
                    });
            });
        };
    };

    return {
        restrict: 'E',
        replace: true,
        controller: bookDetailCtrl,
        templateUrl: 'directive/bookDetail/bookDetail.html',
        link: function(scope, element, attrs, fn) {


        }
    };
});
