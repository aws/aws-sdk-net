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
    /// Filter by asset. [TwinMaker asset]
    /// </summary>
    public partial class FilterByAsset
    {
        /// <summary>
        /// Gets and sets the property AssetExternalId. 
        /// <para>
        /// The external-Id property of an asset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 128)]
        public string AssetExternalId { get; set; }

        /// <summary>
        /// Checks to see if the AssetExternalId property is set.
        /// </summary>
        internal bool IsSetAssetExternalId() => this.AssetExternalId != null;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// Filter by asset Id.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property IncludeAssetModel. 
        /// <para>
        /// Boolean to include the asset model.
        /// </para>
        /// </summary>
        public bool? IncludeAssetModel { get; set; }

        /// <summary>
        /// Checks to see if the IncludeAssetModel property is set.
        /// </summary>
        internal bool IsSetIncludeAssetModel() => this.IncludeAssetModel.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeOffspring. 
        /// <para>
        /// Includes sub-assets.[need description hekp for this]
        /// </para>
        /// </summary>
        public bool? IncludeOffspring { get; set; }

        /// <summary>
        /// Checks to see if the IncludeOffspring property is set.
        /// </summary>
        internal bool IsSetIncludeOffspring() => this.IncludeOffspring.HasValue;
    }
}
