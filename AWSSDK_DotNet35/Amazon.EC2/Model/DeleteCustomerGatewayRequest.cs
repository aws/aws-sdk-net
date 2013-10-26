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
    /// Container for the parameters to the DeleteCustomerGateway operation.
    /// <para> Deletes a customer gateway. You must delete the VPN connection before deleting the customer gateway. </para> <para> You can have a
    /// single active customer gateway per AWS account (active means that you've created a VPN connection with that customer gateway). AWS might
    /// delete any customer gateway you leave inactive for an extended period of time. </para>
    /// </summary>
    public partial class DeleteCustomerGatewayRequest : AmazonEC2Request
    {
        private string customerGatewayId;


        /// <summary>
        /// The ID of the customer gateway to delete.
        ///  
        /// </summary>
        public string CustomerGatewayId
        {
            get { return this.customerGatewayId; }
            set { this.customerGatewayId = value; }
        }

        // Check to see if CustomerGatewayId property is set
        internal bool IsSetCustomerGatewayId()
        {
            return this.customerGatewayId != null;
        }

    }
}
    
