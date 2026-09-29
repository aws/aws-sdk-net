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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeAsset operation.
    /// </summary>
    public partial class DescribeAssetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssetArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the asset, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:${Partition}:iotsitewise:${Region}:${Account}:asset/${AssetId}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string AssetArn { get; set; }

        /// <summary>
        /// Checks to see if the AssetArn property is set.
        /// </summary>
        internal bool IsSetAssetArn() => this.AssetArn != null;

        /// <summary>
        /// Gets and sets the property AssetCompositeModelSummaries. 
        /// <para>
        /// The list of the immediate child custom composite model summaries for the asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetCompositeModelSummary> AssetCompositeModelSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetCompositeModelSummary>() : null;

        /// <summary>
        /// Checks to see if the AssetCompositeModelSummaries property is set.
        /// </summary>
        internal bool IsSetAssetCompositeModelSummaries() => this.AssetCompositeModelSummaries != null && (this.AssetCompositeModelSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetCompositeModels. 
        /// <para>
        /// The composite models for the asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetCompositeModel> AssetCompositeModels { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetCompositeModel>() : null;

        /// <summary>
        /// Checks to see if the AssetCompositeModels property is set.
        /// </summary>
        internal bool IsSetAssetCompositeModels() => this.AssetCompositeModels != null && (this.AssetCompositeModels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetCreationDate. 
        /// <para>
        /// The date the asset was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? AssetCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the AssetCreationDate property is set.
        /// </summary>
        internal bool IsSetAssetCreationDate() => this.AssetCreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property AssetDescription. 
        /// <para>
        /// A description for the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string AssetDescription { get; set; }

        /// <summary>
        /// Checks to see if the AssetDescription property is set.
        /// </summary>
        internal bool IsSetAssetDescription() => this.AssetDescription != null;

        /// <summary>
        /// Gets and sets the property AssetExternalId. 
        /// <para>
        /// The external ID of the asset, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 128)]
        public string AssetExternalId { get; set; }

        /// <summary>
        /// Checks to see if the AssetExternalId property is set.
        /// </summary>
        internal bool IsSetAssetExternalId() => this.AssetExternalId != null;

        /// <summary>
        /// Gets and sets the property AssetHierarchies. 
        /// <para>
        /// A list of asset hierarchies that each contain a <c>hierarchyId</c>. A hierarchy specifies
        /// allowed parent/child asset relationships.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AssetHierarchy> AssetHierarchies { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetHierarchy>() : null;

        /// <summary>
        /// Checks to see if the AssetHierarchies property is set.
        /// </summary>
        internal bool IsSetAssetHierarchies() => this.AssetHierarchies != null && (this.AssetHierarchies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset, in UUID format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property AssetLastUpdateDate. 
        /// <para>
        /// The date the asset was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? AssetLastUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the AssetLastUpdateDate property is set.
        /// </summary>
        internal bool IsSetAssetLastUpdateDate() => this.AssetLastUpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model that was used to create the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AssetModelId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelId property is set.
        /// </summary>
        internal bool IsSetAssetModelId() => this.AssetModelId != null;

        /// <summary>
        /// Gets and sets the property AssetName. 
        /// <para>
        /// The name of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AssetName { get; set; }

        /// <summary>
        /// Checks to see if the AssetName property is set.
        /// </summary>
        internal bool IsSetAssetName() => this.AssetName != null;

        /// <summary>
        /// Gets and sets the property AssetProperties. 
        /// <para>
        /// The list of asset properties for the asset.
        /// </para>
        ///  
        /// <para>
        /// This object doesn't include properties that you define in composite models. You can
        /// find composite model properties in the <c>assetCompositeModels</c> object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AssetProperty> AssetProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetProperty>() : null;

        /// <summary>
        /// Checks to see if the AssetProperties property is set.
        /// </summary>
        internal bool IsSetAssetProperties() => this.AssetProperties != null && (this.AssetProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetStatus. 
        /// <para>
        /// The current status of the asset, which contains a state and any error message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssetStatus AssetStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssetStatus property is set.
        /// </summary>
        internal bool IsSetAssetStatus() => this.AssetStatus != null;
    }
}
