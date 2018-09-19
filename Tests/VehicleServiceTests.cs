using Business;
using FluentAssertions;
using Xunit;

namespace Tests
{
    public class VehicleServiceTests
    {
        [Fact]
        public void ShouldNotBeNullWhenCreated()
        {
            var sut = new VehicleService();

            sut.Should().NotBeNull();
        }
    }
}
