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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// Filter by asset model.
    /// </summary>
    public partial class FilterByAssetModel
    {
        /// <summary>
        /// Gets and sets the property AssetModelExternalId. 
        /// <para>
        /// The external-Id property of an asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 128)]
        public string AssetModelExternalId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelExternalId property is set.
        /// </summary>
        internal bool IsSetAssetModelExternalId() => this.AssetModelExternalId != null;

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The asset model Id.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string AssetModelId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelId property is set.
        /// </summary>
        internal bool IsSetAssetModelId() => this.AssetModelId != null;

        /// <summary>
        /// Gets and sets the property IncludeAssets. 
        /// <para>
        /// Bolean to include assets.
        /// </para>
        /// </summary>
        public bool? IncludeAssets { get; set; }

        /// <summary>
        /// Checks to see if the IncludeAssets property is set.
        /// </summary>
        internal bool IsSetIncludeAssets() => this.IncludeAssets.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeOffspring. 
        /// <para>
        /// Include asset offspring. [need desc.]
        /// </para>
        /// </summary>
        public bool? IncludeOffspring { get; set; }

        /// <summary>
        /// Checks to see if the IncludeOffspring property is set.
        /// </summary>
        internal bool IsSetIncludeOffspring() => this.IncludeOffspring.HasValue;
    }
}
