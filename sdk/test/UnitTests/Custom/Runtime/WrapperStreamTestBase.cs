using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests.Runtime
{
    public abstract class WrapperStreamTestBase<T> where T : Stream
    {
#if ASYNC_AWAIT
        public class AsyncReadOnlyStream : Stream
        {
            public override bool CanRead => true;

            public override bool CanSeek => false;

            public override bool CanWrite => false;

            public override long Length => throw new NotSupportedException();

            public override long Position { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }

            public override void Flush()
            {
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                throw new NotImplementedException();
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                throw new NotSupportedException();
            }

            public override void SetLength(long value)
            {
                throw new NotSupportedException();
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
                throw new NotSupportedException();
            }

            public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
            {
                return Task.FromResult(0);
            }
        }

        [TestMethod]
        public async Task CopyToAsyncShouldCallAsyncReadTest()
        {
            MemoryStream dest = new MemoryStream();
            await WrapStream(new AsyncReadOnlyStream()).CopyToAsync(dest);
            // Expect not to see NotImplementedException
        }

        public abstract T WrapStream(Stream baseStream);
#endif
    }
}
