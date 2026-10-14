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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// A single search result item representing a matched asset.
    /// </summary>
    public partial class SearchResultItem
    {
        /// <summary>
        /// Gets and sets the property AssetDescription. 
        /// <para>
        /// The description of the matched asset.
        /// </para>
        /// </summary>
        public string AssetDescription { get; set; }

        /// <summary>
        /// Checks to see if the AssetDescription property is set.
        /// </summary>
        internal bool IsSetAssetDescription() => this.AssetDescription != null;

        /// <summary>
        /// Gets and sets the property AssetName. 
        /// <para>
        /// The name of the matched asset.
        /// </para>
        /// </summary>
        public string AssetName { get; set; }

        /// <summary>
        /// Checks to see if the AssetName property is set.
        /// </summary>
        internal bool IsSetAssetName() => this.AssetName != null;

        /// <summary>
        /// Gets and sets the property AssetTypeId. 
        /// <para>
        /// The identifier of the asset type for the matched asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AssetTypeId { get; set; }

        /// <summary>
        /// Checks to see if the AssetTypeId property is set.
        /// </summary>
        internal bool IsSetAssetTypeId() => this.AssetTypeId != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the matched asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1087)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp at which the matched asset was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
