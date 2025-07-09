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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateSecurityGroupVpc operation.
    /// Associates a security group with another VPC in the same Region. This enables you
    /// to use the same security group with network interfaces and instances in the specified
    /// VPC.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// The VPC you want to associate the security group with must be in the same Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can associate the security group with another VPC if your account owns the VPC
    /// or if the VPC was shared with you.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must own the security group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You cannot use this feature with default security groups.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You cannot use this feature with the default VPC.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class AssociateSecurityGroupVpcRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _groupId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// A security group ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// A VPC ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}