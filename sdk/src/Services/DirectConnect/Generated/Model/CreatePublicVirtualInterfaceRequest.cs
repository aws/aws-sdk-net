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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
    /// Creates a new public virtual interface. A virtual interface is the VLAN that transports
    /// AWS Direct Connect traffic. A public virtual interface supports sending traffic to
    /// public services of AWS such as Amazon Simple Storage Service (Amazon S3).
    /// 
    ///  
    /// <para>
    /// When creating an IPv6 public virtual interface (addressFamily is 'ipv6'), the customer
    /// and amazon address fields should be left blank to use auto-assigned IPv6 space. Custom
    /// IPv6 Addresses are currently not supported.
    /// </para>
    /// </summary>
    public partial class CreatePublicVirtualInterfaceRequest : AmazonDirectConnectRequest
    {
        private string _connectionId;
        private NewPublicVirtualInterface _newPublicVirtualInterface;

        /// <summary>
        /// Gets and sets the property ConnectionId.
        /// </summary>
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property NewPublicVirtualInterface. 
        /// <para>
        /// Detailed information for the public virtual interface to be created.
        /// </para>
        ///  
        /// <para>
        /// Default: None
        /// </para>
        /// </summary>
        public NewPublicVirtualInterface NewPublicVirtualInterface
        {
            get { return this._newPublicVirtualInterface; }
            set { this._newPublicVirtualInterface = value; }
        }

        // Check to see if NewPublicVirtualInterface property is set
        internal bool IsSetNewPublicVirtualInterface()
        {
            return this._newPublicVirtualInterface != null;
        }

    }
}