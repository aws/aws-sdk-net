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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Details about the generative chunk data.
    /// </summary>
    public partial class GenerativeChunkDataDetails
    {
        /// <summary>
        /// Gets and sets the property Completion. 
        /// <para>
        /// A chunk of the LLM response.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Completion { get; set; }

        /// <summary>
        /// Checks to see if the Completion property is set.
        /// </summary>
        internal bool IsSetCompletion() => this.Completion != null;

        /// <summary>
        /// Gets and sets the property NextChunkToken. 
        /// <para>
        /// The token for the next set of chunks. Use the value returned in the previous response
        /// in the next request to retrieve the next set of chunks.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextChunkToken { get; set; }

        /// <summary>
        /// Checks to see if the NextChunkToken property is set.
        /// </summary>
        internal bool IsSetNextChunkToken() => this.NextChunkToken != null;

        /// <summary>
        /// Gets and sets the property References. 
        /// <para>
        /// The references used to generate the LLM response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataSummary> References { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSummary>() : null;

        /// <summary>
        /// Checks to see if the References property is set.
        /// </summary>
        internal bool IsSetReferences() => this.References != null && (this.References.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
