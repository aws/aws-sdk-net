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
    /// Represents revision details of an artifact.
    /// </summary>
    public partial class ArtifactRevision
    {
        private DateTime? _created;
        private string _name;
        private string _revisionChangeIdentifier;
        private string _revisionId;
        private string _revisionSummary;
        private string _revisionUrl;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time when the most recent revision of the artifact was created, in timestamp
        /// format.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of an artifact. This name might be system-generated, such as "MyApp", or
        /// defined by the user when an action is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionChangeIdentifier. 
        /// <para>
        /// An additional identifier for a revision, such as a commit date or, for artifacts stored
        /// in Amazon S3 buckets, the ETag value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string RevisionChangeIdentifier
        {
            get { return this._revisionChangeIdentifier; }
            set { this._revisionChangeIdentifier = value; }
        }

        // Check to see if RevisionChangeIdentifier property is set
        internal bool IsSetRevisionChangeIdentifier()
        {
            return this._revisionChangeIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The revision ID of the artifact.
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