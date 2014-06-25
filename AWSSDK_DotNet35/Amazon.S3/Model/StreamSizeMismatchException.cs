/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System.Net;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The exception that is thrown when the size of a stream does not match it's expected size.
    /// </summary>
    public class StreamSizeMismatchException : AmazonS3Exception
    {
        public long ExpectedSize { get; set; }

        public long ActualSize { get; set; }

        public StreamSizeMismatchException(string message)
            : base(message)
        {
        }

        public StreamSizeMismatchException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public StreamSizeMismatchException(string message, long expectedSize, long actualSize, string requestId, string amazonId2)
            : base(message)
        {
            this.ExpectedSize = expectedSize;
            this.ActualSize = actualSize;
            this.RequestId = requestId;
            this.AmazonId2 = amazonId2;
        }

        public StreamSizeMismatchException(string message, Exception innerException, long expectedSize, long actualSize, string requestId, string amazonId2)
            : base(message, innerException)
        {
            this.ExpectedSize = expectedSize;
            this.ActualSize = actualSize;
            this.RequestId = requestId;
            this.AmazonId2 = amazonId2;
        }

        public StreamSizeMismatchException(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

        public StreamSizeMismatchException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, errorType, errorCode, requestId, statusCode)
        {
        }

        public StreamSizeMismatchException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, innerException, errorType, errorCode, requestId, statusCode)
        {
        }

        public StreamSizeMismatchException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode, string amazonId2)
            : base(message, innerException, errorType, errorCode, requestId, statusCode, amazonId2)
        {
        }
    }
}
