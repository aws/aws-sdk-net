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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The object that represents any node overrides to a job definition that's used in a
    /// <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_SubmitJob.html">SubmitJob</a>
    /// API operation.
    /// </summary>
    public partial class NodePropertyOverride
    {
        /// <summary>
        /// Gets and sets the property ConsumableResourcePropertiesOverride. 
        /// <para>
        /// An object that contains overrides for the consumable resources of a job.
        /// </para>
        /// </summary>
        public ConsumableResourceProperties ConsumableResourcePropertiesOverride { get; set; }

        /// <summary>
        /// Checks to see if the ConsumableResourcePropertiesOverride property is set.
        /// </summary>
        internal bool IsSetConsumableResourcePropertiesOverride() => this.ConsumableResourcePropertiesOverride != null;

        /// <summary>
        /// Gets and sets the property ContainerOverrides. 
        /// <para>
        /// The overrides that are sent to a node range.
        /// </para>
        /// </summary>
        public ContainerOverrides ContainerOverrides { get; set; }

        /// <summary>
        /// Checks to see if the ContainerOverrides property is set.
        /// </summary>
        internal bool IsSetContainerOverrides() => this.ContainerOverrides != null;

        /// <summary>
        /// Gets and sets the property EcsPropertiesOverride. 
        /// <para>
        /// An object that contains the properties that you want to replace for the existing Amazon
        /// ECS resources of a job.
        /// </para>
        /// </summary>
        public EcsPropertiesOverride EcsPropertiesOverride { get; set; }

        /// <summary>
        /// Checks to see if the EcsPropertiesOverride property is set.
        /// </summary>
        internal bool IsSetEcsPropertiesOverride() => this.EcsPropertiesOverride != null;

        /// <summary>
        /// Gets and sets the property EksPropertiesOverride. 
        /// <para>
        /// An object that contains the properties that you want to replace for the existing Amazon
        /// EKS resources of a job.
        /// </para>
        /// </summary>
        public EksPropertiesOverride EksPropertiesOverride { get; set; }

        /// <summary>
        /// Checks to see if the EksPropertiesOverride property is set.
        /// </summary>
        internal bool IsSetEksPropertiesOverride() => this.EksPropertiesOverride != null;

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// An object that contains the instance types that you want to replace for the existing
        /// resources of a job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceTypes property is set.
        /// </summary>
        internal bool IsSetInstanceTypes() => this.InstanceTypes != null && (this.InstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetNodes. 
        /// <para>
        /// The range of nodes, using node index values, that's used to override. A range of <c>0:3</c>
        /// indicates nodes with index values of <c>0</c> through <c>3</c>. If the starting range
        /// value is omitted (<c>:n</c>), then <c>0</c> is used to start the range. If the ending
        /// range value is omitted (<c>n:</c>), then the highest possible node index is used to
        /// end the range.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetNodes { get; set; }

        /// <summary>
        /// Checks to see if the TargetNodes property is set.
        /// </summary>
        internal bool IsSetTargetNodes() => this.TargetNodes != null;
    }
}
