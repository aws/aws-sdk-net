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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information to connect to Jira as your data source.
    /// </summary>
    public partial class JiraConfiguration
    {
        /// <summary>
        /// Gets and sets the property AttachmentFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of Jira attachments to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to Jira fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html"> Mapping
        /// data source fields</a>. The Jira data source field names must exist in your Jira custom
        /// metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> AttachmentFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the AttachmentFieldMappings property is set.
        /// </summary>
        internal bool IsSetAttachmentFieldMappings() => this.AttachmentFieldMappings != null && (this.AttachmentFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CommentFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of Jira comments to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to Jira fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html"> Mapping
        /// data source fields</a>. The Jira data source field names must exist in your Jira custom
        /// metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> CommentFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the CommentFieldMappings property is set.
        /// </summary>
        internal bool IsSetCommentFieldMappings() => this.CommentFieldMappings != null && (this.CommentFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain file paths, file names, and
        /// file types in your Jira data source. Files that match the patterns are excluded from
        /// the index. Files that don’t match the patterns are included in the index. If a file
        /// matches both an inclusion pattern and an exclusion pattern, the exclusion pattern
        /// takes precedence and the file isn't included in the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public List<string> ExclusionPatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExclusionPatterns property is set.
        /// </summary>
        internal bool IsSetExclusionPatterns() => this.ExclusionPatterns != null && (this.ExclusionPatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain file paths, file names, and
        /// file types in your Jira data source. Files that match the patterns are included in
        /// the index. Files that don't match the patterns are excluded from the index. If a file
        /// matches both an inclusion pattern and an exclusion pattern, the exclusion pattern
        /// takes precedence and the file isn't included in the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public List<string> InclusionPatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InclusionPatterns property is set.
        /// </summary>
        internal bool IsSetInclusionPatterns() => this.InclusionPatterns != null && (this.InclusionPatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IssueFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of Jira issues to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to Jira fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html"> Mapping
        /// data source fields</a>. The Jira data source field names must exist in your Jira custom
        /// metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> IssueFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the IssueFieldMappings property is set.
        /// </summary>
        internal bool IsSetIssueFieldMappings() => this.IssueFieldMappings != null && (this.IssueFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IssueSubEntityFilter. 
        /// <para>
        /// Specify whether to crawl comments, attachments, and work logs. You can specify one
        /// or more of these options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> IssueSubEntityFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IssueSubEntityFilter property is set.
        /// </summary>
        internal bool IsSetIssueSubEntityFilter() => this.IssueSubEntityFilter != null && (this.IssueSubEntityFilter.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IssueType. 
        /// <para>
        /// Specify which issue types to crawl in your Jira data source. You can specify one or
        /// more of these options to crawl.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IssueType { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IssueType property is set.
        /// </summary>
        internal bool IsSetIssueType() => this.IssueType != null && (this.IssueType.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JiraAccountUrl. 
        /// <para>
        /// The URL of the Jira account. For example, <i>company.atlassian.net</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string JiraAccountUrl { get; set; }

        /// <summary>
        /// Checks to see if the JiraAccountUrl property is set.
        /// </summary>
        internal bool IsSetJiraAccountUrl() => this.JiraAccountUrl != null;

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// Specify which projects to crawl in your Jira data source. You can specify one or more
        /// Jira project IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Project { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Project property is set.
        /// </summary>
        internal bool IsSetProject() => this.Project != null && (this.Project.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProjectFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of Jira projects to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to Jira fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html"> Mapping
        /// data source fields</a>. The Jira data source field names must exist in your Jira custom
        /// metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> ProjectFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the ProjectFieldMappings property is set.
        /// </summary>
        internal bool IsSetProjectFieldMappings() => this.ProjectFieldMappings != null && (this.ProjectFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a secret in Secrets Manager contains the key-value
        /// pairs required to connect to your Jira data source. The secret must contain a JSON
        /// structure with the following keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// jiraId—The Jira user name or email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// jiraCredentials—The Jira API token. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-jira.html">Using
        /// a Jira data source</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1284)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specify which statuses to crawl in your Jira data source. You can specify one or more
        /// of these options to crawl.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Status { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null && (this.Status.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UseChangeLog. 
        /// <para>
        ///  <c>TRUE</c> to use the Jira change log to determine which documents require updating
        /// in the index. Depending on the change log's size, it may take longer for Amazon Kendra
        /// to use the change log than to scan all of your documents in Jira.
        /// </para>
        /// </summary>
        public bool? UseChangeLog { get; set; }

        /// <summary>
        /// Checks to see if the UseChangeLog property is set.
        /// </summary>
        internal bool IsSetUseChangeLog() => this.UseChangeLog.HasValue;

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Configuration information for an Amazon Virtual Private Cloud to connect to your Jira.
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/vpc-configuration.html">Configuring
        /// a VPC</a>.
        /// </para>
        /// </summary>
        public DataSourceVpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;

        /// <summary>
        /// Gets and sets the property WorkLogFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of Jira work logs to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to Jira fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html"> Mapping
        /// data source fields</a>. The Jira data source field names must exist in your Jira custom
        /// metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> WorkLogFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the WorkLogFieldMappings property is set.
        /// </summary>
        internal bool IsSetWorkLogFieldMappings() => this.WorkLogFieldMappings != null && (this.WorkLogFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
