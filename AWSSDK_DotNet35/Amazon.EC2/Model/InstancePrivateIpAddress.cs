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
    /// <para>Describes a private IP address.</para>
    /// </summary>
    public class InstancePrivateIpAddress
    {
        
        private string privateIpAddress;
        private string privateDnsName;
        private bool? primary;
        private InstanceNetworkInterfaceAssociation association;


        /// <summary>
        /// The private IP address of the network interface.
        ///  
        /// </summary>
        public string PrivateIpAddress
        {
            get { return this.privateIpAddress; }
            set { this.privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this.privateIpAddress != null;
        }

        /// <summary>
        /// The private DNS name.
        ///  
        /// </summary>
        public string PrivateDnsName
        {
            get { return this.privateDnsName; }
            set { this.privateDnsName = value; }
        }

        // Check to see if PrivateDnsName property is set
        internal bool IsSetPrivateDnsName()
        {
            return this.privateDnsName != null;
        }

        /// <summary>
        /// Indicates whether this IP address is the primary private IP address of the network interface.
        ///  
        /// </summary>
        public bool Primary
        {
            get { return this.primary ?? default(bool); }
            set { this.primary = value; }
        }

        // Check to see if Primary property is set
        internal bool IsSetPrimary()
        {
            return this.primary.HasValue;
        }

        /// <summary>
        /// The association information for an Elastic IP address for the network interface.
        ///  
        /// </summary>
        public InstanceNetworkInterfaceAssociation Association
        {
            get { return this.association; }
            set { this.association = value; }
        }

        // Check to see if Association property is set
        internal bool IsSetAssociation()
        {
            return this.association != null;
        }
    }
}
