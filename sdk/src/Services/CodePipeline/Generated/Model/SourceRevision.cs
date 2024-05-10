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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Information about the version (or revision) of a source artifact that initiated a
    /// pipeline execution.
    /// </summary>
    public partial class SourceRevision
    {
        private string _actionName;
        private string _revisionId;
        private string _revisionSummary;
        private string _revisionUrl;

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The name of the action that processed the revision to the source artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The system-generated unique ID that identifies the revision number of the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1500)]
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionSummary. 
        /// <para>
        /// Summary information about the most recent revision of the artifact. For GitHub and
        /// CodeCommit repositories, the commit message. For Amazon S3 buckets or actions, the
        /// user-provided content of a <c>codepipeline-artifact-revision-summary</c> key specified
        /// in the object metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RevisionSummary
        {
            get { return this._revisionSummary; }
            set { this._revisionSummary = value; }
        }

        // Check to see if RevisionSummary property is set
        internal bool IsSetRevisionSummary()
        {
            return this._revisionSummary != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionUrl. 
        /// <para>
        /// The commit ID for the artifact revision. For artifacts stored in GitHub or CodeCommit
        /// repositories, the commit ID is linked to a commit details page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RevisionUrl
        {
            get { return this._revisionUrl; }
            set { this._revisionUrl = value; }
        }

        // Check to see if RevisionUrl property is set
        internal bool IsSetRevisionUrl()
        {
            return this._revisionUrl != null;
        }

    }
}