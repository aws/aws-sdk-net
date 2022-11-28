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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information to connect to Jira as your data source.
    /// </summary>
    public partial class JiraConfiguration
    {
        private List<DataSourceToIndexFieldMapping> _attachmentFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<DataSourceToIndexFieldMapping> _commentFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<string> _exclusionPatterns = new List<string>();
        private List<string> _inclusionPatterns = new List<string>();
        private List<DataSourceToIndexFieldMapping> _issueFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<string> _issueSubEntityFilter = new List<string>();
        private List<string> _issueType = new List<string>();
        private string _jiraAccountUrl;
        private List<string> _project = new List<string>();
        private List<DataSourceToIndexFieldMapping> _projectFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private string _secretArn;
        private List<string> _status = new List<string>();
        private bool? _useChangeLog;
        private DataSourceVpcConfiguration _vpcConfiguration;
        private List<DataSourceToIndexFieldMapping> _workLogFieldMappings = new List<DataSourceToIndexFieldMapping>();

        /// <summary>
        /// Gets and sets the property AttachmentFieldMappings. 
        /// <para>
        /// A list of DataSourceToIndexFieldMapping objects that map attributes or field names
        /// of Jira attachments to Amazon Kendra index field names. To create custom fields, use
        /// the UpdateIndex API before you map to Jira fields. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">
        /// Mapping data source fields</a>. The Jira data source field names must exist in your
        /// Jira custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> AttachmentFieldMappings
        {
            get { return this._attachmentFieldMappings; }
            set { this._attachmentFieldMappings = value; }
        }

        // Check to see if AttachmentFieldMappings property is set
        internal bool IsSetAttachmentFieldMappings()
        {
            return this._attachmentFieldMappings != null && this._attachmentFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CommentFieldMappings. 
        /// <para>
        /// A list of DataSourceToIndexFieldMapping objects that map attributes or field names
        /// of Jira comments to Amazon Kendra index field names. To create custom fields, use
        /// the UpdateIndex API before you map to Jira fields. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">
        /// Mapping data source fields</a>. The Jira data source field names must exist in your
        /// Jira custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> CommentFieldMappings
        {
            get { return this._commentFieldMappings; }
            set { this._commentFieldMappings = value; }
        }

        // Check to see if CommentFieldMappings property is set
        internal bool IsSetCommentFieldMappings()
        {
            return this._commentFieldMappings != null && this._commentFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain file paths, file names, and
        /// file types in your Jira data source. Files that match the patterns are excluded from
        /// the index. Files that don’t match the patterns are included in the index. If a file
        /// matches both an inclusion pattern and an exclusion pattern, the exclusion pattern
        /// takes precedence and the file isn't included in the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ExclusionPatterns
        {
            get { return this._exclusionPatterns; }
            set { this._exclusionPatterns = value; }
        }

        // Check to see if ExclusionPatterns property is set
        internal bool IsSetExclusionPatterns()
        {
            return this._exclusionPatterns != null && this._exclusionPatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain file paths, file names, and
        /// file types in your Jira data source. Files that match the patterns are included in
        /// the index. Files that don't match the patterns are excluded from the index. If a file
        /// matches both an inclusion pattern and an exclusion pattern, the exclusion pattern
        /// takes precedence and the file isn't included in the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> InclusionPatterns
        {
            get { return this._inclusionPatterns; }
            set { this._inclusionPatterns = value; }
        }

        // Check to see if InclusionPatterns property is set
        internal bool IsSetInclusionPatterns()
        {
            return this._inclusionPatterns != null && this._inclusionPatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IssueFieldMappings. 
        /// <para>
        /// A list of DataSourceToIndexFieldMapping objects that map attributes or field names
        /// of Jira issues to Amazon Kendra index field names. To create custom fields, use the
        /// UpdateIndex API before you map to Jira fields. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">
        /// Mapping data source fields</a>. The Jira data source field names must exist in your
        /// Jira custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> IssueFieldMappings
        {
            get { return this._issueFieldMappings; }
            set { this._issueFieldMappings = value; }
        }

        // Check to see if IssueFieldMappings property is set
        internal bool IsSetIssueFieldMappings()
        {
            return this._issueFieldMappings != null && this._issueFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IssueSubEntityFilter. 
        /// <para>
        /// Specify whether to crawl comments, attachments, and work logs. You can specify one
        /// or more of these options.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> IssueSubEntityFilter
        {
            get { return this._issueSubEntityFilter; }
            set { this._issueSubEntityFilter = value; }
        }

        // Check to see if IssueSubEntityFilter property is set
        internal bool IsSetIssueSubEntityFilter()
        {
            return this._issueSubEntityFilter != null && this._issueSubEntityFilter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IssueType. 
        /// <para>
        /// Specify which issue types to crawl in your Jira data source. You can specify one or
        /// more of these options to crawl.
        /// </para>
        /// </summary>
        public List<string> IssueType
        {
            get { return this._issueType; }
            set { this._issueType = value; }
        }

        // Check to see if IssueType property is set
        internal bool IsSetIssueType()
        {
            return this._issueType != null && this._issueType.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JiraAccountUrl. 
        /// <para>
        /// The URL of the Jira account. For example, <i>company.atlassian.net</i> or <i>https://jira.company.com</i>.
        /// You can find your Jira account URL in the URL of your profile page for Jira desktop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string JiraAccountUrl
        {
            get { return this._jiraAccountUrl; }
            set { this._jiraAccountUrl = value; }
        }

        // Check to see if JiraAccountUrl property is set
        internal bool IsSetJiraAccountUrl()
        {
            return this._jiraAccountUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// Specify which projects to crawl in your Jira data source. You can specify one or more
        /// Jira project IDs.
        /// </para>
        /// </summary>
        public List<string> Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null && this._project.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProjectFieldMappings. 
        /// <para>
        /// A list of DataSourceToIndexFieldMapping objects that map attributes or field names
        /// of Jira projects to Amazon Kendra index field names. To create custom fields, use
        /// the UpdateIndex API before you map to Jira fields. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">
        /// Mapping data source fields</a>. The Jira data source field names must exist in your
        /// Jira custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> ProjectFieldMappings
        {
            get { return this._projectFieldMappings; }
            set { this._projectFieldMappings = value; }
        }

        // Check to see if ProjectFieldMappings property is set
        internal bool IsSetProjectFieldMappings()
        {
            return this._projectFieldMappings != null && this._projectFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a secret in Secrets Manager contains the key-value
        /// pairs required to connect to your Jira data source. The secret must contain a JSON
        /// structure with the following keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// jiraId—The Jira username.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// jiraCredentials—The Jira API token. For more information on creating an API token
        /// in Jira, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-jira.html">
        /// Using a Jira data source</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1284)]
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specify which statuses to crawl in your Jira data source. You can specify one or more
        /// of these options to crawl.
        /// </para>
        /// </summary>
        public List<string> Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null && this._status.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UseChangeLog. 
        /// <para>
        ///  <code>TRUE</code> to use the Jira change log to determine which documents require
        /// updating in the index. Depending on the change log's size, it may take longer for
        /// Amazon Kendra to use the change log than to scan all of your documents in Jira.
        /// </para>
        /// </summary>
        public bool UseChangeLog
        {
            get { return this._useChangeLog.GetValueOrDefault(); }
            set { this._useChangeLog = value; }
        }

        // Check to see if UseChangeLog property is set
        internal bool IsSetUseChangeLog()
        {
            return this._useChangeLog.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Configuration information for an Amazon Virtual Private Cloud to connect to your Jira.
        /// Your Jira account must reside inside your VPC.
        /// </para>
        /// </summary>
        public DataSourceVpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WorkLogFieldMappings. 
        /// <para>
        /// A list of DataSourceToIndexFieldMapping objects that map attributes or field names
        /// of Jira work logs to Amazon Kendra index field names. To create custom fields, use
        /// the UpdateIndex API before you map to Jira fields. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">
        /// Mapping data source fields</a>. The Jira data source field names must exist in your
        /// Jira custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> WorkLogFieldMappings
        {
            get { return this._workLogFieldMappings; }
            set { this._workLogFieldMappings = value; }
        }

        // Check to see if WorkLogFieldMappings property is set
        internal bool IsSetWorkLogFieldMappings()
        {
            return this._workLogFieldMappings != null && this._workLogFieldMappings.Count > 0; 
        }

    }
}