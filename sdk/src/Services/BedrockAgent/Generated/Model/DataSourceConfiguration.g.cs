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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// The connection configuration for the data source.
    /// </summary>
    public partial class DataSourceConfiguration
    {
        /// <summary>
        /// Gets and sets the property ConfluenceConfiguration. 
        /// <para>
        /// The configuration information to connect to Confluence as your data source for self-managed
        /// knowledge bases.
        /// </para>
        ///  <note> 
        /// <para>
        /// To configure this data source for managed knowledge bases, use <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_ManagedKnowledgeBaseConnectorConfiguration.html">managedKnowledgeBaseConnectorConfiguration</a>.
        /// Confluence data source connector for self-managed knowledge bases is in preview release
        /// and is subject to change.
        /// </para>
        ///  </note>
        /// </summary>
        public ConfluenceDataSourceConfiguration ConfluenceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ConfluenceConfiguration property is set.
        /// </summary>
        internal bool IsSetConfluenceConfiguration() => this.ConfluenceConfiguration != null;

        /// <summary>
        /// Gets and sets the property ManagedKnowledgeBaseConnectorConfiguration. 
        /// <para>
        /// Contains the configuration for a data source that connects a managed knowledge base
        /// to a supported data source connector. Specify this object when the data source type
        /// is <c>MANAGED_KNOWLEDGE_BASE_CONNECTOR</c>.
        /// </para>
        /// </summary>
        public ManagedKnowledgeBaseConnectorConfiguration ManagedKnowledgeBaseConnectorConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ManagedKnowledgeBaseConnectorConfiguration property is set.
        /// </summary>
        internal bool IsSetManagedKnowledgeBaseConnectorConfiguration() => this.ManagedKnowledgeBaseConnectorConfiguration != null;

        /// <summary>
        /// Gets and sets the property S3Configuration. 
        /// <para>
        /// The configuration information to connect to Amazon S3 as your data source for self-managed
        /// knowledge bases. To configure this data source for managed knowledge bases, use <a
        /// href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_ManagedKnowledgeBaseConnectorConfiguration.html">managedKnowledgeBaseConnectorConfiguration</a>.
        /// </para>
        /// </summary>
        public S3DataSourceConfiguration S3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the S3Configuration property is set.
        /// </summary>
        internal bool IsSetS3Configuration() => this.S3Configuration != null;

        /// <summary>
        /// Gets and sets the property SalesforceConfiguration. 
        /// <para>
        /// The configuration information to connect to Salesforce as your data source.
        /// </para>
        ///  <note> 
        /// <para>
        /// Salesforce data source connector for self-managed knowledge bases is in preview release
        /// and is subject to change.
        /// </para>
        ///  </note>
        /// </summary>
        public SalesforceDataSourceConfiguration SalesforceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SalesforceConfiguration property is set.
        /// </summary>
        internal bool IsSetSalesforceConfiguration() => this.SalesforceConfiguration != null;

        /// <summary>
        /// Gets and sets the property SharePointConfiguration. 
        /// <para>
        /// The configuration information to connect to SharePoint as your data source for self-managed
        /// knowledge bases.
        /// </para>
        ///  <note> 
        /// <para>
        /// To configure this data source for managed knowledge bases, use <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_ManagedKnowledgeBaseConnectorConfiguration.html">managedKnowledgeBaseConnectorConfiguration</a>.
        /// SharePoint data source connector for self-managed knowledge bases is in preview release
        /// and is subject to change.
        /// </para>
        ///  </note>
        /// </summary>
        public SharePointDataSourceConfiguration SharePointConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SharePointConfiguration property is set.
        /// </summary>
        internal bool IsSetSharePointConfiguration() => this.SharePointConfiguration != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataSourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property WebConfiguration. 
        /// <para>
        /// The configuration of web URLs to crawl for your data source. You should be authorized
        /// to crawl the URLs.
        /// </para>
        ///  <note> 
        /// <para>
        /// To configure this data source for managed knowledge bases, use <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_ManagedKnowledgeBaseConnectorConfiguration.html">managedKnowledgeBaseConnectorConfiguration</a>.
        /// Web crawler data source connector for self-managed knowledge bases is in preview release
        /// and is subject to change.
        /// </para>
        ///  </note>
        /// </summary>
        public WebDataSourceConfiguration WebConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WebConfiguration property is set.
        /// </summary>
        internal bool IsSetWebConfiguration() => this.WebConfiguration != null;
    }
}
