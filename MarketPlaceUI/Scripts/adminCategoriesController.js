
app.controller("adminCategoriesController", function ($scope, $http) {

    var vm = this;
    var errorMessage = "";
    var serviceBase = 'api/categories';

    var categories = [];

    function processError(error) {
        $scope.errorMessage = error.config.url + ' ' + error.statusText +  ' ' + error.status;
    }

    function init() {

        // get categories
        $http.get(serviceBase + '').then(
            function (results) {

                $scope.categories = results.data;

                var gh = 77;
            }, processError);

        $scope.TestHeading = "TestAdminModule-adminCategoriesController";
    };

    init();



});
