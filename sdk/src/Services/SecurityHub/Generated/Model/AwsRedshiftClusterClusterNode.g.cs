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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A node in an Amazon Redshift cluster.
    /// </summary>
    public partial class AwsRedshiftClusterClusterNode
    {
        /// <summary>
        /// Gets and sets the property NodeRole. 
        /// <para>
        /// The role of the node. A node might be a leader node or a compute node.
        /// </para>
        /// </summary>
        public string NodeRole { get; set; }

        /// <summary>
        /// Checks to see if the NodeRole property is set.
        /// </summary>
        internal bool IsSetNodeRole() => this.NodeRole != null;

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The private IP address of the node.
        /// </para>
        /// </summary>
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIpAddress property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddress() => this.PrivateIpAddress != null;

        /// <summary>
        /// Gets and sets the property PublicIpAddress. 
        /// <para>
        /// The public IP address of the node.
        /// </para>
        /// </summary>
        public string PublicIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PublicIpAddress property is set.
        /// </summary>
        internal bool IsSetPublicIpAddress() => this.PublicIpAddress != null;
    }
}
