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

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// An exception indicating that a client-side error occurred during the Apache Airflow
    /// REST API call.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class RestApiClientException : AmazonMWAAException
    {
        /// <summary>
        /// Default constructor for RestApiClientException
        /// message.
        /// </summary>
        public RestApiClientException() : base() { }

        /// <summary>
        /// Constructs a new RestApiClientException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public RestApiClientException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of RestApiClientException
        /// </summary>
        public RestApiClientException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of RestApiClientException
        /// </summary>
        public RestApiClientException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of RestApiClientException
        /// </summary>
        public RestApiClientException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of RestApiClientException
        /// </summary>
        public RestApiClientException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property RestApiResponse. 
        /// <para>
        /// The error response data from the Apache Airflow REST API call, provided as a JSON
        /// object.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Amazon.Runtime.Documents.Document RestApiResponse { get; set; }

        /// <summary>
        /// Checks to see if the RestApiResponse property is set.
        /// </summary>
        internal bool IsSetRestApiResponse() => !this.RestApiResponse.IsNull();

        /// <summary>
        /// Gets and sets the property RestApiStatusCode. 
        /// <para>
        /// The HTTP status code returned by the Apache Airflow REST API call.
        /// </para>
        /// </summary>
        public int? RestApiStatusCode { get; set; }

        /// <summary>
        /// Checks to see if the RestApiStatusCode property is set.
        /// </summary>
        internal bool IsSetRestApiStatusCode() => this.RestApiStatusCode.HasValue;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the RestApiClientException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected RestApiClientException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.RestApiResponse = (Amazon.Runtime.Documents.Document)info.GetValue("RestApiResponse", typeof(Amazon.Runtime.Documents.Document));
            this.RestApiStatusCode = (int?)info.GetValue("RestApiStatusCode", typeof(int?));
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
            info.AddValue("RestApiResponse", this.RestApiResponse);
            info.AddValue("RestApiStatusCode", this.RestApiStatusCode);
        }
#endif
    }
}
