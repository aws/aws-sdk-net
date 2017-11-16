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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateNode operation.
    /// Associates a new node with the server. For more information about how to disassociate
    /// a node, see <a>DisassociateNode</a>.
    /// 
    ///  
    /// <para>
    ///  On a Chef server: This command is an alternative to <code>knife bootstrap</code>.
    /// </para>
    ///  
    /// <para>
    ///  Example (Chef): <code>aws opsworks-cm associate-node --server-name <i>MyServer</i>
    /// --node-name <i>MyManagedNode</i> --engine-attributes "Name=<i>CHEF_ORGANIZATION</i>,Value=default"
    /// "Name=<i>CHEF_NODE_PUBLIC_KEY</i>,Value=<i>public-key-pem</i>"</code> 
    /// </para>
    ///  
    /// <para>
    ///  On a Puppet server, this command is an alternative to the <code>puppet cert sign</code>
    /// command that signs a Puppet node CSR. 
    /// </para>
    ///  
    /// <para>
    ///  Example (Chef): <code>aws opsworks-cm associate-node --server-name <i>MyServer</i>
    /// --node-name <i>MyManagedNode</i> --engine-attributes "Name=<i>PUPPET_NODE_CSR</i>,Value=<i>csr-pem</i>"</code>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  A node can can only be associated with servers that are in a <code>HEALTHY</code>
    /// state. Otherwise, an <code>InvalidStateException</code> is thrown. A <code>ResourceNotFoundException</code>
    /// is thrown when the server does not exist. A <code>ValidationException</code> is raised
    /// when parameters of the request are not valid. The AssociateNode API call can be integrated
    /// into Auto Scaling configurations, AWS Cloudformation templates, or the user data of
    /// a server's instance. 
    /// </para>
    /// </summary>
    public partial class AssociateNodeRequest : AmazonOpsWorksCMRequest
    {
        private List<EngineAttribute> _engineAttributes = new List<EngineAttribute>();
        private string _nodeName;
        private string _serverName;

        /// <summary>
        /// Gets and sets the property EngineAttributes. 
        /// <para>
        /// Engine attributes used for associating the node. 
        /// </para>
        ///  <p class="title"> <b>Attributes accepted in a AssociateNode request for Chef</b>
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CHEF_ORGANIZATION</code>: The Chef organization with which the node is associated.
        /// By default only one organization named <code>default</code> can exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CHEF_NODE_PUBLIC_KEY</code>: A PEM-formatted public key. This key is required
        /// for the <code>chef-client</code> agent to access the Chef API. 
        /// </para>
        ///  </li> </ul> <p class="title"> <b>Attributes accepted in a AssociateNode request for
        /// Puppet</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PUPPET_NODE_CSR</code>: A PEM-formatted certificate-signing request (CSR) that
        /// is created by the node. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<EngineAttribute> EngineAttributes
        {
            get { return this._engineAttributes; }
            set { this._engineAttributes = value; }
        }

        // Check to see if EngineAttributes property is set
        internal bool IsSetEngineAttributes()
        {
            return this._engineAttributes != null && this._engineAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the node. 
        /// </para>
        /// </summary>
        public string NodeName
        {
            get { return this._nodeName; }
            set { this._nodeName = value; }
        }

        // Check to see if NodeName property is set
        internal bool IsSetNodeName()
        {
            return this._nodeName != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server with which to associate the node. 
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

    }
}