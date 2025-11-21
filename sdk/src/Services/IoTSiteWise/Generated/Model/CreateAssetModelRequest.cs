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
    /// Container for the parameters to the CreateAssetModel operation.
    /// Creates an asset model from specified property and hierarchy definitions. You create
    /// assets from asset models. With asset models, you can easily create assets of the same
    /// type that have standardized definitions. Each asset created from a model inherits
    /// the asset model's property and hierarchy definitions. For more information, see <a
    /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/define-models.html">Defining
    /// asset models</a> in the <i>IoT SiteWise User Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can create three types of asset models, <c>ASSET_MODEL</c>, <c>COMPONENT_MODEL</c>,
    /// or an <c>INTERFACE</c>.
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
    ///  </li> <li> 
    /// <para>
    ///  <b>INTERFACE</b> – An interface is a type of model that defines a standard structure
    /// that can be applied to different asset models.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateAssetModelRequest : AmazonIoTSiteWiseRequest
    {
        private List<AssetModelCompositeModelDefinition> _assetModelCompositeModels = AWSConfigs.InitializeCollections ? new List<AssetModelCompositeModelDefinition>() : null;
        private string _assetModelDescription;
        private string _assetModelExternalId;
        private List<AssetModelHierarchyDefinition> _assetModelHierarchies = AWSConfigs.InitializeCollections ? new List<AssetModelHierarchyDefinition>() : null;
        private string _assetModelId;
        private string _assetModelName;
        private List<AssetModelPropertyDefinition> _assetModelProperties = AWSConfigs.InitializeCollections ? new List<AssetModelPropertyDefinition>() : null;
        private AssetModelType _assetModelType;
        private string _clientToken;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        public List<AssetModelCompositeModelDefinition> AssetModelCompositeModels
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
        /// An external ID to assign to the asset model. The external ID must be unique within
        /// your Amazon Web Services account. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-ids">Using
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
        /// The hierarchy definitions of the asset model. Each hierarchy specifies an asset model
        /// whose assets can be children of any other assets created from this asset model. For
        /// more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/asset-hierarchies.html">Asset
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
        public List<AssetModelHierarchyDefinition> AssetModelHierarchies
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
        /// The ID to assign to the asset model, if desired. IoT SiteWise automatically generates
        /// a unique ID for you, so this parameter is never required. However, if you prefer to
        /// supply your own ID instead, you can specify it here in UUID format. If you specify
        /// your own ID, it must be globally unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// The property definitions of the asset model. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/asset-properties.html">Asset
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
        public List<AssetModelPropertyDefinition> AssetModelProperties
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that contain metadata for the asset model. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/tag-resources.html">Tagging
        /// your IoT SiteWise resources</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}