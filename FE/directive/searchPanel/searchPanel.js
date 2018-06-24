angular.module('bookstore').directive('searchPanel', function() {

    var searchPanelCtrl = function($scope, $rootScope, bookService){
        //default values
        $scope.searchValue = "";
        $scope.searchType = "title";

        //searching method
        $scope.searchBook = function(){
			if(!$scope.searchValue){ //retrieve all when search value is empty
                bookService.getAllBooks()
                    .then(function(response) {
                            $scope.bookList = response.data;
                        }, function(response) {
                            $rootScope.popup("Error", response.data);
                    });
            }else{
                bookService.searchBooks($scope.searchValue, $scope.searchType)
                    .then(function(response) {
                            $scope.bookList = response.data;
                            if($scope.bookList.length < 1){
                                $rootScope.popup("no book found","");
                            }
                        }, function(response) {
                            $rootScope.popup("Error", response.data);
                    });
            }

            
        };

        //watch for the genre select and autofills search values
        $scope.$watch('genreValue', function () {
            $scope.searchValue = angular.copy($scope.genreValue);
        });
    };
    
    return {
        restrict: 'E',
        replace: true,
        scope: {
            bookList: "="
        },
        controller: searchPanelCtrl,
        templateUrl: 'directive/searchPanel/searchPanel.html',
        link: function(scope, element, attrs, fn) {


        }
    };
});
