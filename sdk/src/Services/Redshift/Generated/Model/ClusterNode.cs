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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// The identifier of a node in a cluster.
    /// </summary>
    public partial class ClusterNode
    {
        private string _nodeRole;
        private string _privateIPAddress;
        private string _publicIPAddress;

        /// <summary>
        /// Gets and sets the property NodeRole. 
        /// <para>
        /// Whether the node is a leader node or a compute node.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string NodeRole
        {
            get { return this._nodeRole; }
            set { this._nodeRole = value; }
        }

        // Check to see if NodeRole property is set
        internal bool IsSetNodeRole()
        {
            return this._nodeRole != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIPAddress. 
        /// <para>
        /// The private IP address of a node within a cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string PrivateIPAddress
        {
            get { return this._privateIPAddress; }
            set { this._privateIPAddress = value; }
        }

        // Check to see if PrivateIPAddress property is set
        internal bool IsSetPrivateIPAddress()
        {
            return this._privateIPAddress != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIPAddress. 
        /// <para>
        /// The public IP address of a node within a cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string PublicIPAddress
        {
            get { return this._publicIPAddress; }
            set { this._publicIPAddress = value; }
        }

        // Check to see if PublicIPAddress property is set
        internal bool IsSetPublicIPAddress()
        {
            return this._publicIPAddress != null;
        }

    }
}