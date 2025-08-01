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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
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
namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateNode operation.
    /// Associates a new node with the server. For more information about how to disassociate
    /// a node, see <a>DisassociateNode</a>.
    /// 
    ///  
    /// <para>
    ///  On a Chef server: This command is an alternative to <c>knife bootstrap</c>.
    /// </para>
    ///  
    /// <para>
    ///  Example (Chef): <c>aws opsworks-cm associate-node --server-name <i>MyServer</i> --node-name
    /// <i>MyManagedNode</i> --engine-attributes "Name=<i>CHEF_ORGANIZATION</i>,Value=default"
    /// "Name=<i>CHEF_AUTOMATE_NODE_PUBLIC_KEY</i>,Value=<i>public-key-pem</i>"</c> 
    /// </para>
    ///  
    /// <para>
    ///  On a Puppet server, this command is an alternative to the <c>puppet cert sign</c>
    /// command that signs a Puppet node CSR. 
    /// </para>
    ///  
    /// <para>
    ///  Example (Puppet): <c>aws opsworks-cm associate-node --server-name <i>MyServer</i>
    /// --node-name <i>MyManagedNode</i> --engine-attributes "Name=<i>PUPPET_NODE_CSR</i>,Value=<i>csr-pem</i>"</c>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  A node can can only be associated with servers that are in a <c>HEALTHY</c> state.
    /// Otherwise, an <c>InvalidStateException</c> is thrown. A <c>ResourceNotFoundException</c>
    /// is thrown when the server does not exist. A <c>ValidationException</c> is raised when
    /// parameters of the request are not valid. The AssociateNode API call can be integrated
    /// into Auto Scaling configurations, CloudFormation templates, or the user data of a
    /// server's instance. 
    /// </para>
    /// </summary>
    public partial class AssociateNodeRequest : AmazonOpsWorksCMRequest
    {
        private List<EngineAttribute> _engineAttributes = AWSConfigs.InitializeCollections ? new List<EngineAttribute>() : null;
        private string _nodeName;
        private string _serverName;

        /// <summary>
        /// Gets and sets the property EngineAttributes. 
        /// <para>
        /// Engine attributes used for associating the node. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Attributes accepted in a AssociateNode request for Chef</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CHEF_ORGANIZATION</c>: The Chef organization with which the node is associated.
        /// By default only one organization named <c>default</c> can exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CHEF_AUTOMATE_NODE_PUBLIC_KEY</c>: A PEM-formatted public key. This key is required
        /// for the <c>chef-client</c> agent to access the Chef API. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Attributes accepted in a AssociateNode request for Puppet</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PUPPET_NODE_CSR</c>: A PEM-formatted certificate-signing request (CSR) that is
        /// created by the node. 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EngineAttribute> EngineAttributes
        {
            get { return this._engineAttributes; }
            set { this._engineAttributes = value; }
        }

        // Check to see if EngineAttributes property is set
        internal bool IsSetEngineAttributes()
        {
            return this._engineAttributes != null && (this._engineAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the node. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=10000)]
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
        [AWSProperty(Required=true, Min=1, Max=40)]
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