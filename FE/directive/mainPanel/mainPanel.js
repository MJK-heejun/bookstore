angular.module('bookstore').directive('mainPanel', function() {

	var mainPanelCtrl = function($scope, $rootScope){
		$scope.bookList = [];
		$scope.currentBook = null;

		$scope.createBook = function(){
			$scope.currentBook = {title: "", author:"",description:""};
			$scope.editModeEnabled = true;
		};


		$scope.selectBook = function(book){
			$scope.currentBook = angular.copy(book);
			$scope.editModeEnabled = false;
		};

		$scope.deselectBook = function(){
            $scope.currentBook = null;
        };
	};

	return {
		restrict: 'E',
		replace: true,
		scope: {

		},
		controller: mainPanelCtrl,
		templateUrl: 'directive/mainPanel/mainPanel.html',
		link: function(scope, element, attrs, fn) {


		}
	};
});
