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
    /// Container for the parameters to the UpdateAssetModel operation. Updates an asset model
    /// and all of the assets that were created from the model. Each asset created from the
    /// model inherits the updated asset model's property and hierarchy definitions. For more
    /// information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/update-assets-and-models.html">Updating
    /// assets and models</a> in the <i>IoT SiteWise User Guide</i>. <important> <para> If
    /// you remove a property from an asset model, IoT SiteWise deletes all previous data
    /// for that property. You can’t change the type or data type of an existing property.
    /// </para> <para> To replace an existing asset model property with a new one with the
    /// same <c>name</c>, do the following: </para> <ol> <li> <para> Submit an <c>UpdateAssetModel</c>
    /// request with the entire existing property removed. </para> </li> <li> <para> Submit
    /// a second <c>UpdateAssetModel</c> request that includes the new property. The new asset
    /// property will have the same <c>name</c> as the previous one and IoT SiteWise will
    /// generate a new unique <c>id</c>. </para> </li> </ol> </important>
    /// </summary>
    public partial class UpdateAssetModelRequest : AmazonIoTSiteWiseRequest
    {
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetModelCompositeModel> AssetModelCompositeModels { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetModelCompositeModel>() : null;

        /// <summary>
        /// Checks to see if the AssetModelCompositeModels property is set.
        /// </summary>
        internal bool IsSetAssetModelCompositeModels() => this.AssetModelCompositeModels != null && (this.AssetModelCompositeModels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetModelDescription. 
        /// <para>
        /// A description for the asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string AssetModelDescription { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelDescription property is set.
        /// </summary>
        internal bool IsSetAssetModelDescription() => this.AssetModelDescription != null;

        /// <summary>
        /// Gets and sets the property AssetModelExternalId. 
        /// <para>
        /// An external ID to assign to the asset model. The asset model must not already have
        /// an external ID. The external ID must be unique within your Amazon Web Services account.
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-ids">Using
        /// external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 128)]
        public string AssetModelExternalId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelExternalId property is set.
        /// </summary>
        internal bool IsSetAssetModelExternalId() => this.AssetModelExternalId != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetModelHierarchy> AssetModelHierarchies { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetModelHierarchy>() : null;

        /// <summary>
        /// Checks to see if the AssetModelHierarchies property is set.
        /// </summary>
        internal bool IsSetAssetModelHierarchies() => this.AssetModelHierarchies != null && (this.AssetModelHierarchies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model to update. This can be either the actual ID in UUID format,
        /// or else <c>externalId:</c> followed by the external ID, if it has one. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 13, Max = 139)]
        public string AssetModelId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelId property is set.
        /// </summary>
        internal bool IsSetAssetModelId() => this.AssetModelId != null;

        /// <summary>
        /// Gets and sets the property AssetModelName. 
        /// <para>
        /// A unique name for the asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AssetModelName { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelName property is set.
        /// </summary>
        internal bool IsSetAssetModelName() => this.AssetModelName != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetModelProperty> AssetModelProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetModelProperty>() : null;

        /// <summary>
        /// Checks to see if the AssetModelProperties property is set.
        /// </summary>
        internal bool IsSetAssetModelProperties() => this.AssetModelProperties != null && (this.AssetModelProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique case-sensitive identifier that you can provide to ensure the idempotency
        /// of the request. Don't reuse this client token if a new idempotent request is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The expected current entity tag (ETag) for the asset model’s latest or active version
        /// (specified using <c>matchForVersionType</c>). The update request is rejected if the
        /// tag does not match the latest or active version's current entity tag. See <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/opt-locking-for-model.html">Optimistic
        /// locking for asset model writes</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        public string IfMatch { get; set; }

        /// <summary>
        /// Checks to see if the IfMatch property is set.
        /// </summary>
        internal bool IsSetIfMatch() => this.IfMatch != null;

        /// <summary>
        /// Gets and sets the property IfNoneMatch. 
        /// <para>
        /// Accepts <b>*</b> to reject the update request if an active version (specified using
        /// <c>matchForVersionType</c> as <c>ACTIVE</c>) already exists for the asset model.
        /// </para>
        /// </summary>
        public string IfNoneMatch { get; set; }

        /// <summary>
        /// Checks to see if the IfNoneMatch property is set.
        /// </summary>
        internal bool IsSetIfNoneMatch() => this.IfNoneMatch != null;

        /// <summary>
        /// Gets and sets the property MatchForVersionType. 
        /// <para>
        /// Specifies the asset model version type (<c>LATEST</c> or <c>ACTIVE</c>) used in conjunction
        /// with <c>If-Match</c> or <c>If-None-Match</c> headers to determine the target ETag
        /// for the update operation.
        /// </para>
        /// </summary>
        public AssetModelVersionType MatchForVersionType { get; set; }

        /// <summary>
        /// Checks to see if the MatchForVersionType property is set.
        /// </summary>
        internal bool IsSetMatchForVersionType() => this.MatchForVersionType != null;
    }
}
