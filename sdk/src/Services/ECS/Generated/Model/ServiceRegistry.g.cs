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
    /// The details for the service registry.
    /// 
    ///  
    /// <para>
    /// Each service may be associated with one service registry. Multiple service registries
    /// for each service are not supported.
    /// </para>
    ///  
    /// <para>
    /// When you add, update, or remove the service registries configuration, Amazon ECS starts
    /// a new deployment. New tasks are registered and deregistered to the updated service
    /// registry configuration.
    /// </para>
    /// </summary>
    public partial class ServiceRegistry
    {
        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The container name value to be used for your service discovery service. It's already
        /// specified in the task definition. If the task definition that your service task specifies
        /// uses the <c>bridge</c> or <c>host</c> network mode, you must specify a <c>containerName</c>
        /// and <c>containerPort</c> combination from the task definition. If the task definition
        /// that your service task specifies uses the <c>awsvpc</c> network mode and a type SRV
        /// DNS record is used, you must specify either a <c>containerName</c> and <c>containerPort</c>
        /// combination or a <c>port</c> value. However, you can't specify both.
        /// </para>
        /// </summary>
        public string ContainerName { get; set; }

        /// <summary>
        /// Checks to see if the ContainerName property is set.
        /// </summary>
        internal bool IsSetContainerName() => this.ContainerName != null;

        /// <summary>
        /// Gets and sets the property ContainerPort. 
        /// <para>
        /// The port value to be used for your service discovery service. It's already specified
        /// in the task definition. If the task definition your service task specifies uses the
        /// <c>bridge</c> or <c>host</c> network mode, you must specify a <c>containerName</c>
        /// and <c>containerPort</c> combination from the task definition. If the task definition
        /// your service task specifies uses the <c>awsvpc</c> network mode and a type SRV DNS
        /// record is used, you must specify either a <c>containerName</c> and <c>containerPort</c>
        /// combination or a <c>port</c> value. However, you can't specify both.
        /// </para>
        /// </summary>
        public int? ContainerPort { get; set; }

        /// <summary>
        /// Checks to see if the ContainerPort property is set.
        /// </summary>
        internal bool IsSetContainerPort() => this.ContainerPort.HasValue;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port value used if your service discovery service specified an SRV record. This
        /// field might be used if both the <c>awsvpc</c> network mode and SRV records are used.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property RegistryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service registry. The currently supported service
        /// registry is Cloud Map. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_CreateService.html">CreateService</a>.
        /// </para>
        /// </summary>
        public string RegistryArn { get; set; }

        /// <summary>
        /// Checks to see if the RegistryArn property is set.
        /// </summary>
        internal bool IsSetRegistryArn() => this.RegistryArn != null;
    }
}
