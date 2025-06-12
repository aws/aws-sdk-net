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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
        private string _context;
        private string _instanceFleetId;
        private List<InstanceTypeConfig> _instanceTypeConfigs = AWSConfigs.InitializeCollections ? new List<InstanceTypeConfig>() : null;
        private InstanceFleetResizingSpecifications _resizeSpecifications;
        private int? _targetOnDemandCapacity;
        private int? _targetSpotCapacity;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceFleetId. 
        /// <para>
        /// A unique identifier for the instance fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceFleetId
        {
            get { return this._instanceFleetId; }
            set { this._instanceFleetId = value; }
        }

        // Check to see if InstanceFleetId property is set
        internal bool IsSetInstanceFleetId()
        {
            return this._instanceFleetId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceTypeConfigs. 
        /// <para>
        /// An array of InstanceTypeConfig objects that specify how Amazon EMR provisions Amazon
        /// EC2 instances when it fulfills On-Demand and Spot capacities. For more information,
        /// see <a href="https://docs.aws.amazon.com/emr/latest/APIReference/API_InstanceTypeConfig.html">InstanceTypeConfig</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceTypeConfig> InstanceTypeConfigs
        {
            get { return this._instanceTypeConfigs; }
            set { this._instanceTypeConfigs = value; }
        }

        // Check to see if InstanceTypeConfigs property is set
        internal bool IsSetInstanceTypeConfigs()
        {
            return this._instanceTypeConfigs != null && (this._instanceTypeConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResizeSpecifications. 
        /// <para>
        /// The resize specification for the instance fleet.
        /// </para>
        /// </summary>
        public InstanceFleetResizingSpecifications ResizeSpecifications
        {
            get { return this._resizeSpecifications; }
            set { this._resizeSpecifications = value; }
        }

        // Check to see if ResizeSpecifications property is set
        internal bool IsSetResizeSpecifications()
        {
            return this._resizeSpecifications != null;
        }

        /// <summary>
        /// Gets and sets the property TargetOnDemandCapacity. 
        /// <para>
        /// The target capacity of On-Demand units for the instance fleet. For more information
        /// see <a>InstanceFleetConfig$TargetOnDemandCapacity</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TargetOnDemandCapacity
        {
            get { return this._targetOnDemandCapacity; }
            set { this._targetOnDemandCapacity = value; }
        }

        // Check to see if TargetOnDemandCapacity property is set
        internal bool IsSetTargetOnDemandCapacity()
        {
            return this._targetOnDemandCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetSpotCapacity. 
        /// <para>
        /// The target capacity of Spot units for the instance fleet. For more information, see
        /// <a>InstanceFleetConfig$TargetSpotCapacity</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TargetSpotCapacity
        {
            get { return this._targetSpotCapacity; }
            set { this._targetSpotCapacity = value; }
        }

        // Check to see if TargetSpotCapacity property is set
        internal bool IsSetTargetSpotCapacity()
        {
            return this._targetSpotCapacity.HasValue; 
        }

    }
}