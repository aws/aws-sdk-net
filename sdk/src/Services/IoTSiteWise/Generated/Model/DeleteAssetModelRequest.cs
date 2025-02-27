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
    /// Container for the parameters to the DeleteAssetModel operation.
    /// Deletes an asset model. This action can't be undone. You must delete all assets created
    /// from an asset model before you can delete the model. Also, you can't delete an asset
    /// model if a parent asset model exists that contains a property formula expression that
    /// depends on the asset model that you want to delete. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/delete-assets-and-models.html">Deleting
    /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
    /// </summary>
    public partial class DeleteAssetModelRequest : AmazonIoTSiteWiseRequest
    {
        private string _assetModelId;
        private string _clientToken;
        private string _ifMatch;
        private string _ifNoneMatch;
        private AssetModelVersionType _matchForVersionType;

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model to delete. This can be either the actual ID in UUID format,
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
        /// (specified using <c>matchForVersionType</c>). The delete request is rejected if the
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
        /// Accepts <b>*</b> to reject the delete request if an active version (specified using
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
        /// for the delete operation.
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