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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the CreateContainerAssociation operation. Creates
    /// a Network Firewall container association. The association monitors container lifecycle
    /// events in your Amazon ECS or Amazon EKS clusters and resolves running container addresses
    /// for use in firewall rules.
    /// </summary>
    public partial class CreateContainerAssociationRequest : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property ContainerAssociationName. 
        /// <para>
        /// The descriptive name of the container association. You can't change the name of a
        /// container association after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ContainerAssociationName { get; set; }

        /// <summary>
        /// Checks to see if the ContainerAssociationName property is set.
        /// </summary>
        internal bool IsSetContainerAssociationName() => this.ContainerAssociationName != null;

        /// <summary>
        /// Gets and sets the property ContainerMonitoringConfigurations. 
        /// <para>
        /// The monitoring configurations for the container association. Each configuration specifies
        /// an Amazon ECS or Amazon EKS cluster to monitor and optional attribute filters to narrow
        /// which containers are tracked.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ContainerMonitoringConfiguration> ContainerMonitoringConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ContainerMonitoringConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ContainerMonitoringConfigurations property is set.
        /// </summary>
        internal bool IsSetContainerMonitoringConfigurations() => this.ContainerMonitoringConfigurations != null && (this.ContainerMonitoringConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the container association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of containers to monitor. You can't change the container type after creation.
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ECS</c> - Amazon Elastic Container Service
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EKS</c> - Amazon Elastic Kubernetes Service
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContainerMonitoringType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
