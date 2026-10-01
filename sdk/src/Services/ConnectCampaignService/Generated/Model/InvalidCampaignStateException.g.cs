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

namespace Amazon.ConnectCampaignService.Model
{
    /// <summary>
    /// The request could not be processed because of conflict in the current state of the
    /// campaign.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class InvalidCampaignStateException : AmazonConnectCampaignServiceException
    {
        /// <summary>
        /// Default constructor for InvalidCampaignStateException
        /// message.
        /// </summary>
        public InvalidCampaignStateException() : base() { }

        /// <summary>
        /// Constructs a new InvalidCampaignStateException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public InvalidCampaignStateException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of InvalidCampaignStateException
        /// </summary>
        public InvalidCampaignStateException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of InvalidCampaignStateException
        /// </summary>
        public InvalidCampaignStateException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of InvalidCampaignStateException
        /// </summary>
        public InvalidCampaignStateException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of InvalidCampaignStateException
        /// </summary>
        public InvalidCampaignStateException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property State.
        /// </summary>
        [AWSProperty(Required = true)]
        public CampaignState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property XAmzErrorType.
        /// </summary>
        public string XAmzErrorType { get; set; }

        /// <summary>
        /// Checks to see if the XAmzErrorType property is set.
        /// </summary>
        internal bool IsSetXAmzErrorType() => this.XAmzErrorType != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the InvalidCampaignStateException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected InvalidCampaignStateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.State = (CampaignState)info.GetValue("State", typeof(CampaignState));
            this.XAmzErrorType = (string)info.GetValue("XAmzErrorType", typeof(string));
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
            info.AddValue("State", this.State);
            info.AddValue("XAmzErrorType", this.XAmzErrorType);
        }
#endif
    }
}
