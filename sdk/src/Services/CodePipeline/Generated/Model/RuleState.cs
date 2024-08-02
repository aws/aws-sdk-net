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
    /// Returns information about the state of a rule.
    /// 
    ///  <note> 
    /// <para>
    /// Values returned in the <c>revisionId</c> field indicate the rule revision information,
    /// such as the commit ID, for the current state.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RuleState
    {
        private RuleRevision _currentRevision;
        private string _entityUrl;
        private RuleExecution _latestExecution;
        private string _revisionUrl;
        private string _ruleName;

        /// <summary>
        /// Gets and sets the property CurrentRevision. 
        /// <para>
        /// The ID of the current revision of the artifact successfully worked on by the job.
        /// </para>
        /// </summary>
        public RuleRevision CurrentRevision
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
        /// A URL link for more information about the state of the action, such as a details page.
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
        /// Represents information about the latest run of an rule.
        /// </para>
        /// </summary>
        public RuleExecution LatestExecution
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

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

    }
}