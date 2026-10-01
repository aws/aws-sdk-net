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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// A collection of harvested manifests of different types.
    /// </summary>
    public partial class HarvestedManifests
    {
        /// <summary>
        /// Gets and sets the property DashManifests. 
        /// <para>
        /// A list of harvested DASH manifests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarvestedDashManifest> DashManifests { get; set; } = AWSConfigs.InitializeCollections ? new List<HarvestedDashManifest>() : null;

        /// <summary>
        /// Checks to see if the DashManifests property is set.
        /// </summary>
        internal bool IsSetDashManifests() => this.DashManifests != null && (this.DashManifests.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HlsManifests. 
        /// <para>
        /// A list of harvested HLS manifests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarvestedHlsManifest> HlsManifests { get; set; } = AWSConfigs.InitializeCollections ? new List<HarvestedHlsManifest>() : null;

        /// <summary>
        /// Checks to see if the HlsManifests property is set.
        /// </summary>
        internal bool IsSetHlsManifests() => this.HlsManifests != null && (this.HlsManifests.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LowLatencyHlsManifests. 
        /// <para>
        /// A list of harvested Low-Latency HLS manifests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarvestedLowLatencyHlsManifest> LowLatencyHlsManifests { get; set; } = AWSConfigs.InitializeCollections ? new List<HarvestedLowLatencyHlsManifest>() : null;

        /// <summary>
        /// Checks to see if the LowLatencyHlsManifests property is set.
        /// </summary>
        internal bool IsSetLowLatencyHlsManifests() => this.LowLatencyHlsManifests != null && (this.LowLatencyHlsManifests.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
