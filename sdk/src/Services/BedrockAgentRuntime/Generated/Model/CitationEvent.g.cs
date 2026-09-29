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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// A citation event.
    /// </summary>
    public partial class CitationEvent : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property Citation. 
        /// <para>
        /// The citation.
        /// </para>
        /// </summary>
        [Obsolete("Citation is deprecated. Please use GeneratedResponsePart and RetrievedReferences for citation event.")]
        public Citation Citation { get; set; }

        /// <summary>
        /// Checks to see if the Citation property is set.
        /// </summary>
        internal bool IsSetCitation() => this.Citation != null;

        /// <summary>
        /// Gets and sets the property GeneratedResponsePart. 
        /// <para>
        /// The generated response to the citation event.
        /// </para>
        /// </summary>
        public GeneratedResponsePart GeneratedResponsePart { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedResponsePart property is set.
        /// </summary>
        internal bool IsSetGeneratedResponsePart() => this.GeneratedResponsePart != null;

        /// <summary>
        /// Gets and sets the property RetrievedReferences. 
        /// <para>
        /// The retrieved references of the citation event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RetrievedReference> RetrievedReferences { get; set; } = AWSConfigs.InitializeCollections ? new List<RetrievedReference>() : null;

        /// <summary>
        /// Checks to see if the RetrievedReferences property is set.
        /// </summary>
        internal bool IsSetRetrievedReferences() => this.RetrievedReferences != null && (this.RetrievedReferences.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
