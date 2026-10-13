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
    /// Provides the configuration information to connect to Alfresco as your data source.
    /// 
    ///  <note> 
    /// <para>
    /// Support for <c>AlfrescoConfiguration</c> ended May 2023. We recommend migrating to
    /// or using the Alfresco data source template schema / <a href="https://docs.aws.amazon.com/kendra/latest/APIReference/API_TemplateConfiguration.html">TemplateConfiguration</a>
    /// API.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AlfrescoConfiguration
    {
        /// <summary>
        /// Gets and sets the property BlogFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of Alfresco blogs to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to Alfresco fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html"> Mapping
        /// data source fields</a>. The Alfresco data source field names must exist in your Alfresco
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
        public List<DataSourceToIndexFieldMapping> BlogFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the BlogFieldMappings property is set.
        /// </summary>
        internal bool IsSetBlogFieldMappings() => this.BlogFieldMappings != null && (this.BlogFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CrawlComments. 
        /// <para>
        ///  <c>TRUE</c> to index comments of blogs and other content.
        /// </para>
        /// </summary>
        public bool? CrawlComments { get; set; }

        /// <summary>
        /// Checks to see if the CrawlComments property is set.
        /// </summary>
        internal bool IsSetCrawlComments() => this.CrawlComments.HasValue;

        /// <summary>
        /// Gets and sets the property CrawlSystemFolders. 
        /// <para>
        ///  <c>TRUE</c> to index shared files.
        /// </para>
        /// </summary>
        public bool? CrawlSystemFolders { get; set; }

        /// <summary>
        /// Checks to see if the CrawlSystemFolders property is set.
        /// </summary>
        internal bool IsSetCrawlSystemFolders() => this.CrawlSystemFolders.HasValue;

        /// <summary>
        /// Gets and sets the property DocumentLibraryFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of Alfresco document libraries to Amazon Kendra index field names. To create
        /// custom fields, use the <c>UpdateIndex</c> API before you map to Alfresco fields. For
        /// more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">
        /// Mapping data source fields</a>. The Alfresco data source field names must exist in
        /// your Alfresco custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> DocumentLibraryFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the DocumentLibraryFieldMappings property is set.
        /// </summary>
        internal bool IsSetDocumentLibraryFieldMappings() => this.DocumentLibraryFieldMappings != null && (this.DocumentLibraryFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EntityFilter. 
        /// <para>
        /// Specify whether to index document libraries, wikis, or blogs. You can specify one
        /// or more of these options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<string> EntityFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EntityFilter property is set.
        /// </summary>
        internal bool IsSetEntityFilter() => this.EntityFilter != null && (this.EntityFilter.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain files in your Alfresco data
        /// source. Files that match the patterns are excluded from the index. Files that don't
        /// match the patterns are included in the index. If a file matches both an inclusion
        /// pattern and an exclusion pattern, the exclusion pattern takes precedence and the file
        /// isn't included in the index.
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
        /// A list of regular expression patterns to include certain files in your Alfresco data
        /// source. Files that match the patterns are included in the index. Files that don't
        /// match the patterns are excluded from the index. If a file matches both an inclusion
        /// pattern and an exclusion pattern, the exclusion pattern takes precedence and the file
        /// isn't included in the index.
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
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Secrets Manager secret that contains the key-value
        /// pairs required to connect to your Alfresco data source. The secret must contain a
        /// JSON structure with the following keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// username—The user name of the Alfresco account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// password—The password of the Alfresco account.
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
        /// Gets and sets the property SiteId. 
        /// <para>
        /// The identifier of the Alfresco site. For example, <i>my-site</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string SiteId { get; set; }

        /// <summary>
        /// Checks to see if the SiteId property is set.
        /// </summary>
        internal bool IsSetSiteId() => this.SiteId != null;

        /// <summary>
        /// Gets and sets the property SiteUrl. 
        /// <para>
        /// The URL of the Alfresco site. For example, <i>https://hostname:8080</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string SiteUrl { get; set; }

        /// <summary>
        /// Checks to see if the SiteUrl property is set.
        /// </summary>
        internal bool IsSetSiteUrl() => this.SiteUrl != null;

        /// <summary>
        /// Gets and sets the property SslCertificateS3Path. 
        /// <para>
        /// The path to the SSL certificate stored in an Amazon S3 bucket. You use this to connect
        /// to Alfresco if you require a secure SSL connection.
        /// </para>
        ///  
        /// <para>
        /// You can simply generate a self-signed X509 certificate on any computer using OpenSSL.
        /// For an example of using OpenSSL to create an X509 certificate, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/configuring-https-ssl.html">Create
        /// and sign an X509 certificate</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3Path SslCertificateS3Path { get; set; }

        /// <summary>
        /// Checks to see if the SslCertificateS3Path property is set.
        /// </summary>
        internal bool IsSetSslCertificateS3Path() => this.SslCertificateS3Path != null;

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Configuration information for an Amazon Virtual Private Cloud to connect to your Alfresco.
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
        /// Gets and sets the property WikiFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of Alfresco wikis to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to Alfresco fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html"> Mapping
        /// data source fields</a>. The Alfresco data source field names must exist in your Alfresco
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
        public List<DataSourceToIndexFieldMapping> WikiFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the WikiFieldMappings property is set.
        /// </summary>
        internal bool IsSetWikiFieldMappings() => this.WikiFieldMappings != null && (this.WikiFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
