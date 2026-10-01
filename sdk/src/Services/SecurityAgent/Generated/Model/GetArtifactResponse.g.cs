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
    /// This is the response object from the GetArtifact operation.
    /// </summary>
    public partial class GetArtifactResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space that contains the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property Artifact. 
        /// <para>
        /// The artifact content and type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Artifact Artifact { get; set; }

        /// <summary>
        /// Checks to see if the Artifact property is set.
        /// </summary>
        internal bool IsSetArtifact() => this.Artifact != null;

        /// <summary>
        /// Gets and sets the property ArtifactId. 
        /// <para>
        /// The unique identifier of the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactId property is set.
        /// </summary>
        internal bool IsSetArtifactId() => this.ArtifactId != null;

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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the artifact was last updated, in UTC format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
