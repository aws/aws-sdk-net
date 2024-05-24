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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents the elastic network interface for a multi-node parallel
    /// job node.
    /// </summary>
    public partial class NetworkInterface
    {
        private string _attachmentId;
        private string _ipv6Address;
        private string _privateIpv4Address;

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The attachment ID for the network interface.
        /// </para>
        /// </summary>
        public string AttachmentId
        {
            get { return this._attachmentId; }
            set { this._attachmentId = value; }
        }

        // Check to see if AttachmentId property is set
        internal bool IsSetAttachmentId()
        {
            return this._attachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// The private IPv6 address for the network interface.
        /// </para>
        /// </summary>
        public string Ipv6Address
        {
            get { return this._ipv6Address; }
            set { this._ipv6Address = value; }
        }

        // Check to see if Ipv6Address property is set
        internal bool IsSetIpv6Address()
        {
            return this._ipv6Address != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIpv4Address. 
        /// <para>
        /// The private IPv4 address for the network interface.
        /// </para>
        /// </summary>
        public string PrivateIpv4Address
        {
            get { return this._privateIpv4Address; }
            set { this._privateIpv4Address = value; }
        }

        // Check to see if PrivateIpv4Address property is set
        internal bool IsSetPrivateIpv4Address()
        {
            return this._privateIpv4Address != null;
        }

    }
}