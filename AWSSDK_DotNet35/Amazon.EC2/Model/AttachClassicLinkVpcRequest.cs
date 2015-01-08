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

/*
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AttachClassicLinkVpc operation.
    /// Links an EC2-Classic instance to a ClassicLink-enabled VPC through one or more of
    /// the VPC's security groups. You cannot link an EC2-Classic instance to more than one
    /// VPC at a time. You can only link an instance that's in the <code>running</code> state.
    /// An instance is automatically unlinked from a VPC when it's stopped - you can link
    /// it to the VPC again when you restart it.
    /// 
    ///  
    /// <para>
    /// After you've linked an instance, you cannot change the VPC security groups that are
    /// associated with it. To change the security groups, you must first unlink the instance,
    /// and then link it again. 
    /// </para>
    ///  
    /// <para>
    /// Linking your instance to a VPC is sometimes referred to as <i>attaching</i> your instance.
    /// </para>
    /// </summary>
    public partial class AttachClassicLinkVpcRequest : AmazonEC2Request
    {
        private List<string> _groups = new List<string>();
        private string _instanceId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The ID of one or more of the VPC's security groups. You cannot specify security groups
        /// from a different VPC.
        /// </para>
        /// </summary>
        public List<string> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && this._groups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of an EC2-Classic instance to link to the ClassicLink-enabled VPC.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of a ClassicLink-enabled VPC.
        /// </para>
        /// </summary>
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