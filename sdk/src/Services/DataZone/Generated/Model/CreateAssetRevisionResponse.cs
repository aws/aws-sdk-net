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
    /// This is the response object from the CreateAssetRevision operation.
    /// </summary>
    public partial class CreateAssetRevisionResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private string _domainId;
        private string _externalIdentifier;
        private DateTime? _firstRevisionCreatedAt;
        private string _firstRevisionCreatedBy;
        private List<FormOutput> _formsOutput = AWSConfigs.InitializeCollections ? new List<FormOutput>() : null;
        private List<string> _glossaryTerms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _governedGlossaryTerms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _id;
        private List<TimeSeriesDataPointSummaryFormOutput> _latestTimeSeriesDataPointFormsOutput = AWSConfigs.InitializeCollections ? new List<TimeSeriesDataPointSummaryFormOutput>() : null;
        private AssetListingDetails _listing;
        private string _name;
        private string _owningProjectId;
        private PredictionConfiguration _predictionConfiguration;
        private List<FormOutput> _readOnlyFormsOutput = AWSConfigs.InitializeCollections ? new List<FormOutput>() : null;
        private string _revision;
        private string _typeIdentifier;
        private string _typeRevision;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the asset revision occured.
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
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon DataZone user who performed the asset revision.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The revised asset description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the Amazon DataZone domain where the asset was revised.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalIdentifier. 
        /// <para>
        /// The external identifier of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=600)]
        public string ExternalIdentifier
        {
            get { return this._externalIdentifier; }
            set { this._externalIdentifier = value; }
        }

        // Check to see if ExternalIdentifier property is set
        internal bool IsSetExternalIdentifier()
        {
            return this._externalIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FirstRevisionCreatedAt. 
        /// <para>
        /// The timestamp of when the first asset revision occured.
        /// </para>
        /// </summary>
        public DateTime? FirstRevisionCreatedAt
        {
            get { return this._firstRevisionCreatedAt; }
            set { this._firstRevisionCreatedAt = value; }
        }

        // Check to see if FirstRevisionCreatedAt property is set
        internal bool IsSetFirstRevisionCreatedAt()
        {
            return this._firstRevisionCreatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FirstRevisionCreatedBy. 
        /// <para>
        /// The Amazon DataZone user who performed the first asset revision.
        /// </para>
        /// </summary>
        public string FirstRevisionCreatedBy
        {
            get { return this._firstRevisionCreatedBy; }
            set { this._firstRevisionCreatedBy = value; }
        }

        // Check to see if FirstRevisionCreatedBy property is set
        internal bool IsSetFirstRevisionCreatedBy()
        {
            return this._firstRevisionCreatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property FormsOutput. 
        /// <para>
        /// The metadata forms that were attached to the asset as part of the asset revision.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<FormOutput> FormsOutput
        {
            get { return this._formsOutput; }
            set { this._formsOutput = value; }
        }

        // Check to see if FormsOutput property is set
        internal bool IsSetFormsOutput()
        {
            return this._formsOutput != null && (this._formsOutput.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms that were attached to the asset as part of asset revision.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> GlossaryTerms
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
        /// The glossary terms in a restricted glossary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> GovernedGlossaryTerms
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the asset revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LatestTimeSeriesDataPointFormsOutput. 
        /// <para>
        /// The latest data point that was imported into the time series form for the asset. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TimeSeriesDataPointSummaryFormOutput> LatestTimeSeriesDataPointFormsOutput
        {
            get { return this._latestTimeSeriesDataPointFormsOutput; }
            set { this._latestTimeSeriesDataPointFormsOutput = value; }
        }

        // Check to see if LatestTimeSeriesDataPointFormsOutput property is set
        internal bool IsSetLatestTimeSeriesDataPointFormsOutput()
        {
            return this._latestTimeSeriesDataPointFormsOutput != null && (this._latestTimeSeriesDataPointFormsOutput.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Listing. 
        /// <para>
        /// The details of an asset published in an Amazon DataZone catalog. 
        /// </para>
        /// </summary>
        public AssetListingDetails Listing
        {
            get { return this._listing; }
            set { this._listing = value; }
        }

        // Check to see if Listing property is set
        internal bool IsSetListing()
        {
            return this._listing != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The revised name of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The unique identifier of the revised project that owns the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property PredictionConfiguration. 
        /// <para>
        /// The configuration of the automatically generated business-friendly metadata for the
        /// asset.
        /// </para>
        /// </summary>
        public PredictionConfiguration PredictionConfiguration
        {
            get { return this._predictionConfiguration; }
            set { this._predictionConfiguration = value; }
        }

        // Check to see if PredictionConfiguration property is set
        internal bool IsSetPredictionConfiguration()
        {
            return this._predictionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ReadOnlyFormsOutput. 
        /// <para>
        /// The read-only metadata forms that were attached to the asset as part of the asset
        /// revision.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<FormOutput> ReadOnlyFormsOutput
        {
            get { return this._readOnlyFormsOutput; }
            set { this._readOnlyFormsOutput = value; }
        }

        // Check to see if ReadOnlyFormsOutput property is set
        internal bool IsSetReadOnlyFormsOutput()
        {
            return this._readOnlyFormsOutput != null && (this._readOnlyFormsOutput.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

        /// <summary>
        /// Gets and sets the property TypeIdentifier. 
        /// <para>
        /// The identifier of the revision type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=513)]
        public string TypeIdentifier
        {
            get { return this._typeIdentifier; }
            set { this._typeIdentifier = value; }
        }

        // Check to see if TypeIdentifier property is set
        internal bool IsSetTypeIdentifier()
        {
            return this._typeIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TypeRevision. 
        /// <para>
        /// The revision type of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TypeRevision
        {
            get { return this._typeRevision; }
            set { this._typeRevision = value; }
        }

        // Check to see if TypeRevision property is set
        internal bool IsSetTypeRevision()
        {
            return this._typeRevision != null;
        }

    }
}