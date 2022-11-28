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
    /// The Service Connect service object configuration. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
    /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </summary>
    public partial class ServiceConnectService
    {
        private List<ServiceConnectClientAlias> _clientAliases = new List<ServiceConnectClientAlias>();
        private string _discoveryName;
        private int? _ingressPortOverride;
        private string _portName;

        /// <summary>
        /// Gets and sets the property ClientAliases. 
        /// <para>
        /// The list of client aliases for this Service Connect service. You use these to assign
        /// names that can be used by client applications. The maximum number of client aliases
        /// that you can have in this list is 1.
        /// </para>
        ///  
        /// <para>
        /// Each alias ("endpoint") is a fully-qualified name and port number that other Amazon
        /// ECS tasks ("clients") can use to connect to this service.
        /// </para>
        ///  
        /// <para>
        /// Each name and port mapping must be unique within the namespace.
        /// </para>
        ///  
        /// <para>
        /// For each <code>ServiceConnectService</code>, you must provide at least one <code>clientAlias</code>
        /// with one <code>port</code>.
        /// </para>
        /// </summary>
        public List<ServiceConnectClientAlias> ClientAliases
        {
            get { return this._clientAliases; }
            set { this._clientAliases = value; }
        }

        // Check to see if ClientAliases property is set
        internal bool IsSetClientAliases()
        {
            return this._clientAliases != null && this._clientAliases.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DiscoveryName. 
        /// <para>
        /// The <code>discoveryName</code> is the name of the new Cloud Map service that Amazon
        /// ECS creates for this Amazon ECS service. This must be unique within the Cloud Map
        /// namespace. Up to 64 characters are allowed. The characters can include lowercase letters,
        /// numbers, underscores (_), and hyphens (-). A hyphen can't be the first character.
        /// </para>
        ///  
        /// <para>
        /// If this field isn't specified, <code>portName</code> is used.
        /// </para>
        /// </summary>
        public string DiscoveryName
        {
            get { return this._discoveryName; }
            set { this._discoveryName = value; }
        }

        // Check to see if DiscoveryName property is set
        internal bool IsSetDiscoveryName()
        {
            return this._discoveryName != null;
        }

        /// <summary>
        /// Gets and sets the property IngressPortOverride. 
        /// <para>
        /// The port number for the Service Connect proxy to listen on.
        /// </para>
        ///  
        /// <para>
        /// Use the value of this field to bypass the proxy for traffic on the port number specified
        /// in the named <code>portMapping</code> in the task definition of this application,
        /// and then use it in your VPC security groups to allow traffic into the proxy for this
        /// Amazon ECS service.
        /// </para>
        ///  
        /// <para>
        /// In <code>awsvpc</code> mode and Fargate, the default value is the container port number.
        /// The container port number is in the <code>portMapping</code> in the task definition.
        /// In bridge mode, the default value is the ephemeral port of the Service Connect proxy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int IngressPortOverride
        {
            get { return this._ingressPortOverride.GetValueOrDefault(); }
            set { this._ingressPortOverride = value; }
        }

        // Check to see if IngressPortOverride property is set
        internal bool IsSetIngressPortOverride()
        {
            return this._ingressPortOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PortName. 
        /// <para>
        /// The <code>portName</code> must match the name of one of the <code>portMappings</code>
        /// from all the containers in the task definition of this Amazon ECS service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PortName
        {
            get { return this._portName; }
            set { this._portName = value; }
        }

        // Check to see if PortName property is set
        internal bool IsSetPortName()
        {
            return this._portName != null;
        }

    }
}