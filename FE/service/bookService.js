angular.module('bookstore')
    .factory('bookService', ['$http', '$rootScope', '$q', function($http, $rootScope, $q) {

        var bookService = {};

        var rootUrl = "http://localhost:63901";
        // var rootUrl = "http://bookstore.azurewebsites.net";

        bookService.getAllBooks = function(){
            var url = rootUrl + '/api/books';
            return $http.get(url);
        };

        bookService.searchBooks = function(searchValue, searchType){
            var url = rootUrl + '/api/books?'+searchType+'='+searchValue;
            return $http.get(url);
        };

        bookService.createBook = function(book){
            var url = rootUrl + '/api/books';
            return $http.post(url, book);
        };

        bookService.updateBook = function(book, id){
            var url = rootUrl + '/api/books/'+id;
            return $http.put(url, book);
        };

        bookService.deleteBook = function(id){
            var url = rootUrl + '/api/books/'+id;
            return $http.delete(url);
        };
        
        return bookService;
    }]);
