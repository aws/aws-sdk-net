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
    /// Container for the parameters to the UpdateAssetModelCompositeModel operation. Updates
    /// a composite model and all of the assets that were created from the model. Each asset
    /// created from the model inherits the updated asset model's property and hierarchy definitions.
    /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/update-assets-and-models.html">Updating
    /// assets and models</a> in the <i>IoT SiteWise User Guide</i>. <important> <para> If
    /// you remove a property from a composite asset model, IoT SiteWise deletes all previous
    /// data for that property. You can’t change the type or data type of an existing property.
    /// </para> <para> To replace an existing composite asset model property with a new one
    /// with the same <c>name</c>, do the following: </para> <ol> <li> <para> Submit an <c>UpdateAssetModelCompositeModel</c>
    /// request with the entire existing property removed. </para> </li> <li> <para> Submit
    /// a second <c>UpdateAssetModelCompositeModel</c> request that includes the new property.
    /// The new asset property will have the same <c>name</c> as the previous one and IoT
    /// SiteWise will generate a new unique <c>id</c>. </para> </li> </ol> </important>
    /// </summary>
    public partial class UpdateAssetModelCompositeModelRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelDescription. 
        /// <para>
        /// A description for the composite model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string AssetModelCompositeModelDescription { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelCompositeModelDescription property is set.
        /// </summary>
        internal bool IsSetAssetModelCompositeModelDescription() => this.AssetModelCompositeModelDescription != null;

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelExternalId. 
        /// <para>
        /// An external ID to assign to the asset model. You can only set the external ID of the
        /// asset model if it wasn't set when it was created, or you're setting it to the exact
        /// same thing as when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 128)]
        public string AssetModelCompositeModelExternalId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelCompositeModelExternalId property is set.
        /// </summary>
        internal bool IsSetAssetModelCompositeModelExternalId() => this.AssetModelCompositeModelExternalId != null;

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelId. 
        /// <para>
        /// The ID of a composite model on this asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 13, Max = 139)]
        public string AssetModelCompositeModelId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelCompositeModelId property is set.
        /// </summary>
        internal bool IsSetAssetModelCompositeModelId() => this.AssetModelCompositeModelId != null;

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelName. 
        /// <para>
        /// A unique name for the composite model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AssetModelCompositeModelName { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelCompositeModelName property is set.
        /// </summary>
        internal bool IsSetAssetModelCompositeModelName() => this.AssetModelCompositeModelName != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetModelProperty> AssetModelCompositeModelProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetModelProperty>() : null;

        /// <summary>
        /// Checks to see if the AssetModelCompositeModelProperties property is set.
        /// </summary>
        internal bool IsSetAssetModelCompositeModelProperties() => this.AssetModelCompositeModelProperties != null && (this.AssetModelCompositeModelProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model, in UUID format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 13, Max = 139)]
        public string AssetModelId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelId property is set.
        /// </summary>
        internal bool IsSetAssetModelId() => this.AssetModelId != null;

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
