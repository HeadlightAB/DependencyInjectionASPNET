using System.Collections.Generic;
using Business;
using Core.Models;
using DataAccess;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace Tests
{
    public class VehicleServiceTests
    {
        [Fact]
        public void ShouldNotBeNullWhenCreated()
        {
            var sut = new VehicleService(Substitute.For<IDataAccess>());

            sut.Should().NotBeNull();
        }

        [Fact]
        public void ShouldInvokeDataAccessWhenGetAll()
        {
            var dataAccess = Substitute.For<IDataAccess>();
            var sut = new VehicleService(dataAccess);

            var _ = sut.GetAll();

            dataAccess.Received().GetAllVehicles();
        }

        [Fact]
        public void ShouldReturnListOfVehiclesWhenGetAll()
        {
            var dataAccess = Substitute.For<IDataAccess>();
            dataAccess.GetAllVehicles().Returns(new List<Vehicle> {new Vehicle("Whatever Car", "Whatever model", 1066) });
            var sut = new VehicleService(dataAccess);

            var result = sut.GetAll();

            result.Should().NotBeEmpty();
        }
    }
}
