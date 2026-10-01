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

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// This is the response object from the GetAsset operation.
    /// </summary>
    public partial class GetAssetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN for the asset.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssetDetails. 
        /// <para>
        /// Details about the asset.
        /// </para>
        /// </summary>
        public AssetDetails AssetDetails { get; set; }

        /// <summary>
        /// Checks to see if the AssetDetails property is set.
        /// </summary>
        internal bool IsSetAssetDetails() => this.AssetDetails != null;

        /// <summary>
        /// Gets and sets the property AssetType. 
        /// <para>
        /// The type of asset that is added to a data set.
        /// </para>
        /// </summary>
        public AssetType AssetType { get; set; }

        /// <summary>
        /// Checks to see if the AssetType property is set.
        /// </summary>
        internal bool IsSetAssetType() => this.AssetType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the asset was created, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The unique identifier for the data set associated with this asset.
        /// </para>
        /// </summary>
        public string DataSetId { get; set; }

        /// <summary>
        /// Checks to see if the DataSetId property is set.
        /// </summary>
        internal bool IsSetDataSetId() => this.DataSetId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the asset.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the asset. When importing from Amazon S3, the Amazon S3 object key is
        /// used as the asset name. When exporting to Amazon S3, the asset name is used as default
        /// target Amazon S3 object key. When importing from Amazon API Gateway API, the API name
        /// is used as the asset name. When importing from Amazon Redshift, the datashare name
        /// is used as the asset name. When importing from AWS Lake Formation, the static values
        /// of "Database(s) included in the LF-tag policy" or "Table(s) included in the LF-tag
        /// policy" are used as the asset name.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The unique identifier for the revision associated with this asset.
        /// </para>
        /// </summary>
        public string RevisionId { get; set; }

        /// <summary>
        /// Checks to see if the RevisionId property is set.
        /// </summary>
        internal bool IsSetRevisionId() => this.RevisionId != null;

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The asset ID of the owned asset corresponding to the entitled asset being viewed.
        /// This parameter is returned when an asset owner is viewing the entitled copy of its
        /// owned asset.
        /// </para>
        /// </summary>
        public string SourceId { get; set; }

        /// <summary>
        /// Checks to see if the SourceId property is set.
        /// </summary>
        internal bool IsSetSourceId() => this.SourceId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the asset was last updated, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
