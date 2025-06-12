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
    /// Container for the parameters to the CreateAssetModelCompositeModel operation.
    /// Creates a custom composite model from specified property and hierarchy definitions.
    /// There are two types of custom composite models, <c>inline</c> and <c>component-model-based</c>.
    /// 
    /// 
    ///  
    /// <para>
    /// Use component-model-based custom composite models to define standard, reusable components.
    /// A component-model-based custom composite model consists of a name, a description,
    /// and the ID of the component model it references. A component-model-based custom composite
    /// model has no properties of its own; its referenced component model provides its associated
    /// properties to any created assets. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/custom-composite-models.html">Custom
    /// composite models (Components)</a> in the <i>IoT SiteWise User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Use inline custom composite models to organize the properties of an asset model. The
    /// properties of inline custom composite models are local to the asset model where they
    /// are included and can't be used to create multiple assets.
    /// </para>
    ///  
    /// <para>
    /// To create a component-model-based model, specify the <c>composedAssetModelId</c> of
    /// an existing asset model with <c>assetModelType</c> of <c>COMPONENT_MODEL</c>.
    /// </para>
    ///  
    /// <para>
    /// To create an inline model, specify the <c>assetModelCompositeModelProperties</c> and
    /// don't include an <c>composedAssetModelId</c>.
    /// </para>
    /// </summary>
    public partial class CreateAssetModelCompositeModelRequest : AmazonIoTSiteWiseRequest
    {
        private string _assetModelCompositeModelDescription;
        private string _assetModelCompositeModelExternalId;
        private string _assetModelCompositeModelId;
        private string _assetModelCompositeModelName;
        private List<AssetModelPropertyDefinition> _assetModelCompositeModelProperties = AWSConfigs.InitializeCollections ? new List<AssetModelPropertyDefinition>() : null;
        private string _assetModelCompositeModelType;
        private string _assetModelId;
        private string _clientToken;
        private string _composedAssetModelId;
        private string _ifMatch;
        private string _ifNoneMatch;
        private AssetModelVersionType _matchForVersionType;
        private string _parentAssetModelCompositeModelId;

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelDescription. 
        /// <para>
        /// A description for the composite model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AssetModelCompositeModelDescription
        {
            get { return this._assetModelCompositeModelDescription; }
            set { this._assetModelCompositeModelDescription = value; }
        }

        // Check to see if AssetModelCompositeModelDescription property is set
        internal bool IsSetAssetModelCompositeModelDescription()
        {
            return this._assetModelCompositeModelDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelExternalId. 
        /// <para>
        /// An external ID to assign to the composite model.
        /// </para>
        ///  
        /// <para>
        /// If the composite model is a derived composite model, or one nested inside a component
        /// model, you can only set the external ID using <c>UpdateAssetModelCompositeModel</c>
        /// and specifying the derived ID of the model or property from the created model it's
        /// a part of.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=128)]
        public string AssetModelCompositeModelExternalId
        {
            get { return this._assetModelCompositeModelExternalId; }
            set { this._assetModelCompositeModelExternalId = value; }
        }

        // Check to see if AssetModelCompositeModelExternalId property is set
        internal bool IsSetAssetModelCompositeModelExternalId()
        {
            return this._assetModelCompositeModelExternalId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelId. 
        /// <para>
        /// The ID of the composite model. IoT SiteWise automatically generates a unique ID for
        /// you, so this parameter is never required. However, if you prefer to supply your own
        /// ID instead, you can specify it here in UUID format. If you specify your own ID, it
        /// must be globally unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string AssetModelCompositeModelId
        {
            get { return this._assetModelCompositeModelId; }
            set { this._assetModelCompositeModelId = value; }
        }

        // Check to see if AssetModelCompositeModelId property is set
        internal bool IsSetAssetModelCompositeModelId()
        {
            return this._assetModelCompositeModelId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelName. 
        /// <para>
        /// A unique name for the composite model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AssetModelCompositeModelName
        {
            get { return this._assetModelCompositeModelName; }
            set { this._assetModelCompositeModelName = value; }
        }

        // Check to see if AssetModelCompositeModelName property is set
        internal bool IsSetAssetModelCompositeModelName()
        {
            return this._assetModelCompositeModelName != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelProperties. 
        /// <para>
        /// The property definitions of the composite model. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/custom-composite-models.html#inline-composite-models">
        /// Inline custom composite models</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to 200 properties per composite model. For more information, see
        /// <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetModelPropertyDefinition> AssetModelCompositeModelProperties
        {
            get { return this._assetModelCompositeModelProperties; }
            set { this._assetModelCompositeModelProperties = value; }
        }

        // Check to see if AssetModelCompositeModelProperties property is set
        internal bool IsSetAssetModelCompositeModelProperties()
        {
            return this._assetModelCompositeModelProperties != null && (this._assetModelCompositeModelProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelType. 
        /// <para>
        /// The composite model type. Valid values are <c>AWS/ALARM</c>, <c>CUSTOM</c>, or <c>
        /// AWS/L4E_ANOMALY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AssetModelCompositeModelType
        {
            get { return this._assetModelCompositeModelType; }
            set { this._assetModelCompositeModelType = value; }
        }

        // Check to see if AssetModelCompositeModelType property is set
        internal bool IsSetAssetModelCompositeModelType()
        {
            return this._assetModelCompositeModelType != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model this composite model is a part of.
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
        /// Gets and sets the property ComposedAssetModelId. 
        /// <para>
        /// The ID of a component model which is reused to create this composite model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=13, Max=139)]
        public string ComposedAssetModelId
        {
            get { return this._composedAssetModelId; }
            set { this._composedAssetModelId = value; }
        }

        // Check to see if ComposedAssetModelId property is set
        internal bool IsSetComposedAssetModelId()
        {
            return this._composedAssetModelId != null;
        }

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The expected current entity tag (ETag) for the asset model’s latest or active version
        /// (specified using <c>matchForVersionType</c>). The create request is rejected if the
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
        /// Accepts <b>*</b> to reject the create request if an active version (specified using
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
        /// for the create operation.
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

        /// <summary>
        /// Gets and sets the property ParentAssetModelCompositeModelId. 
        /// <para>
        /// The ID of the parent composite model in this asset model relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min=13, Max=139)]
        public string ParentAssetModelCompositeModelId
        {
            get { return this._parentAssetModelCompositeModelId; }
            set { this._parentAssetModelCompositeModelId = value; }
        }

        // Check to see if ParentAssetModelCompositeModelId property is set
        internal bool IsSetParentAssetModelCompositeModelId()
        {
            return this._parentAssetModelCompositeModelId != null;
        }

    }
}