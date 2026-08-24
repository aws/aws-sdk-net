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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Predictive config
    /// </summary>
    public partial class PredictiveConfig
    {
        private double? _bandwidthAllocation;
        private List<PacingStrategy> _pacingStrategies = AWSConfigs.InitializeCollections ? new List<PacingStrategy>() : null;

        /// <summary>
        /// Gets and sets the property BandwidthAllocation.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2)]
        public double? BandwidthAllocation
        {
            get { return this._bandwidthAllocation; }
            set { this._bandwidthAllocation = value; }
        }

        // Check to see if BandwidthAllocation property is set
        internal bool IsSetBandwidthAllocation()
        {
            return this._bandwidthAllocation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PacingStrategies. 
        /// <para>
        /// Pacing strategies the dialer enforces simultaneously.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<PacingStrategy> PacingStrategies
        {
            get { return this._pacingStrategies; }
            set { this._pacingStrategies = value; }
        }

        // Check to see if PacingStrategies property is set
        internal bool IsSetPacingStrategies()
        {
            return this._pacingStrategies != null && (this._pacingStrategies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}