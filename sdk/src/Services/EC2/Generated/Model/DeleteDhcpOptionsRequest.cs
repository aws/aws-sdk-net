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
    /// Container for the parameters to the DeleteDhcpOptions operation.
    /// Deletes the specified set of DHCP options. You must disassociate the set of DHCP options
    /// before you can delete it. You can disassociate the set of DHCP options by associating
    /// either a new set of options or the default set of options with the VPC.
    /// </summary>
    public partial class DeleteDhcpOptionsRequest : AmazonEC2Request
    {
        private string _dhcpOptionsId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteDhcpOptionsRequest() { }

        /// <summary>
        /// Instantiates DeleteDhcpOptionsRequest with the parameterized properties
        /// </summary>
        /// <param name="dhcpOptionsId">The ID of the DHCP options set.</param>
        public DeleteDhcpOptionsRequest(string dhcpOptionsId)
        {
            _dhcpOptionsId = dhcpOptionsId;
        }

        /// <summary>
        /// Gets and sets the property DhcpOptionsId. 
        /// <para>
        /// The ID of the DHCP options set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DhcpOptionsId
        {
            get { return this._dhcpOptionsId; }
            set { this._dhcpOptionsId = value; }
        }

        // Check to see if DhcpOptionsId property is set
        internal bool IsSetDhcpOptionsId()
        {
            return this._dhcpOptionsId != null;
        }

    }
}