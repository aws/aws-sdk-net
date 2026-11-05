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
    /// Describes a container deployment configuration of an Amazon Lightsail container service.
    /// 
    ///  
    /// <para>
    /// A deployment specifies the settings, such as the ports and launch command, of containers
    /// that are deployed to your container service.
    /// </para>
    /// </summary>
    public partial class ContainerServiceDeploymentRequest
    {
        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// An object that describes the configuration for the containers of the deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Container> Containers { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Container>() : null;

        /// <summary>
        /// Checks to see if the Containers property is set.
        /// </summary>
        internal bool IsSetContainers() => this.Containers != null && (this.Containers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PublicEndpoint. 
        /// <para>
        /// An object that describes the endpoint of the deployment.
        /// </para>
        /// </summary>
        public EndpointRequest PublicEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the PublicEndpoint property is set.
        /// </summary>
        internal bool IsSetPublicEndpoint() => this.PublicEndpoint != null;
    }
}
