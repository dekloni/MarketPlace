app.controller("adminCategoriesEditController", function ($scope, $http, $routeParams) {

    var categoryId = ($routeParams.categoryId) ? parseInt($routeParams.categoryId) : 0;

    $scope.buttonText = (categoryId > 0) ? "Update" : "Add";
    $scope.successMessage = "";
    $scope.test1 = "asdasd";

    var serviceBase = 'api/categories';

    function processError(error) {
        $scope.errorMessage = error.config.url + ' ' + error.statusText + ' ' + error.status;
    }

    function init() {

        if (categoryId > 0) {
            // get category details
            $http.get(serviceBase + '/' + categoryId).then(
             function (results) {

                 $scope.category = results.data;

                 var gh = 77;
             }, processError);

        }

    }

    $scope.save = function save() {
        //$scope.$apply();
        if ($scope.editForm.$valid) {
            if (categoryId > 0)
                $http.put(serviceBase + '/' + categoryId, $scope.category).then(
                    function(result) {
                        $scope.successMessage = "great success";
                    }, processError);
            else {
                // add 
                $http.post(serviceBase + '/' + categoryId, $scope.category).then(
                    function (result) {
                        $scope.successMessage = "great success creating";
                    }, processError);
            }
        } else {
            $scope.errorMessag = "Not valid form";
        }
    }



    $scope.cancel = function cancel() {
        alert("Cancel");
    }

    $scope.$watch('test1', function(val) {
        var hhh = 888;
    }, true);
    init();

});
