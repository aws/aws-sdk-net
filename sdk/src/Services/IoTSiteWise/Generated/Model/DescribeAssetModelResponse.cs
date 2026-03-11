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
    /// This is the response object from the DescribeAssetModel operation.
    /// </summary>
    public partial class DescribeAssetModelResponse : AmazonWebServiceResponse
    {
        private string _assetModelArn;
        private List<AssetModelCompositeModel> _assetModelCompositeModels = AWSConfigs.InitializeCollections ? new List<AssetModelCompositeModel>() : null;
        private List<AssetModelCompositeModelSummary> _assetModelCompositeModelSummaries = AWSConfigs.InitializeCollections ? new List<AssetModelCompositeModelSummary>() : null;
        private DateTime? _assetModelCreationDate;
        private string _assetModelDescription;
        private string _assetModelExternalId;
        private List<AssetModelHierarchy> _assetModelHierarchies = AWSConfigs.InitializeCollections ? new List<AssetModelHierarchy>() : null;
        private string _assetModelId;
        private DateTime? _assetModelLastUpdateDate;
        private string _assetModelName;
        private List<AssetModelProperty> _assetModelProperties = AWSConfigs.InitializeCollections ? new List<AssetModelProperty>() : null;
        private AssetModelStatus _assetModelStatus;
        private AssetModelType _assetModelType;
        private string _assetModelVersion;
        private string _eTag;
        private List<InterfaceRelationship> _interfaceDetails = AWSConfigs.InitializeCollections ? new List<InterfaceRelationship>() : null;

        /// <summary>
        /// Gets and sets the property AssetModelArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the asset model, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:${Partition}:iotsitewise:${Region}:${Account}:asset-model/${AssetModelId}</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string AssetModelArn
        {
            get { return this._assetModelArn; }
            set { this._assetModelArn = value; }
        }

        // Check to see if AssetModelArn property is set
        internal bool IsSetAssetModelArn()
        {
            return this._assetModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModels. 
        /// <para>
        /// The list of built-in composite models for the asset model, such as those with those
        /// of type <c>AWS/ALARMS</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetModelCompositeModel> AssetModelCompositeModels
        {
            get { return this._assetModelCompositeModels; }
            set { this._assetModelCompositeModels = value; }
        }

        // Check to see if AssetModelCompositeModels property is set
        internal bool IsSetAssetModelCompositeModels()
        {
            return this._assetModelCompositeModels != null && (this._assetModelCompositeModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelSummaries. 
        /// <para>
        /// The list of the immediate child custom composite model summaries for the asset model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetModelCompositeModelSummary> AssetModelCompositeModelSummaries
        {
            get { return this._assetModelCompositeModelSummaries; }
            set { this._assetModelCompositeModelSummaries = value; }
        }

        // Check to see if AssetModelCompositeModelSummaries property is set
        internal bool IsSetAssetModelCompositeModelSummaries()
        {
            return this._assetModelCompositeModelSummaries != null && (this._assetModelCompositeModelSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetModelCreationDate. 
        /// <para>
        /// The date the asset model was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? AssetModelCreationDate
        {
            get { return this._assetModelCreationDate; }
            set { this._assetModelCreationDate = value; }
        }

        // Check to see if AssetModelCreationDate property is set
        internal bool IsSetAssetModelCreationDate()
        {
            return this._assetModelCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssetModelDescription. 
        /// <para>
        /// The asset model's description.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string AssetModelDescription
        {
            get { return this._assetModelDescription; }
            set { this._assetModelDescription = value; }
        }

        // Check to see if AssetModelDescription property is set
        internal bool IsSetAssetModelDescription()
        {
            return this._assetModelDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelExternalId. 
        /// <para>
        /// The external ID of the asset model, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=128)]
        public string AssetModelExternalId
        {
            get { return this._assetModelExternalId; }
            set { this._assetModelExternalId = value; }
        }

        // Check to see if AssetModelExternalId property is set
        internal bool IsSetAssetModelExternalId()
        {
            return this._assetModelExternalId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelHierarchies. 
        /// <para>
        /// A list of asset model hierarchies that each contain a <c>childAssetModelId</c> and
        /// a <c>hierarchyId</c> (named <c>id</c>). A hierarchy specifies allowed parent/child
        /// asset relationships for an asset model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetModelHierarchy> AssetModelHierarchies
        {
            get { return this._assetModelHierarchies; }
            set { this._assetModelHierarchies = value; }
        }

        // Check to see if AssetModelHierarchies property is set
        internal bool IsSetAssetModelHierarchies()
        {
            return this._assetModelHierarchies != null && (this._assetModelHierarchies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model, in UUID format.
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
        /// Gets and sets the property AssetModelLastUpdateDate. 
        /// <para>
        /// The date the asset model was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? AssetModelLastUpdateDate
        {
            get { return this._assetModelLastUpdateDate; }
            set { this._assetModelLastUpdateDate = value; }
        }

        // Check to see if AssetModelLastUpdateDate property is set
        internal bool IsSetAssetModelLastUpdateDate()
        {
            return this._assetModelLastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssetModelName. 
        /// <para>
        /// The name of the asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AssetModelName
        {
            get { return this._assetModelName; }
            set { this._assetModelName = value; }
        }

        // Check to see if AssetModelName property is set
        internal bool IsSetAssetModelName()
        {
            return this._assetModelName != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelProperties. 
        /// <para>
        /// The list of asset properties for the asset model.
        /// </para>
        ///  
        /// <para>
        /// This object doesn't include properties that you define in composite models. You can
        /// find composite model properties in the <c>assetModelCompositeModels</c> object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetModelProperty> AssetModelProperties
        {
            get { return this._assetModelProperties; }
            set { this._assetModelProperties = value; }
        }

        // Check to see if AssetModelProperties property is set
        internal bool IsSetAssetModelProperties()
        {
            return this._assetModelProperties != null && (this._assetModelProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetModelStatus. 
        /// <para>
        /// The current status of the asset model, which contains a state and any error message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetModelStatus AssetModelStatus
        {
            get { return this._assetModelStatus; }
            set { this._assetModelStatus = value; }
        }

        // Check to see if AssetModelStatus property is set
        internal bool IsSetAssetModelStatus()
        {
            return this._assetModelStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelType. 
        /// <para>
        /// The type of asset model.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ASSET_MODEL</b> – (default) An asset model that you can use to create assets.
        /// Can't be included as a component in another asset model.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>COMPONENT_MODEL</b> – A reusable component that you can include in the composite
        /// models of other asset models. You can't create assets directly from this type of asset
        /// model. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AssetModelType AssetModelType
        {
            get { return this._assetModelType; }
            set { this._assetModelType = value; }
        }

        // Check to see if AssetModelType property is set
        internal bool IsSetAssetModelType()
        {
            return this._assetModelType != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelVersion. 
        /// <para>
        /// The version of the asset model. See <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/model-active-version.html">
        /// Asset model versions</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string AssetModelVersion
        {
            get { return this._assetModelVersion; }
            set { this._assetModelVersion = value; }
        }

        // Check to see if AssetModelVersion property is set
        internal bool IsSetAssetModelVersion()
        {
            return this._assetModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The entity tag (ETag) is a hash of the retrieved version of the asset model. It's
        /// used to make concurrent updates safely to the resource. See <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/opt-locking-for-model.html">Optimistic
        /// locking for asset model writes</a> in the <i>IoT SiteWise User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/opt-locking-for-model.html">
        /// Optimistic locking for asset model writes</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property InterfaceDetails. 
        /// <para>
        /// A list of interface details that describe the interfaces implemented by this asset
        /// model, including interface asset model IDs and property mappings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InterfaceRelationship> InterfaceDetails
        {
            get { return this._interfaceDetails; }
            set { this._interfaceDetails = value; }
        }

        // Check to see if InterfaceDetails property is set
        internal bool IsSetInterfaceDetails()
        {
            return this._interfaceDetails != null && (this._interfaceDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}