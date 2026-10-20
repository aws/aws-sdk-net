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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The Service Connect configuration of your Amazon ECS service. The configuration for
    /// this service to discover and connect to services, and be discovered by, and connected
    /// from, other services within a namespace.
    /// 
    ///  
    /// <para>
    /// Tasks that run in a namespace can use short names to connect to services in the namespace.
    /// Tasks can connect to services across all of the clusters in the namespace. Tasks connect
    /// through a managed proxy container that collects logs and metrics for increased visibility.
    /// Only the tasks that Amazon ECS services create are supported with Service Connect.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
    /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ServiceConnectConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccessLogConfiguration. 
        /// <para>
        /// The configuration for Service Connect access logging. Access logs capture detailed
        /// information about requests made to your service, including request patterns, response
        /// codes, and timing data. They can be useful for debugging connectivity issues, monitoring
        /// service performance, and auditing service-to-service communication for security and
        /// compliance purposes.
        /// </para>
        ///  <note> 
        /// <para>
        /// To enable access logs, you must also specify a <c>logConfiguration</c> in the <c>serviceConnectConfiguration</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public ServiceConnectAccessLogConfiguration AccessLogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AccessLogConfiguration property is set.
        /// </summary>
        internal bool IsSetAccessLogConfiguration() => this.AccessLogConfiguration != null;

        /// <summary>
        /// Gets and sets the property ContainerConfigurations. 
        /// <para>
        /// The settings for the Service Connect proxy container that Amazon ECS adds to each
        /// task in this service. Each object in the list sets exactly one setting, and each setting
        /// can appear only once in the list.
        /// </para>
        ///  
        /// <para>
        /// Your changes to these settings apply only to tasks that Amazon ECS launches after
        /// you update the service. Your running tasks keep their existing settings until Amazon
        /// ECS replaces them. If you update the <c>serviceConnectConfiguration</c> of your service
        /// and don't include <c>containerConfigurations</c>, the proxy container settings return
        /// to their defaults.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<ServiceConnectContainerConfiguration> ContainerConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceConnectContainerConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ContainerConfigurations property is set.
        /// </summary>
        internal bool IsSetContainerConfigurations() => this.ContainerConfigurations != null && (this.ContainerConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether to use Service Connect with this service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property LogConfiguration.
        /// </summary>
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace name or full Amazon Resource Name (ARN) of the Cloud Map namespace for
        /// use with Service Connect. The namespace must be in the same Amazon Web Services Region
        /// as the Amazon ECS service and cluster. The type of namespace doesn't affect Service
        /// Connect. For more information about Cloud Map, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/working-with-services.html">Working
        /// with Services</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property Services. 
        /// <para>
        /// The list of Service Connect service objects. These are names and aliases (also known
        /// as endpoints) that are used by other Amazon ECS services to connect to this service.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This field is not required for a "client" Amazon ECS service that's a member of a
        /// namespace only to connect to other services within the namespace. An example of this
        /// would be a frontend application that accepts incoming requests from either a load
        /// balancer that's attached to the service or by other means.
        /// </para>
        ///  
        /// <para>
        /// An object selects a port from the task definition, assigns a name for the Cloud Map
        /// service, and a list of aliases (endpoints) and ports for client applications to refer
        /// to this service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceConnectService> Services { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceConnectService>() : null;

        /// <summary>
        /// Checks to see if the Services property is set.
        /// </summary>
        internal bool IsSetServices() => this.Services != null && (this.Services.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
