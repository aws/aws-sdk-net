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

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// The service can't be created because a service with the same name already exists.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class ServiceAlreadyExistsException : AmazonServiceDiscoveryException
    {
        /// <summary>
        /// Default constructor for ServiceAlreadyExistsException
        /// message.
        /// </summary>
        public ServiceAlreadyExistsException() : base() { }

        /// <summary>
        /// Constructs a new ServiceAlreadyExistsException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ServiceAlreadyExistsException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of ServiceAlreadyExistsException
        /// </summary>
        public ServiceAlreadyExistsException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of ServiceAlreadyExistsException
        /// </summary>
        public ServiceAlreadyExistsException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of ServiceAlreadyExistsException
        /// </summary>
        public ServiceAlreadyExistsException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of ServiceAlreadyExistsException
        /// </summary>
        public ServiceAlreadyExistsException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// The <c>CreatorRequestId</c> that was used to create the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The ARN of the existing service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the existing service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceId property is set.
        /// </summary>
        internal bool IsSetServiceId() => this.ServiceId != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the ServiceAlreadyExistsException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected ServiceAlreadyExistsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.CreatorRequestId = (string)info.GetValue("CreatorRequestId", typeof(string));
            this.ServiceArn = (string)info.GetValue("ServiceArn", typeof(string));
            this.ServiceId = (string)info.GetValue("ServiceId", typeof(string));
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
            info.AddValue("CreatorRequestId", this.CreatorRequestId);
            info.AddValue("ServiceArn", this.ServiceArn);
            info.AddValue("ServiceId", this.ServiceId);
        }
#endif
    }
}
