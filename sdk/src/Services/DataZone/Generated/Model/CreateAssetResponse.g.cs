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
    /// This is the response object from the CreateAsset operation.
    /// </summary>
    public partial class CreateAssetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the asset was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon DataZone user that created this asset in the catalog.
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the created asset.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which the asset was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property ExternalIdentifier. 
        /// <para>
        /// The external identifier of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 600)]
        public string ExternalIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ExternalIdentifier property is set.
        /// </summary>
        internal bool IsSetExternalIdentifier() => this.ExternalIdentifier != null;

        /// <summary>
        /// Gets and sets the property FirstRevisionCreatedAt. 
        /// <para>
        /// The timestamp of when the first revision of the asset took place.
        /// </para>
        /// </summary>
        public DateTime? FirstRevisionCreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the FirstRevisionCreatedAt property is set.
        /// </summary>
        internal bool IsSetFirstRevisionCreatedAt() => this.FirstRevisionCreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FirstRevisionCreatedBy. 
        /// <para>
        /// The Amazon DataZone user that made the first revision of the asset.
        /// </para>
        /// </summary>
        public string FirstRevisionCreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the FirstRevisionCreatedBy property is set.
        /// </summary>
        internal bool IsSetFirstRevisionCreatedBy() => this.FirstRevisionCreatedBy != null;

        /// <summary>
        /// Gets and sets the property FormsOutput. 
        /// <para>
        /// The metadata forms that are attached to the created asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public List<FormOutput> FormsOutput { get; set; } = AWSConfigs.InitializeCollections ? new List<FormOutput>() : null;

        /// <summary>
        /// Checks to see if the FormsOutput property is set.
        /// </summary>
        internal bool IsSetFormsOutput() => this.FormsOutput != null && (this.FormsOutput.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms that are attached to the created asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> GlossaryTerms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GlossaryTerms property is set.
        /// </summary>
        internal bool IsSetGlossaryTerms() => this.GlossaryTerms != null && (this.GlossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GovernedGlossaryTerms. 
        /// <para>
        /// The glossary terms in a restricted glossary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> GovernedGlossaryTerms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GovernedGlossaryTerms property is set.
        /// </summary>
        internal bool IsSetGovernedGlossaryTerms() => this.GovernedGlossaryTerms != null && (this.GovernedGlossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the created asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LatestTimeSeriesDataPointFormsOutput. 
        /// <para>
        /// The latest data point that was imported into the time series form for the asset. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TimeSeriesDataPointSummaryFormOutput> LatestTimeSeriesDataPointFormsOutput { get; set; } = AWSConfigs.InitializeCollections ? new List<TimeSeriesDataPointSummaryFormOutput>() : null;

        /// <summary>
        /// Checks to see if the LatestTimeSeriesDataPointFormsOutput property is set.
        /// </summary>
        internal bool IsSetLatestTimeSeriesDataPointFormsOutput() => this.LatestTimeSeriesDataPointFormsOutput != null && (this.LatestTimeSeriesDataPointFormsOutput.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Listing. 
        /// <para>
        /// The details of an asset published in an Amazon DataZone catalog.
        /// </para>
        /// </summary>
        public AssetListingDetails Listing { get; set; }

        /// <summary>
        /// Checks to see if the Listing property is set.
        /// </summary>
        internal bool IsSetListing() => this.Listing != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the created asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The ID of the Amazon DataZone project that owns the created asset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OwningProjectId { get; set; }

        /// <summary>
        /// Checks to see if the OwningProjectId property is set.
        /// </summary>
        internal bool IsSetOwningProjectId() => this.OwningProjectId != null;

        /// <summary>
        /// Gets and sets the property PredictionConfiguration. 
        /// <para>
        /// The configuration of the automatically generated business-friendly metadata for the
        /// asset.
        /// </para>
        /// </summary>
        public PredictionConfiguration PredictionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PredictionConfiguration property is set.
        /// </summary>
        internal bool IsSetPredictionConfiguration() => this.PredictionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ReadOnlyFormsOutput. 
        /// <para>
        /// The read-only metadata forms that are attached to the created asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<FormOutput> ReadOnlyFormsOutput { get; set; } = AWSConfigs.InitializeCollections ? new List<FormOutput>() : null;

        /// <summary>
        /// Checks to see if the ReadOnlyFormsOutput property is set.
        /// </summary>
        internal bool IsSetReadOnlyFormsOutput() => this.ReadOnlyFormsOutput != null && (this.ReadOnlyFormsOutput.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision != null;

        /// <summary>
        /// Gets and sets the property TypeIdentifier. 
        /// <para>
        /// The identifier of the created asset type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 513)]
        public string TypeIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TypeIdentifier property is set.
        /// </summary>
        internal bool IsSetTypeIdentifier() => this.TypeIdentifier != null;

        /// <summary>
        /// Gets and sets the property TypeRevision. 
        /// <para>
        /// The revision type of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string TypeRevision { get; set; }

        /// <summary>
        /// Checks to see if the TypeRevision property is set.
        /// </summary>
        internal bool IsSetTypeRevision() => this.TypeRevision != null;
    }
}
