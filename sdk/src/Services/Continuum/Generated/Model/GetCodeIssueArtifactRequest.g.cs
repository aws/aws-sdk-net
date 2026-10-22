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
    /// Container for the parameters to the GetCodeIssueArtifact operation. Retrieves one
    /// immutable artifact attached to an issue, including its content.
    /// </summary>
    public partial class GetCodeIssueArtifactRequest : AmazonContinuumRequest
    {
        /// <summary>
        /// Gets and sets the property ArtifactId. The unique identifier of the artifact to retrieve.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactId property is set.
        /// </summary>
        internal bool IsSetArtifactId() => this.ArtifactId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. The environment that owns the issue.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property IssueId. The issue the artifact is attached to.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string IssueId { get; set; }

        /// <summary>
        /// Checks to see if the IssueId property is set.
        /// </summary>
        internal bool IsSetIssueId() => this.IssueId != null;
    }
}
