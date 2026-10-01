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
    /// This entity describes a virtual cluster. A virtual cluster is a Kubernetes namespace
    /// that Amazon EMR is registered with. Amazon EMR uses virtual clusters to run jobs and
    /// host endpoints. Multiple virtual clusters can be backed by the same physical cluster.
    /// However, each virtual cluster maps to one namespace on an Amazon EKS cluster. Virtual
    /// clusters do not create any active resources that contribute to your bill or that require
    /// lifecycle management outside the service.
    /// </summary>
    public partial class VirtualCluster
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 1024)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ContainerProvider. 
        /// <para>
        /// The container provider of the virtual cluster.
        /// </para>
        /// </summary>
        public ContainerProvider ContainerProvider { get; set; }

        /// <summary>
        /// Checks to see if the ContainerProvider property is set.
        /// </summary>
        internal bool IsSetContainerProvider() => this.ContainerProvider != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the virtual cluster is created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SchedulerConfiguration. 
        /// <para>
        /// The scheduler configuration (concurrency and queue limits) applied to the virtual
        /// cluster. The service does not return this field when no scheduler limits are configured.
        /// </para>
        /// </summary>
        public SchedulerConfiguration SchedulerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SchedulerConfiguration property is set.
        /// </summary>
        internal bool IsSetSchedulerConfiguration() => this.SchedulerConfiguration != null;

        /// <summary>
        /// Gets and sets the property SchedulerStatus. 
        /// <para>
        /// The current in-queue and concurrent job-run counts for the virtual cluster.
        /// </para>
        /// </summary>
        public SchedulerStatus SchedulerStatus { get; set; }

        /// <summary>
        /// Checks to see if the SchedulerStatus property is set.
        /// </summary>
        internal bool IsSetSchedulerStatus() => this.SchedulerStatus != null;

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
        /// Specifies whether the virtual cluster has session support enabled. 
        /// </para>
        /// </summary>
        public bool? SessionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SessionEnabled property is set.
        /// </summary>
        internal bool IsSetSessionEnabled() => this.SessionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the virtual cluster.
        /// </para>
        /// </summary>
        public VirtualClusterState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The assigned tags of the virtual cluster.
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
