/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Amazon.Util
{
    /// <summary>
    /// This class is used to wrap a stream for a particular segment of a stream.  It 
    /// makes that segment look like you are reading from beginning to end of the stream.
    /// </summary>
    internal class PartStreamWrapper : Stream
    {
        private Stream wrappedStream;
        private long initialPosition;
        private long partSize;

        internal PartStreamWrapper(Stream stream, long partSize)
        {
            this.wrappedStream = stream;
            this.initialPosition = stream.Position;

            long remainingData = stream.Length - stream.Position;
            if (partSize == 0 || remainingData < partSize)
            {
                this.partSize = remainingData;
            }
            else
            {
                this.partSize = partSize;
            }
        }

        private long RemainingPartSize
        {
            get
            {

                long remaining = this.partSize - this.Position;
                return remaining;
            }
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
            get
            {
                long length = this.wrappedStream.Length - this.initialPosition;
                if (length > this.partSize)
                {
                    length = this.partSize;
                }

                return length;
            }
        }

        public override long Position
        {
            get
            {
                return this.wrappedStream.Position - this.initialPosition;
            }
            set
            {
                this.wrappedStream.Position = this.initialPosition + value;
            }
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

        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, Object state)
        {
            throw new NotImplementedException();
        }

        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, Object state)
        {
            throw new NotImplementedException();
        }

        public override void Close()
        {
        }

        protected override void Dispose(bool disposing)
        {
        }

        public override int EndRead(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }

        public override void EndWrite(IAsyncResult asyncResult)
        {
            throw new NotImplementedException();
        }

        public override void Flush()
        {
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int bytesToRead = count < this.RemainingPartSize ? count : (int)this.RemainingPartSize;
            if (bytesToRead < 0)
                return 0;
            return this.wrappedStream.Read(buffer, offset, bytesToRead);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            long position = 0;
            switch(origin)
            {
                case SeekOrigin.Begin:
                    position = this.initialPosition + offset;
                    break;
                case SeekOrigin.Current:
                    position = this.wrappedStream.Position + offset;
                    break;
                case SeekOrigin.End:
                    position = this.wrappedStream.Position + this.partSize + offset;
                    break;
            }

            if (position < this.initialPosition)
            {
                position = this.initialPosition;
            }
            else if (position > this.initialPosition + this.partSize)
            {
                position = this.initialPosition + this.partSize;
            }

            this.wrappedStream.Position = position;

            return this.Position;
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override void WriteByte(byte value)
        {
            throw new NotImplementedException();
        }

    }
}
