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
    /// A single search result item representing a matched asset.
    /// </summary>
    public partial class SearchResultItem
    {
        private string _assetDescription;
        private string _assetName;
        private string _assetTypeId;
        private string _id;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AssetDescription. 
        /// <para>
        /// The description of the matched asset.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property AssetName. 
        /// <para>
        /// The name of the matched asset.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property AssetTypeId. 
        /// <para>
        /// The identifier of the asset type for the matched asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the matched asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1087)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp at which the matched asset was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}