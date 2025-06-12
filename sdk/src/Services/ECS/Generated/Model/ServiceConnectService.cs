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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The Service Connect service object configuration. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
    /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </summary>
    public partial class ServiceConnectService
    {
        private List<ServiceConnectClientAlias> _clientAliases = AWSConfigs.InitializeCollections ? new List<ServiceConnectClientAlias>() : null;
        private string _discoveryName;
        private int? _ingressPortOverride;
        private string _portName;
        private TimeoutConfiguration _timeout;
        private ServiceConnectTlsConfiguration _tls;

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
        /// For each <c>ServiceConnectService</c>, you must provide at least one <c>clientAlias</c>
        /// with one <c>port</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceConnectClientAlias> ClientAliases
        {
            get { return this._clientAliases; }
            set { this._clientAliases = value; }
        }

        // Check to see if ClientAliases property is set
        internal bool IsSetClientAliases()
        {
            return this._clientAliases != null && (this._clientAliases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DiscoveryName. 
        /// <para>
        /// The <c>discoveryName</c> is the name of the new Cloud Map service that Amazon ECS
        /// creates for this Amazon ECS service. This must be unique within the Cloud Map namespace.
        /// The name can contain up to 64 characters. The name can include lowercase letters,
        /// numbers, underscores (_), and hyphens (-). The name can't start with a hyphen.
        /// </para>
        ///  
        /// <para>
        /// If the <c>discoveryName</c> isn't specified, the port mapping name from the task definition
        /// is used in <c>portName.namespace</c>.
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
        /// in the named <c>portMapping</c> in the task definition of this application, and then
        /// use it in your VPC security groups to allow traffic into the proxy for this Amazon
        /// ECS service.
        /// </para>
        ///  
        /// <para>
        /// In <c>awsvpc</c> mode and Fargate, the default value is the container port number.
        /// The container port number is in the <c>portMapping</c> in the task definition. In
        /// bridge mode, the default value is the ephemeral port of the Service Connect proxy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int? IngressPortOverride
        {
            get { return this._ingressPortOverride; }
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
        /// The <c>portName</c> must match the name of one of the <c>portMappings</c> from all
        /// the containers in the task definition of this Amazon ECS service.
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

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// A reference to an object that represents the configured timeouts for Service Connect.
        /// </para>
        /// </summary>
        public TimeoutConfiguration Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout != null;
        }

        /// <summary>
        /// Gets and sets the property Tls. 
        /// <para>
        /// A reference to an object that represents a Transport Layer Security (TLS) configuration.
        /// </para>
        /// </summary>
        public ServiceConnectTlsConfiguration Tls
        {
            get { return this._tls; }
            set { this._tls = value; }
        }

        // Check to see if Tls property is set
        internal bool IsSetTls()
        {
            return this._tls != null;
        }

    }
}