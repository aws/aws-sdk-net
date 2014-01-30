/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the DeleteVpc operation.
    /// <para>Deletes the specified VPC. You must detach or delete all gateways and resources that are associated with the VPC before you can delete
    /// it. For example, you must terminate all instances running in the VPC, delete all security groups associated with the VPC (except the default
    /// one), delete all route tables associated with the VPC (except the default one), and so on.</para>
    /// </summary>
    public partial class DeleteVpcRequest : AmazonEC2Request
    {
        private string vpcId;


        /// <summary>
        /// The ID of the VPC.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

    }
}
    
