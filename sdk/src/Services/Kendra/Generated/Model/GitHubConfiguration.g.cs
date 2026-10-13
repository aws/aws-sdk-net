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
    /// Provides the configuration information to connect to GitHub as your data source.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Kendra now supports an upgraded GitHub connector.
    /// </para>
    ///  
    /// <para>
    /// You must now use the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_TemplateConfiguration.html">TemplateConfiguration</a>
    /// object instead of the <c>GitHubConfiguration</c> object to configure your connector.
    /// </para>
    ///  
    /// <para>
    /// Connectors configured using the older console and API architecture will continue to
    /// function as configured. However, you won’t be able to edit or update them. If you
    /// want to edit or update your connector configuration, you must create a new connector.
    /// </para>
    ///  
    /// <para>
    /// We recommended migrating your connector workflow to the upgraded version. Support
    /// for connectors configured using the older architecture is scheduled to end by June
    /// 2024.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GitHubConfiguration
    {
        /// <summary>
        /// Gets and sets the property ExclusionFileNamePatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain file names in your GitHub
        /// repository or repositories. File names that match the patterns are excluded from the
        /// index. File names that don't match the patterns are included in the index. If a file
        /// matches both an exclusion and inclusion pattern, the exclusion pattern takes precedence
        /// and the file isn't included in the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExclusionFileNamePatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExclusionFileNamePatterns property is set.
        /// </summary>
        internal bool IsSetExclusionFileNamePatterns() => this.ExclusionFileNamePatterns != null && (this.ExclusionFileNamePatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExclusionFileTypePatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain file types in your GitHub
        /// repository or repositories. File types that match the patterns are excluded from the
        /// index. File types that don't match the patterns are included in the index. If a file
        /// matches both an exclusion and inclusion pattern, the exclusion pattern takes precedence
        /// and the file isn't included in the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExclusionFileTypePatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExclusionFileTypePatterns property is set.
        /// </summary>
        internal bool IsSetExclusionFileTypePatterns() => this.ExclusionFileTypePatterns != null && (this.ExclusionFileTypePatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExclusionFolderNamePatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain folder names in your GitHub
        /// repository or repositories. Folder names that match the patterns are excluded from
        /// the index. Folder names that don't match the patterns are included in the index. If
        /// a folder matches both an exclusion and inclusion pattern, the exclusion pattern takes
        /// precedence and the folder isn't included in the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExclusionFolderNamePatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExclusionFolderNamePatterns property is set.
        /// </summary>
        internal bool IsSetExclusionFolderNamePatterns() => this.ExclusionFolderNamePatterns != null && (this.ExclusionFolderNamePatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GitHubCommitConfigurationFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of GitHub commits to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to GitHub fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> GitHubCommitConfigurationFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the GitHubCommitConfigurationFieldMappings property is set.
        /// </summary>
        internal bool IsSetGitHubCommitConfigurationFieldMappings() => this.GitHubCommitConfigurationFieldMappings != null && (this.GitHubCommitConfigurationFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GitHubDocumentCrawlProperties. 
        /// <para>
        /// Configuration information to include certain types of GitHub content. You can configure
        /// to index repository files only, or also include issues and pull requests, comments,
        /// and comment attachments.
        /// </para>
        /// </summary>
        public GitHubDocumentCrawlProperties GitHubDocumentCrawlProperties { get; set; }

        /// <summary>
        /// Checks to see if the GitHubDocumentCrawlProperties property is set.
        /// </summary>
        internal bool IsSetGitHubDocumentCrawlProperties() => this.GitHubDocumentCrawlProperties != null;

        /// <summary>
        /// Gets and sets the property GitHubIssueAttachmentConfigurationFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of GitHub issue attachments to Amazon Kendra index field names. To create custom
        /// fields, use the <c>UpdateIndex</c> API before you map to GitHub fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> GitHubIssueAttachmentConfigurationFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the GitHubIssueAttachmentConfigurationFieldMappings property is set.
        /// </summary>
        internal bool IsSetGitHubIssueAttachmentConfigurationFieldMappings() => this.GitHubIssueAttachmentConfigurationFieldMappings != null && (this.GitHubIssueAttachmentConfigurationFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GitHubIssueCommentConfigurationFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of GitHub issue comments to Amazon Kendra index field names. To create custom
        /// fields, use the <c>UpdateIndex</c> API before you map to GitHub fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> GitHubIssueCommentConfigurationFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the GitHubIssueCommentConfigurationFieldMappings property is set.
        /// </summary>
        internal bool IsSetGitHubIssueCommentConfigurationFieldMappings() => this.GitHubIssueCommentConfigurationFieldMappings != null && (this.GitHubIssueCommentConfigurationFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GitHubIssueDocumentConfigurationFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of GitHub issues to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to GitHub fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> GitHubIssueDocumentConfigurationFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the GitHubIssueDocumentConfigurationFieldMappings property is set.
        /// </summary>
        internal bool IsSetGitHubIssueDocumentConfigurationFieldMappings() => this.GitHubIssueDocumentConfigurationFieldMappings != null && (this.GitHubIssueDocumentConfigurationFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GitHubPullRequestCommentConfigurationFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of GitHub pull request comments to Amazon Kendra index field names. To create
        /// custom fields, use the <c>UpdateIndex</c> API before you map to GitHub fields. For
        /// more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> GitHubPullRequestCommentConfigurationFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the GitHubPullRequestCommentConfigurationFieldMappings property is set.
        /// </summary>
        internal bool IsSetGitHubPullRequestCommentConfigurationFieldMappings() => this.GitHubPullRequestCommentConfigurationFieldMappings != null && (this.GitHubPullRequestCommentConfigurationFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GitHubPullRequestDocumentAttachmentConfigurationFieldMappings.
        /// 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of GitHub pull request attachments to Amazon Kendra index field names. To create
        /// custom fields, use the <c>UpdateIndex</c> API before you map to GitHub fields. For
        /// more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> GitHubPullRequestDocumentAttachmentConfigurationFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the GitHubPullRequestDocumentAttachmentConfigurationFieldMappings property is set.
        /// </summary>
        internal bool IsSetGitHubPullRequestDocumentAttachmentConfigurationFieldMappings() => this.GitHubPullRequestDocumentAttachmentConfigurationFieldMappings != null && (this.GitHubPullRequestDocumentAttachmentConfigurationFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GitHubPullRequestDocumentConfigurationFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of GitHub pull requests to Amazon Kendra index field names. To create custom
        /// fields, use the <c>UpdateIndex</c> API before you map to GitHub fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> GitHubPullRequestDocumentConfigurationFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the GitHubPullRequestDocumentConfigurationFieldMappings property is set.
        /// </summary>
        internal bool IsSetGitHubPullRequestDocumentConfigurationFieldMappings() => this.GitHubPullRequestDocumentConfigurationFieldMappings != null && (this.GitHubPullRequestDocumentConfigurationFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GitHubRepositoryConfigurationFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map GitHub repository
        /// attributes or field names to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to GitHub fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> GitHubRepositoryConfigurationFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the GitHubRepositoryConfigurationFieldMappings property is set.
        /// </summary>
        internal bool IsSetGitHubRepositoryConfigurationFieldMappings() => this.GitHubRepositoryConfigurationFieldMappings != null && (this.GitHubRepositoryConfigurationFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InclusionFileNamePatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain file names in your GitHub
        /// repository or repositories. File names that match the patterns are included in the
        /// index. File names that don't match the patterns are excluded from the index. If a
        /// file matches both an inclusion and exclusion pattern, the exclusion pattern takes
        /// precedence and the file isn't included in the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InclusionFileNamePatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InclusionFileNamePatterns property is set.
        /// </summary>
        internal bool IsSetInclusionFileNamePatterns() => this.InclusionFileNamePatterns != null && (this.InclusionFileNamePatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InclusionFileTypePatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain file types in your GitHub
        /// repository or repositories. File types that match the patterns are included in the
        /// index. File types that don't match the patterns are excluded from the index. If a
        /// file matches both an inclusion and exclusion pattern, the exclusion pattern takes
        /// precedence and the file isn't included in the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InclusionFileTypePatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InclusionFileTypePatterns property is set.
        /// </summary>
        internal bool IsSetInclusionFileTypePatterns() => this.InclusionFileTypePatterns != null && (this.InclusionFileTypePatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InclusionFolderNamePatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain folder names in your GitHub
        /// repository or repositories. Folder names that match the patterns are included in the
        /// index. Folder names that don't match the patterns are excluded from the index. If
        /// a folder matches both an inclusion and exclusion pattern, the exclusion pattern takes
        /// precedence and the folder isn't included in the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InclusionFolderNamePatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InclusionFolderNamePatterns property is set.
        /// </summary>
        internal bool IsSetInclusionFolderNamePatterns() => this.InclusionFolderNamePatterns != null && (this.InclusionFolderNamePatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OnPremiseConfiguration. 
        /// <para>
        /// Configuration information to connect to GitHub Enterprise Server (on premises).
        /// </para>
        /// </summary>
        public OnPremiseConfiguration OnPremiseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OnPremiseConfiguration property is set.
        /// </summary>
        internal bool IsSetOnPremiseConfiguration() => this.OnPremiseConfiguration != null;

        /// <summary>
        /// Gets and sets the property RepositoryFilter. 
        /// <para>
        /// A list of names of the specific repositories you want to index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RepositoryFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RepositoryFilter property is set.
        /// </summary>
        internal bool IsSetRepositoryFilter() => this.RepositoryFilter != null && (this.RepositoryFilter.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SaaSConfiguration. 
        /// <para>
        /// Configuration information to connect to GitHub Enterprise Cloud (SaaS).
        /// </para>
        /// </summary>
        public SaaSConfiguration SaaSConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SaaSConfiguration property is set.
        /// </summary>
        internal bool IsSetSaaSConfiguration() => this.SaaSConfiguration != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Secrets Manager secret that contains the key-value
        /// pairs required to connect to your GitHub. The secret must contain a JSON structure
        /// with the following keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// personalToken—The access token created in GitHub. For more information on creating
        /// a token in GitHub, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-github.html">Using
        /// a GitHub data source</a>.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of GitHub service you want to connect to—GitHub Enterprise Cloud (SaaS) or
        /// GitHub Enterprise Server (on premises).
        /// </para>
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UseChangeLog. 
        /// <para>
        ///  <c>TRUE</c> to use the GitHub change log to determine which documents require updating
        /// in the index. Depending on the GitHub change log's size, it may take longer for Amazon
        /// Kendra to use the change log than to scan all of your documents in GitHub.
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
        /// Configuration information of an Amazon Virtual Private Cloud to connect to your GitHub.
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/vpc-configuration.html">Configuring
        /// a VPC</a>.
        /// </para>
        /// </summary>
        public DataSourceVpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;
    }
}
