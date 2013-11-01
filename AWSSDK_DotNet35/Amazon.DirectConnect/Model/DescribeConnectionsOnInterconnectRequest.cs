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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConnectionsOnInterconnect operation.
    /// <para>Return a list of connections that have been provisioned on the given interconnect.</para>
    /// </summary>
    public partial class DescribeConnectionsOnInterconnectRequest : AmazonDirectConnectRequest
    {
        private string interconnectId;


        /// <summary>
        /// ID of the interconnect on which a list of connection is provisioned. Example: dxcon-abc123 Default: None
        ///  
        /// </summary>
        public string InterconnectId
        {
            get { return this.interconnectId; }
            set { this.interconnectId = value; }
        }

        // Check to see if InterconnectId property is set
        internal bool IsSetInterconnectId()
        {
            return this.interconnectId != null;
        }

    }
}
    
