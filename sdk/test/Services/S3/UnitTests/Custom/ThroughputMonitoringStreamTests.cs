#if !NETFRAMEWORK
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Amazon.S3.Transfer.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class ThroughputMonitoringStreamTests
    {
        /// <summary>Stream whose reads block for a configurable delay before returning data.</summary>
        private sealed class DelayedStream : Stream
        {
            private readonly byte[] _data;
            private readonly TimeSpan _delayPerRead;
            private int _position;

            public DelayedStream(byte[] data, TimeSpan delayPerRead)
            {
                _data = data;
                _delayPerRead = delayPerRead;
            }

            public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
            {
                await Task.Delay(_delayPerRead, cancellationToken).ConfigureAwait(false);

                var remaining = _data.Length - _position;
                if (remaining <= 0)
                    return 0;

                var toCopy = Math.Min(count, remaining);
                Buffer.BlockCopy(_data, _position, buffer, offset, toCopy);
                _position += toCopy;
                return toCopy;
            }

            public override int Read(byte[] buffer, int offset, int count)
                => ReadAsync(buffer, offset, count, CancellationToken.None).GetAwaiter().GetResult();

            public override bool CanRead => true;
            public override bool CanSeek => false;
            public override bool CanWrite => false;
            public override long Length => _data.Length;
            public override long Position { get => _position; set => throw new NotSupportedException(); }
            public override void Flush() { }
            public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
            public override void SetLength(long value) => throw new NotSupportedException();
            public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
        }

        private static ThroughputMonitoringStream Wrap(Stream inner, TimeSpan interval, long minBytesPerSecond = 1)
            => new ThroughputMonitoringStream(inner, minBytesPerSecond, interval);

        [TestMethod]
        [TestCategory("S3")]
        public async Task HealthyStreamIsUnaffected()
        {
            var payload = Encoding.UTF8.GetBytes(new string('x', 4096));
            using (var stream = Wrap(new DelayedStream(payload, TimeSpan.Zero), TimeSpan.FromSeconds(5)))
            using (var destination = new MemoryStream())
            {
                await stream.CopyToAsync(destination).ConfigureAwait(false);

                Assert.AreEqual(payload.Length, destination.Length);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task StalledReadThrowsIOException()
        {
            // IOException specifically: the SDK retry pipeline already treats it as retryable, so a
            // stalled part is retried instead of failing the whole transfer.
            var payload = new byte[1024];
            using (var stream = Wrap(new DelayedStream(payload, TimeSpan.FromSeconds(5)), TimeSpan.FromMilliseconds(200)))
            {
                var buffer = new byte[1024];

                await Assert.ThrowsExactlyAsync<IOException>(
                    async () => await stream.ReadAsync(buffer, 0, buffer.Length, CancellationToken.None));
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task CallerCancellationIsNotReportedAsAStall()
        {
            // A user cancelling their own transfer must surface as cancellation, not as a bogus
            // connection fault that the retry pipeline would then retry.
            var payload = new byte[1024];
            using (var stream = Wrap(new DelayedStream(payload, TimeSpan.FromSeconds(5)), TimeSpan.FromSeconds(30)))
            using (var cts = new CancellationTokenSource())
            {
                var buffer = new byte[1024];
                var read = stream.ReadAsync(buffer, 0, buffer.Length, cts.Token);
                cts.Cancel();

                await Assert.ThrowsExactlyAsync<TaskCanceledException>(async () => await read);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task EndOfStreamDoesNotThrow()
        {
            // A finished body reads zero bytes; that must never be mistaken for a stall.
            using (var stream = Wrap(new DelayedStream(new byte[0], TimeSpan.Zero), TimeSpan.FromMilliseconds(200)))
            {
                var buffer = new byte[16];

                Assert.AreEqual(0, await stream.ReadAsync(buffer, 0, buffer.Length, CancellationToken.None));
                Assert.AreEqual(0, await stream.ReadAsync(buffer, 0, buffer.Length, CancellationToken.None));
            }
        }
    }
}
#endif
