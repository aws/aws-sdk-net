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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// An asset in AWS Data Exchange is a piece of data (Amazon S3 object) or a means of
    /// fulfilling data (Amazon Redshift datashare or Amazon API Gateway API, AWS Lake Formation
    /// data permission, or Amazon S3 data access). The asset can be a structured data file,
    /// an image file, or some other data file that can be stored as an Amazon S3 object,
    /// an Amazon API Gateway API, or an Amazon Redshift datashare, an AWS Lake Formation
    /// data permission, or an Amazon S3 data access. When you create an import job for your
    /// files, API Gateway APIs, Amazon Redshift datashares, AWS Lake Formation data permission,
    /// or Amazon S3 data access, you create an asset in AWS Data Exchange.
    /// </summary>
    public partial class AssetEntry
    {
        private string _arn;
        private AssetDetails _assetDetails;
        private AssetType _assetType;
        private DateTime? _createdAt;
        private string _dataSetId;
        private string _id;
        private string _name;
        private string _revisionId;
        private string _sourceId;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN for the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssetDetails. 
        /// <para>
        /// Details about the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetDetails AssetDetails
        {
            get { return this._assetDetails; }
            set { this._assetDetails = value; }
        }

        // Check to see if AssetDetails property is set
        internal bool IsSetAssetDetails()
        {
            return this._assetDetails != null;
        }

        /// <summary>
        /// Gets and sets the property AssetType. 
        /// <para>
        /// The type of asset that is added to a data set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetType AssetType
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
        /// The date and time that the asset was created, in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The unique identifier for the data set associated with this asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSetId
        {
            get { return this._dataSetId; }
            set { this._dataSetId = value; }
        }

        // Check to see if DataSetId property is set
        internal bool IsSetDataSetId()
        {
            return this._dataSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the asset.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the asset. When importing from Amazon S3, the Amazon S3 object key is
        /// used as the asset name. When exporting to Amazon S3, the asset name is used as default
        /// target Amazon S3 object key. When importing from Amazon API Gateway API, the API name
        /// is used as the asset name. When importing from Amazon Redshift, the datashare name
        /// is used as the asset name. When importing from AWS Lake Formation, the static values
        /// of "Database(s) included in LF-tag policy" or "Table(s) included in LF-tag policy"
        /// are used as the asset name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The unique identifier for the revision associated with this asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The asset ID of the owned asset corresponding to the entitled asset being viewed.
        /// This parameter is returned when an asset owner is viewing the entitled copy of its
        /// owned asset.
        /// </para>
        /// </summary>
        public string SourceId
        {
            get { return this._sourceId; }
            set { this._sourceId = value; }
        }

        // Check to see if SourceId property is set
        internal bool IsSetSourceId()
        {
            return this._sourceId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the asset was last updated, in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}