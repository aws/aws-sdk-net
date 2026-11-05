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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// A summary of an artifact returned in list responses.
    /// </summary>
    public partial class IssueArtifactItem
    {
        /// <summary>
        /// Gets and sets the property ArtifactId. The unique identifier of the artifact.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactId property is set.
        /// </summary>
        internal bool IsSetArtifactId() => this.ArtifactId != null;

        /// <summary>
        /// Gets and sets the property ArtifactType. Semantic category of the artifact.
        /// </summary>
        [AWSProperty(Required = true)]
        public IssueArtifactType ArtifactType { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactType property is set.
        /// </summary>
        internal bool IsSetArtifactType() => this.ArtifactType != null;

        /// <summary>
        /// Gets and sets the property ContentSizeBytes. Size of the artifact content in bytes.
        /// The content itself is returned by GetCodeIssueArtifact.
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ContentSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the ContentSizeBytes property is set.
        /// </summary>
        internal bool IsSetContentSizeBytes() => this.ContentSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. The timestamp when the artifact was created.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property MediaType. MIME type of the artifact content.
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 255)]
        public string MediaType { get; set; }

        /// <summary>
        /// Checks to see if the MediaType property is set.
        /// </summary>
        internal bool IsSetMediaType() => this.MediaType != null;

        /// <summary>
        /// Gets and sets the property Producer. The agent that produced the artifact.
        /// </summary>
        [AWSProperty(Required = true)]
        public IssueArtifactProducerSummary Producer { get; set; }

        /// <summary>
        /// Checks to see if the Producer property is set.
        /// </summary>
        internal bool IsSetProducer() => this.Producer != null;
    }
}
