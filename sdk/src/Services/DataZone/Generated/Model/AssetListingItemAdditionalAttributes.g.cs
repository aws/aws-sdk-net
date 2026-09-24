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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Additional attributes of an inventory asset.
    /// </summary>
    public partial class AssetListingItemAdditionalAttributes
    {
        /// <summary>
        /// Gets and sets the property Forms. 
        /// <para>
        /// The metadata forms that form additional attributes of the metadata asset.
        /// </para>
        /// </summary>
        public string Forms { get; set; }

        /// <summary>
        /// Checks to see if the Forms property is set.
        /// </summary>
        internal bool IsSetForms() => this.Forms != null;

        /// <summary>
        /// Gets and sets the property LatestTimeSeriesDataPointForms. 
        /// <para>
        /// The latest time series data points forms included in the additional attributes of
        /// an asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TimeSeriesDataPointSummaryFormOutput> LatestTimeSeriesDataPointForms { get; set; } = AWSConfigs.InitializeCollections ? new List<TimeSeriesDataPointSummaryFormOutput>() : null;

        /// <summary>
        /// Checks to see if the LatestTimeSeriesDataPointForms property is set.
        /// </summary>
        internal bool IsSetLatestTimeSeriesDataPointForms() => this.LatestTimeSeriesDataPointForms != null && (this.LatestTimeSeriesDataPointForms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MatchRationale. 
        /// <para>
        /// List of rationales indicating why this item was matched by search.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MatchRationaleItem> MatchRationale { get; set; } = AWSConfigs.InitializeCollections ? new List<MatchRationaleItem>() : null;

        /// <summary>
        /// Checks to see if the MatchRationale property is set.
        /// </summary>
        internal bool IsSetMatchRationale() => this.MatchRationale != null && (this.MatchRationale.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
