using Xunit;

namespace Service.UnitTests
{
    public class PrinterServiceTests
    {
        [Fact]
        public void Should_print_ok()
        {
            var target = new PrinterService();
            target.Print("hello");
        }
    }
}
