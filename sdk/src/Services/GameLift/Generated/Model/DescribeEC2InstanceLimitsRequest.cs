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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
    /// Container for the parameters to the DescribeEC2InstanceLimits operation.
    /// Retrieves the instance limits and current utilization for an Amazon Web Services Region
    /// or location. Instance limits control the number of instances, per instance type, per
    /// location, that your Amazon Web Services account can use. Learn more at <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
    /// EC2 Instance Types</a>. The information returned includes the maximum number of instances
    /// allowed and your account's current usage across all fleets. This information can affect
    /// your ability to scale your Amazon GameLift Servers fleets. You can request a limit
    /// increase for your account by using the <b>Service limits</b> page in the Amazon GameLift
    /// Servers console.
    /// 
    ///  
    /// <para>
    /// Instance limits differ based on whether the instances are deployed in a fleet's home
    /// Region or in a remote location. For remote locations, limits also differ based on
    /// the combination of home Region and remote location. All requests must specify an Amazon
    /// Web Services Region (either explicitly or as your default settings). To get the limit
    /// for a remote location, you must also specify the location. For example, the following
    /// requests all return different results: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Request specifies the Region <c>ap-northeast-1</c> with no location. The result is
    /// limits and usage data on all instance types that are deployed in <c>us-east-2</c>,
    /// by all of the fleets that reside in <c>ap-northeast-1</c>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Request specifies the Region <c>us-east-1</c> with location <c>ca-central-1</c>. The
    /// result is limits and usage data on all instance types that are deployed in <c>ca-central-1</c>,
    /// by all of the fleets that reside in <c>us-east-2</c>. These limits do not affect fleets
    /// in any other Regions that deploy instances to <c>ca-central-1</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Request specifies the Region <c>eu-west-1</c> with location <c>ca-central-1</c>. The
    /// result is limits and usage data on all instance types that are deployed in <c>ca-central-1</c>,
    /// by all of the fleets that reside in <c>eu-west-1</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation can be used in the following ways:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To get limit and usage data for all instance types that are deployed in an Amazon
    /// Web Services Region by fleets that reside in the same Region: Specify the Region only.
    /// Optionally, specify a single instance type to retrieve information for.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To get limit and usage data for all instance types that are deployed to a remote location
    /// by fleets that reside in different Amazon Web Services Region: Provide both the Amazon
    /// Web Services Region and the remote location. Optionally, specify a single instance
    /// type to retrieve information for.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If successful, an <c>EC2InstanceLimits</c> object is returned with limits and usage
    /// data for each requested instance type.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
    /// up Amazon GameLift Servers fleets</a> 
    /// </para>
    /// </summary>
    public partial class DescribeEC2InstanceLimitsRequest : AmazonGameLiftRequest
    {
        private EC2InstanceType _ec2InstanceType;
        private string _location;

        /// <summary>
        /// Gets and sets the property EC2InstanceType. 
        /// <para>
        /// Name of an Amazon EC2 instance type that is supported in Amazon GameLift Servers.
        /// A fleet instance type determines the computing resources of each instance in the fleet,
        /// including CPU, memory, storage, and networking capacity. Do not specify a value for
        /// this parameter to retrieve limits for all instance types.
        /// </para>
        /// </summary>
        public EC2InstanceType EC2InstanceType
        {
            get { return this._ec2InstanceType; }
            set { this._ec2InstanceType = value; }
        }

        // Check to see if EC2InstanceType property is set
        internal bool IsSetEC2InstanceType()
        {
            return this._ec2InstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The name of a remote location to request instance limits for, in the form of an Amazon
        /// Web Services Region code such as <c>us-west-2</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}