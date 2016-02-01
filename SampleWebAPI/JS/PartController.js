
//AngularJS controller
app.controller('PartController', ['$scope', '$http', PartController]);

//AngularJS controller method
function PartController($scope, $http) {
    //Select all the data's
    $http.get('../api/Part').success(function (data) {
        $scope.Parts = data;
    })
    .error(function () {
        $scope.error = "An Error has occured while loading posts!";
    });


    //Select single data
    $scope.getSingleData = function (Part) {
        $http.get('../api/Part/' + Part.PartId).success(function (data) {
            $scope.part = data;
        })
        .error(function () {
            $scope.error = "An Error has occured while loading posts!";
        });
    }


    //Inser operation
    $scope.add = function (Part) {
        $http.post('../api/Part', Part).success(function (data) {
            alert("Added successfully!!");
            $scope.Parts.push(data);
            ClearFields();
        }).error(function (data) {
            $scope.error = "An error has occured while adding! " + data;
        });
    };


    //Edit/Update operation
    $scope.save = function (Part) {
        $http.put('../api/Part/' + Part.PartId, Part).success(function (data) {
            alert("Updated successfully!!");
            $http.get('../api/Part').success(function (data) {
                $scope.Parts = data;
                ClearFields();
            })
        }).error(function (data) {
            $scope.error = "An Error has occured while updating! " + data;
        });
    };


    //Delete operation
    $scope.deletePart = function (Part) {
        $http.delete('../api/Part/' + Part.PartId).success(function (data) {
            alert("Deleted successfully!!");
            $http.get('../api/Part').success(function (data) {
                $scope.Parts = data;
            })
        }).error(function (data) {
            $scope.error = "An error has occured while deleting! " + data;
        });
    };


    //Cler inputs
    function ClearFields() {
        $scope.Part.PartId = "";
        $scope.Part.PartDescription = "";
        $scope.Part.UOM = "";
        $scope.Part.Location = "";
    }
}

//app.controller('PartController', ['$scope', 'PartService', function ($scope, PartService) {
//    //$scope.message = "Now viewing home!";

//    $scope.parts = {
//        PartId: "",
//        PartDescription: "",
//        UOM: "",
//        Location: ""
//    };

//    PartService.getParts($scope);
//}])

//app.service('PartService', ['$http', function ($http) {
//    this.getParts = function ($scope) {
//        return $http({
//            method: "GET",
//            url: "../api/Part",
//            headers: { 'Content-Type': 'application/json' }
//        }).success(function (data) {
//            $scope.parts = data;
//            //console.log(data);
//        }).error(function (data) {
//            alert(data);
//            //console.log(data);
//        });;
//    };
//}]);

//app.controller('PartDetailController', ['$scope', 'PartDetailService', function ($scope, PartService, $routeParams) {
//    //$scope.message = "Now viewing home!";

//    //$scope.partDetail = {
//    //    PartId: "",
//    //    PartDescription: "",
//    //    UOM: "",
//    //    Location: ""
//    //};

//    PartService.getPartDetail($scope,$routeParams.id);
//}])



//app.service('PartDetailService', ['$http', function ($http) {
//    this.getPartDetail = function ($scope,id) {
//        return $http({
//            method: "GET",
//            url: "../api/Part/" + id,
//            headers: { 'Content-Type': 'application/json' }
//        }).success(function (data) {
//            $scope.partDetail = data;
//            console.log(data);
//        }).error(function (data) {
//            alert(data);
//            console.log(data);
//        });;
//    };
//}]);

