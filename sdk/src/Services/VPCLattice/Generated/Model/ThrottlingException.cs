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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// The limit on the number of requests per second was exceeded.
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class ThrottlingException : AmazonVPCLatticeException
    {
        private string _quotaCode;
        private int? _retryAfterSeconds;
        private string _serviceCode;

        private RetryableDetails _retryableDetails = new RetryableDetails(true);

        /// <summary>
        /// Constructs a new ThrottlingException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ThrottlingException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of ThrottlingException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ThrottlingException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of ThrottlingException
        /// </summary>
        /// <param name="innerException"></param>
        public ThrottlingException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of ThrottlingException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ThrottlingException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of ThrottlingException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ThrottlingException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the ThrottlingException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected ThrottlingException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.QuotaCode = (string)info.GetValue("QuotaCode", typeof(string));
            this.RetryAfterSeconds = (int)info.GetValue("RetryAfterSeconds", typeof(int));
            this.ServiceCode = (string)info.GetValue("ServiceCode", typeof(string));
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
        // These FxCop rules are giving false-positives for this method
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("QuotaCode", this.QuotaCode);
            info.AddValue("RetryAfterSeconds", this.RetryAfterSeconds);
            info.AddValue("ServiceCode", this.ServiceCode);
        }
#endif

        /// <summary>
        /// Gets and sets the property QuotaCode. 
        /// <para>
        /// The ID of the service quota that was exceeded.
        /// </para>
        /// </summary>
        public string QuotaCode
        {
            get { return this._quotaCode; }
            set { this._quotaCode = value; }
        }

        // Check to see if QuotaCode property is set
        internal bool IsSetQuotaCode()
        {
            return this._quotaCode != null;
        }

        /// <summary>
        /// Gets and sets the property RetryAfterSeconds. 
        /// <para>
        /// The number of seconds to wait before retrying.
        /// </para>
        /// </summary>
        public int RetryAfterSeconds
        {
            get { return this._retryAfterSeconds.GetValueOrDefault(); }
            set { this._retryAfterSeconds = value; }
        }

        // Check to see if RetryAfterSeconds property is set
        internal bool IsSetRetryAfterSeconds()
        {
            return this._retryAfterSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// The service code.
        /// </para>
        /// </summary>
        public string ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

        /// <summary>
        /// Flag indicating if the exception is retryable and the associated retry
        /// details. A null value indicates that the exception is not retryable.
        /// </summary>
        public override RetryableDetails Retryable
        {
            get
            {
                return _retryableDetails;
            }
        }
    }
}