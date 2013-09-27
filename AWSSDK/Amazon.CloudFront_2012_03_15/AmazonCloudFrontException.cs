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
 *  API Version: 2010-11-01
 *
 */

using System;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Amazon.CloudFront_2012_03_15
{
    /// <summary>
    /// Amazon CloudFront Exception provides details of errors
    /// returned by Amazon CloudFront service
    /// </summary>
    [Serializable]
    public class AmazonCloudFrontException : Exception, ISerializable
    {
        private HttpStatusCode statusCode = default(HttpStatusCode);
        private string errorCode;
        private string message;
        private string type;
        private string requestId;
        private string xml;
        private string requestAddr;
        private WebHeaderCollection responseHeaders;

        /// <summary>
        /// Initializes a new AmazonCloudFrontException with default values.
        /// </summary>
        public AmazonCloudFrontException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new AmazonCloudFrontException with a specified error message
        /// </summary>
        /// <param name="message">A message that describes the error</param>
        public AmazonCloudFrontException(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// Initializes a new AmazonCloudFrontException from the inner exception that is
        /// the cause of this exception.
        /// </summary>
        /// <param name="innerException">The nested exception that caused the AmazonCloudFrontException</param>
        public AmazonCloudFrontException(Exception innerException)
            : this(innerException.Message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new AmazonCloudFrontException with serialized data.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.
        /// </param>
        /// <param name="context">The contextual information about the source or destination.
        /// </param>
        protected AmazonCloudFrontException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            this.statusCode = (HttpStatusCode)info.GetValue("statusCode", typeof(HttpStatusCode));
            this.errorCode = info.GetString("errorCode");
            this.message = info.GetString("message");
            this.type = info.GetString("type");
            this.requestId = info.GetString("requestId");
            this.xml = info.GetString("xml");
            this.requestAddr = info.GetString("requestAddr");
            this.responseHeaders = (WebHeaderCollection)info.GetValue("responseHeaders", typeof(WebHeaderCollection));
        }

        /// <summary>
        /// Serializes this instance of AmazonCloudFrontException.
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
            info.AddValue("type", type, typeof(string));
            info.AddValue("requestId", requestId, typeof(string));
            info.AddValue("xml", xml, typeof(string));
            info.AddValue("requestAddr", requestAddr, typeof(string));
            info.AddValue("responseHeaders", responseHeaders, typeof(WebHeaderCollection));
            base.GetObjectData(info, context);
        }

        /// <summary>
        /// Initializes a new AmazonCloudFrontException with a specific error message and the inner exception
        /// that is the cause of this exception.
        /// </summary>
        /// <param name="message">Overview of error</param>
        /// <param name="innerException">The exception that is the cause of the current exception.
        /// If the innerException parameter is not a null reference, the current exception is
        /// raised in a catch block that handles the inner exception.</param>
        public AmazonCloudFrontException(string message, Exception innerException)
            : base(message, innerException)
        {
            this.message = message;
            AmazonCloudFrontException ex = innerException as AmazonCloudFrontException;
            if (ex != null)
            {
                this.statusCode = ex.StatusCode;
                this.errorCode = ex.ErrorCode;
                this.requestId = ex.RequestId;
                this.message = ex.Message;
                this.type = ex.type;
                this.xml = ex.XML;
            }
        }

        /// <summary>
        /// Initializes an AmazonCloudFrontException with a specific message and
        /// HTTP status code
        /// </summary>
        /// <param name="message">Overview of error</param>
        /// <param name="statusCode">HTTP status code for error response</param>
        public AmazonCloudFrontException(string message, HttpStatusCode statusCode)
            : this(message)
        {
            this.statusCode = statusCode;
        }

        /// <summary>
        /// Initializes an AmazonCloudFrontException with error information provided in an
        /// AmazonCloudFront response.
        /// </summary>
        /// <param name="message">Overview of error</param>
        /// <param name="statusCode">HTTP status code for error response</param>
        /// <param name="errorCode">Error Code returned by the service</param>
        /// <param name="requestId">Request ID returned by the service</param>
        /// <param name="type">Error Type</param>
        /// <param name="xml">Compete xml found in response</param>
        /// <param name="requestAddr">The CloudFront request url</param>
        /// <param name="responseHeaders">The response headers containing CloudFront specific information</param>
        /// <param name="innerException">The exception that is the cause of the current exception.
        /// If the innerException parameter is not a null reference, the current exception is
        /// raised in a catch block that handles the inner exception.</param>
        public AmazonCloudFrontException(
            string message,
            HttpStatusCode statusCode,
            string errorCode,
            string requestId,
            string type,
            string xml,
            string requestAddr,
            WebHeaderCollection responseHeaders,
            Exception innerException)
            : this(message, innerException)
        {
            this.errorCode = errorCode;
            this.type = type;
            this.requestId = requestId;
            this.xml = xml;
            this.requestAddr = requestAddr;
            this.responseHeaders = responseHeaders;
            this.statusCode = statusCode;
        }

        /// <summary>
        /// Gets the HostId property.
        /// </summary>
        public string HostId
        {
            get { return this.type; }
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
        /// Gets the CloudFront service address used to make this request.
        /// </summary>
        public string CloudFrontRequestAddress
        {
            get { return this.requestAddr; }
        }

        /// <summary>
        /// Gets the error response HTTP headers so that CloudFront specific information
        /// can be retrieved for debugging. Interesting fields are:
        /// a. x-amz-id-2
        /// b. x-amz-request-id
        /// c. Date
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