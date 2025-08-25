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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
        private string _assetId;
        private string _assetRevision;
        private string _assetType;
        private DateTime? _createdAt;
        private string _forms;
        private List<DetailedGlossaryTerm> _glossaryTerms = AWSConfigs.InitializeCollections ? new List<DetailedGlossaryTerm>() : null;
        private List<DetailedGlossaryTerm> _governedGlossaryTerms = AWSConfigs.InitializeCollections ? new List<DetailedGlossaryTerm>() : null;
        private List<TimeSeriesDataPointSummaryFormOutput> _latestTimeSeriesDataPointForms = AWSConfigs.InitializeCollections ? new List<TimeSeriesDataPointSummaryFormOutput>() : null;
        private string _owningProjectId;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The identifier of an asset published in an Amazon DataZone catalog. 
        /// </para>
        /// </summary>
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetRevision. 
        /// <para>
        /// The revision of an asset published in an Amazon DataZone catalog. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AssetRevision
        {
            get { return this._assetRevision; }
            set { this._assetRevision = value; }
        }

        // Check to see if AssetRevision property is set
        internal bool IsSetAssetRevision()
        {
            return this._assetRevision != null;
        }

        /// <summary>
        /// Gets and sets the property AssetType. 
        /// <para>
        /// The type of an asset published in an Amazon DataZone catalog. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AssetType
        {
            get { return this._assetType; }
            set { this._assetType = value; }
        }

        // Check to see if AssetType property is set
        internal bool IsSetAssetType()
        {
            return this._assetType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when an asset published in an Amazon DataZone catalog was created.
        /// 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Forms. 
        /// <para>
        /// The metadata forms attached to an asset published in an Amazon DataZone catalog. 
        /// </para>
        /// </summary>
        public string Forms
        {
            get { return this._forms; }
            set { this._forms = value; }
        }

        // Check to see if Forms property is set
        internal bool IsSetForms()
        {
            return this._forms != null;
        }

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms attached to an asset published in an Amazon DataZone catalog. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DetailedGlossaryTerm> GlossaryTerms
        {
            get { return this._glossaryTerms; }
            set { this._glossaryTerms = value; }
        }

        // Check to see if GlossaryTerms property is set
        internal bool IsSetGlossaryTerms()
        {
            return this._glossaryTerms != null && (this._glossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GovernedGlossaryTerms. 
        /// <para>
        /// The restricted glossary terms associated with an asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<DetailedGlossaryTerm> GovernedGlossaryTerms
        {
            get { return this._governedGlossaryTerms; }
            set { this._governedGlossaryTerms = value; }
        }

        // Check to see if GovernedGlossaryTerms property is set
        internal bool IsSetGovernedGlossaryTerms()
        {
            return this._governedGlossaryTerms != null && (this._governedGlossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LatestTimeSeriesDataPointForms. 
        /// <para>
        /// The latest time series data points forms included in the additional attributes of
        /// an asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TimeSeriesDataPointSummaryFormOutput> LatestTimeSeriesDataPointForms
        {
            get { return this._latestTimeSeriesDataPointForms; }
            set { this._latestTimeSeriesDataPointForms = value; }
        }

        // Check to see if LatestTimeSeriesDataPointForms property is set
        internal bool IsSetLatestTimeSeriesDataPointForms()
        {
            return this._latestTimeSeriesDataPointForms != null && (this._latestTimeSeriesDataPointForms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The identifier of the project where an asset published in an Amazon DataZone catalog
        /// exists. 
        /// </para>
        /// </summary>
        public string OwningProjectId
        {
            get { return this._owningProjectId; }
            set { this._owningProjectId = value; }
        }

        // Check to see if OwningProjectId property is set
        internal bool IsSetOwningProjectId()
        {
            return this._owningProjectId != null;
        }

    }
}