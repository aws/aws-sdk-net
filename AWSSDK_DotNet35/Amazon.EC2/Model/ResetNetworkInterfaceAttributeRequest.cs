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
    /// Container for the parameters to the ResetNetworkInterfaceAttribute operation.
    /// <para>Resets a network interface attribute. You can specify only one attribute at a time.</para>
    /// </summary>
    public partial class ResetNetworkInterfaceAttributeRequest : AmazonEC2Request
    {
        private string networkInterfaceId;
        private string sourceDestCheck;


        /// <summary>
        /// The ID of the network interface.
        ///  
        /// </summary>
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

        /// <summary>
        /// Indicates whether source/destination checking is enabled. A value of <c>true</c> means checking is enabled, and <c>false</c> means checking
        /// is disabled. This value must be <c>false</c> for a NAT instance to perform NAT.
        ///  
        /// </summary>
        public string SourceDestCheck
        {
            get { return this.sourceDestCheck; }
            set { this.sourceDestCheck = value; }
        }

        // Check to see if SourceDestCheck property is set
        internal bool IsSetSourceDestCheck()
        {
            return this.sourceDestCheck != null;
        }

    }
}
    
