using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
    internal class EventStream : Stream
    {
        internal delegate void ReadProgress(int bytesRead);
        internal event ReadProgress OnRead;
        bool disableClose;

        Stream wrappedStream;

        internal EventStream(Stream stream, bool disableClose)
        {
            this.wrappedStream = stream;
            this.disableClose = disableClose;
        }

        protected override void Dispose(bool disposing)
        {
        }

        public override bool CanRead
        {
            get { return this.wrappedStream.CanRead; }
        }

        public override bool CanSeek
        {
            get { return this.wrappedStream.CanSeek; }
        }

        public override bool CanTimeout
        {
            get { return this.wrappedStream.CanTimeout; }
        }

        public override bool CanWrite
        {
            get { return this.wrappedStream.CanWrite; }
        }

        public override long Length
        {
            get { return this.wrappedStream.Length; }
        }

        public override long Position
        {
            get { return this.wrappedStream.Position; }
            set { this.wrappedStream.Position = value; }
        }

        public override int ReadTimeout
        {
            get { return this.wrappedStream.ReadTimeout; }
            set { this.wrappedStream.ReadTimeout = value; }
        }

        public override int WriteTimeout
        {
            get { return this.wrappedStream.WriteTimeout; }
            set { this.wrappedStream.WriteTimeout = value; }
        }

        public override void Flush()
        {
            this.wrappedStream.Flush();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int bytesRead = this.wrappedStream.Read(buffer, offset, count);
            if (this.OnRead != null)
            {
                this.OnRead(bytesRead);
            }

            return bytesRead;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return this.wrappedStream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            this.wrappedStream.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override void WriteByte(byte value)
        {
            throw new NotImplementedException();
        }

#if !(WIN_RT || PCL)
        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, Object state)
        {
            var result = new AsyncResult()
            {
                AsyncState = state,
                CompletedSynchronously = true,
                IsCompleted = true,
                AsyncWaitHandle = new ManualResetEvent(true)
            };

            try
            {
                int bytesRead = this.Read(buffer, offset, count);
                result.Return = bytesRead;
            }
            catch (Exception e)
            {
                result.Return = e;
            }

            if (callback != null)
                callback(result);

            return result;
        }

        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, Object state)
        {
            throw new NotImplementedException();
        }

        public override void Close()
        {
            if (!disableClose)
            {
                this.wrappedStream.Close();
            }
        }

        public override int EndRead(IAsyncResult asyncResult)
        {
            var result = asyncResult as AsyncResult;
            if (result.Return is Exception)
                throw (Exception)result.Return;

            return Convert.ToInt32(result.Return, CultureInfo.InvariantCulture);
        }

        public override void EndWrite(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }
#endif

        class AsyncResult : IAsyncResult
        {
            public object AsyncState { get; internal set; }
            public WaitHandle AsyncWaitHandle { get; internal set; }
            public bool CompletedSynchronously { get; internal set; }
            public bool IsCompleted { get; internal set; }

            internal object Return { get; set; }
        }
    }
}
