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

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Your account is pending verification.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class PendingVerificationException : AmazonIVSRealTimeException
    {
        /// <summary>
        /// Default constructor for PendingVerificationException
        /// message.
        /// </summary>
        public PendingVerificationException() : base() { }

        /// <summary>
        /// Constructs a new PendingVerificationException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public PendingVerificationException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of PendingVerificationException
        /// </summary>
        public PendingVerificationException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of PendingVerificationException
        /// </summary>
        public PendingVerificationException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of PendingVerificationException
        /// </summary>
        public PendingVerificationException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of PendingVerificationException
        /// </summary>
        public PendingVerificationException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property AccessControlAllowOrigin.
        /// </summary>
        public string AccessControlAllowOrigin { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlAllowOrigin property is set.
        /// </summary>
        internal bool IsSetAccessControlAllowOrigin() => this.AccessControlAllowOrigin != null;

        /// <summary>
        /// Gets and sets the property AccessControlExposeHeaders.
        /// </summary>
        public string AccessControlExposeHeaders { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlExposeHeaders property is set.
        /// </summary>
        internal bool IsSetAccessControlExposeHeaders() => this.AccessControlExposeHeaders != null;

        /// <summary>
        /// Gets and sets the property CacheControl.
        /// </summary>
        public string CacheControl { get; set; }

        /// <summary>
        /// Checks to see if the CacheControl property is set.
        /// </summary>
        internal bool IsSetCacheControl() => this.CacheControl != null;

        /// <summary>
        /// Gets and sets the property ContentSecurityPolicy.
        /// </summary>
        public string ContentSecurityPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ContentSecurityPolicy property is set.
        /// </summary>
        internal bool IsSetContentSecurityPolicy() => this.ContentSecurityPolicy != null;

        /// <summary>
        /// Gets and sets the property ExceptionMessage. 
        /// <para>
        ///  Your account is pending verification. 
        /// </para>
        /// </summary>
        public string ExceptionMessage { get; set; }

        /// <summary>
        /// Checks to see if the ExceptionMessage property is set.
        /// </summary>
        internal bool IsSetExceptionMessage() => this.ExceptionMessage != null;

        /// <summary>
        /// Gets and sets the property StrictTransportSecurity.
        /// </summary>
        public string StrictTransportSecurity { get; set; }

        /// <summary>
        /// Checks to see if the StrictTransportSecurity property is set.
        /// </summary>
        internal bool IsSetStrictTransportSecurity() => this.StrictTransportSecurity != null;

        /// <summary>
        /// Gets and sets the property XAmznErrorType.
        /// </summary>
        public string XAmznErrorType { get; set; }

        /// <summary>
        /// Checks to see if the XAmznErrorType property is set.
        /// </summary>
        internal bool IsSetXAmznErrorType() => this.XAmznErrorType != null;

        /// <summary>
        /// Gets and sets the property XContentTypeOptions.
        /// </summary>
        public string XContentTypeOptions { get; set; }

        /// <summary>
        /// Checks to see if the XContentTypeOptions property is set.
        /// </summary>
        internal bool IsSetXContentTypeOptions() => this.XContentTypeOptions != null;

        /// <summary>
        /// Gets and sets the property XFrameOptions.
        /// </summary>
        public string XFrameOptions { get; set; }

        /// <summary>
        /// Checks to see if the XFrameOptions property is set.
        /// </summary>
        internal bool IsSetXFrameOptions() => this.XFrameOptions != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the PendingVerificationException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected PendingVerificationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.AccessControlAllowOrigin = (string)info.GetValue("AccessControlAllowOrigin", typeof(string));
            this.AccessControlExposeHeaders = (string)info.GetValue("AccessControlExposeHeaders", typeof(string));
            this.CacheControl = (string)info.GetValue("CacheControl", typeof(string));
            this.ContentSecurityPolicy = (string)info.GetValue("ContentSecurityPolicy", typeof(string));
            this.ExceptionMessage = (string)info.GetValue("ExceptionMessage", typeof(string));
            this.StrictTransportSecurity = (string)info.GetValue("StrictTransportSecurity", typeof(string));
            this.XAmznErrorType = (string)info.GetValue("XAmznErrorType", typeof(string));
            this.XContentTypeOptions = (string)info.GetValue("XContentTypeOptions", typeof(string));
            this.XFrameOptions = (string)info.GetValue("XFrameOptions", typeof(string));
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
            info.AddValue("AccessControlAllowOrigin", this.AccessControlAllowOrigin);
            info.AddValue("AccessControlExposeHeaders", this.AccessControlExposeHeaders);
            info.AddValue("CacheControl", this.CacheControl);
            info.AddValue("ContentSecurityPolicy", this.ContentSecurityPolicy);
            info.AddValue("ExceptionMessage", this.ExceptionMessage);
            info.AddValue("StrictTransportSecurity", this.StrictTransportSecurity);
            info.AddValue("XAmznErrorType", this.XAmznErrorType);
            info.AddValue("XContentTypeOptions", this.XContentTypeOptions);
            info.AddValue("XFrameOptions", this.XFrameOptions);
        }
#endif
    }
}
