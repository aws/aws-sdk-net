/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Linq;
using System.Text;
using System.IO;
using System.Security.AccessControl;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;

using Amazon.Util;

namespace Amazon.S3.IO
{
    internal class S3FileStream : Stream
    {
        private static int MEG = (int)Math.Pow(2, 20);
        private static int MIN_SIZE = 5 * MEG;

        private S3FileInfo file;
        private MemoryStream buffer;

        private bool canRead = true;
        private bool canSeek = true;
        private bool canTimeout = true;
        private bool canWrite = true;
        private long startPosition = 0;
        private bool disposed = false;

        private bool bucketExist;
        private bool fileExist;
        private long lastWriteCounter = 0;
        private long lastFlushMarker = -1;

        internal S3FileStream(IAmazonS3 s3Client, string bucket, string key, FileMode mode)
            : this(s3Client, bucket, key, mode, FileAccess.ReadWrite, MIN_SIZE)
        { }

        internal S3FileStream(IAmazonS3 s3Client, string bucket, string key, FileMode mode, FileAccess access)
            : this(s3Client, bucket, key, mode, access, 0)
        { }

        internal S3FileStream(IAmazonS3 s3Client, string bucket, string key, FileMode mode, FileAccess access, int buffersize)
        {
            file = new S3FileInfo(s3Client, bucket, key);
            buffer = new MemoryStream(buffersize);

            fileExist = file.ExistsWithBucketCheck(out bucketExist);

            if ((access & FileAccess.Read) != FileAccess.Read)
            {
                canRead = false;
            }
            if ((access & FileAccess.Write) != FileAccess.Write)
            {
                canWrite = false;
            }

            switch (mode)
            {
                case FileMode.Append:
                    if ((access & FileAccess.Write) != FileAccess.Write)
                    {
                        throw new ArgumentException("Append requires Write access");
                    }
                    PopulateData();
                    buffer.Seek(0, SeekOrigin.End);
                    startPosition = buffer.Position;
                    break;

                case FileMode.Create:
                    if ((access & FileAccess.Write) != FileAccess.Write)
                    {
                        throw new ArgumentException("Create requires Write access");
                    }
                    break;

                case FileMode.CreateNew:
                    if (fileExist)
                    {
                        throw new IOException("CreateNew requires the file not to already exist");
                    }
                    if ((access & FileAccess.Write) != FileAccess.Write)
                    {
                        throw new ArgumentException("Create requires Write access");
                    }
                    break;

                case FileMode.Open:
                    if (!fileExist)
                    {
                        throw new IOException("Open requires the file to already exist");
                    }
                    PopulateData();
                    break;

                case FileMode.OpenOrCreate:
                    if (fileExist)
                    {
                        if ((access & FileAccess.Write) != FileAccess.Write)
                        {
                            throw new ArgumentException("Create requires Write access");
                        }
                    }
                    break;

                case FileMode.Truncate:
                    if (!fileExist)
                    {
                        throw new IOException("Truncate requires the file to already exist");
                    }
                    if ((access & FileAccess.Write) != FileAccess.Write)
                    {
                        throw new ArgumentException("Truncate requires Write access");
                    }
                    break;

                default:
                    throw new ArgumentException("Invalid value", "mode");
            }
        }

        public override bool CanRead
        {
            get
            {
                return canRead;
            }
        }

        public override bool CanSeek
        {
            get
            {
                return canSeek;
            }
        }

        public override bool CanTimeout
        {
            get
            {
                return canTimeout;
            }
        }

        public override bool CanWrite
        {
            get
            {
                return canWrite;
            }
        }

        public override long Length
        {
            get
            {
                return buffer.Length;
            }
        }

        public string Name
        {
            get
            {
                return file.FullName;
            }
        }

        public override long Position
        {
            get
            {
                return buffer.Position;
            }
            set
            {
                if (!CanSeek)
                {
                    throw new NotSupportedException("The stream does not support seeking");
                }
                if (value < startPosition)
                {
                    throw new ArgumentOutOfRangeException("value", "Can not seek to specified location");
                }
                buffer.Position = value;
            }
        }

        public override int ReadTimeout
        {
            get
            {
                return buffer.ReadTimeout;
            }
            set
            {
                buffer.ReadTimeout = value;
            }
        }

