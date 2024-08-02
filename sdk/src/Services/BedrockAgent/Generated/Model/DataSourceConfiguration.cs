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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
        private ConfluenceDataSourceConfiguration _confluenceConfiguration;
        private S3DataSourceConfiguration _s3Configuration;
        private SalesforceDataSourceConfiguration _salesforceConfiguration;
        private SharePointDataSourceConfiguration _sharePointConfiguration;
        private DataSourceType _type;
        private WebDataSourceConfiguration _webConfiguration;

        /// <summary>
        /// Gets and sets the property ConfluenceConfiguration. 
        /// <para>
        /// The configuration information to connect to Confluence as your data source.
        /// </para>
        ///  <note> 
        /// <para>
        /// Confluence data source connector is in preview release and is subject to change.
        /// </para>
        ///  </note>
        /// </summary>
        public ConfluenceDataSourceConfiguration ConfluenceConfiguration
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
        /// Gets and sets the property S3Configuration. 
        /// <para>
        /// The configuration information to connect to Amazon S3 as your data source.
        /// </para>
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
        /// The configuration information to connect to Salesforce as your data source.
        /// </para>
        ///  <note> 
        /// <para>
        /// Salesforce data source connector is in preview release and is subject to change.
        /// </para>
        ///  </note>
        /// </summary>
        public SalesforceDataSourceConfiguration SalesforceConfiguration
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
        /// Gets and sets the property SharePointConfiguration. 
        /// <para>
        /// The configuration information to connect to SharePoint as your data source.
        /// </para>
        ///  <note> 
        /// <para>
        /// SharePoint data source connector is in preview release and is subject to change.
        /// </para>
        ///  </note>
        /// </summary>
        public SharePointDataSourceConfiguration SharePointConfiguration
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceType Type
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
        /// Gets and sets the property WebConfiguration. 
        /// <para>
        /// The configuration of web URLs to crawl for your data source. You should be authorized
        /// to crawl the URLs.
        /// </para>
        ///  <note> 
        /// <para>
        /// Crawling web URLs as your data source is in preview release and is subject to change.
        /// </para>
        ///  </note>
        /// </summary>
        public WebDataSourceConfiguration WebConfiguration
        {
            get { return this._webConfiguration; }
            set { this._webConfiguration = value; }
        }

        // Check to see if WebConfiguration property is set
        internal bool IsSetWebConfiguration()
        {
            return this._webConfiguration != null;
        }

    }
}