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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
        private string _agentSpaceId;
        private Artifact _artifact;
        private string _artifactId;
        private string _fileName;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// Unique identifier of the agent space
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentSpaceId
        {
            get { return this._agentSpaceId; }
            set { this._agentSpaceId = value; }
        }

        // Check to see if AgentSpaceId property is set
        internal bool IsSetAgentSpaceId()
        {
            return this._agentSpaceId != null;
        }

        /// <summary>
        /// Gets and sets the property Artifact. 
        /// <para>
        /// Artifact details
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Artifact Artifact
        {
            get { return this._artifact; }
            set { this._artifact = value; }
        }

        // Check to see if Artifact property is set
        internal bool IsSetArtifact()
        {
            return this._artifact != null;
        }

        /// <summary>
        /// Gets and sets the property ArtifactId. 
        /// <para>
        /// Unique identifier of the artifact
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ArtifactId
        {
            get { return this._artifactId; }
            set { this._artifactId = value; }
        }

        // Check to see if ArtifactId property is set
        internal bool IsSetArtifactId()
        {
            return this._artifactId != null;
        }

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// Name of the artifact file
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }

        // Check to see if FileName property is set
        internal bool IsSetFileName()
        {
            return this._fileName != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp when the artifact was last updated
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}