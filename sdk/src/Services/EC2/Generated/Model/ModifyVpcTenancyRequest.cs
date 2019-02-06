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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the ModifyVpcTenancy operation.
    /// Modifies the instance tenancy attribute of the specified VPC. You can change the instance
    /// tenancy attribute of a VPC to <code>default</code> only. You cannot change the instance
    /// tenancy attribute to <code>dedicated</code>.
    /// 
    ///  
    /// <para>
    /// After you modify the tenancy of the VPC, any new instances that you launch into the
    /// VPC have a tenancy of <code>default</code>, unless you specify otherwise during launch.
    /// The tenancy of any existing instances in the VPC is not affected.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-instance.html">Dedicated
    /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyVpcTenancyRequest : AmazonEC2Request
    {
        private VpcTenancy _instanceTenancy;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property InstanceTenancy. 
        /// <para>
        /// The instance tenancy attribute for the VPC. 
        /// </para>
        /// </summary>
        public VpcTenancy InstanceTenancy
        {
            get { return this._instanceTenancy; }
            set { this._instanceTenancy = value; }
        }

        // Check to see if InstanceTenancy property is set
        internal bool IsSetInstanceTenancy()
        {
            return this._instanceTenancy != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
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