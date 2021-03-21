using Microsoft.AspNetCore.Mvc;
using PackagesManagement.Models.Packages;
using System;
using Xunit;

namespace PackagesManagementTest
{
    public class ManagePackagesControllerTests
    {
        [Fact]
        public async void DeletePostValidationFailedTest()
        {
            var controller = new PackagesManagement.Controllers.ManagePackagesController();
            controller.ModelState.AddModelError("Name", "fake error");

            var vm = new PackageFullEditViewModel();
            var result = await controller.Edit(vm, null);

            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(vm, viewResult.Model);
        }
    }
}
