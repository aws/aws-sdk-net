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
    /// Provides the configuration information to connect to GitHub as your data source.
    /// </summary>
    public partial class GitHubConfiguration
    {
        private List<string> _exclusionFileNamePatterns = new List<string>();
        private List<string> _exclusionFileTypePatterns = new List<string>();
        private List<string> _exclusionFolderNamePatterns = new List<string>();
        private List<DataSourceToIndexFieldMapping> _gitHubCommitConfigurationFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private GitHubDocumentCrawlProperties _gitHubDocumentCrawlProperties;
        private List<DataSourceToIndexFieldMapping> _gitHubIssueAttachmentConfigurationFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<DataSourceToIndexFieldMapping> _gitHubIssueCommentConfigurationFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<DataSourceToIndexFieldMapping> _gitHubIssueDocumentConfigurationFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<DataSourceToIndexFieldMapping> _gitHubPullRequestCommentConfigurationFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<DataSourceToIndexFieldMapping> _gitHubPullRequestDocumentAttachmentConfigurationFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<DataSourceToIndexFieldMapping> _gitHubPullRequestDocumentConfigurationFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<DataSourceToIndexFieldMapping> _gitHubRepositoryConfigurationFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<string> _inclusionFileNamePatterns = new List<string>();
        private List<string> _inclusionFileTypePatterns = new List<string>();
        private List<string> _inclusionFolderNamePatterns = new List<string>();
        private OnPremiseConfiguration _onPremiseConfiguration;
        private List<string> _repositoryFilter = new List<string>();
        private SaaSConfiguration _saaSConfiguration;
        private string _secretArn;
        private Type _type;
        private bool? _useChangeLog;
        private DataSourceVpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property ExclusionFileNamePatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain file names in your GitHub
        /// repository or repositories. File names that match the patterns are excluded from the
        /// index. File names that don't match the patterns are included in the index. If a file
        /// matches both an exclusion and inclusion pattern, the exclusion pattern takes precedence
        /// and the file isn't included in the index.
        /// </para>
        /// </summary>
        public List<string> ExclusionFileNamePatterns
        {
            get { return this._exclusionFileNamePatterns; }
            set { this._exclusionFileNamePatterns = value; }
        }

        // Check to see if ExclusionFileNamePatterns property is set
        internal bool IsSetExclusionFileNamePatterns()
        {
            return this._exclusionFileNamePatterns != null && this._exclusionFileNamePatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExclusionFileTypePatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain file types in your GitHub
        /// repository or repositories. File types that match the patterns are excluded from the
        /// index. File types that don't match the patterns are included in the index. If a file
        /// matches both an exclusion and inclusion pattern, the exclusion pattern takes precedence
        /// and the file isn't included in the index.
        /// </para>
        /// </summary>
        public List<string> ExclusionFileTypePatterns
        {
            get { return this._exclusionFileTypePatterns; }
            set { this._exclusionFileTypePatterns = value; }
        }

        // Check to see if ExclusionFileTypePatterns property is set
        internal bool IsSetExclusionFileTypePatterns()
        {
            return this._exclusionFileTypePatterns != null && this._exclusionFileTypePatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExclusionFolderNamePatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain folder names in your GitHub
        /// repository or repositories. Folder names that match the patterns are excluded from
        /// the index. Folder names that don't match the patterns are included in the index. If
        /// a folder matches both an exclusion and inclusion pattern, the exclusion pattern takes
        /// precedence and the folder isn't included in the index.
        /// </para>
        /// </summary>
        public List<string> ExclusionFolderNamePatterns
        {
            get { return this._exclusionFolderNamePatterns; }
            set { this._exclusionFolderNamePatterns = value; }
        }

        // Check to see if ExclusionFolderNamePatterns property is set
        internal bool IsSetExclusionFolderNamePatterns()
        {
            return this._exclusionFolderNamePatterns != null && this._exclusionFolderNamePatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GitHubCommitConfigurationFieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map attributes or
        /// field names of GitHub commits to Amazon Kendra index field names. To create custom
        /// fields, use the <code>UpdateIndex</code> API before you map to GitHub fields. For
        /// more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> GitHubCommitConfigurationFieldMappings
        {
            get { return this._gitHubCommitConfigurationFieldMappings; }
            set { this._gitHubCommitConfigurationFieldMappings = value; }
        }

        // Check to see if GitHubCommitConfigurationFieldMappings property is set
        internal bool IsSetGitHubCommitConfigurationFieldMappings()
        {
            return this._gitHubCommitConfigurationFieldMappings != null && this._gitHubCommitConfigurationFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GitHubDocumentCrawlProperties. 
        /// <para>
        /// Configuration information to include certain types of GitHub content. You can configure
        /// to index repository files only, or also include issues and pull requests, comments,
        /// and comment attachments.
        /// </para>
        /// </summary>
        public GitHubDocumentCrawlProperties GitHubDocumentCrawlProperties
        {
            get { return this._gitHubDocumentCrawlProperties; }
            set { this._gitHubDocumentCrawlProperties = value; }
        }

        // Check to see if GitHubDocumentCrawlProperties property is set
        internal bool IsSetGitHubDocumentCrawlProperties()
        {
            return this._gitHubDocumentCrawlProperties != null;
        }

        /// <summary>
        /// Gets and sets the property GitHubIssueAttachmentConfigurationFieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map attributes or
        /// field names of GitHub issue attachments to Amazon Kendra index field names. To create
        /// custom fields, use the <code>UpdateIndex</code> API before you map to GitHub fields.
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> GitHubIssueAttachmentConfigurationFieldMappings
        {
            get { return this._gitHubIssueAttachmentConfigurationFieldMappings; }
            set { this._gitHubIssueAttachmentConfigurationFieldMappings = value; }
        }

        // Check to see if GitHubIssueAttachmentConfigurationFieldMappings property is set
        internal bool IsSetGitHubIssueAttachmentConfigurationFieldMappings()
        {
            return this._gitHubIssueAttachmentConfigurationFieldMappings != null && this._gitHubIssueAttachmentConfigurationFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GitHubIssueCommentConfigurationFieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map attributes or
        /// field names of GitHub issue comments to Amazon Kendra index field names. To create
        /// custom fields, use the <code>UpdateIndex</code> API before you map to GitHub fields.
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> GitHubIssueCommentConfigurationFieldMappings
        {
            get { return this._gitHubIssueCommentConfigurationFieldMappings; }
            set { this._gitHubIssueCommentConfigurationFieldMappings = value; }
        }

        // Check to see if GitHubIssueCommentConfigurationFieldMappings property is set
        internal bool IsSetGitHubIssueCommentConfigurationFieldMappings()
        {
            return this._gitHubIssueCommentConfigurationFieldMappings != null && this._gitHubIssueCommentConfigurationFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GitHubIssueDocumentConfigurationFieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map attributes or
        /// field names of GitHub issues to Amazon Kendra index field names. To create custom
        /// fields, use the <code>UpdateIndex</code> API before you map to GitHub fields. For
        /// more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> GitHubIssueDocumentConfigurationFieldMappings
        {
            get { return this._gitHubIssueDocumentConfigurationFieldMappings; }
            set { this._gitHubIssueDocumentConfigurationFieldMappings = value; }
        }

        // Check to see if GitHubIssueDocumentConfigurationFieldMappings property is set
        internal bool IsSetGitHubIssueDocumentConfigurationFieldMappings()
        {
            return this._gitHubIssueDocumentConfigurationFieldMappings != null && this._gitHubIssueDocumentConfigurationFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GitHubPullRequestCommentConfigurationFieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map attributes or
        /// field names of GitHub pull request comments to Amazon Kendra index field names. To
        /// create custom fields, use the <code>UpdateIndex</code> API before you map to GitHub
        /// fields. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> GitHubPullRequestCommentConfigurationFieldMappings
        {
            get { return this._gitHubPullRequestCommentConfigurationFieldMappings; }
            set { this._gitHubPullRequestCommentConfigurationFieldMappings = value; }
        }

        // Check to see if GitHubPullRequestCommentConfigurationFieldMappings property is set
        internal bool IsSetGitHubPullRequestCommentConfigurationFieldMappings()
        {
            return this._gitHubPullRequestCommentConfigurationFieldMappings != null && this._gitHubPullRequestCommentConfigurationFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GitHubPullRequestDocumentAttachmentConfigurationFieldMappings.
        /// 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map attributes or
        /// field names of GitHub pull request attachments to Amazon Kendra index field names.
        /// To create custom fields, use the <code>UpdateIndex</code> API before you map to GitHub
        /// fields. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> GitHubPullRequestDocumentAttachmentConfigurationFieldMappings
        {
            get { return this._gitHubPullRequestDocumentAttachmentConfigurationFieldMappings; }
            set { this._gitHubPullRequestDocumentAttachmentConfigurationFieldMappings = value; }
        }

        // Check to see if GitHubPullRequestDocumentAttachmentConfigurationFieldMappings property is set
        internal bool IsSetGitHubPullRequestDocumentAttachmentConfigurationFieldMappings()
        {
            return this._gitHubPullRequestDocumentAttachmentConfigurationFieldMappings != null && this._gitHubPullRequestDocumentAttachmentConfigurationFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GitHubPullRequestDocumentConfigurationFieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map attributes or
        /// field names of GitHub pull requests to Amazon Kendra index field names. To create
        /// custom fields, use the <code>UpdateIndex</code> API before you map to GitHub fields.
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> GitHubPullRequestDocumentConfigurationFieldMappings
        {
            get { return this._gitHubPullRequestDocumentConfigurationFieldMappings; }
            set { this._gitHubPullRequestDocumentConfigurationFieldMappings = value; }
        }

        // Check to see if GitHubPullRequestDocumentConfigurationFieldMappings property is set
        internal bool IsSetGitHubPullRequestDocumentConfigurationFieldMappings()
        {
            return this._gitHubPullRequestDocumentConfigurationFieldMappings != null && this._gitHubPullRequestDocumentConfigurationFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GitHubRepositoryConfigurationFieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map GitHub repository
        /// attributes or field names to Amazon Kendra index field names. To create custom fields,
        /// use the <code>UpdateIndex</code> API before you map to GitHub fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The GitHub data source field names must exist in your GitHub
        /// custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> GitHubRepositoryConfigurationFieldMappings
        {
            get { return this._gitHubRepositoryConfigurationFieldMappings; }
            set { this._gitHubRepositoryConfigurationFieldMappings = value; }
        }

        // Check to see if GitHubRepositoryConfigurationFieldMappings property is set
        internal bool IsSetGitHubRepositoryConfigurationFieldMappings()
        {
            return this._gitHubRepositoryConfigurationFieldMappings != null && this._gitHubRepositoryConfigurationFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InclusionFileNamePatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain file names in your GitHub
        /// repository or repositories. File names that match the patterns are included in the
        /// index. File names that don't match the patterns are excluded from the index. If a
        /// file matches both an inclusion and exclusion pattern, the exclusion pattern takes
        /// precedence and the file isn't included in the index.
        /// </para>
        /// </summary>
        public List<string> InclusionFileNamePatterns
        {
            get { return this._inclusionFileNamePatterns; }
            set { this._inclusionFileNamePatterns = value; }
        }

        // Check to see if InclusionFileNamePatterns property is set
        internal bool IsSetInclusionFileNamePatterns()
        {
            return this._inclusionFileNamePatterns != null && this._inclusionFileNamePatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InclusionFileTypePatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain file types in your GitHub
        /// repository or repositories. File types that match the patterns are included in the
        /// index. File types that don't match the patterns are excluded from the index. If a
        /// file matches both an inclusion and exclusion pattern, the exclusion pattern takes
        /// precedence and the file isn't included in the index.
        /// </para>
        /// </summary>
        public List<string> InclusionFileTypePatterns
        {
            get { return this._inclusionFileTypePatterns; }
            set { this._inclusionFileTypePatterns = value; }
        }

        // Check to see if InclusionFileTypePatterns property is set
        internal bool IsSetInclusionFileTypePatterns()
        {
            return this._inclusionFileTypePatterns != null && this._inclusionFileTypePatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InclusionFolderNamePatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain folder names in your GitHub
        /// repository or repositories. Folder names that match the patterns are included in the
        /// index. Folder names that don't match the patterns are excluded from the index. If
        /// a folder matches both an inclusion and exclusion pattern, the exclusion pattern takes
        /// precedence and the folder isn't included in the index.
        /// </para>
        /// </summary>
        public List<string> InclusionFolderNamePatterns
        {
            get { return this._inclusionFolderNamePatterns; }
            set { this._inclusionFolderNamePatterns = value; }
        }

        // Check to see if InclusionFolderNamePatterns property is set
        internal bool IsSetInclusionFolderNamePatterns()
        {
            return this._inclusionFolderNamePatterns != null && this._inclusionFolderNamePatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OnPremiseConfiguration. 
        /// <para>
        /// Configuration information to connect to GitHub Enterprise Server (on premises).
        /// </para>
        /// </summary>
        public OnPremiseConfiguration OnPremiseConfiguration
        {
            get { return this._onPremiseConfiguration; }
            set { this._onPremiseConfiguration = value; }
        }

        // Check to see if OnPremiseConfiguration property is set
        internal bool IsSetOnPremiseConfiguration()
        {
            return this._onPremiseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryFilter. 
        /// <para>
        /// A list of names of the specific repositories you want to index.
        /// </para>
        /// </summary>
        public List<string> RepositoryFilter
        {
            get { return this._repositoryFilter; }
            set { this._repositoryFilter = value; }
        }

        // Check to see if RepositoryFilter property is set
        internal bool IsSetRepositoryFilter()
        {
            return this._repositoryFilter != null && this._repositoryFilter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SaaSConfiguration. 
        /// <para>
        /// Configuration information to connect to GitHub Enterprise Cloud (SaaS).
        /// </para>
        /// </summary>
        public SaaSConfiguration SaaSConfiguration
        {
            get { return this._saaSConfiguration; }
            set { this._saaSConfiguration = value; }
        }

        // Check to see if SaaSConfiguration property is set
        internal bool IsSetSaaSConfiguration()
        {
            return this._saaSConfiguration != null;
        }

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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of GitHub service you want to connect to—GitHub Enterprise Cloud (SaaS) or
        /// GitHub Enterprise Server (on premises).
        /// </para>
        /// </summary>
        public Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UseChangeLog. 
        /// <para>
        ///  <code>TRUE</code> to use the GitHub change log to determine which documents require
        /// updating in the index. Depending on the GitHub change log's size, it may take longer
        /// for Amazon Kendra to use the change log than to scan all of your documents in GitHub.
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
        /// Configuration information of an Amazon Virtual Private Cloud to connect to your GitHub.
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/vpc-configuration.html">Configuring
        /// a VPC</a>.
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

    }
}