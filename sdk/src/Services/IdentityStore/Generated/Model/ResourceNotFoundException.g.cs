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

namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// Indicates that a requested resource is not found.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class ResourceNotFoundException : AmazonIdentityStoreException
    {
        /// <summary>
        /// Default constructor for ResourceNotFoundException
        /// message.
        /// </summary>
        public ResourceNotFoundException() : base() { }

        /// <summary>
        /// Constructs a new ResourceNotFoundException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ResourceNotFoundException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of ResourceNotFoundException
        /// </summary>
        public ResourceNotFoundException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of ResourceNotFoundException
        /// </summary>
        public ResourceNotFoundException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of ResourceNotFoundException
        /// </summary>
        public ResourceNotFoundException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of ResourceNotFoundException
        /// </summary>
        public ResourceNotFoundException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// Indicates the reason for a resource not found error when the service is unable to
        /// access a Customer Managed KMS key. For non-KMS permission errors, this field is not
        /// included.
        /// </para>
        /// </summary>
        public ResourceNotFoundExceptionReason Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier for a resource in the identity store that can be used as <c>UserId</c>
        /// or <c>GroupId</c>. The format for <c>ResourceId</c> is either <c>UUID</c> or <c>1234567890-UUID</c>,
        /// where <c>UUID</c> is a randomly generated value for each resource when it is created
        /// and <c>1234567890</c> represents the <c> IdentityStoreId</c> string value. In the
        /// case that the identity store is migrated from a legacy SSO identity store, the <c>ResourceId</c>
        /// for that identity store will be in the format of <c>UUID</c>. Otherwise, it will be
        /// in the <c>1234567890-UUID</c> format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// An enum object indicating the type of resource in the identity store service. Valid
        /// values include USER, GROUP, and IDENTITY_STORE.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the ResourceNotFoundException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected ResourceNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Reason = (ResourceNotFoundExceptionReason)info.GetValue("Reason", typeof(ResourceNotFoundExceptionReason));
            this.RequestId = (string)info.GetValue("RequestId", typeof(string));
            this.ResourceId = (string)info.GetValue("ResourceId", typeof(string));
            this.ResourceType = (ResourceType)info.GetValue("ResourceType", typeof(ResourceType));
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
            info.AddValue("Reason", this.Reason);
            info.AddValue("RequestId", this.RequestId);
            info.AddValue("ResourceId", this.ResourceId);
            info.AddValue("ResourceType", this.ResourceType);
        }
#endif
    }
}
