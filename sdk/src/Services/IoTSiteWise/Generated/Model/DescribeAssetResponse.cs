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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
        private string _assetArn;
        private List<AssetCompositeModel> _assetCompositeModels = AWSConfigs.InitializeCollections ? new List<AssetCompositeModel>() : null;
        private List<AssetCompositeModelSummary> _assetCompositeModelSummaries = AWSConfigs.InitializeCollections ? new List<AssetCompositeModelSummary>() : null;
        private DateTime? _assetCreationDate;
        private string _assetDescription;
        private string _assetExternalId;
        private List<AssetHierarchy> _assetHierarchies = AWSConfigs.InitializeCollections ? new List<AssetHierarchy>() : null;
        private string _assetId;
        private DateTime? _assetLastUpdateDate;
        private string _assetModelId;
        private string _assetName;
        private List<AssetProperty> _assetProperties = AWSConfigs.InitializeCollections ? new List<AssetProperty>() : null;
        private AssetStatus _assetStatus;

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
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string AssetArn
        {
            get { return this._assetArn; }
            set { this._assetArn = value; }
        }

        // Check to see if AssetArn property is set
        internal bool IsSetAssetArn()
        {
            return this._assetArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssetCompositeModels. 
        /// <para>
        /// The composite models for the asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetCompositeModel> AssetCompositeModels
        {
            get { return this._assetCompositeModels; }
            set { this._assetCompositeModels = value; }
        }

        // Check to see if AssetCompositeModels property is set
        internal bool IsSetAssetCompositeModels()
        {
            return this._assetCompositeModels != null && (this._assetCompositeModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetCompositeModelSummaries. 
        /// <para>
        /// The list of the immediate child custom composite model summaries for the asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetCompositeModelSummary> AssetCompositeModelSummaries
        {
            get { return this._assetCompositeModelSummaries; }
            set { this._assetCompositeModelSummaries = value; }
        }

        // Check to see if AssetCompositeModelSummaries property is set
        internal bool IsSetAssetCompositeModelSummaries()
        {
            return this._assetCompositeModelSummaries != null && (this._assetCompositeModelSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetCreationDate. 
        /// <para>
        /// The date the asset was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? AssetCreationDate
        {
            get { return this._assetCreationDate; }
            set { this._assetCreationDate = value; }
        }

        // Check to see if AssetCreationDate property is set
        internal bool IsSetAssetCreationDate()
        {
            return this._assetCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssetDescription. 
        /// <para>
        /// A description for the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AssetDescription
        {
            get { return this._assetDescription; }
            set { this._assetDescription = value; }
        }

        // Check to see if AssetDescription property is set
        internal bool IsSetAssetDescription()
        {
            return this._assetDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AssetExternalId. 
        /// <para>
        /// The external ID of the asset, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=128)]
        public string AssetExternalId
        {
            get { return this._assetExternalId; }
            set { this._assetExternalId = value; }
        }

        // Check to see if AssetExternalId property is set
        internal bool IsSetAssetExternalId()
        {
            return this._assetExternalId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetHierarchies. 
        /// <para>
        /// A list of asset hierarchies that each contain a <c>hierarchyId</c>. A hierarchy specifies
        /// allowed parent/child asset relationships.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetHierarchy> AssetHierarchies
        {
            get { return this._assetHierarchies; }
            set { this._assetHierarchies = value; }
        }

        // Check to see if AssetHierarchies property is set
        internal bool IsSetAssetHierarchies()
        {
            return this._assetHierarchies != null && (this._assetHierarchies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset, in UUID format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Gets and sets the property AssetLastUpdateDate. 
        /// <para>
        /// The date the asset was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? AssetLastUpdateDate
        {
            get { return this._assetLastUpdateDate; }
            set { this._assetLastUpdateDate = value; }
        }

        // Check to see if AssetLastUpdateDate property is set
        internal bool IsSetAssetLastUpdateDate()
        {
            return this._assetLastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model that was used to create the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssetModelId
        {
            get { return this._assetModelId; }
            set { this._assetModelId = value; }
        }

        // Check to see if AssetModelId property is set
        internal bool IsSetAssetModelId()
        {
            return this._assetModelId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetName. 
        /// <para>
        /// The name of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AssetName
        {
            get { return this._assetName; }
            set { this._assetName = value; }
        }

        // Check to see if AssetName property is set
        internal bool IsSetAssetName()
        {
            return this._assetName != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetProperty> AssetProperties
        {
            get { return this._assetProperties; }
            set { this._assetProperties = value; }
        }

        // Check to see if AssetProperties property is set
        internal bool IsSetAssetProperties()
        {
            return this._assetProperties != null && (this._assetProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetStatus. 
        /// <para>
        /// The current status of the asset, which contains a state and any error message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetStatus AssetStatus
        {
            get { return this._assetStatus; }
            set { this._assetStatus = value; }
        }

        // Check to see if AssetStatus property is set
        internal bool IsSetAssetStatus()
        {
            return this._assetStatus != null;
        }

    }
}