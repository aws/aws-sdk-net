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
    /// Summary information about an artifact
    /// </summary>
    public partial class ArtifactSummary
    {
        private string _artifactId;
        private ArtifactType _artifactType;
        private string _fileName;

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
        /// Gets and sets the property ArtifactType. 
        /// <para>
        /// Type of the artifact file
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ArtifactType ArtifactType
        {
            get { return this._artifactType; }
            set { this._artifactType = value; }
        }

        // Check to see if ArtifactType property is set
        internal bool IsSetArtifactType()
        {
            return this._artifactType != null;
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

    }
}