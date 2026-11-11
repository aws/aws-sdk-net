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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about a deployment configuration.
    /// </summary>
    public partial class DeploymentConfigInfo
    {
        /// <summary>
        /// Gets and sets the property ComputePlatform. 
        /// <para>
        /// The destination platform type for the deployment (<c>Lambda</c>, <c>Server</c>, or
        /// <c>ECS</c>).
        /// </para>
        /// </summary>
        public ComputePlatform ComputePlatform { get; set; }

        /// <summary>
        /// Checks to see if the ComputePlatform property is set.
        /// </summary>
        internal bool IsSetComputePlatform() => this.ComputePlatform != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the deployment configuration was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentConfigId. 
        /// <para>
        /// The deployment configuration ID.
        /// </para>
        /// </summary>
        public string DeploymentConfigId { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfigId property is set.
        /// </summary>
        internal bool IsSetDeploymentConfigId() => this.DeploymentConfigId != null;

        /// <summary>
        /// Gets and sets the property DeploymentConfigName. 
        /// <para>
        /// The deployment configuration name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DeploymentConfigName { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfigName property is set.
        /// </summary>
        internal bool IsSetDeploymentConfigName() => this.DeploymentConfigName != null;

        /// <summary>
        /// Gets and sets the property MinimumHealthyHosts. 
        /// <para>
        /// Information about the number or percentage of minimum healthy instances.
        /// </para>
        /// </summary>
        public MinimumHealthyHosts MinimumHealthyHosts { get; set; }

        /// <summary>
        /// Checks to see if the MinimumHealthyHosts property is set.
        /// </summary>
        internal bool IsSetMinimumHealthyHosts() => this.MinimumHealthyHosts != null;

        /// <summary>
        /// Gets and sets the property TrafficRoutingConfig. 
        /// <para>
        /// The configuration that specifies how the deployment traffic is routed. Used for deployments
        /// with a Lambda or Amazon ECS compute platform only.
        /// </para>
        /// </summary>
        public TrafficRoutingConfig TrafficRoutingConfig { get; set; }

        /// <summary>
        /// Checks to see if the TrafficRoutingConfig property is set.
        /// </summary>
        internal bool IsSetTrafficRoutingConfig() => this.TrafficRoutingConfig != null;

        /// <summary>
        /// Gets and sets the property ZonalConfig. 
        /// <para>
        /// Information about a zonal configuration.
        /// </para>
        /// </summary>
        public ZonalConfig ZonalConfig { get; set; }

        /// <summary>
        /// Checks to see if the ZonalConfig property is set.
        /// </summary>
        internal bool IsSetZonalConfig() => this.ZonalConfig != null;
    }
}
