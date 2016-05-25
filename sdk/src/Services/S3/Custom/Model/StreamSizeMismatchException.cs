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
#if !PCL
    [Serializable]
#endif
    public class StreamSizeMismatchException : AmazonS3Exception
    {
        /// <summary>
        /// Gets and sets ExpectedSize property.
        /// </summary>
        public long ExpectedSize { get; set; }

        /// <summary>
        /// Gets and sets ActualSize property.
        /// </summary>
        public long ActualSize { get; set; }

        /// <summary>
        /// Construct an instance of StreamSizeMismatchException.
        /// </summary>
        /// <param name="message"></param>
        public StreamSizeMismatchException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Construct an instance of StreamSizeMismatchException.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public StreamSizeMismatchException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Construct an instance of StreamSizeMismatchException.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="expectedSize"></param>
        /// <param name="actualSize"></param>
        /// <param name="requestId"></param>
        /// <param name="amazonId2"></param>
        public StreamSizeMismatchException(string message, long expectedSize, long actualSize, string requestId, string amazonId2)
            : base(message)
        {
            this.ExpectedSize = expectedSize;
            this.ActualSize = actualSize;
            this.RequestId = requestId;
            this.AmazonId2 = amazonId2;
        }

        /// <summary>
        /// Construct an instance of StreamSizeMismatchException.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="expectedSize"></param>
        /// <param name="actualSize"></param>
        /// <param name="requestId"></param>
        /// <param name="amazonId2"></param>
        /// <param name="amazonCfId"></param>
        public StreamSizeMismatchException(string message, long expectedSize, long actualSize, string requestId, string amazonId2, string amazonCfId)
            : base(message)
        {
            this.ExpectedSize = expectedSize;
            this.ActualSize = actualSize;
            this.RequestId = requestId;
            this.AmazonId2 = amazonId2;
            this.AmazonCloudFrontId = amazonCfId;
        }

        /// <summary>
        /// Construct an instance of StreamSizeMismatchException.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="expectedSize"></param>
        /// <param name="actualSize"></param>
        /// <param name="requestId"></param>
        /// <param name="amazonId2"></param>
        public StreamSizeMismatchException(string message, Exception innerException, long expectedSize, long actualSize, string requestId, string amazonId2)
            : base(message, innerException)
        {
            this.ExpectedSize = expectedSize;
            this.ActualSize = actualSize;
            this.RequestId = requestId;
            this.AmazonId2 = amazonId2;
        }

        /// <summary>
        /// Construct an instance of StreamSizeMismatchException.
        /// </summary>
        /// <param name="innerException"></param>
        public StreamSizeMismatchException(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

        /// <summary>
        /// Construct an instance of StreamSizeMismatchException.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public StreamSizeMismatchException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, errorType, errorCode, requestId, statusCode)
        {
        }

        /// <summary>
        /// Construct an instance of StreamSizeMismatchException.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public StreamSizeMismatchException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, innerException, errorType, errorCode, requestId, statusCode)
        {
        }

        /// <summary>
        /// Construct an instance of StreamSizeMismatchException.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        /// <param name="amazonId2"></param>
        public StreamSizeMismatchException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode, string amazonId2)
            : base(message, innerException, errorType, errorCode, requestId, statusCode, amazonId2)
        {
        }

#if !PCL
        /// <summary>
        /// Constructs a new instance of the AmazonServiceException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected StreamSizeMismatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            if (info != null)
            {
                this.ExpectedSize = info.GetInt64("ExpectedSize");
                this.ActualSize = info.GetInt64("ActualSize");
            }
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
#if BCL35
        [System.Security.Permissions.SecurityPermission(
            System.Security.Permissions.SecurityAction.LinkDemand,
            Flags = System.Security.Permissions.SecurityPermissionFlag.SerializationFormatter)]
#endif
        [System.Security.SecurityCritical]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);

            if (info != null)
            {
                info.AddValue("ExpectedSize", this.ExpectedSize);
                info.AddValue("ActualSize", this.ActualSize);
            }
        }
#endif
    }
}
