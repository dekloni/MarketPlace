var app = angular.module('myAppAdmin', ['ngRoute']);

app.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('admin/cat', {
            templateUrl: 'partials/Categories.html',
            controller: 'PhoneListCtrl'
        }).
        when('/product/:phoneId', {
            templateUrl: 'partials/products.html',
            controller: 'PhoneDetailCtrl'
        }).
        otherwise({
            redirectTo: '/phones'
        });
  }]);

app.controller("myAdminNavControlls", function ($scope, $http) {

    var vm = this;

    function init() {
        $scope.TestHeading = "TestAdminModule-ControllerNav";
    };

    init();



});
