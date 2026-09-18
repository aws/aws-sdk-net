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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Represents a portion of a source document with line number annotations. Chunks help
    /// organize document content for easier navigation and reference.
    /// </summary>
    public partial class AutomatedReasoningPolicyAnnotatedChunk
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The lines of text contained within this chunk, each annotated with its line number.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AutomatedReasoningPolicyAnnotatedContent> Content { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyAnnotatedContent>() : null;

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null && (this.Content.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PageNumber. 
        /// <para>
        /// The page number where this chunk begins, if the document is divided into pages.
        /// </para>
        /// </summary>
        public int? PageNumber { get; set; }

        /// <summary>
        /// Checks to see if the PageNumber property is set.
        /// </summary>
        internal bool IsSetPageNumber() => this.PageNumber.HasValue;
    }
}
