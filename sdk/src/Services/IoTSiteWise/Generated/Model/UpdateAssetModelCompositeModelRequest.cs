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
    /// Container for the parameters to the UpdateAssetModelCompositeModel operation.
    /// Updates a composite model and all of the assets that were created from the model.
    /// Each asset created from the model inherits the updated asset model's property and
    /// hierarchy definitions. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/update-assets-and-models.html">Updating
    /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// If you remove a property from a composite asset model, IoT SiteWise deletes all previous
    /// data for that property. You can’t change the type or data type of an existing property.
    /// </para>
    ///  
    /// <para>
    /// To replace an existing composite asset model property with a new one with the same
    /// <c>name</c>, do the following:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Submit an <c>UpdateAssetModelCompositeModel</c> request with the entire existing property
    /// removed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit a second <c>UpdateAssetModelCompositeModel</c> request that includes the new
    /// property. The new asset property will have the same <c>name</c> as the previous one
    /// and IoT SiteWise will generate a new unique <c>id</c>.
    /// </para>
    ///  </li> </ol> </important>
    /// </summary>
    public partial class UpdateAssetModelCompositeModelRequest : AmazonIoTSiteWiseRequest
    {
        private string _assetModelCompositeModelDescription;
        private string _assetModelCompositeModelExternalId;
        private string _assetModelCompositeModelId;
        private string _assetModelCompositeModelName;
        private List<AssetModelProperty> _assetModelCompositeModelProperties = AWSConfigs.InitializeCollections ? new List<AssetModelProperty>() : null;
        private string _assetModelId;
        private string _clientToken;
        private string _ifMatch;
        private string _ifNoneMatch;
        private AssetModelVersionType _matchForVersionType;

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
        /// An external ID to assign to the asset model. You can only set the external ID of the
        /// asset model if it wasn't set when it was created, or you're setting it to the exact
        /// same thing as when it was created.
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
        /// The ID of a composite model on this asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=139)]
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
        public List<AssetModelProperty> AssetModelCompositeModelProperties
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
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model, in UUID format.
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