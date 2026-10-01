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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Specifies how metadata fields should be handled during the reranking process.
    /// </summary>
    public partial class MetadataConfigurationForReranking
    {
        /// <summary>
        /// Gets and sets the property SelectionMode. 
        /// <para>
        /// The mode for selecting metadata fields for reranking.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RerankingMetadataSelectionMode SelectionMode { get; set; }

        /// <summary>
        /// Checks to see if the SelectionMode property is set.
        /// </summary>
        internal bool IsSetSelectionMode() => this.SelectionMode != null;

        /// <summary>
        /// Gets and sets the property SelectiveModeConfiguration. 
        /// <para>
        /// The configuration for selective metadata field inclusion or exclusion during reranking.
        /// </para>
        /// </summary>
        public RerankingMetadataSelectiveModeConfiguration SelectiveModeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SelectiveModeConfiguration property is set.
        /// </summary>
        internal bool IsSetSelectiveModeConfiguration() => this.SelectiveModeConfiguration != null;
    }
}
