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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAsset operation. Updates an asset in the
    /// specified agent space
    /// </summary>
    public partial class UpdateAssetRequest : AmazonDevOpsAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier for the agent space containing the asset
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The unique identifier of the asset to update
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier used for idempotent asset update
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Optional content update. A single file adds or replaces one file; a zip replaces all
        /// files; a sourceUrl re-syncs from the original source.
        /// </para>
        /// </summary>
        public AssetContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata fields to update. Only the fields present in this document are updated. Omitted
        /// fields retain their current values.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => !this.Metadata.IsNull();
    }
}
