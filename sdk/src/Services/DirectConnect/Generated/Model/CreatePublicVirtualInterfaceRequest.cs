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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePublicVirtualInterface operation.
    /// Creates a public virtual interface. A virtual interface is the VLAN that transports
    /// Direct Connect traffic. A public virtual interface supports sending traffic to public
    /// services of Amazon Web Services such as Amazon S3.
    /// 
    ///  
    /// <para>
    /// When creating an IPv6 public virtual interface (<c>addressFamily</c> is <c>ipv6</c>),
    /// leave the <c>customer</c> and <c>amazon</c> address fields blank to use auto-assigned
    /// IPv6 space. Custom IPv6 addresses are not supported.
    /// </para>
    /// </summary>
    public partial class CreatePublicVirtualInterfaceRequest : AmazonDirectConnectRequest
    {
        private string _connectionId;
        private NewPublicVirtualInterface _newPublicVirtualInterface;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Information about the public virtual interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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