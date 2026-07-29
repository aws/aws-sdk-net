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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the PutAsset operation.
    /// Creates or updates an asset in Glue Data Catalog. If the asset already exists, this
    /// operation updates it; otherwise, a new asset is created.
    /// </summary>
    public partial class PutAssetRequest : AmazonGlueRequest
    {
        private string _assetTypeId;
        private string _clientToken;
        private string _description;
        private Dictionary<string, AssetFormEntry> _forms = AWSConfigs.InitializeCollections ? new Dictionary<string, AssetFormEntry>() : null;
        private string _identifier;
        private string _name;

        /// <summary>
        /// Gets and sets the property AssetTypeId. 
        /// <para>
        /// The identifier of the asset type for the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AssetTypeId
        {
            get { return this._assetTypeId; }
            set { this._assetTypeId = value; }
        }

        // Check to see if AssetTypeId property is set
        internal bool IsSetAssetTypeId()
        {
            return this._assetTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the asset.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Forms. 
        /// <para>
        /// The forms to set on the asset, keyed by form name. Each entry specifies the form type
        /// and its JSON content.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, AssetFormEntry> Forms
        {
            get { return this._forms; }
            set { this._forms = value; }
        }

        // Check to see if Forms property is set
        internal bool IsSetForms()
        {
            return this._forms != null && (this._forms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier of the asset. If an asset with this identifier already exists,
        /// it is updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1087)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}