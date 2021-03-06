using System;
using NSec.Cryptography;
using Xunit;

namespace NSec.Tests.Algorithms
{
    public static class ChaCha20Poly1305Tests
    {
        #region Properties

        [Fact]
        public static void Properties()
        {
            var a = AeadAlgorithm.ChaCha20Poly1305;

            Assert.Equal(32, a.KeySize);
            Assert.Equal(12, a.NonceSize);
            Assert.Equal(16, a.TagSize);
        }

        #endregion
    }
}
