using Xunit;

namespace Service.UnitTests
{
    internal class LightServiceSub : LightService
    {
        internal new void Light(bool light)
        {
            base.Light(light);
        }
    }

    public class LightServiceTests
    {
        [Fact]
        public void Should_light_ok()
        {
            var target = new LightServiceSub();

            target.Light(true);
        }
    }
}
