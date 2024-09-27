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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
namespace Amazon.PCS.Model
{
    /// <summary>
    /// You exceeded your service quota. Service quotas, also referred to as limits, are the
    /// maximum number of service resources or operations for your Amazon Web Services account.
    /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
    /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
    /// 
    ///  
    /// <para>
    ///  <u>Examples</u> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The max number of clusters or queues has been reached for the account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The max number of compute node groups has been reached for the associated cluster.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The total of <c>maxInstances</c> across all compute node groups has been reached for
    /// associated cluster.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class ServiceQuotaExceededException : AmazonPCSException
    {
        private string _quotaCode;
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
            this.QuotaCode = (string)info.GetValue("QuotaCode", typeof(string));
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
            info.AddValue("QuotaCode", this.QuotaCode);
            info.AddValue("ResourceId", this.ResourceId);
            info.AddValue("ResourceType", this.ResourceType);
            info.AddValue("ServiceCode", this.ServiceCode);
        }
#endif

        /// <summary>
        /// Gets and sets the property QuotaCode. 
        /// <para>
        ///  The <b>quota code</b> of the service quota that was exceeded. 
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        ///  The unique identifier of the resource that caused the quota to be exceeded. 
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
        ///  The type or category of the resource that caused the quota to be exceeded. 
        /// </para>
        /// </summary>
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
        ///  The service code associated with the quota that was exceeded. 
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