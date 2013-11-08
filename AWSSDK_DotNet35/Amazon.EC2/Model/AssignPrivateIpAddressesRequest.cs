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
    /// Container for the parameters to the AssignPrivateIpAddresses operation.
    /// 
    /// </summary>
    public partial class AssignPrivateIpAddressesRequest : AmazonEC2Request
    {
        private string networkInterfaceId;
        private List<string> privateIpAddresses = new List<string>();
        private int? secondaryPrivateIpAddressCount;
        private bool? allowReassignment;

        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceId; }
            set { this.networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this.networkInterfaceId != null;
        }
        public List<string> PrivateIpAddresses
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
        public bool AllowReassignment
        {
            get { return this.allowReassignment ?? default(bool); }
            set { this.allowReassignment = value; }
        }

        // Check to see if AllowReassignment property is set
        internal bool IsSetAllowReassignment()
        {
            return this.allowReassignment.HasValue;
        }

    }
}
    
