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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Configuration parameters for an instance fleet modification request.
    /// 
    ///  <note> 
    /// <para>
    /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
    /// later, excluding 5.0.x versions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class InstanceFleetModifyConfig
    {
        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;

        /// <summary>
        /// Gets and sets the property InstanceFleetId. 
        /// <para>
        /// A unique identifier for the instance fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string InstanceFleetId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFleetId property is set.
        /// </summary>
        internal bool IsSetInstanceFleetId() => this.InstanceFleetId != null;

        /// <summary>
        /// Gets and sets the property InstanceTypeConfigs. 
        /// <para>
        /// An array of InstanceTypeConfig objects that specify how Amazon EMR provisions Amazon
        /// EC2 instances when it fulfills On-Demand and Spot capacities. For more information,
        /// see <a href="https://docs.aws.amazon.com/emr/latest/APIReference/API_InstanceTypeConfig.html">InstanceTypeConfig</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceTypeConfig> InstanceTypeConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceTypeConfig>() : null;

        /// <summary>
        /// Checks to see if the InstanceTypeConfigs property is set.
        /// </summary>
        internal bool IsSetInstanceTypeConfigs() => this.InstanceTypeConfigs != null && (this.InstanceTypeConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResizeSpecifications. 
        /// <para>
        /// The resize specification for the instance fleet.
        /// </para>
        /// </summary>
        public InstanceFleetResizingSpecifications ResizeSpecifications { get; set; }

        /// <summary>
        /// Checks to see if the ResizeSpecifications property is set.
        /// </summary>
        internal bool IsSetResizeSpecifications() => this.ResizeSpecifications != null;

        /// <summary>
        /// Gets and sets the property TargetOnDemandCapacity. 
        /// <para>
        /// The target capacity of On-Demand units for the instance fleet. For more information
        /// see <a>InstanceFleetConfig$TargetOnDemandCapacity</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TargetOnDemandCapacity { get; set; }

        /// <summary>
        /// Checks to see if the TargetOnDemandCapacity property is set.
        /// </summary>
        internal bool IsSetTargetOnDemandCapacity() => this.TargetOnDemandCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property TargetSpotCapacity. 
        /// <para>
        /// The target capacity of Spot units for the instance fleet. For more information, see
        /// <a>InstanceFleetConfig$TargetSpotCapacity</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TargetSpotCapacity { get; set; }

        /// <summary>
        /// Checks to see if the TargetSpotCapacity property is set.
        /// </summary>
        internal bool IsSetTargetSpotCapacity() => this.TargetSpotCapacity.HasValue;
    }
}
