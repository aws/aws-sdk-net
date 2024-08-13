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
    /// Represents information about a current revision.
    /// </summary>
    public partial class CurrentRevision
    {
        private string _changeIdentifier;
        private DateTime? _created;
        private string _revision;
        private string _revisionSummary;

        /// <summary>
        /// Gets and sets the property ChangeIdentifier. 
        /// <para>
        /// The change identifier for the current revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ChangeIdentifier
        {
            get { return this._changeIdentifier; }
            set { this._changeIdentifier = value; }
        }

        // Check to see if ChangeIdentifier property is set
        internal bool IsSetChangeIdentifier()
        {
            return this._changeIdentifier != null;
        }

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
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision ID of the current version of an artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1500)]
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionSummary. 
        /// <para>
        /// The summary of the most recent revision of the artifact.
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

    }
}