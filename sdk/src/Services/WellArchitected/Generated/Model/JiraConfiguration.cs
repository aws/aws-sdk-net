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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Configuration of the Jira integration.
    /// </summary>
    public partial class JiraConfiguration
    {
        private string _jiraIssueUrl;
        private DateTime? _lastSyncedTime;

        /// <summary>
        /// Gets and sets the property JiraIssueUrl. 
        /// <para>
        /// The URL of the associated Jira issue.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string JiraIssueUrl
        {
            get { return this._jiraIssueUrl; }
            set { this._jiraIssueUrl = value; }
        }

        // Check to see if JiraIssueUrl property is set
        internal bool IsSetJiraIssueUrl()
        {
            return this._jiraIssueUrl != null;
        }

        /// <summary>
        /// Gets and sets the property LastSyncedTime.
        /// </summary>
        public DateTime? LastSyncedTime
        {
            get { return this._lastSyncedTime; }
            set { this._lastSyncedTime = value; }
        }

        // Check to see if LastSyncedTime property is set
        internal bool IsSetLastSyncedTime()
        {
            return this._lastSyncedTime.HasValue; 
        }

    }
}