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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The template configuration for a knowledge base. This object contains connector-specific
    /// configuration that defines how data is crawled and indexed.
    /// </summary>
    public partial class KbTemplateConfiguration
    {
        private Amazon.Runtime.Documents.Document _template;

        /// <summary>
        /// Gets and sets the property Template. 
        /// <para>
        /// The connector configuration for the knowledge base data source. The structure depends
        /// on the connector type of the data source referenced by <c>DataSourceArn</c>.
        /// </para>
        ///  
        /// <para>
        /// The template must be a JSON object. The required fields vary by connector type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Amazon S3</b> (<c>S3V2</c>) – Requires <c>connectionConfiguration</c> with <c>bucketName</c>.
        /// Supports <c>filterConfiguration</c> for inclusion and exclusion prefixes and patterns.
        /// Supports <c>accessControlConfiguration</c> and <c>deletionProtectionConfiguration</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Google Drive</b> (<c>GOOGLEDRIVEV3</c>) – Requires <c>connectionConfiguration</c>
        /// with <c>authType</c> set to <c>SERVICE_ACCOUNT</c>. Supports <c>dataEntityConfiguration</c>
        /// with <c>crawlMyDrive</c>, <c>crawlSharedWithMe</c>, and <c>crawlSharedDrives</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OneDrive</b> (<c>ONEDRIVEV3</c>) – Requires <c>authType</c> at the template root
        /// level set to <c>TWO_LEGGED_OAUTH</c>. Requires <c>connectionConfiguration</c> with
        /// <c>tenantId</c> in UUID format. Supports <c>dataEntityConfiguration</c> with <c>crawlPersonalDrives</c>
        /// and <c>crawlSharedWithMe</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SharePoint</b> (<c>SHAREPOINTV3</c>) – Requires <c>connectionConfiguration</c>
        /// with <c>tenantId</c> in UUID format. Supports <c>dataEntityConfiguration</c> with
        /// <c>siteUrls</c>, <c>crawlFiles</c>, and <c>crawlPages</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Web Crawler</b> (<c>WEBCRAWLERV3</c>) – Requires <c>connectionConfiguration</c>
        /// with <c>seedUrls</c> or <c>siteMapUrls</c> (mutually exclusive) and <c>authType</c>.
        /// Supports <c>crawlConfiguration</c> for crawl depth, rate limits, and scope. Supports
        /// <c>filterConfiguration</c> for file size limits and URL patterns. Valid values for
        /// <c>authType</c>: <c>NO_AUTH</c>, <c>BASIC_AUTH</c>, <c>FORM</c>, <c>SAML</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The optional <c>deletionProtectionConfiguration</c> object is supported by all connector
        /// types. It contains <c>enableDeletionProtection</c> and <c>deletionProtectionThreshold</c>.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Template
        {
            get { return this._template; }
            set { this._template = value; }
        }

        // Check to see if Template property is set
        internal bool IsSetTemplate()
        {
            return !this._template.IsNull();
        }

    }
}