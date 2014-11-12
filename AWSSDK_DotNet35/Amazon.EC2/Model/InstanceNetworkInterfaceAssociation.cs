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
    /// Describes association information for an Elastic IP address.
    /// </summary>
    public partial class InstanceNetworkInterfaceAssociation
    {
        private string _ipOwnerId;
        private string _publicDnsName;
        private string _publicIp;

        /// <summary>
        /// Gets and sets the property IpOwnerId. 
        /// <para>
        /// The ID of the owner of the Elastic IP address.
        /// </para>
        /// </summary>
        public string IpOwnerId
        {
            get { return this._ipOwnerId; }
            set { this._ipOwnerId = value; }
        }

        // Check to see if IpOwnerId property is set
        internal bool IsSetIpOwnerId()
        {
            return this._ipOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property PublicDnsName. 
        /// <para>
        /// The public DNS name.
        /// </para>
        /// </summary>
        public string PublicDnsName
        {
            get { return this._publicDnsName; }
            set { this._publicDnsName = value; }
        }

        // Check to see if PublicDnsName property is set
        internal bool IsSetPublicDnsName()
        {
            return this._publicDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// The public IP address or Elastic IP address bound to the network interface.
        /// </para>
        /// </summary>
        public string PublicIp
        {
            get { return this._publicIp; }
            set { this._publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this._publicIp != null;
        }

    }
}