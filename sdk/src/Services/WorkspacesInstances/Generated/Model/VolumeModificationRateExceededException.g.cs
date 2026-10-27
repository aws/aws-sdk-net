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

namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// The volume has a previous modification that is still in progress, or has reached the
    /// limit of four modifications in a rolling 24-hour period. Wait for the current modification
    /// to finish, or wait until the time indicated in the error message, and then retry the
    /// request.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class VolumeModificationRateExceededException : AmazonWorkspacesInstancesException
    {
        /// <summary>
        /// Default constructor for VolumeModificationRateExceededException
        /// message.
        /// </summary>
        public VolumeModificationRateExceededException() : base() { }

        /// <summary>
        /// Constructs a new VolumeModificationRateExceededException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public VolumeModificationRateExceededException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of VolumeModificationRateExceededException
        /// </summary>
        public VolumeModificationRateExceededException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of VolumeModificationRateExceededException
        /// </summary>
        public VolumeModificationRateExceededException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of VolumeModificationRateExceededException
        /// </summary>
        public VolumeModificationRateExceededException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of VolumeModificationRateExceededException
        /// </summary>
        public VolumeModificationRateExceededException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Specifies the identifier of the volume for which the modification request was rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies the type of the resource for which the modification request was rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the VolumeModificationRateExceededException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected VolumeModificationRateExceededException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.ResourceId = (string)info.GetValue("ResourceId", typeof(string));
            this.ResourceType = (string)info.GetValue("ResourceType", typeof(string));
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
            info.AddValue("ResourceId", this.ResourceId);
            info.AddValue("ResourceType", this.ResourceType);
        }
#endif
    }
}
