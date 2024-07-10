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
    /// The configuration information to connect to Salesforce as your data source.
    /// </summary>
    public partial class SalesforceDataSourceConfiguration
    {
        private SalesforceCrawlerConfiguration _crawlerConfiguration;
        private SalesforceSourceConfiguration _sourceConfiguration;

        /// <summary>
        /// Gets and sets the property CrawlerConfiguration. 
        /// <para>
        /// The configuration of the Salesforce content. For example, configuring specific types
        /// of Salesforce content.
        /// </para>
        /// </summary>
        public SalesforceCrawlerConfiguration CrawlerConfiguration
        {
            get { return this._crawlerConfiguration; }
            set { this._crawlerConfiguration = value; }
        }

        // Check to see if CrawlerConfiguration property is set
        internal bool IsSetCrawlerConfiguration()
        {
            return this._crawlerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// The endpoint information to connect to your Salesforce data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SalesforceSourceConfiguration SourceConfiguration
        {
            get { return this._sourceConfiguration; }
            set { this._sourceConfiguration = value; }
        }

        // Check to see if SourceConfiguration property is set
        internal bool IsSetSourceConfiguration()
        {
            return this._sourceConfiguration != null;
        }

    }
}