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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The host property details.
    /// </summary>
    public partial class HostPropertiesResponse
    {
        /// <summary>
        /// Gets and sets the property Ec2InstanceArn. 
        /// <para>
        /// The ARN of the host EC2 instance.
        /// </para>
        /// </summary>
        public string Ec2InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceArn property is set.
        /// </summary>
        internal bool IsSetEc2InstanceArn() => this.Ec2InstanceArn != null;

        /// <summary>
        /// Gets and sets the property Ec2InstanceType. 
        /// <para>
        /// The instance type of the host EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Ec2InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceType property is set.
        /// </summary>
        internal bool IsSetEc2InstanceType() => this.Ec2InstanceType != null;

        /// <summary>
        /// Gets and sets the property HostName. 
        /// <para>
        /// The host name.
        /// </para>
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// Checks to see if the HostName property is set.
        /// </summary>
        internal bool IsSetHostName() => this.HostName != null;

        /// <summary>
        /// Gets and sets the property IpAddresses. 
        /// <para>
        /// The IP address of the host.
        /// </para>
        /// </summary>
        public IpAddresses IpAddresses { get; set; }

        /// <summary>
        /// Checks to see if the IpAddresses property is set.
        /// </summary>
        internal bool IsSetIpAddresses() => this.IpAddresses != null;
    }
}