        public override int WriteTimeout
        {
            get
            {
                return buffer.WriteTimeout;
            }
            set
            {
                buffer.WriteTimeout = value;
            }
        }

        public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            if (!canRead)
            {
                throw new NotSupportedException("Stream does not support reading");
            }
            return this.buffer.BeginRead(buffer, offset, count, callback, state);
        }

        public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            if (!canWrite)
            {
                throw new NotSupportedException("Stream does not support writing");
            }
            return this.buffer.BeginWrite(buffer, offset, count, callback, state);

        }

        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Flush(true);
                    if (buffer != null)
                        buffer.Dispose();
                }
                disposed = true;
            }
        }

        public override int EndRead(IAsyncResult asyncResult)
        {
            return buffer.EndRead(asyncResult);
        }

        public override void EndWrite(IAsyncResult asyncResult)
        {
            buffer.EndWrite(asyncResult);
        }

        public override void Flush()
        {
            Flush(true);
        }

        public void Flush(bool flushToS3)
        {
            if (this.canWrite && flushToS3 && this.lastWriteCounter != this.lastFlushMarker)
            {
                long pos = Position;

                try
                {
                    if (!this.bucketExist)
                    {
                        file.S3Client.PutBucket(new PutBucketRequest { BucketName = file.BucketName });
                        this.bucketExist = true;
                    }

                    var request = new PutObjectRequest
                    {
                        BucketName = file.BucketName,
                        Key=S3Helper.EncodeKey(file.ObjectKey),
                        InputStream = buffer,
                        AutoCloseStream = false
                    };
                    ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);

                    try
                    {
                        buffer.Seek(0, SeekOrigin.Begin);
                        file.S3Client.PutObject(request);
                    }
                    catch (AmazonS3Exception e)
                    {
                        if (!string.Equals(e.ErrorCode, "NoSuchBucket"))
                            throw;

                        // Bucket no longer exists so create and retry put
                        file.Directory.Create();

                        buffer.Seek(0, SeekOrigin.Begin);
                        file.S3Client.PutObject(request);
                    }
                    this.lastFlushMarker = this.lastWriteCounter;
                }
                finally
                {
                    buffer.Seek(pos, SeekOrigin.Begin);
                }
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (!canRead)
            {
                throw new NotSupportedException("Stream does not support reading");
            }
            return this.buffer.Read(buffer, offset, count);
        }

        public override int ReadByte()
        {
            if (!canRead)
            {
                throw new NotSupportedException("Stream does not support reading");
            }
            return buffer.ReadByte(); 
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            if (!canSeek)
            {
                throw new NotSupportedException("Stream does not support seeking");
            }
            if (LessThanStart(offset, origin))
            {
                throw new ArgumentOutOfRangeException("offset", "Attempting to seek to a restricted section");
            }
            return buffer.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            if (!canWrite && !canSeek)
            {
                throw new NotSupportedException();
            }
            buffer.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            if (!canWrite)
            {
                throw new NotSupportedException("Stream does not support writing");
            }
            this.buffer.Write(buffer, offset, count);
            this.lastWriteCounter++;
        }

        public override void WriteByte(byte value)
        {
            if (!canWrite)
            {
                throw new NotSupportedException("Stream does not support writing");
            }
            buffer.WriteByte(value);
            this.lastWriteCounter++;
        }

        private void PopulateData()
        {
            var getObjectRequest = new GetObjectRequest
            {
                BucketName = file.BucketName,
                Key = S3Helper.EncodeKey(file.ObjectKey)
            };
            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)getObjectRequest).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);
            var getObjectResponse = file.S3Client.GetObject(getObjectRequest);
            using (Stream data = getObjectResponse.ResponseStream)
            {
                byte[] tempBuffer = new byte[AWSSDKUtils.DefaultBufferSize];
                int bytesRead = 0;
                while ((bytesRead = data.Read(tempBuffer, 0, tempBuffer.Length)) > 0)
                {
                    buffer.Write(tempBuffer, 0, bytesRead);
                }
            }
            buffer.Position = 0;

        }

        private bool LessThanStart(long offset, SeekOrigin origin)
        {
            bool ret = false;

            ret |= ((origin == SeekOrigin.Begin) && (offset < startPosition));
            ret |= ((origin == SeekOrigin.Current) && (offset < startPosition - Position));
            ret |= ((origin == SeekOrigin.End) && (offset < startPosition - Length));

            return ret;
        }
    }
}
