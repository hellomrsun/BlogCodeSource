using Xunit;

namespace Service.UnitTests
{
    public class ComputerServiceTests
    {
        [Fact]
        public void Should_calculate_ok()
        {
            var target = new ComputerService();

            target.Calculate(10);
        }
    }
}
