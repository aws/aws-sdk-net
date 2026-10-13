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
    /// Provides the configuration information for an Amazon Kendra data source.
    /// </summary>
    public partial class DataSourceConfiguration
    {
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
        public AlfrescoConfiguration AlfrescoConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AlfrescoConfiguration property is set.
        /// </summary>
        internal bool IsSetAlfrescoConfiguration() => this.AlfrescoConfiguration != null;

        /// <summary>
        /// Gets and sets the property BoxConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Box as your data source.
        /// </para>
        /// </summary>
        public BoxConfiguration BoxConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BoxConfiguration property is set.
        /// </summary>
        internal bool IsSetBoxConfiguration() => this.BoxConfiguration != null;

        /// <summary>
        /// Gets and sets the property ConfluenceConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Confluence as your data source.
        /// </para>
        /// </summary>
        public ConfluenceConfiguration ConfluenceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ConfluenceConfiguration property is set.
        /// </summary>
        internal bool IsSetConfluenceConfiguration() => this.ConfluenceConfiguration != null;

        /// <summary>
        /// Gets and sets the property DatabaseConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to a database as your data source.
        /// </para>
        /// </summary>
        public DatabaseConfiguration DatabaseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseConfiguration property is set.
        /// </summary>
        internal bool IsSetDatabaseConfiguration() => this.DatabaseConfiguration != null;

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
        public FsxConfiguration FsxConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FsxConfiguration property is set.
        /// </summary>
        internal bool IsSetFsxConfiguration() => this.FsxConfiguration != null;

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
        public GitHubConfiguration GitHubConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GitHubConfiguration property is set.
        /// </summary>
        internal bool IsSetGitHubConfiguration() => this.GitHubConfiguration != null;

        /// <summary>
        /// Gets and sets the property GoogleDriveConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Google Drive as your data source.
        /// </para>
        /// </summary>
        public GoogleDriveConfiguration GoogleDriveConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GoogleDriveConfiguration property is set.
        /// </summary>
        internal bool IsSetGoogleDriveConfiguration() => this.GoogleDriveConfiguration != null;

        /// <summary>
        /// Gets and sets the property JiraConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Jira as your data source.
        /// </para>
        /// </summary>
        public JiraConfiguration JiraConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the JiraConfiguration property is set.
        /// </summary>
        internal bool IsSetJiraConfiguration() => this.JiraConfiguration != null;

        /// <summary>
        /// Gets and sets the property OneDriveConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Microsoft OneDrive as your data
        /// source.
        /// </para>
        /// </summary>
        public OneDriveConfiguration OneDriveConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OneDriveConfiguration property is set.
        /// </summary>
        internal bool IsSetOneDriveConfiguration() => this.OneDriveConfiguration != null;

        /// <summary>
        /// Gets and sets the property QuipConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Quip as your data source.
        /// </para>
        /// </summary>
        public QuipConfiguration QuipConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the QuipConfiguration property is set.
        /// </summary>
        internal bool IsSetQuipConfiguration() => this.QuipConfiguration != null;

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
        public S3DataSourceConfiguration S3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the S3Configuration property is set.
        /// </summary>
        internal bool IsSetS3Configuration() => this.S3Configuration != null;

        /// <summary>
        /// Gets and sets the property SalesforceConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Salesforce as your data source.
        /// </para>
        /// </summary>
        public SalesforceConfiguration SalesforceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SalesforceConfiguration property is set.
        /// </summary>
        internal bool IsSetSalesforceConfiguration() => this.SalesforceConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServiceNowConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to ServiceNow as your data source.
        /// </para>
        /// </summary>
        public ServiceNowConfiguration ServiceNowConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNowConfiguration property is set.
        /// </summary>
        internal bool IsSetServiceNowConfiguration() => this.ServiceNowConfiguration != null;

        /// <summary>
        /// Gets and sets the property SharePointConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to Microsoft SharePoint as your
        /// data source.
        /// </para>
        /// </summary>
        public SharePointConfiguration SharePointConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SharePointConfiguration property is set.
        /// </summary>
        internal bool IsSetSharePointConfiguration() => this.SharePointConfiguration != null;

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
        public SlackConfiguration SlackConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SlackConfiguration property is set.
        /// </summary>
        internal bool IsSetSlackConfiguration() => this.SlackConfiguration != null;

        /// <summary>
        /// Gets and sets the property TemplateConfiguration. 
        /// <para>
        /// Provides a template for the configuration information to connect to your data source.
        /// </para>
        /// </summary>
        public TemplateConfiguration TemplateConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TemplateConfiguration property is set.
        /// </summary>
        internal bool IsSetTemplateConfiguration() => this.TemplateConfiguration != null;

        /// <summary>
        /// Gets and sets the property WebCrawlerConfiguration.
        /// </summary>
        public WebCrawlerConfiguration WebCrawlerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WebCrawlerConfiguration property is set.
        /// </summary>
        internal bool IsSetWebCrawlerConfiguration() => this.WebCrawlerConfiguration != null;

        /// <summary>
        /// Gets and sets the property WorkDocsConfiguration. 
        /// <para>
        /// Provides the configuration information to connect to WorkDocs as your data source.
        /// </para>
        /// </summary>
        public WorkDocsConfiguration WorkDocsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WorkDocsConfiguration property is set.
        /// </summary>
        internal bool IsSetWorkDocsConfiguration() => this.WorkDocsConfiguration != null;
    }
}
