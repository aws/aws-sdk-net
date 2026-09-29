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
    /// Container for the parameters to the DeleteAssetModelCompositeModel operation. Deletes
    /// a composite model. This action can't be undone. You must delete all assets created
    /// from a composite model before you can delete the model. Also, you can't delete a composite
    /// model if a parent asset model exists that contains a property formula expression that
    /// depends on the asset model that you want to delete. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/delete-assets-and-models.html">Deleting
    /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
    /// </summary>
    public partial class DeleteAssetModelCompositeModelRequest : AmazonIoTSiteWiseRequest
    {
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
        /// (specified using <c>matchForVersionType</c>). The delete request is rejected if the
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
        /// Accepts <b>*</b> to reject the delete request if an active version (specified using
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
        /// for the delete operation.
        /// </para>
        /// </summary>
        public AssetModelVersionType MatchForVersionType { get; set; }

        /// <summary>
        /// Checks to see if the MatchForVersionType property is set.
        /// </summary>
        internal bool IsSetMatchForVersionType() => this.MatchForVersionType != null;
    }
}
