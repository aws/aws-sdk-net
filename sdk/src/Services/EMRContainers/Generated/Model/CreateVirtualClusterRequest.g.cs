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

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVirtualCluster operation. Creates a virtual
    /// cluster. Virtual cluster is a managed entity on Amazon EMR on EKS. You can create,
    /// update, describe, list and delete virtual clusters. They do not consume any additional
    /// resource in your system. A single virtual cluster maps to a single Kubernetes namespace.
    /// Given this relationship, you can model virtual clusters the same way you model Kubernetes
    /// namespaces to meet your requirements.
    /// </summary>
    public partial class CreateVirtualClusterRequest : AmazonEMRContainersRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token of the virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ContainerProvider. 
        /// <para>
        /// The container provider of the virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContainerProvider ContainerProvider { get; set; }

        /// <summary>
        /// Checks to see if the ContainerProvider property is set.
        /// </summary>
        internal bool IsSetContainerProvider() => this.ContainerProvider != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The specified name of the virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SchedulerConfiguration. 
        /// <para>
        /// The scheduler configuration (concurrency and queue limits) to apply to the virtual
        /// cluster at creation time. When omitted, no limits are applied.
        /// </para>
        /// </summary>
        public SchedulerConfiguration SchedulerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SchedulerConfiguration property is set.
        /// </summary>
        internal bool IsSetSchedulerConfiguration() => this.SchedulerConfiguration != null;

        /// <summary>
        /// Gets and sets the property SecurityConfigurationId. 
        /// <para>
        /// The ID of the security configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SecurityConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfigurationId property is set.
        /// </summary>
        internal bool IsSetSecurityConfigurationId() => this.SecurityConfigurationId != null;

        /// <summary>
        /// Gets and sets the property SessionEnabled. 
        /// <para>
        /// Indicates whether the virtual cluster has session support enabled.
        /// </para>
        /// </summary>
        public bool? SessionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SessionEnabled property is set.
        /// </summary>
        internal bool IsSetSessionEnabled() => this.SessionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the virtual cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
