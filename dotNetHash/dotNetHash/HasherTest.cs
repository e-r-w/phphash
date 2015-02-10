using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace dotNetHash
{
    [TestFixture]
    public class HasherTest
    {
        [Test]
        public void ShouldHashThings()
        {
            var expectedHash = "b4a68e00d87c605b4d251617fb7a7e101ef7a0d6329263065493920972794779";
            var id = "12345";
            var timeStamp = "2015-02-10T10:22:13";
            var hash = Hasher.Hash(id, timeStamp);
            Assert.That(hash, Is.EqualTo(expectedHash));
        }
    }
}
