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
    /// Container for the parameters to the DetachInternetGateway operation.
    /// <para> Detaches an Internet gateway from a VPC, disabling connectivity between the Internet and the VPC. The VPC must not contain any
    /// running instances with elastic IP addresses. For more information about your VPC and Internet gateway, go to Amazon Virtual Private Cloud
    /// User Guide. </para> <para> For more information about Amazon Virtual Private Cloud and Internet gateways, go to the Amazon Virtual Private
    /// Cloud User Guide. </para>
    /// </summary>
    public partial class DetachInternetGatewayRequest : AmazonEC2Request
    {
        private string internetGatewayId;
        private string vpcId;


        /// <summary>
        /// The ID of the Internet gateway to detach.
        ///  
        /// </summary>
        public string InternetGatewayId
        {
            get { return this.internetGatewayId; }
            set { this.internetGatewayId = value; }
        }

        // Check to see if InternetGatewayId property is set
        internal bool IsSetInternetGatewayId()
        {
            return this.internetGatewayId != null;
        }

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
    
