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
    /// Represents information about the state of an action.
    /// </summary>
    public partial class ActionState
    {
        private string _actionName;
        private ActionRevision _currentRevision;
        private string _entityUrl;
        private ActionExecution _latestExecution;
        private string _revisionUrl;

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The name of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property CurrentRevision. 
        /// <para>
        /// Represents information about the version (or revision) of an action.
        /// </para>
        /// </summary>
        public ActionRevision CurrentRevision
        {
            get { return this._currentRevision; }
            set { this._currentRevision = value; }
        }

        // Check to see if CurrentRevision property is set
        internal bool IsSetCurrentRevision()
        {
            return this._currentRevision != null;
        }

        /// <summary>
        /// Gets and sets the property EntityUrl. 
        /// <para>
        /// A URL link for more information about the state of the action, such as a deployment
        /// group details page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EntityUrl
        {
            get { return this._entityUrl; }
            set { this._entityUrl = value; }
        }

        // Check to see if EntityUrl property is set
        internal bool IsSetEntityUrl()
        {
            return this._entityUrl != null;
        }

        /// <summary>
        /// Gets and sets the property LatestExecution. 
        /// <para>
        /// Represents information about the run of an action.
        /// </para>
        /// </summary>
        public ActionExecution LatestExecution
        {
            get { return this._latestExecution; }
            set { this._latestExecution = value; }
        }

        // Check to see if LatestExecution property is set
        internal bool IsSetLatestExecution()
        {
            return this._latestExecution != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionUrl. 
        /// <para>
        /// A URL link for more information about the revision, such as a commit details page.
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