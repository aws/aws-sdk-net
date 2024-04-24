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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information for an Amazon Kendra data source.
    /// </summary>
    public partial class DataSourceConfiguration
    {
        private AlfrescoConfiguration _alfrescoConfiguration;
        private BoxConfiguration _boxConfiguration;
        private ConfluenceConfiguration _confluenceConfiguration;
        private DatabaseConfiguration _databaseConfiguration;
        private FsxConfiguration _fsxConfiguration;
        private GitHubConfiguration _gitHubConfiguration;
        private GoogleDriveConfiguration _googleDriveConfiguration;
        private JiraConfiguration _jiraConfiguration;
        private OneDriveConfiguration _oneDriveConfiguration;
        private QuipConfiguration _quipConfiguration;
        private S3DataSourceConfiguration _s3Configuration;
        private SalesforceConfiguration _salesforceConfiguration;
        private ServiceNowConfiguration _serviceNowConfiguration;
        private SharePointConfiguration _sharePointConfiguration;
        private SlackConfiguration _slackConfiguration;
        private TemplateConfiguration _templateConfiguration;
        private WebCrawlerConfiguration _webCrawlerConfiguration;
        private WorkDocsConfiguration _workDocsConfiguration;

        /// <summary>
        /// Gets and sets the property AlfrescoConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Alfresco as your data source.
        /// </para>
        ///  <note> 
        /// <para>
        /// Support for <c>AlfrescoConfiguration</c> ended May 2023. We recommend migrating to
        /// or using the Alfresco data source template schema / <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_TemplateConfiguration.html">TemplateConfiguration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("Deprecated AlfrescoConfiguration in favor of TemplateConfiguration")]
        public AlfrescoConfiguration AlfrescoConfiguration
        {
            get { return this._alfrescoConfiguration; }
            set { this._alfrescoConfiguration = value; }
        }

        // Check to see if AlfrescoConfiguration property is set
        internal bool IsSetAlfrescoConfiguration()
        {
            return this._alfrescoConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property BoxConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Box as your data source.
        /// </para>
        /// </summary>
        public BoxConfiguration BoxConfiguration
        {
            get { return this._boxConfiguration; }
            set { this._boxConfiguration = value; }
        }

        // Check to see if BoxConfiguration property is set
        internal bool IsSetBoxConfiguration()
        {
            return this._boxConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ConfluenceConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Confluence as your data source.
        /// </para>
        /// </summary>
        public ConfluenceConfiguration ConfluenceConfiguration
        {
            get { return this._confluenceConfiguration; }
            set { this._confluenceConfiguration = value; }
        }

        // Check to see if ConfluenceConfiguration property is set
        internal bool IsSetConfluenceConfiguration()
        {
            return this._confluenceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to a database as your data source.
        /// </para>
        /// </summary>
        public DatabaseConfiguration DatabaseConfiguration
        {
            get { return this._databaseConfiguration; }
            set { this._databaseConfiguration = value; }
        }

        // Check to see if DatabaseConfiguration property is set
        internal bool IsSetDatabaseConfiguration()
        {
            return this._databaseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FsxConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Amazon FSx as your data source.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Kendra now supports an upgraded Amazon FSx Windows connector.
        /// </para>
        ///  
        /// <para>
        /// You must now use the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_TemplateConfiguration.html">TemplateConfiguration</a>
        /// object instead of the <c>FsxConfiguration</c> object to configure your connector.
        /// </para>
        ///  
        /// <para>
        /// Connectors configured using the older console and API architecture will continue to
        /// function as configured. However, you won't be able to edit or update them. If you
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
        public FsxConfiguration FsxConfiguration
        {
            get { return this._fsxConfiguration; }
            set { this._fsxConfiguration = value; }
        }

        // Check to see if FsxConfiguration property is set
        internal bool IsSetFsxConfiguration()
        {
            return this._fsxConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property GitHubConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to GitHub as your data source.
        /// </para>
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
        public GitHubConfiguration GitHubConfiguration
        {
            get { return this._gitHubConfiguration; }
            set { this._gitHubConfiguration = value; }
        }

        // Check to see if GitHubConfiguration property is set
        internal bool IsSetGitHubConfiguration()
        {
            return this._gitHubConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property GoogleDriveConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Google Drive as your data source.
        /// </para>
        /// </summary>
        public GoogleDriveConfiguration GoogleDriveConfiguration
        {
            get { return this._googleDriveConfiguration; }
            set { this._googleDriveConfiguration = value; }
        }

        // Check to see if GoogleDriveConfiguration property is set
        internal bool IsSetGoogleDriveConfiguration()
        {
            return this._googleDriveConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property JiraConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Jira as your data source.
        /// </para>
        /// </summary>
        public JiraConfiguration JiraConfiguration
        {
            get { return this._jiraConfiguration; }
            set { this._jiraConfiguration = value; }
        }

        // Check to see if JiraConfiguration property is set
        internal bool IsSetJiraConfiguration()
        {
            return this._jiraConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OneDriveConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Microsoft OneDrive as your data
        /// source.
        /// </para>
        /// </summary>
        public OneDriveConfiguration OneDriveConfiguration
        {
            get { return this._oneDriveConfiguration; }
            set { this._oneDriveConfiguration = value; }
        }

        // Check to see if OneDriveConfiguration property is set
        internal bool IsSetOneDriveConfiguration()
        {
            return this._oneDriveConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property QuipConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Quip as your data source.
        /// </para>
        /// </summary>
        public QuipConfiguration QuipConfiguration
        {
            get { return this._quipConfiguration; }
            set { this._quipConfiguration = value; }
        }

        // Check to see if QuipConfiguration property is set
        internal bool IsSetQuipConfiguration()
        {
            return this._quipConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3Configuration. 
        /// <para>
        /// Provides the configuration information to connect to an Amazon S3 bucket as your data
        /// source.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Kendra now supports an upgraded Amazon S3 connector.
        /// </para>
        ///  
        /// <para>
        /// You must now use the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_TemplateConfiguration.html">TemplateConfiguration</a>
        /// object instead of the <c>S3DataSourceConfiguration</c> object to configure your connector.
        /// </para>
        ///  
        /// <para>
        /// Connectors configured using the older console and API architecture will continue to
        /// function as configured. However, you won't be able to edit or update them. If you
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
        public S3DataSourceConfiguration S3Configuration
        {
            get { return this._s3Configuration; }
            set { this._s3Configuration = value; }
        }

        // Check to see if S3Configuration property is set
        internal bool IsSetS3Configuration()
        {
            return this._s3Configuration != null;
        }

        /// <summary>
        /// Gets and sets the property SalesforceConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Salesforce as your data source.
        /// </para>
        /// </summary>
        public SalesforceConfiguration SalesforceConfiguration
        {
            get { return this._salesforceConfiguration; }
            set { this._salesforceConfiguration = value; }
        }

        // Check to see if SalesforceConfiguration property is set
        internal bool IsSetSalesforceConfiguration()
        {
            return this._salesforceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNowConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to ServiceNow as your data source.
        /// </para>
        /// </summary>
        public ServiceNowConfiguration ServiceNowConfiguration
        {
            get { return this._serviceNowConfiguration; }
            set { this._serviceNowConfiguration = value; }
        }

        // Check to see if ServiceNowConfiguration property is set
        internal bool IsSetServiceNowConfiguration()
        {
            return this._serviceNowConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SharePointConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Microsoft SharePoint as your
        /// data source.
        /// </para>
        /// </summary>
        public SharePointConfiguration SharePointConfiguration
        {
            get { return this._sharePointConfiguration; }
            set { this._sharePointConfiguration = value; }
        }

        // Check to see if SharePointConfiguration property is set
        internal bool IsSetSharePointConfiguration()
        {
            return this._sharePointConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SlackConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Slack as your data source.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Kendra now supports an upgraded Slack connector.
        /// </para>
        ///  
        /// <para>
        /// You must now use the <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_TemplateConfiguration.html">TemplateConfiguration</a>
        /// object instead of the <c>SlackConfiguration</c> object to configure your connector.
        /// </para>
        ///  
        /// <para>
        /// Connectors configured using the older console and API architecture will continue to
        /// function as configured. However, you won't be able to edit or update them. If you
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
        public SlackConfiguration SlackConfiguration
        {
            get { return this._slackConfiguration; }
            set { this._slackConfiguration = value; }
        }

        // Check to see if SlackConfiguration property is set
        internal bool IsSetSlackConfiguration()
        {
            return this._slackConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// Provides a template for the configuration information to connect to your data source.
        /// </para>
        /// </summary>
        public TemplateConfiguration TemplateConfiguration
        {
            get { return this._templateConfiguration; }
            set { this._templateConfiguration = value; }
        }

        // Check to see if TemplateConfiguration property is set
        internal bool IsSetTemplateConfiguration()
        {
            return this._templateConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WebCrawlerConfiguration.
        /// </summary>
        public WebCrawlerConfiguration WebCrawlerConfiguration
        {
            get { return this._webCrawlerConfiguration; }
            set { this._webCrawlerConfiguration = value; }
        }

        // Check to see if WebCrawlerConfiguration property is set
        internal bool IsSetWebCrawlerConfiguration()
        {
            return this._webCrawlerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WorkDocsConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Amazon WorkDocs as your data
        /// source.
        /// </para>
        /// </summary>
        public WorkDocsConfiguration WorkDocsConfiguration
        {
            get { return this._workDocsConfiguration; }
            set { this._workDocsConfiguration = value; }
        }

        // Check to see if WorkDocsConfiguration property is set
        internal bool IsSetWorkDocsConfiguration()
        {
            return this._workDocsConfiguration != null;
        }

    }
}