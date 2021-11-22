var myApp = angular.module('Welcome',[]);
myApp.controller('WelcomeController', ['$scope', '$http', '$log', function ($scope, $http, $log) {
        $scope.list = [];
        $scope.text = 'hello';
        $scope.submit = function () {
            if ($scope.text) {
                $scope.list.push(this.text);
                $scope.text = '';
            }
        };

    }]);