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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes association information for an Elastic IP address.</para>
    /// </summary>
    public class InstanceNetworkInterfaceAssociation
    {
        
        private string publicIp;
        private string publicDnsName;
        private string ipOwnerId;


        /// <summary>
        /// The address of the Elastic IP address bound to the network interface.
        ///  
        /// </summary>
        public string PublicIp
        {
            get { return this.publicIp; }
            set { this.publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this.publicIp != null;
        }

        /// <summary>
        /// The public DNS name.
        ///  
        /// </summary>
        public string PublicDnsName
        {
            get { return this.publicDnsName; }
            set { this.publicDnsName = value; }
        }

        // Check to see if PublicDnsName property is set
        internal bool IsSetPublicDnsName()
        {
            return this.publicDnsName != null;
        }

        /// <summary>
        /// The ID of the owner of the Elastic IP address.
        ///  
        /// </summary>
        public string IpOwnerId
        {
            get { return this.ipOwnerId; }
            set { this.ipOwnerId = value; }
        }

        // Check to see if IpOwnerId property is set
        internal bool IsSetIpOwnerId()
        {
            return this.ipOwnerId != null;
        }
    }
}
