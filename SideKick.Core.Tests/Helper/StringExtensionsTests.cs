using SideKick.Core.Helper;
using Xunit;

namespace SideKick.Core.Tests.Helper
{
    public class StringExtensionsTests
    {
        [Fact()]
        public void ExtractIPAddressTest()
        {
            Assert.Equal("198.168.0.1", "Ip 198.168.0.1".ExtractIPAddress());
        }
    }
}