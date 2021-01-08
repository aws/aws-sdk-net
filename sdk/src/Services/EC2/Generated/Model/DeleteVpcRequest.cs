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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteVpc operation.
    /// Deletes the specified VPC. You must detach or delete all gateways and resources that
    /// are associated with the VPC before you can delete it. For example, you must terminate
    /// all instances running in the VPC, delete all security groups associated with the VPC
    /// (except the default one), delete all route tables associated with the VPC (except
    /// the default one), and so on.
    /// </summary>
    public partial class DeleteVpcRequest : AmazonEC2Request
    {
        private string _vpcId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteVpcRequest() { }

        /// <summary>
        /// Instantiates DeleteVpcRequest with the parameterized properties
        /// </summary>
        /// <param name="vpcId">The ID of the VPC.</param>
        public DeleteVpcRequest(string vpcId)
        {
            _vpcId = vpcId;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
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