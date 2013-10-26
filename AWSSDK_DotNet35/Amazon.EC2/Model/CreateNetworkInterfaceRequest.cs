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
    /// Container for the parameters to the CreateNetworkInterface operation.
    /// 
    /// </summary>
    public partial class CreateNetworkInterfaceRequest : AmazonEC2Request
    {
        private string subnetId;
        private string description;
        private string privateIpAddress;
        private List<string> groups = new List<string>();
        private List<PrivateIpAddressSpecification> privateIpAddresses = new List<PrivateIpAddressSpecification>();
        private int? secondaryPrivateIpAddressCount;

        public string SubnetId
        {
            get { return this.subnetId; }
            set { this.subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this.subnetId != null;
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }
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
        public List<string> Groups
        {
            get { return this.groups; }
            set { this.groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this.groups.Count > 0;
        }
        public List<PrivateIpAddressSpecification> PrivateIpAddresses
        {
            get { return this.privateIpAddresses; }
            set { this.privateIpAddresses = value; }
        }

        // Check to see if PrivateIpAddresses property is set
        internal bool IsSetPrivateIpAddresses()
        {
            return this.privateIpAddresses.Count > 0;
        }
        public int SecondaryPrivateIpAddressCount
        {
            get { return this.secondaryPrivateIpAddressCount ?? default(int); }
            set { this.secondaryPrivateIpAddressCount = value; }
        }

        // Check to see if SecondaryPrivateIpAddressCount property is set
        internal bool IsSetSecondaryPrivateIpAddressCount()
        {
            return this.secondaryPrivateIpAddressCount.HasValue;
        }

    }
}
    
