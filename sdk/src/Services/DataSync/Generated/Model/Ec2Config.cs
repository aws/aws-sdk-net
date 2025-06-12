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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The subnet and security groups that DataSync uses to connect to one of your Amazon
    /// EFS file system's <a href="https://docs.aws.amazon.com/efs/latest/ug/accessing-fs.html">mount
    /// targets</a>.
    /// </summary>
    public partial class Ec2Config
    {
        private List<string> _securityGroupArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _subnetArn;

        /// <summary>
        /// Gets and sets the property SecurityGroupArns. 
        /// <para>
        /// Specifies the Amazon Resource Names (ARNs) of the security groups associated with
        /// an Amazon EFS file system's mount target.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> SecurityGroupArns
        {
            get { return this._securityGroupArns; }
            set { this._securityGroupArns = value; }
        }

        // Check to see if SecurityGroupArns property is set
        internal bool IsSetSecurityGroupArns()
        {
            return this._securityGroupArns != null && (this._securityGroupArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetArn. 
        /// <para>
        /// Specifies the ARN of a subnet where DataSync creates the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/datasync-network.html#required-network-interfaces">network
        /// interfaces</a> for managing traffic during your transfer.
        /// </para>
        ///  
        /// <para>
        /// The subnet must be located:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// In the same virtual private cloud (VPC) as the Amazon EFS file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the same Availability Zone as at least one mount target for the Amazon EFS file
        /// system.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You don't need to specify a subnet that includes a file system mount target.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string SubnetArn
        {
            get { return this._subnetArn; }
            set { this._subnetArn = value; }
        }

        // Check to see if SubnetArn property is set
        internal bool IsSetSubnetArn()
        {
            return this._subnetArn != null;
        }

    }
}