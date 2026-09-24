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
    /// An asset published in an Amazon DataZone catalog.
    /// </summary>
    public partial class AssetListing
    {
        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The identifier of an asset published in an Amazon DataZone catalog. 
        /// </para>
        /// </summary>
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property AssetRevision. 
        /// <para>
        /// The revision of an asset published in an Amazon DataZone catalog. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AssetRevision { get; set; }

        /// <summary>
        /// Checks to see if the AssetRevision property is set.
        /// </summary>
        internal bool IsSetAssetRevision() => this.AssetRevision != null;

        /// <summary>
        /// Gets and sets the property AssetType. 
        /// <para>
        /// The type of an asset published in an Amazon DataZone catalog. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AssetType { get; set; }

        /// <summary>
        /// Checks to see if the AssetType property is set.
        /// </summary>
        internal bool IsSetAssetType() => this.AssetType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when an asset published in an Amazon DataZone catalog was created.
        /// 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Forms. 
        /// <para>
        /// The metadata forms attached to an asset published in an Amazon DataZone catalog. 
        /// </para>
        /// </summary>
        public string Forms { get; set; }

        /// <summary>
        /// Checks to see if the Forms property is set.
        /// </summary>
        internal bool IsSetForms() => this.Forms != null;

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms attached to an asset published in an Amazon DataZone catalog. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DetailedGlossaryTerm> GlossaryTerms { get; set; } = AWSConfigs.InitializeCollections ? new List<DetailedGlossaryTerm>() : null;

        /// <summary>
        /// Checks to see if the GlossaryTerms property is set.
        /// </summary>
        internal bool IsSetGlossaryTerms() => this.GlossaryTerms != null && (this.GlossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GovernedGlossaryTerms. 
        /// <para>
        /// The restricted glossary terms associated with an asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<DetailedGlossaryTerm> GovernedGlossaryTerms { get; set; } = AWSConfigs.InitializeCollections ? new List<DetailedGlossaryTerm>() : null;

        /// <summary>
        /// Checks to see if the GovernedGlossaryTerms property is set.
        /// </summary>
        internal bool IsSetGovernedGlossaryTerms() => this.GovernedGlossaryTerms != null && (this.GovernedGlossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The identifier of the project where an asset published in an Amazon DataZone catalog
        /// exists. 
        /// </para>
        /// </summary>
        public string OwningProjectId { get; set; }

        /// <summary>
        /// Checks to see if the OwningProjectId property is set.
        /// </summary>
        internal bool IsSetOwningProjectId() => this.OwningProjectId != null;
    }
}
