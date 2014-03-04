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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>The identifier of a node in a cluster. --> </para>
    /// </summary>
    public partial class ClusterNode
    {
        
        private string nodeRole;
        private string privateIPAddress;
        private string publicIPAddress;

        /// <summary>
        /// Whether the node is a leader node or a compute node.
        ///  
        /// </summary>
        public string NodeRole
        {
            get { return this.nodeRole; }
            set { this.nodeRole = value; }
        }

        /// <summary>
        /// Sets the NodeRole property
        /// </summary>
        /// <param name="nodeRole">The value to set for the NodeRole property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterNode WithNodeRole(string nodeRole)
        {
            this.nodeRole = nodeRole;
            return this;
        }
            

        // Check to see if NodeRole property is set
        internal bool IsSetNodeRole()
        {
            return this.nodeRole != null;
        }

        /// <summary>
        /// The private IP address of a node within a cluster.
        ///  
        /// </summary>
        public string PrivateIPAddress
        {
            get { return this.privateIPAddress; }
            set { this.privateIPAddress = value; }
        }

        /// <summary>
        /// Sets the PrivateIPAddress property
        /// </summary>
        /// <param name="privateIPAddress">The value to set for the PrivateIPAddress property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterNode WithPrivateIPAddress(string privateIPAddress)
        {
            this.privateIPAddress = privateIPAddress;
            return this;
        }
            

        // Check to see if PrivateIPAddress property is set
        internal bool IsSetPrivateIPAddress()
        {
            return this.privateIPAddress != null;
        }

        /// <summary>
        /// The public IP address of a node within a cluster.
        ///  
        /// </summary>
        public string PublicIPAddress
        {
            get { return this.publicIPAddress; }
            set { this.publicIPAddress = value; }
        }

        /// <summary>
        /// Sets the PublicIPAddress property
        /// </summary>
        /// <param name="publicIPAddress">The value to set for the PublicIPAddress property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterNode WithPublicIPAddress(string publicIPAddress)
        {
            this.publicIPAddress = publicIPAddress;
            return this;
        }
            

        // Check to see if PublicIPAddress property is set
        internal bool IsSetPublicIPAddress()
        {
            return this.publicIPAddress != null;
        }
    }
}
