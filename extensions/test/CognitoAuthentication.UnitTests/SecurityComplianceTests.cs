using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Amazon.Extensions.CognitoAuthentication.UnitTests
{
    public class SecurityComplianceTests
    {
        private const int ModulusBitSize = 3072;
        private const int EphemeralBitSize = 256;

        private const int BitsInHexDigit = 4;
        private const int BitsInByte = 8;

        [Fact]
        public void ModulusLengthTest()
        {
            var modulusLength = AuthenticationHelper.HexN.Length * BitsInHexDigit;
            Assert.Equal(ModulusBitSize, modulusLength);
        }

        [Fact]
        public void EphemeralKeyLengthTest()
        {
            var ephemeralBytes = AuthenticationHelper.CreateEphemeralRandomBytes();
            var ephemeralLengthBits = ephemeralBytes.Length * BitsInByte;
            Assert.True(ephemeralLengthBits >= EphemeralBitSize);
        }
    }
}
