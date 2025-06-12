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
    /// Container for the parameters to the CreateAsset operation.
    /// Creates an asset from an existing asset model. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/create-assets.html">Creating
    /// assets</a> in the <i>IoT SiteWise User Guide</i>.
    /// </summary>
    public partial class CreateAssetRequest : AmazonIoTSiteWiseRequest
    {
        private string _assetDescription;
        private string _assetExternalId;
        private string _assetId;
        private string _assetModelId;
        private string _assetName;
        private string _clientToken;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        /// An external ID to assign to the asset. The external ID must be unique within your
        /// Amazon Web Services account. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-ids">Using
        /// external IDs</a> in the <i>IoT SiteWise User Guide</i>.
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
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID to assign to the asset, if desired. IoT SiteWise automatically generates a
        /// unique ID for you, so this parameter is never required. However, if you prefer to
        /// supply your own ID instead, you can specify it here in UUID format. If you specify
        /// your own ID, it must be globally unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model from which to create the asset. This can be either the actual
        /// ID in UUID format, or else <c>externalId:</c> followed by the external ID, if it has
        /// one. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
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
        /// Gets and sets the property AssetName. 
        /// <para>
        /// A friendly name for the asset.
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
        /// A list of key-value pairs that contain metadata for the asset. For more information,
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