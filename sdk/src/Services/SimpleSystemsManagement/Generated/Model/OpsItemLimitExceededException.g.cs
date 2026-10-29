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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The request caused OpsItems to exceed one or more quotas.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class OpsItemLimitExceededException : AmazonSimpleSystemsManagementException
    {
        /// <summary>
        /// Default constructor for OpsItemLimitExceededException
        /// message.
        /// </summary>
        public OpsItemLimitExceededException() : base() { }

        /// <summary>
        /// Constructs a new OpsItemLimitExceededException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public OpsItemLimitExceededException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of OpsItemLimitExceededException
        /// </summary>
        public OpsItemLimitExceededException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of OpsItemLimitExceededException
        /// </summary>
        public OpsItemLimitExceededException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of OpsItemLimitExceededException
        /// </summary>
        public OpsItemLimitExceededException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of OpsItemLimitExceededException
        /// </summary>
        public OpsItemLimitExceededException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property Limit.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property LimitType.
        /// </summary>
        public string LimitType { get; set; }

        /// <summary>
        /// Checks to see if the LimitType property is set.
        /// </summary>
        internal bool IsSetLimitType() => this.LimitType != null;

        /// <summary>
        /// Gets and sets the property ResourceTypes.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypes property is set.
        /// </summary>
        internal bool IsSetResourceTypes() => this.ResourceTypes != null && (this.ResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the OpsItemLimitExceededException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected OpsItemLimitExceededException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Limit = (int?)info.GetValue("Limit", typeof(int?));
            this.LimitType = (string)info.GetValue("LimitType", typeof(string));
            this.ResourceTypes = (List<string>)info.GetValue("ResourceTypes", typeof(List<string>));
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
            info.AddValue("Limit", this.Limit);
            info.AddValue("LimitType", this.LimitType);
            info.AddValue("ResourceTypes", this.ResourceTypes);
        }
#endif
    }
}
