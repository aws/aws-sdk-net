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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// The Amazon GameLift Servers service limits for an Amazon EC2 instance type and current
    /// utilization. Amazon GameLift Servers allows Amazon Web Services accounts a maximum
    /// number of instances, per instance type, per Amazon Web Services Region or location,
    /// for use with Amazon GameLift Servers. You can request a limit increase for your account
    /// by using the <b>Service limits</b> page in the Amazon GameLift Servers console.
    /// </summary>
    public partial class EC2InstanceLimit
    {
        /// <summary>
        /// Gets and sets the property CurrentInstances. 
        /// <para>
        /// The number of instances for the specified type and location that are currently being
        /// used by the Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CurrentInstances { get; set; }

        /// <summary>
        /// Checks to see if the CurrentInstances property is set.
        /// </summary>
        internal bool IsSetCurrentInstances() => this.CurrentInstances.HasValue;

        /// <summary>
        /// Gets and sets the property EC2InstanceType. 
        /// <para>
        /// The name of an Amazon EC2 instance type. See <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// Elastic Compute Cloud Instance Types</a> for detailed descriptions. 
        /// </para>
        /// </summary>
        public EC2InstanceType EC2InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the EC2InstanceType property is set.
        /// </summary>
        internal bool IsSetEC2InstanceType() => this.EC2InstanceType != null;

        /// <summary>
        /// Gets and sets the property InstanceLimit. 
        /// <para>
        /// The number of instances that is allowed for the specified instance type and location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? InstanceLimit { get; set; }

        /// <summary>
        /// Checks to see if the InstanceLimit property is set.
        /// </summary>
        internal bool IsSetInstanceLimit() => this.InstanceLimit.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// An Amazon Web Services Region code, such as <c>us-west-2</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;
    }
}
