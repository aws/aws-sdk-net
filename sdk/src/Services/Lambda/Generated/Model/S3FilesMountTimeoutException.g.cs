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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// The Lambda function made a network connection to the configured S3 Files access point,
    /// but the mount operation timed out.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class S3FilesMountTimeoutException : AmazonLambdaException
    {
        /// <summary>
        /// Default constructor for S3FilesMountTimeoutException
        /// message.
        /// </summary>
        public S3FilesMountTimeoutException() : base() { }

        /// <summary>
        /// Constructs a new S3FilesMountTimeoutException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public S3FilesMountTimeoutException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of S3FilesMountTimeoutException
        /// </summary>
        public S3FilesMountTimeoutException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of S3FilesMountTimeoutException
        /// </summary>
        public S3FilesMountTimeoutException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of S3FilesMountTimeoutException
        /// </summary>
        public S3FilesMountTimeoutException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of S3FilesMountTimeoutException
        /// </summary>
        public S3FilesMountTimeoutException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The exception type.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the S3FilesMountTimeoutException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected S3FilesMountTimeoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Type = (string)info.GetValue("Type", typeof(string));
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
        [System.Security.SecurityCritical]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Type", this.Type);
        }
#endif
    }
}
