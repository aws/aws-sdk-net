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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// A collection of harvested manifests of different types.
    /// </summary>
    public partial class HarvestedManifests
    {
        private List<HarvestedDashManifest> _dashManifests = AWSConfigs.InitializeCollections ? new List<HarvestedDashManifest>() : null;
        private List<HarvestedHlsManifest> _hlsManifests = AWSConfigs.InitializeCollections ? new List<HarvestedHlsManifest>() : null;
        private List<HarvestedLowLatencyHlsManifest> _lowLatencyHlsManifests = AWSConfigs.InitializeCollections ? new List<HarvestedLowLatencyHlsManifest>() : null;

        /// <summary>
        /// Gets and sets the property DashManifests. 
        /// <para>
        /// A list of harvested DASH manifests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarvestedDashManifest> DashManifests
        {
            get { return this._dashManifests; }
            set { this._dashManifests = value; }
        }

        // Check to see if DashManifests property is set
        internal bool IsSetDashManifests()
        {
            return this._dashManifests != null && (this._dashManifests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HlsManifests. 
        /// <para>
        /// A list of harvested HLS manifests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarvestedHlsManifest> HlsManifests
        {
            get { return this._hlsManifests; }
            set { this._hlsManifests = value; }
        }

        // Check to see if HlsManifests property is set
        internal bool IsSetHlsManifests()
        {
            return this._hlsManifests != null && (this._hlsManifests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LowLatencyHlsManifests. 
        /// <para>
        /// A list of harvested Low-Latency HLS manifests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarvestedLowLatencyHlsManifest> LowLatencyHlsManifests
        {
            get { return this._lowLatencyHlsManifests; }
            set { this._lowLatencyHlsManifests = value; }
        }

        // Check to see if LowLatencyHlsManifests property is set
        internal bool IsSetLowLatencyHlsManifests()
        {
            return this._lowLatencyHlsManifests != null && (this._lowLatencyHlsManifests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}