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
    /// This is an object that represents the properties of the node range for a multi-node
    /// parallel job.
    /// </summary>
    public partial class NodeRangeProperty
    {
        /// <summary>
        /// Gets and sets the property ConsumableResourceProperties. 
        /// <para>
        /// Contains a list of consumable resources required by a job.
        /// </para>
        /// </summary>
        public ConsumableResourceProperties ConsumableResourceProperties { get; set; }

        /// <summary>
        /// Checks to see if the ConsumableResourceProperties property is set.
        /// </summary>
        internal bool IsSetConsumableResourceProperties() => this.ConsumableResourceProperties != null;

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// The container details for the node range.
        /// </para>
        /// </summary>
        public ContainerProperties Container { get; set; }

        /// <summary>
        /// Checks to see if the Container property is set.
        /// </summary>
        internal bool IsSetContainer() => this.Container != null;

        /// <summary>
        /// Gets and sets the property EcsProperties. 
        /// <para>
        /// This is an object that represents the properties of the node range for a multi-node
        /// parallel job.
        /// </para>
        /// </summary>
        public EcsProperties EcsProperties { get; set; }

        /// <summary>
        /// Checks to see if the EcsProperties property is set.
        /// </summary>
        internal bool IsSetEcsProperties() => this.EcsProperties != null;

        /// <summary>
        /// Gets and sets the property EksProperties. 
        /// <para>
        /// This is an object that represents the properties of the node range for a multi-node
        /// parallel job.
        /// </para>
        /// </summary>
        public EksProperties EksProperties { get; set; }

        /// <summary>
        /// Checks to see if the EksProperties property is set.
        /// </summary>
        internal bool IsSetEksProperties() => this.EksProperties != null;

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// The instance types of the underlying host infrastructure of a multi-node parallel
        /// job.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources.
        /// </para>
        ///  
        /// <para>
        /// In addition, this list object is currently limited to one element.
        /// </para>
        ///  </note>
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
        /// The range of nodes, using node index values. A range of <c>0:3</c> indicates nodes
        /// with index values of <c>0</c> through <c>3</c>. If the starting range value is omitted
        /// (<c>:n</c>), then <c>0</c> is used to start the range. If the ending range value is
        /// omitted (<c>n:</c>), then the highest possible node index is used to end the range.
        /// Your accumulative node ranges must account for all nodes (<c>0:n</c>). You can nest
        /// node ranges (for example, <c>0:10</c> and <c>4:5</c>). In this case, the <c>4:5</c>
        /// range properties override the <c>0:10</c> properties.
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
