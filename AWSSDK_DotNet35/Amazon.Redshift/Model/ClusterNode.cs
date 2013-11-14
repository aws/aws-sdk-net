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
    public class ClusterNode
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

        // Check to see if PublicIPAddress property is set
        internal bool IsSetPublicIPAddress()
        {
            return this.publicIPAddress != null;
        }
    }
}
