/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Formats.Cbor;
using System.IO;
using System.Linq;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Extensions.CborProtocol.Internal.Transform
{
    public class CborUnmarshallerContext : UnmarshallerContext
    {
        private bool disposed = false;
        private byte[] rentedBuffer = null;
        private readonly Stack<string> _pathStack = new Stack<string>();

        // There isn't a direct way to check if the reader is at the start of the document,
        // and we don't need it for the unmarshalling logic anyway.
        public override bool IsStartOfDocument => throw new NotImplementedException();

        public override bool IsEndElement => Reader.PeekState() == CborReaderState.Finished;
        public override bool IsStartElement => Reader.PeekState() == CborReaderState.StartMap;

        public CborReader Reader { get; set; }
        public override string CurrentPath => string.Join("/", _pathStack.Reverse());
        public override int CurrentDepth => Reader.CurrentDepth;

        public CborUnmarshallerContext(
            Stream responseStream,
            bool maintainResponseBody,
            IWebResponseData responseData,
            bool isException = false
        )
            : this(responseStream, maintainResponseBody, responseData, isException, null) { }

        public CborUnmarshallerContext(
            Stream responseStream,
            bool maintainResponseBody,
            IWebResponseData responseData,
            bool isException,
            IRequestContext requestContext
        )
        {
            if (isException)
            {
                WrappingStream = new CachingWrapperStream(responseStream);
            }
            else if (maintainResponseBody)
            {
                WrappingStream = new CachingWrapperStream(
                    responseStream,
                    AWSConfigs.LoggingConfig.LogResponsesSizeLimit
                );
            }

            if (isException || maintainResponseBody)
            {
                responseStream = WrappingStream;
            }

            long? streamSize = null;

            if (responseData != null)
            {
                bool parsedContentLengthHeader = long.TryParse(
                    responseData.GetHeaderValue("Content-Length"),
                    out long contentLength
                );
                if (parsedContentLengthHeader && contentLength == 0)
                {
                    IsEmptyResponse = true;
                }

                if (
                    parsedContentLengthHeader
                    && responseData.ContentLength == contentLength
                    && string.IsNullOrEmpty(responseData.GetHeaderValue("Content-Encoding"))
                    && requestContext?.OriginalRequest?.CoreChecksumMode
                        == CoreChecksumResponseBehavior.ENABLED
                )
                {
                    base.SetupCRCStream(responseData, responseStream, contentLength);
                    base.SetupFlexibleChecksumStream(
                        responseData,
                        CrcStream ?? responseStream,
                        contentLength,
                        requestContext
                    );
                }
                if (parsedContentLengthHeader && responseData.ContentLength == contentLength)
                {
                    streamSize = contentLength;
                }
            }

            this.WebResponseData = responseData;
            this.MaintainResponseBody = maintainResponseBody;
            this.IsException = isException;

            Reader = CreateCborReaderFromStream(
                FlexibleChecksumStream ?? CrcStream ?? responseStream,
                streamSize
            );
        }

        private CborReader CreateCborReaderFromStream(Stream stream, long? streamSize = null)
        {
            int totalRead = 0;
            if (streamSize.HasValue)
            {
                // TODO: update this method to read the stream in chunks incase the stream is larger than int.MaxValue
                // If we know the size, we can read directly into a buffer of exact size
                rentedBuffer = ArrayPool<byte>.Shared.Rent((int)streamSize.Value);

                while (totalRead < streamSize.Value)
                {
                    int bytesRead = stream.Read(rentedBuffer, totalRead, (int)(streamSize.Value - totalRead));
                    if (bytesRead == 0)
                    {
                        // If no bytes are read, it means we've reached the end of the stream before reading the whole streamSize.
                        throw new EndOfStreamException($"Expected {streamSize.Value} bytes but only read {totalRead}.");
                    }

                    totalRead += bytesRead;
                }
            }
            else
            {
                const int InitialBufferSize = 1024 * 8; // 8kb
                rentedBuffer = ArrayPool<byte>.Shared.Rent(InitialBufferSize);

                while (true)
                {
                    int read = stream.Read(rentedBuffer, totalRead, rentedBuffer.Length - totalRead);
                    if (read == 0)
                        break;

                    totalRead += read;

                    if (totalRead == rentedBuffer.Length)
                    {
                        // Expand the buffer size by doubling it
                        var newBuffer = ArrayPool<byte>.Shared.Rent(rentedBuffer.Length * 2);
                        try
                        {
                            Buffer.BlockCopy(rentedBuffer, 0, newBuffer, 0, totalRead);
                        }
                        catch
                        {
                            ArrayPool<byte>.Shared.Return(newBuffer);
                            ArrayPool<byte>.Shared.Return(rentedBuffer);
                            rentedBuffer = null;
                            throw;
                        }
                        ArrayPool<byte>.Shared.Return(rentedBuffer);
                        rentedBuffer = newBuffer;
                    }
                }
            }

            var actualBytes = new ReadOnlyMemory<byte>(rentedBuffer, 0, totalRead);
            return new CborReader(actualBytes);
        }

        /// <summary>
        /// Adds a new segment to the current path stack.
        /// Typically used when entering a new object property.
        /// </summary>
        /// <param name="segment">The segment name to add</param>
        public void AddPathSegment(string segment)
        {
            _pathStack.Push(segment);
        }

        /// <summary>
        /// Removes the most recent segment from the path stack.
        /// Typically used when exiting a property.
        /// </summary>
        /// <returns>The segment that was removed.</returns>
        public string PopPathSegment()
        {
            return _pathStack.Pop();
        }

        protected override void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing && rentedBuffer != null)
                {
                    ArrayPool<byte>.Shared.Return(rentedBuffer);
                }
                disposed = true;
            }
            base.Dispose(disposing);
        }
    }
}
