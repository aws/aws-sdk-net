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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about hardware assets.
    /// </summary>
    public partial class AssetInfo
    {
        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        ///  The ID of the asset. An Outpost asset can be a single server within an Outposts rack
        /// or an Outposts server configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property AssetLocation. 
        /// <para>
        ///  The position of an asset in a rack. 
        /// </para>
        /// </summary>
        public AssetLocation AssetLocation { get; set; }

        /// <summary>
        /// Checks to see if the AssetLocation property is set.
        /// </summary>
        internal bool IsSetAssetLocation() => this.AssetLocation != null;

        /// <summary>
        /// Gets and sets the property AssetType. 
        /// <para>
        ///  The type of the asset. 
        /// </para>
        /// </summary>
        public AssetType AssetType { get; set; }

        /// <summary>
        /// Checks to see if the AssetType property is set.
        /// </summary>
        internal bool IsSetAssetType() => this.AssetType != null;

        /// <summary>
        /// Gets and sets the property ComputeAttributes. 
        /// <para>
        ///  Information about compute hardware assets. 
        /// </para>
        /// </summary>
        public ComputeAttributes ComputeAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ComputeAttributes property is set.
        /// </summary>
        internal bool IsSetComputeAttributes() => this.ComputeAttributes != null;

        /// <summary>
        /// Gets and sets the property RackId. 
        /// <para>
        ///  The rack ID of the asset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 20)]
        public string RackId { get; set; }

        /// <summary>
        /// Checks to see if the RackId property is set.
        /// </summary>
        internal bool IsSetRackId() => this.RackId != null;
    }
}
