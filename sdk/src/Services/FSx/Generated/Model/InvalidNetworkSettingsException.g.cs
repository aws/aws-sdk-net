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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// One or more network settings specified in the request are invalid.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class InvalidNetworkSettingsException : AmazonFSxException
    {
        /// <summary>
        /// Default constructor for InvalidNetworkSettingsException
        /// message.
        /// </summary>
        public InvalidNetworkSettingsException() : base() { }

        /// <summary>
        /// Constructs a new InvalidNetworkSettingsException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public InvalidNetworkSettingsException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of InvalidNetworkSettingsException
        /// </summary>
        public InvalidNetworkSettingsException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of InvalidNetworkSettingsException
        /// </summary>
        public InvalidNetworkSettingsException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of InvalidNetworkSettingsException
        /// </summary>
        public InvalidNetworkSettingsException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of InvalidNetworkSettingsException
        /// </summary>
        public InvalidNetworkSettingsException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property InvalidRouteTableId. 
        /// <para>
        /// The route table ID is either invalid or not part of the VPC specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 21)]
        public string InvalidRouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the InvalidRouteTableId property is set.
        /// </summary>
        internal bool IsSetInvalidRouteTableId() => this.InvalidRouteTableId != null;

        /// <summary>
        /// Gets and sets the property InvalidSecurityGroupId. 
        /// <para>
        /// The security group ID is either invalid or not part of the VPC specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 20)]
        public string InvalidSecurityGroupId { get; set; }

        /// <summary>
        /// Checks to see if the InvalidSecurityGroupId property is set.
        /// </summary>
        internal bool IsSetInvalidSecurityGroupId() => this.InvalidSecurityGroupId != null;

        /// <summary>
        /// Gets and sets the property InvalidSubnetId. 
        /// <para>
        /// The subnet ID that is either invalid or not part of the VPC specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 24)]
        public string InvalidSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the InvalidSubnetId property is set.
        /// </summary>
        internal bool IsSetInvalidSubnetId() => this.InvalidSubnetId != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the InvalidNetworkSettingsException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected InvalidNetworkSettingsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.InvalidRouteTableId = (string)info.GetValue("InvalidRouteTableId", typeof(string));
            this.InvalidSecurityGroupId = (string)info.GetValue("InvalidSecurityGroupId", typeof(string));
            this.InvalidSubnetId = (string)info.GetValue("InvalidSubnetId", typeof(string));
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
            info.AddValue("InvalidRouteTableId", this.InvalidRouteTableId);
            info.AddValue("InvalidSecurityGroupId", this.InvalidSecurityGroupId);
            info.AddValue("InvalidSubnetId", this.InvalidSubnetId);
        }
#endif
    }
}
