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
    /// Container for the parameters to the EnableVpcClassicLink operation.
    /// Enables a VPC for ClassicLink. You can then link EC2-Classic instances to your ClassicLink-enabled
    /// VPC to allow communication over private IP addresses. You cannot enable your VPC for
    /// ClassicLink if any of your VPC's route tables have existing routes for address ranges
    /// within the <code>10.0.0.0/8</code> IP address range, excluding local routes for VPCs
    /// in the <code>10.0.0.0/16</code> and <code>10.1.0.0/16</code> IP address ranges. For
    /// more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
    /// in the Amazon Elastic Compute Cloud User Guide for Linux.
    /// </summary>
    public partial class EnableVpcClassicLinkRequest : AmazonEC2Request
    {
        private string _vpcId;

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