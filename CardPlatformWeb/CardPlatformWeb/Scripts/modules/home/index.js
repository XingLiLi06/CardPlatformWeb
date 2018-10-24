angular.module("HomeModule", [])
    .controller("HomeController", function ($rootScope, $scope, $http) {
        $scope.Filter = {
            Name: "",
            id: "",
            RoleName:""
        }
        $scope.MenuList = [];
        //$scope.imgUrl = ["主页", "配送管理", "退单管理", "报表", "财务管理","业务查询", "基础信息管理", "系统管理"];
        $scope.icon = ["fa fa-home", "fa fa-truck", "fa fa-shopping-cart", "fa fa-list-alt", "fa fa-user-secret", "fa fa-briefcase", "fa fa-file-text", "fa fa-cogs"];
        //获取菜单
        $http.get("/Home/GetNavigation").success(function(response) {
            if (response) {
                for (var i = 0; i < response.length; i++) {
                    response[i]["icon"] = $scope.icon[i];
                    if (response[i].SecondNavList.length > 0 || i === 0 ) {
                        $scope.MenuList.push(response[i]);
                    } 
                }
            }
        });
        
        


        //获取当前用户
        $http.get("/Home/CurrentUser").success(function (response) {
            if (response) {
                $scope.Filter.Name = response.RealName;
                if (response.UserType == 0) {
                    $scope.Filter.RoleName = "站长";
                }

                if (response.UserType == 1) {
                    $scope.Filter.RoleName = "管理员";
                }
            }
        });

    })