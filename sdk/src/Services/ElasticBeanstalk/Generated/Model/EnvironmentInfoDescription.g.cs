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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// The information retrieved from the Amazon EC2 instances.
    /// </summary>
    public partial class EnvironmentInfoDescription
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public EnvironmentInfoDescription() { }

        /// <summary>
        /// Gets and sets the property Ec2InstanceId. 
        /// <para>
        /// The Amazon EC2 Instance ID for this information.
        /// </para>
        /// </summary>
        public string Ec2InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceId property is set.
        /// </summary>
        internal bool IsSetEc2InstanceId() => this.Ec2InstanceId != null;

        /// <summary>
        /// Gets and sets the property InfoType. 
        /// <para>
        /// The type of information retrieved.
        /// </para>
        /// </summary>
        public EnvironmentInfoType InfoType { get; set; }

        /// <summary>
        /// Checks to see if the InfoType property is set.
        /// </summary>
        internal bool IsSetInfoType() => this.InfoType != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The retrieved information. Currently contains a presigned Amazon S3 URL. The files
        /// are deleted after 15 minutes.
        /// </para>
        ///  
        /// <para>
        /// Anyone in possession of this URL can access the files before they are deleted. Make
        /// the URL available only to trusted parties.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property SampleTimestamp. 
        /// <para>
        /// The time stamp when this information was retrieved.
        /// </para>
        /// </summary>
        public DateTime? SampleTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the SampleTimestamp property is set.
        /// </summary>
        internal bool IsSetSampleTimestamp() => this.SampleTimestamp.HasValue;
    }
}
