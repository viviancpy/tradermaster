(function () {
    'use strict';

    // Demonstrate how to register services
    // In this case it is a simple value service.
    angular.module('app.services', [])
        .value('version', '0.1')
        .factory('traderTasksDataService', ['$http', traderTasksDataService]);

    function traderTasksDataService($http) {
        var service = {
            getAllTasks : function(){
                return $http.get('/api/tasks/all', { cache: false })
                    .then(function (response) {
                        return response.data;
                    }
                );
            }
        };
        return service;
    }

})();