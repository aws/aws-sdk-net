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
using System.Net;
using System.Runtime.Serialization;
using System.Security.Permissions;

using Amazon.S3.Model;

namespace Amazon.S3
{
    /// <summary>
    /// Amazon S3 Exception provides details of errors returned by Amazon S3 service.
    /// 
    /// In particular, this class provides access to S3's extended request ID, the Date,
    /// and the host ID which are required debugging information in the odd case that 
    /// you need to contact Amazon about an issue where Amazon S3 is incorrectly handling 
    /// a request.
    /// 
    /// The ResponseHeaders property of the AmazonS3Exception contains all the HTTP headers
    /// in the Error Response returned by the S3 service.
    /// </summary>
    [Serializable]
    public class AmazonS3Exception : Exception, ISerializable
    {
        private HttpStatusCode statusCode = default(HttpStatusCode);
        private string errorCode;
        private string message;
        private string hostId;
        private string requestId;
        private string xml;
        private string requestAddr;
        private WebHeaderCollection responseHeaders;

        /// <summary>
        /// Initializes a new AmazonS3Exception with default values.
        /// </summary>
        public AmazonS3Exception()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new AmazonS3Exception with a specified error message
        /// </summary>
        /// <param name="message">A message that describes the error</param>
        public AmazonS3Exception(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// Initializes a new AmazonS3Exception from the inner exception that is
        /// the cause of this exception.
        /// </summary>
        /// <param name="innerException">The nested exception that caused the AmazonS3Exception</param>
        public AmazonS3Exception(Exception innerException)
            : this(innerException.Message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new AmazonS3Exception with serialized data.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.
        /// </param>
        /// <param name="context">The contextual information about the source or destination.
        /// </param>
        protected AmazonS3Exception(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            this.statusCode = (HttpStatusCode)info.GetValue("statusCode", typeof(HttpStatusCode));
            this.errorCode = info.GetString("errorCode");
            this.message = info.GetString("message");
            this.hostId = info.GetString("hostId");
            this.requestId = info.GetString("requestId");
            this.xml = info.GetString("xml");
            this.requestAddr = info.GetString("requestAddr");
            this.responseHeaders = (WebHeaderCollection)info.GetValue("responseHeaders", typeof(WebHeaderCollection));
        }

        /// <summary>
        /// Serializes this instance of AmazonS3Exception.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.
        /// </param>
        [SecurityPermissionAttribute(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("statusCode", statusCode, typeof(HttpStatusCode));
            info.AddValue("errorCode", errorCode, typeof(string));
            info.AddValue("message", message, typeof(string));
            info.AddValue("hostId", hostId, typeof(string));
            info.AddValue("requestId", requestId, typeof(string));
            info.AddValue("xml", xml, typeof(string));
            info.AddValue("requestAddr", requestAddr, typeof(string));
            info.AddValue("responseHeaders", responseHeaders, typeof(WebHeaderCollection));
            base.GetObjectData(info, context);
        }

        /// <summary>
        /// Initializes a new AmazonS3Exception with a specific error message and the inner exception
        /// that is the cause of this exception.
        /// </summary>
        /// <param name="message">Overview of error</param>
        /// <param name="innerException">The exception that is the cause of the current exception.
        /// If the innerException parameter is not a null reference, the current exception is
        /// raised in a catch block that handles the inner exception.</param>
        public AmazonS3Exception(string message, Exception innerException)
            : base(message, innerException)
        {
            this.message = message;
            AmazonS3Exception ex = innerException as AmazonS3Exception;
            if (ex != null)
            {
                this.statusCode = ex.StatusCode;
                this.errorCode = ex.ErrorCode;
                this.requestId = ex.RequestId;
                this.message = ex.Message;
                this.hostId = ex.hostId;
                this.xml = ex.XML;
            }
        }

        /// <summary>
        /// Initializes an AmazonS3Exception with a specific message and
        /// HTTP status code
        /// </summary>
        /// <param name="message">Overview of error</param>
        /// <param name="statusCode">HTTP status code for error response</param>
        public AmazonS3Exception(string message, HttpStatusCode statusCode)
            : this(message)
        {
            this.statusCode = statusCode;
        }

        /// <summary>
        /// Initializes an AmazonS3Exception with error information provided in an
        /// AmazonS3 response.
        /// </summary>
        /// <param name="message">Overview of error</param>
        /// <param name="statusCode">HTTP status code for error response</param>
        /// <param name="errorCode">Error Code returned by the service</param>
        /// <param name="requestId">Request ID returned by the service</param>
        /// <param name="hostId">S3 Host ID returned by the service</param>
        /// <param name="xml">Compete xml found in response</param>
        /// <param name="requestAddr">The S3 request url</param>
        /// <param name="responseHeaders">The response headers containing S3 specific information
        /// </param>
        public AmazonS3Exception(
            string message,
            HttpStatusCode statusCode,
            string errorCode,
            string requestId,
            string hostId,
            string xml,
            string requestAddr,
            WebHeaderCollection responseHeaders)
            : this(message, statusCode)
        {
            this.errorCode = errorCode;
            this.hostId = hostId;
            this.requestId = requestId;
            this.xml = xml;
            this.requestAddr = requestAddr;
            this.responseHeaders = responseHeaders;
        }

        /// <summary>
        /// Initializes an AmazonS3Exception with error information provided in an
        /// AmazonS3 response and the inner exception that is the cause of the exception
        /// </summary>
        /// <param name="message">Overview of error</param>
        /// <param name="statusCode">HTTP status code for error response</param>
        /// <param name="requestAddr">The S3 request url</param>
        /// <param name="responseHeaders">The response headers containing S3 specific information
        /// <param name="innerException">The nested exception that caused the AmazonS3Exception</param>
        /// </param>
        public AmazonS3Exception(
            string message,
            HttpStatusCode statusCode,
            string requestAddr,
            WebHeaderCollection responseHeaders,
            Exception innerException)
            : this(message, innerException)
        {
            this.statusCode = statusCode;
            this.requestAddr = requestAddr;
            this.responseHeaders = responseHeaders;
        }

        /// <summary>
        /// Initializes an AmazonS3Exception with error information provided in an
        /// AmazonS3 response and the inner exception that is the cause of the exception
        /// </summary>
        /// <param name="statusCode">HTTP status code for error response</param>
        /// <param name="xml">Compete xml found in response</param>
        /// <param name="requestAddr">The S3 request url</param>
        /// <param name="responseHeaders">The response headers containing S3 specific information
        /// <param name="error">The nested exception that caused the AmazonS3Exception</param>
        /// </param>
        public AmazonS3Exception(
            HttpStatusCode statusCode,
            string xml,
            string requestAddr,
            WebHeaderCollection responseHeaders,
            S3Error error)
        {
            this.xml = xml;
            this.statusCode = statusCode;
            this.requestAddr = requestAddr;
            this.responseHeaders = responseHeaders;
            if (error != null)
            {
                this.errorCode = error.Code;
                this.hostId = error.HostId;
                this.requestId = error.RequestId;
                this.message = error.Message;
            }
        }

        /// <summary>
        /// Gets the HostId property.
        /// </summary>
        public string HostId
        {
            get { return this.hostId; }
        }

        /// <summary>
        /// Gets the ErrorCode property.
        /// </summary>
        public string ErrorCode
        {
            get { return this.errorCode; }
        }

        /// <summary>
        /// Gets error message
        /// </summary>
        public override string Message
        {
            get { return this.message; }
        }

        /// <summary>
        /// Gets status code returned by the service if available. If status
        /// code is set to -1, it means that status code was unavailable at the
        /// time exception was thrown
        /// </summary>
        public HttpStatusCode StatusCode
        {
            get { return this.statusCode; }
        }

        /// <summary>
        /// Gets XML returned by the service if available.
        /// </summary>
        public string XML
        {
            get { return this.xml; }
        }

        /// <summary>
        /// Gets Request ID returned by the service if available.
        /// </summary>
        public string RequestId
        {
            get { return this.requestId; }
        }

        /// <summary>
        /// Gets the S3 service address used to make this request.
        /// </summary>
        public string S3RequestAddress
        {
            get { return this.requestAddr; }
        }

        /// <summary>
        /// Gets the error response HTTP headers so that S3 specific information
        /// can be retrieved for debugging. Interesting fields are:
        /// a. x-amz-id-2
        /// b. Date
        ///
        /// A value can be retrieved from this HeaderCollection via:
        /// ResponseHeaders.Get("key");
        /// </summary>
        public WebHeaderCollection ResponseHeaders
        {
            get { return this.responseHeaders; }
        }
    }
}