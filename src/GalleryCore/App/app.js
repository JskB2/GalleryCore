var app = angular.module("galleryApp", ["ngRoute", "ngFileUpload"]);

app.config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {
    $routeProvider.when("/", {
        controller: "MainCtrl",
        templateUrl: "partials/main.html"
    });

    $locationProvider.html5mode = true; 
}])