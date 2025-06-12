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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// You exceeded your service quota. Service quotas, also referred to as limits, are the
    /// maximum number of service resources or operations for your Amazon Web Services account.
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class ServiceQuotaExceededException : AmazonDeadlineException
    {
        private Dictionary<string, string> _context = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _quotaCode;
        private ServiceQuotaExceededExceptionReason _reason;
        private string _resourceId;
        private string _resourceType;
        private string _serviceCode;

        /// <summary>
        /// Constructs a new ServiceQuotaExceededException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ServiceQuotaExceededException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of ServiceQuotaExceededException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ServiceQuotaExceededException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of ServiceQuotaExceededException
        /// </summary>
        /// <param name="innerException"></param>
        public ServiceQuotaExceededException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of ServiceQuotaExceededException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ServiceQuotaExceededException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of ServiceQuotaExceededException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ServiceQuotaExceededException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the ServiceQuotaExceededException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected ServiceQuotaExceededException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Context = (Dictionary<string, string>)info.GetValue("Context", typeof(Dictionary<string, string>));
            this.QuotaCode = (string)info.GetValue("QuotaCode", typeof(string));
            this.Reason = (ServiceQuotaExceededExceptionReason)info.GetValue("Reason", typeof(ServiceQuotaExceededExceptionReason));
            this.ResourceId = (string)info.GetValue("ResourceId", typeof(string));
            this.ResourceType = (string)info.GetValue("ResourceType", typeof(string));
            this.ServiceCode = (string)info.GetValue("ServiceCode", typeof(string));
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
            info.AddValue("Context", this.Context);
            info.AddValue("QuotaCode", this.QuotaCode);
            info.AddValue("Reason", this.Reason);
            info.AddValue("ResourceId", this.ResourceId);
            info.AddValue("ResourceType", this.ResourceType);
            info.AddValue("ServiceCode", this.ServiceCode);
        }
#endif

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Information about the resources in use when the exception was thrown.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null && (this._context.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QuotaCode. 
        /// <para>
        /// Identifies the quota that has been exceeded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// A string that describes the reason the quota was exceeded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceQuotaExceededExceptionReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the affected resource.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the affected resource
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// Identifies the service that exceeded the quota.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}