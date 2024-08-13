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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// Filter by asset model.
    /// </summary>
    public partial class FilterByAssetModel
    {
        private string _assetModelExternalId;
        private string _assetModelId;
        private bool? _includeAssets;
        private bool? _includeOffspring;

        /// <summary>
        /// Gets and sets the property AssetModelExternalId. 
        /// <para>
        /// The external-Id property of an asset model.
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
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The asset model Id.
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
        /// Gets and sets the property IncludeAssets. 
        /// <para>
        /// Bolean to include assets.
        /// </para>
        /// </summary>
        public bool? IncludeAssets
        {
            get { return this._includeAssets; }
            set { this._includeAssets = value; }
        }

        // Check to see if IncludeAssets property is set
        internal bool IsSetIncludeAssets()
        {
            return this._includeAssets.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeOffspring. 
        /// <para>
        /// Include asset offspring. [need desc.]
        /// </para>
        /// </summary>
        public bool? IncludeOffspring
        {
            get { return this._includeOffspring; }
            set { this._includeOffspring = value; }
        }

        // Check to see if IncludeOffspring property is set
        internal bool IsSetIncludeOffspring()
        {
            return this._includeOffspring.HasValue; 
        }

    }
}