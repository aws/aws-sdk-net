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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the public endpoint configuration of a deployment of an Amazon Lightsail
    /// container service.
    /// </summary>
    public partial class ContainerServiceEndpoint
    {
        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container entry of the deployment that the endpoint configuration
        /// applies to.
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
        /// The port of the specified container to which traffic is forwarded to.
        /// </para>
        /// </summary>
        public int? ContainerPort { get; set; }

        /// <summary>
        /// Checks to see if the ContainerPort property is set.
        /// </summary>
        internal bool IsSetContainerPort() => this.ContainerPort.HasValue;

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// An object that describes the health check configuration of the container.
        /// </para>
        /// </summary>
        public ContainerServiceHealthCheckConfig HealthCheck { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheck property is set.
        /// </summary>
        internal bool IsSetHealthCheck() => this.HealthCheck != null;
    }
}
