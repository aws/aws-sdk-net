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
        /// The template must be a JSON object. All connector types share the following top-level
        /// keys. The value of <c>type</c> and the contents of <c>connectionConfiguration</c>
        /// vary by connector type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>type</c> – (Required) The connector type of the data source. This value identifies
        /// the connector. Valid values: <c>S3V2</c>, <c>WEBCRAWLERV3</c>, <c>GOOGLEDRIVEV3</c>,
        /// <c>ONEDRIVEV3</c>, <c>SHAREPOINTV3</c>. For the fields required by each connector,
        /// see the connector-specific list that follows.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>connectionConfiguration</c> – (Required) The connection details for the data source.
        /// The keys in this object vary by connector type; see the connector-specific list that
        /// follows.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>filterConfiguration</c> – (Optional) Rules that determine which content is crawled,
        /// such as inclusion and exclusion prefixes, patterns, or file-size limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>accessControlConfiguration</c> – (Optional) Document-level access control (ACL)
        /// settings. Supported by all connector types except Web Crawler (<c>WEBCRAWLERV3</c>).
        /// The available fields depend on the connector type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deletionProtectionConfiguration</c> – (Optional) Deletion-protection settings,
        /// supported by all connector types. Contains <c>enableDeletionProtection</c> (Boolean)
        /// and <c>deletionProtectionThreshold</c> (String; a value from 1 to 100).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following list describes the valid <c>type</c> value, the <c>connectionConfiguration</c>
        /// contents, and any connector-specific fields for each connector type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Amazon S3</b> (<c>type</c>: <c>S3V2</c>) – The <c>type</c> value must be <c>S3V2</c>.
        /// <c>connectionConfiguration</c> is required and contains:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>bucketName</c> – (Required) The name of the Amazon S3 bucket to crawl. Type: String.
        /// Length: 3–63 characters. Pattern: <c>^[a-z0-9][.\-a-z0-9]{1,61}[a-z0-9]$</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>bucketOwnerAccountId</c> – (Required) The ID of the AWS account that owns the
        /// bucket. Type: String. Pattern: <c>^\d{12}$</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon S3 supports the following optional <c>filterConfiguration</c> fields:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>inclusionPrefixes</c> or <c>exclusionPrefixes</c> – Amazon S3 key prefixes to
        /// include or exclude. Type: Array of String. Up to 350 items, each 1–1,024 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>inclusionPatterns</c> or <c>exclusionPatterns</c> – Patterns to include or exclude
        /// objects. Type: Array of String. Up to 350 items, each 1–1,024 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>maxFileSizeInMegaBytes</c> – The maximum size, in MB, of a file to ingest. Type:
        /// String. Pattern: <c>^\d+$</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For Amazon S3, <c>accessControlConfiguration</c> supports the following fields:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>crawlAcl</c> – Specifies whether the connector crawls and enforces document access
        /// control lists (ACLs). Type: Boolean. When set to <c>true</c>, provide ACLs either
        /// in a global ACL configuration file (<c>aclConfigurationFilePath</c>) or in per-document
        /// metadata files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aclConfigurationFilePath</c> – The Amazon S3 URI of the global ACL configuration
        /// file. Type: String. Length: 1–1,024 characters. Optional. If you don't provide a global
        /// ACL configuration file, define ACLs in per-document metadata files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>defaultAccessType</c> – The access behavior applied to Amazon S3 prefixes that
        /// are not listed in the ACL configuration. Type: String. The only supported value is
        /// <c>ALLOW</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>metadataFilesPrefix</c> – (Optional) The Amazon S3 prefix under which per-document
        /// metadata files are stored. Each metadata file describes a single source document and
        /// its indexable attributes. This is not the global ACL configuration file. For a single
        /// global ACL file, use <c>accessControlConfiguration.aclConfigurationFilePath</c>. Type:
        /// String. Length: 1–1,024 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Google Drive</b> (<c>type</c>: <c>GOOGLEDRIVEV3</c>) – Requires <c>connectionConfiguration</c>
        /// with <c>authType</c> set to <c>SERVICE_ACCOUNT</c>. Supports <c>dataEntityConfiguration</c>
        /// with <c>crawlMyDrive</c>, <c>crawlSharedWithMe</c>, and <c>crawlSharedDrives</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OneDrive</b> (<c>type</c>: <c>ONEDRIVEV3</c>) – Requires <c>authType</c> at the
        /// template root level set to <c>TWO_LEGGED_OAUTH</c>. Requires <c>connectionConfiguration</c>
        /// with <c>tenantId</c> in UUID format. Supports <c>dataEntityConfiguration</c> with
        /// <c>crawlPersonalDrives</c> and <c>crawlSharedWithMe</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SharePoint</b> (<c>type</c>: <c>SHAREPOINTV3</c>) – Requires <c>connectionConfiguration</c>
        /// with <c>tenantId</c> in UUID format. Supports <c>dataEntityConfiguration</c> with
        /// <c>siteUrls</c>, <c>crawlFiles</c>, and <c>crawlPages</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Web Crawler</b> (<c>type</c>: <c>WEBCRAWLERV3</c>) – Requires <c>connectionConfiguration</c>
        /// with <c>seedUrls</c> or <c>siteMapUrls</c> (mutually exclusive) and <c>authType</c>.
        /// Supports <c>crawlConfiguration</c> for crawl depth, rate limits, and scope. Supports
        /// <c>filterConfiguration</c> for file size limits and URL patterns. Valid values for
        /// <c>authType</c>: <c>NO_AUTH</c>, <c>BASIC_AUTH</c>, <c>FORM</c>, <c>SAML</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Enabling document-level access control for Amazon S3</b> 
        /// </para>
        ///  
        /// <para>
        /// For an Amazon S3 (<c>S3V2</c>) knowledge base, document-level access control is governed
        /// by two settings that must both be enabled:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// In this template, set <c>accessControlConfiguration.crawlAcl</c> to <c>true</c>. Define
        /// ACLs either in a global ACL configuration file, referenced by <c>accessControlConfiguration.aclConfigurationFilePath</c>,
        /// or in per-document metadata files. To control access for prefixes that are not listed
        /// in the ACL file, you can also set <c>accessControlConfiguration.defaultAccessType</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the <c>CreateKnowledgeBase</c> or <c>UpdateKnowledgeBase</c> request, set the top-level
        /// <c>AccessControlConfiguration.isACLEnabled</c> to <c>true</c>.
        /// </para>
        ///  </li> </ol>
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