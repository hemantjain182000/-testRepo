var app = angular.module("myApp", []);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.

    when('/addPart', {
        templateUrl: '/Views/Part/Addpart.htm',
        controller: 'PartController'
    }).

    when('/part', {
        templateUrl: '/Views/Part/PartList.htm',
        controller: 'PartController'
    }).

    when('/partDetail', {
        templateUrl: '/Views/Part/PartDetail.htm',
        controller: 'PartController'
    }).

    otherwise({
        redirectTo: '/Views/Part/PartList.htm'
    });

}]);