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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
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
    /// 
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class InternalServerException : AmazonIVSRealTimeException
    {
        private string _accessControlAllowOrigin;
        private string _accessControlExposeHeaders;
        private string _cacheControl;
        private string _contentSecurityPolicy;
        private string _exceptionMessage;
        private string _strictTransportSecurity;
        private string _xAmznErrorType;
        private string _xContentTypeOptions;
        private string _xFrameOptions;

        /// <summary>
        /// Constructs a new InternalServerException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public InternalServerException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of InternalServerException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public InternalServerException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of InternalServerException
        /// </summary>
        /// <param name="innerException"></param>
        public InternalServerException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of InternalServerException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public InternalServerException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of InternalServerException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public InternalServerException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the InternalServerException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected InternalServerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
        // These FxCop rules are giving false-positives for this method
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
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

        /// <summary>
        /// Gets and sets the property AccessControlAllowOrigin.
        /// </summary>
        public string AccessControlAllowOrigin
        {
            get { return this._accessControlAllowOrigin; }
            set { this._accessControlAllowOrigin = value; }
        }

        // Check to see if AccessControlAllowOrigin property is set
        internal bool IsSetAccessControlAllowOrigin()
        {
            return this._accessControlAllowOrigin != null;
        }

        /// <summary>
        /// Gets and sets the property AccessControlExposeHeaders.
        /// </summary>
        public string AccessControlExposeHeaders
        {
            get { return this._accessControlExposeHeaders; }
            set { this._accessControlExposeHeaders = value; }
        }

        // Check to see if AccessControlExposeHeaders property is set
        internal bool IsSetAccessControlExposeHeaders()
        {
            return this._accessControlExposeHeaders != null;
        }

        /// <summary>
        /// Gets and sets the property CacheControl.
        /// </summary>
        public string CacheControl
        {
            get { return this._cacheControl; }
            set { this._cacheControl = value; }
        }

        // Check to see if CacheControl property is set
        internal bool IsSetCacheControl()
        {
            return this._cacheControl != null;
        }

        /// <summary>
        /// Gets and sets the property ContentSecurityPolicy.
        /// </summary>
        public string ContentSecurityPolicy
        {
            get { return this._contentSecurityPolicy; }
            set { this._contentSecurityPolicy = value; }
        }

        // Check to see if ContentSecurityPolicy property is set
        internal bool IsSetContentSecurityPolicy()
        {
            return this._contentSecurityPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ExceptionMessage. 
        /// <para>
        /// Unexpected error during processing of request.
        /// </para>
        /// </summary>
        public string ExceptionMessage
        {
            get { return this._exceptionMessage; }
            set { this._exceptionMessage = value; }
        }

        // Check to see if ExceptionMessage property is set
        internal bool IsSetExceptionMessage()
        {
            return this._exceptionMessage != null;
        }

        /// <summary>
        /// Gets and sets the property StrictTransportSecurity.
        /// </summary>
        public string StrictTransportSecurity
        {
            get { return this._strictTransportSecurity; }
            set { this._strictTransportSecurity = value; }
        }

        // Check to see if StrictTransportSecurity property is set
        internal bool IsSetStrictTransportSecurity()
        {
            return this._strictTransportSecurity != null;
        }

        /// <summary>
        /// Gets and sets the property XAmznErrorType.
        /// </summary>
        public string XAmznErrorType
        {
            get { return this._xAmznErrorType; }
            set { this._xAmznErrorType = value; }
        }

        // Check to see if XAmznErrorType property is set
        internal bool IsSetXAmznErrorType()
        {
            return this._xAmznErrorType != null;
        }

        /// <summary>
        /// Gets and sets the property XContentTypeOptions.
        /// </summary>
        public string XContentTypeOptions
        {
            get { return this._xContentTypeOptions; }
            set { this._xContentTypeOptions = value; }
        }

        // Check to see if XContentTypeOptions property is set
        internal bool IsSetXContentTypeOptions()
        {
            return this._xContentTypeOptions != null;
        }

        /// <summary>
        /// Gets and sets the property XFrameOptions.
        /// </summary>
        public string XFrameOptions
        {
            get { return this._xFrameOptions; }
            set { this._xFrameOptions = value; }
        }

        // Check to see if XFrameOptions property is set
        internal bool IsSetXFrameOptions()
        {
            return this._xFrameOptions != null;
        }

    }
}