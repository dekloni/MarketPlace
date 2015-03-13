var app = angular.module('myAppAdmin', []);

app.controller("myAdminNavControlls", function ($scope, $http) {

    var vm = this;

    function init() {
        $scope.TestHeading = "TestOnlyFromAng";
    };

    init();



});
