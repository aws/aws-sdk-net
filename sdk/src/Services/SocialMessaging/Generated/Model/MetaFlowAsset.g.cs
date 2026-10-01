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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Represents a single asset file associated with a WhatsApp Flow, including a presigned
    /// download URL.
    /// </summary>
    public partial class MetaFlowAsset
    {
        /// <summary>
        /// Gets and sets the property AssetType. 
        /// <para>
        /// The type of asset. Currently the only supported value is FLOW_JSON.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string AssetType { get; set; }

        /// <summary>
        /// Checks to see if the AssetType property is set.
        /// </summary>
        internal bool IsSetAssetType() => this.AssetType != null;

        /// <summary>
        /// Gets and sets the property DownloadUrl. 
        /// <para>
        /// A presigned URL from Meta for downloading the asset. The URL expires after a short
        /// period.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Checks to see if the DownloadUrl property is set.
        /// </summary>
        internal bool IsSetDownloadUrl() => this.DownloadUrl != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The filename of the asset (for example, flow.json).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
