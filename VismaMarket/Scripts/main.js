var app = angular.module('myApp', []);

app.run(function() {
    //$rootScope.name = "Ani loren";
});


app.controller('MyController', function ($scope) {
    $scope.person = {
        name: "Ari Lerner"
    };
});

app.controller('PlayerController', ['$scope', function ($scope) {
    $scope.playing = false;
    $scope.audio = document.createElement('audio');
    $scope.audio.src = 'https://auphonic.com/media/blog/auphonic_chapters_demo.m4a';

    $scope.play = function() {
        $scope.audio.play();
        $scope.playing = true;
    };
    $scope.stop = function () {
        $scope.audio.pause();
        $scope.playing = false;
    };
    $scope.audio.addEventListener('ended', function () {
        $scope.$apply(function () {
            $scope.stop();
        });
    });
}]);

app.controller('RelatedController', ['$scope', function ($scope) {
}]);
