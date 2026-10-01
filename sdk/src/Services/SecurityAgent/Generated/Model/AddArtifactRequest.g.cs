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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the AddArtifact operation. Uploads an artifact to
    /// an agent space. Artifacts provide additional context for security testing, such as
    /// architecture diagrams, API specifications, or configuration files.
    /// </summary>
    public partial class AddArtifactRequest : AmazonSecurityAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space to add the artifact to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property ArtifactContent. 
        /// <para>
        /// The binary content of the artifact to upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemoryStream ArtifactContent { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactContent property is set.
        /// </summary>
        internal bool IsSetArtifactContent() => this.ArtifactContent != null;

        /// <summary>
        /// Gets and sets the property ArtifactType. 
        /// <para>
        /// The file type of the artifact. Valid values include TXT, PNG, JPEG, MD, PDF, DOCX,
        /// DOC, JSON, and YAML.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ArtifactType ArtifactType { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactType property is set.
        /// </summary>
        internal bool IsSetArtifactType() => this.ArtifactType != null;

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The file name of the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;
    }
}
