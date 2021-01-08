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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The configuration details for the App Mesh proxy.
    /// 
    ///  
    /// <para>
    /// For tasks using the EC2 launch type, the container instances require at least version
    /// 1.26.0 of the container agent and at least version 1.26.0-1 of the <code>ecs-init</code>
    /// package to enable a proxy configuration. If your container instances are launched
    /// from the Amazon ECS-optimized AMI version <code>20190301</code> or later, then they
    /// contain the required versions of the container agent and <code>ecs-init</code>. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-optimized_AMI.html">Amazon
    /// ECS-optimized Linux AMI</a> 
    /// </para>
    /// </summary>
    public partial class ProxyConfiguration
    {
        private string _containerName;
        private List<KeyValuePair> _properties = new List<KeyValuePair>();
        private ProxyConfigurationType _type;

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container that will serve as the App Mesh proxy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// The set of network configuration parameters to provide the Container Network Interface
        /// (CNI) plugin, specified as key-value pairs.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>IgnoredUID</code> - (Required) The user ID (UID) of the proxy container as
        /// defined by the <code>user</code> parameter in a container definition. This is used
        /// to ensure the proxy ignores its own traffic. If <code>IgnoredGID</code> is specified,
        /// this field can be empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IgnoredGID</code> - (Required) The group ID (GID) of the proxy container as
        /// defined by the <code>user</code> parameter in a container definition. This is used
        /// to ensure the proxy ignores its own traffic. If <code>IgnoredUID</code> is specified,
        /// this field can be empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AppPorts</code> - (Required) The list of ports that the application uses. Network
        /// traffic to these ports is forwarded to the <code>ProxyIngressPort</code> and <code>ProxyEgressPort</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ProxyIngressPort</code> - (Required) Specifies the port that incoming traffic
        /// to the <code>AppPorts</code> is directed to.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ProxyEgressPort</code> - (Required) Specifies the port that outgoing traffic
        /// from the <code>AppPorts</code> is directed to.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EgressIgnoredPorts</code> - (Required) The egress traffic going to the specified
        /// ports is ignored and not redirected to the <code>ProxyEgressPort</code>. It can be
        /// an empty list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EgressIgnoredIPs</code> - (Required) The egress traffic going to the specified
        /// IP addresses is ignored and not redirected to the <code>ProxyEgressPort</code>. It
        /// can be an empty list.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<KeyValuePair> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && this._properties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The proxy type. The only supported value is <code>APPMESH</code>.
        /// </para>
        /// </summary>
        public ProxyConfigurationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}