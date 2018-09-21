using System.Collections.Generic;
using System.Web.Mvc;
using Business;
using Core.Models;
using DependencyInjectionASPNET.Controllers;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void ShouldReturnViewResultWhenIndex()
        {
            var sut = new HomeController(Substitute.For<IVehicleService>());

            var result = sut.Index();

            result.As<ViewResult>().Should().NotBeNull();
        }

        [Fact]
        public void ShouldInvokeServiceWhenIndex()
        {
            var service = Substitute.For<IVehicleService>();
            var sut = new HomeController(service);

            var _ = sut.Index();
            
            service.Received().GetAll();
        }

        [Fact]
        public void ShouldReturnViewResultWithListWhenIndex()
        {
            var service = Substitute.For<IVehicleService>();
            service.GetAll().Returns(new List<Vehicle> {new Vehicle("Whatever Car", "Whatever model", 1066)});
            var sut = new HomeController(service);

            var result = sut.Index().As<ViewResult>();

            result.Model.As<IEnumerable<Vehicle>>().Should().NotBeEmpty();
        }
    }
}