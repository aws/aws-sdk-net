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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Request would cause a service quota to be exceeded.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class ServiceQuotaExceededException : AmazonSSMIncidentsException
    {
        /// <summary>
        /// Default constructor for ServiceQuotaExceededException
        /// message.
        /// </summary>
        public ServiceQuotaExceededException() : base() { }

        /// <summary>
        /// Constructs a new ServiceQuotaExceededException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ServiceQuotaExceededException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of ServiceQuotaExceededException
        /// </summary>
        public ServiceQuotaExceededException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of ServiceQuotaExceededException
        /// </summary>
        public ServiceQuotaExceededException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of ServiceQuotaExceededException
        /// </summary>
        public ServiceQuotaExceededException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of ServiceQuotaExceededException
        /// </summary>
        public ServiceQuotaExceededException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property QuotaCode. Originating quota code
        /// </summary>
        [AWSProperty(Required = true)]
        public string QuotaCode { get; set; }

        /// <summary>
        /// Checks to see if the QuotaCode property is set.
        /// </summary>
        internal bool IsSetQuotaCode() => this.QuotaCode != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. The identifier for the requested resource
        /// </summary>
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceType. The resource type
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property ServiceCode. Originating service code
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceCode ServiceCode { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCode property is set.
        /// </summary>
        internal bool IsSetServiceCode() => this.ServiceCode != null;

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
            this.ResourceIdentifier = (string)info.GetValue("ResourceIdentifier", typeof(string));
            this.ResourceType = (ResourceType)info.GetValue("ResourceType", typeof(ResourceType));
            this.ServiceCode = (ServiceCode)info.GetValue("ServiceCode", typeof(ServiceCode));
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
            info.AddValue("QuotaCode", this.QuotaCode);
            info.AddValue("ResourceIdentifier", this.ResourceIdentifier);
            info.AddValue("ResourceType", this.ResourceType);
            info.AddValue("ServiceCode", this.ServiceCode);
        }
#endif
    }
}
