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
    /// Container for the parameters to the UpdateAssetModel operation.
    /// Updates an asset model and all of the assets that were created from the model. Each
    /// asset created from the model inherits the updated asset model's property and hierarchy
    /// definitions. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/update-assets-and-models.html">Updating
    /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// If you remove a property from an asset model, IoT SiteWise deletes all previous data
    /// for that property. You can’t change the type or data type of an existing property.
    /// </para>
    ///  
    /// <para>
    /// To replace an existing asset model property with a new one with the same <c>name</c>,
    /// do the following:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Submit an <c>UpdateAssetModel</c> request with the entire existing property removed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit a second <c>UpdateAssetModel</c> request that includes the new property. The
    /// new asset property will have the same <c>name</c> as the previous one and IoT SiteWise
    /// will generate a new unique <c>id</c>.
    /// </para>
    ///  </li> </ol> </important>
    /// </summary>
    public partial class UpdateAssetModelRequest : AmazonIoTSiteWiseRequest
    {
        private List<AssetModelCompositeModel> _assetModelCompositeModels = AWSConfigs.InitializeCollections ? new List<AssetModelCompositeModel>() : null;
        private string _assetModelDescription;
        private string _assetModelExternalId;
        private List<AssetModelHierarchy> _assetModelHierarchies = AWSConfigs.InitializeCollections ? new List<AssetModelHierarchy>() : null;
        private string _assetModelId;
        private string _assetModelName;
        private List<AssetModelProperty> _assetModelProperties = AWSConfigs.InitializeCollections ? new List<AssetModelProperty>() : null;
        private string _clientToken;
        private string _ifMatch;
        private string _ifNoneMatch;
        private AssetModelVersionType _matchForVersionType;

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModels. 
        /// <para>
        /// The composite models that are part of this asset model. It groups properties (such
        /// as attributes, measurements, transforms, and metrics) and child composite models that
        /// model parts of your industrial equipment. Each composite model has a type that defines
        /// the properties that the composite model supports. Use composite models to define alarms
        /// on this asset model.
        /// </para>
        ///  <note> 
        /// <para>
        /// When creating custom composite models, you need to use <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_CreateAssetModelCompositeModel.html">CreateAssetModelCompositeModel</a>.
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/create-custom-composite-models.html">Creating
        /// custom composite models (Components)</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property AssetModelDescription. 
        /// <para>
        /// A description for the asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// An external ID to assign to the asset model. The asset model must not already have
        /// an external ID. The external ID must be unique within your Amazon Web Services account.
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-ids">Using
        /// external IDs</a> in the <i>IoT SiteWise User Guide</i>.
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
        /// The updated hierarchy definitions of the asset model. Each hierarchy specifies an
        /// asset model whose assets can be children of any other assets created from this asset
        /// model. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/asset-hierarchies.html">Asset
        /// hierarchies</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to 10 hierarchies per asset model. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// The ID of the asset model to update. This can be either the actual ID in UUID format,
        /// or else <c>externalId:</c> followed by the external ID, if it has one. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=139)]
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
        /// Gets and sets the property AssetModelName. 
        /// <para>
        /// A unique name for the asset model.
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
        /// The updated property definitions of the asset model. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/asset-properties.html">Asset
        /// properties</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to 200 properties per asset model. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique case-sensitive identifier that you can provide to ensure the idempotency
        /// of the request. Don't reuse this client token if a new idempotent request is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The expected current entity tag (ETag) for the asset model’s latest or active version
        /// (specified using <c>matchForVersionType</c>). The update request is rejected if the
        /// tag does not match the latest or active version's current entity tag. See <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/opt-locking-for-model.html">Optimistic
        /// locking for asset model writes</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

        /// <summary>
        /// Gets and sets the property IfNoneMatch. 
        /// <para>
        /// Accepts <b>*</b> to reject the update request if an active version (specified using
        /// <c>matchForVersionType</c> as <c>ACTIVE</c>) already exists for the asset model.
        /// </para>
        /// </summary>
        public string IfNoneMatch
        {
            get { return this._ifNoneMatch; }
            set { this._ifNoneMatch = value; }
        }

        // Check to see if IfNoneMatch property is set
        internal bool IsSetIfNoneMatch()
        {
            return this._ifNoneMatch != null;
        }

        /// <summary>
        /// Gets and sets the property MatchForVersionType. 
        /// <para>
        /// Specifies the asset model version type (<c>LATEST</c> or <c>ACTIVE</c>) used in conjunction
        /// with <c>If-Match</c> or <c>If-None-Match</c> headers to determine the target ETag
        /// for the update operation.
        /// </para>
        /// </summary>
        public AssetModelVersionType MatchForVersionType
        {
            get { return this._matchForVersionType; }
            set { this._matchForVersionType = value; }
        }

        // Check to see if MatchForVersionType property is set
        internal bool IsSetMatchForVersionType()
        {
            return this._matchForVersionType != null;
        }

    }
}