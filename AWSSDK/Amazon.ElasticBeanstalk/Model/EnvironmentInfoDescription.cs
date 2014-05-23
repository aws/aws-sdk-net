/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// The information retrieved from the Amazon EC2 instances.
    /// </summary>
    public partial class EnvironmentInfoDescription
    {
        private string _ec2InstanceId;
        private string _infoType;
        private string _message;
        private DateTime? _sampleTimestamp;


        /// <summary>
        /// Gets and sets the property Ec2InstanceId. 
        /// <para>
        /// The Amazon EC2 Instance ID for this information.
        /// </para>
        /// </summary>
        public string Ec2InstanceId
        {
            get { return this._ec2InstanceId; }
            set { this._ec2InstanceId = value; }
        }


        /// <summary>
        /// Sets the Ec2InstanceId property
        /// </summary>
        /// <param name="ec2InstanceId">The value to set for the Ec2InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentInfoDescription WithEc2InstanceId(string ec2InstanceId)
        {
            this._ec2InstanceId = ec2InstanceId;
            return this;
        }

        // Check to see if Ec2InstanceId property is set
        internal bool IsSetEc2InstanceId()
        {
            return this._ec2InstanceId != null;
        }


        /// <summary>
        /// Gets and sets the property InfoType. 
        /// <para>
        /// The type of information retrieved.
        /// </para>
        /// </summary>
        public string InfoType
        {
            get { return this._infoType; }
            set { this._infoType = value; }
        }


        /// <summary>
        /// Sets the InfoType property
        /// </summary>
        /// <param name="infoType">The value to set for the InfoType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentInfoDescription WithInfoType(string infoType)
        {
            this._infoType = infoType;
            return this;
        }

        // Check to see if InfoType property is set
        internal bool IsSetInfoType()
        {
            return this._infoType != null;
        }


        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The retrieved information.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }


        /// <summary>
        /// Sets the Message property
        /// </summary>
        /// <param name="message">The value to set for the Message property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentInfoDescription WithMessage(string message)
        {
            this._message = message;
            return this;
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }


        /// <summary>
        /// Gets and sets the property SampleTimestamp. 
        /// <para>
        /// The time stamp when this information was retrieved.
        /// </para>
        /// </summary>
        public DateTime SampleTimestamp
        {
            get { return this._sampleTimestamp.GetValueOrDefault(); }
            set { this._sampleTimestamp = value; }
        }


        /// <summary>
        /// Sets the SampleTimestamp property
        /// </summary>
        /// <param name="sampleTimestamp">The value to set for the SampleTimestamp property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentInfoDescription WithSampleTimestamp(DateTime sampleTimestamp)
        {
            this._sampleTimestamp = sampleTimestamp;
            return this;
        }

        // Check to see if SampleTimestamp property is set
        internal bool IsSetSampleTimestamp()
        {
            return this._sampleTimestamp.HasValue; 
        }

    }
}