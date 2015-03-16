var app = angular.module('myApp', ['ngRoute']);

app.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/cat', {
            templateUrl: '/public-categories.html',
            controller: 'MyController'
        }).
        when('/product/:phoneId', {
            templateUrl: 'public-products.html',
            controller: 'MyController'
        }).
        otherwise({
            redirectTo: '/cat'
        });
  }]);


app.controller("MyController", function ($scope, $http) {

    init();
    $scope.products = [];
    //[
    //    {
    //        name: "NVdia",
    //        description: "TopNotch"
    //    },
    //    {
    //        name: "NVdia2",
    //        description: "TopNotch2"
    //    }
    //];

    $scope.person = { name: "HiME" };

    $scope.getLatest = function () {
        //$scope.products = [
        //    {
        //        name: "NVdia3",
        //        description: "TopNotch"
        //    },
        //    {
        //        name: "NVdia4",
        //        description: "TopNotch2"
        //    }
        //];
    };

    function processError(data, status, headers, config) {
        alert(+status + " " + data.Message + " " + config.url);
        // called asynchronously if an error occurs
        // or server returns response with an error status.
    }

    $scope.getPopular = function () {

        $http.get('/api/products?type=popular').
          success(function (data, status, headers, config) {
              $scope.products = data;
              //alert(data.message);
              // this callback will be called asynchronously
              // when the response is available
          }).
          error(processError);
    }

    function init() {
        $http.get('/api/products?type=latest').
       success(function (data, status, headers, config) {
           $scope.products = data;
           //alert(data.message);
           // this callback will be called asynchronously
           // when the response is available
       }).
       error(processError);
    }



});