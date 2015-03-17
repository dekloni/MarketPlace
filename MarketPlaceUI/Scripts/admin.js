var app = angular.module('myAppAdmin', ['ngRoute']);

app.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/cat', {
            templateUrl: '/admin-categories.html',
            controller: 'adminCategoriesController'
        }).
        when('/product/:phoneId', {
            templateUrl: '/admin-products.html',
            controller: 'myAdminNavControlls'
        }).
        otherwise({
            redirectTo: '/cat'
        });
  }]);

app.controller("myAdminNavControlls", function ($scope, $http) {

    var vm = this;

    function init() {
        $scope.TestHeading = "TestAdminModule-ControllerNav";
    };

    init();



});
