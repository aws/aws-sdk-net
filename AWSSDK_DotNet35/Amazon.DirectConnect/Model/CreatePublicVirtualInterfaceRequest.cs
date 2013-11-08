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
    /// Container for the parameters to the CreatePublicVirtualInterface operation.
    /// <para>Creates a new public virtual interface. A virtual interface is the VLAN that transports AWS Direct Connect traffic. A public virtual
    /// interface supports sending traffic to public services of AWS such as Amazon Simple Storage Service (Amazon S3).</para>
    /// </summary>
    public partial class CreatePublicVirtualInterfaceRequest : AmazonDirectConnectRequest
    {
        private string connectionId;
        private NewPublicVirtualInterface newPublicVirtualInterface;


        /// <summary>
        /// ID of the connection. Example: dxcon-fg5678gh Default: None
        ///  
        /// </summary>
        public string ConnectionId
        {
            get { return this.connectionId; }
            set { this.connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this.connectionId != null;
        }

        /// <summary>
        /// Detailed information of the public virtual interface to be created. Default: None
        ///  
        /// </summary>
        public NewPublicVirtualInterface NewPublicVirtualInterface
        {
            get { return this.newPublicVirtualInterface; }
            set { this.newPublicVirtualInterface = value; }
        }

        // Check to see if NewPublicVirtualInterface property is set
        internal bool IsSetNewPublicVirtualInterface()
        {
            return this.newPublicVirtualInterface != null;
        }

    }
}
    
