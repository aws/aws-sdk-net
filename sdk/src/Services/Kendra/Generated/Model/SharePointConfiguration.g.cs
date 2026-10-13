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
    /// Provides the configuration information to connect to Microsoft SharePoint as your
    /// data source.
    /// </summary>
    public partial class SharePointConfiguration
    {
        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// Whether you want to connect to SharePoint Online using basic authentication of user
        /// name and password, or OAuth authentication of user name, password, client ID, and
        /// client secret, or AD App-only authentication of client secret.
        /// </para>
        /// </summary>
        public SharePointOnlineAuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationType property is set.
        /// </summary>
        internal bool IsSetAuthenticationType() => this.AuthenticationType != null;

        /// <summary>
        /// Gets and sets the property CrawlAttachments. 
        /// <para>
        ///  <c>TRUE</c> to index document attachments.
        /// </para>
        /// </summary>
        public bool? CrawlAttachments { get; set; }

        /// <summary>
        /// Checks to see if the CrawlAttachments property is set.
        /// </summary>
        internal bool IsSetCrawlAttachments() => this.CrawlAttachments.HasValue;

        /// <summary>
        /// Gets and sets the property DisableLocalGroups. 
        /// <para>
        ///  <c>TRUE</c> to disable local groups information.
        /// </para>
        /// </summary>
        public bool? DisableLocalGroups { get; set; }

        /// <summary>
        /// Checks to see if the DisableLocalGroups property is set.
        /// </summary>
        internal bool IsSetDisableLocalGroups() => this.DisableLocalGroups.HasValue;

        /// <summary>
        /// Gets and sets the property DocumentTitleFieldName. 
        /// <para>
        /// The Microsoft SharePoint attribute field that contains the title of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DocumentTitleFieldName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentTitleFieldName property is set.
        /// </summary>
        internal bool IsSetDocumentTitleFieldName() => this.DocumentTitleFieldName != null;

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain documents in your SharePoint.
        /// Documents that match the patterns are excluded from the index. Documents that don't
        /// match the patterns are included in the index. If a document matches both an inclusion
        /// and exclusion pattern, the exclusion pattern takes precedence and the document isn't
        /// included in the index.
        /// </para>
        ///  
        /// <para>
        /// The regex applies to the display URL of the SharePoint document.
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
        /// Gets and sets the property FieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map SharePoint data source
        /// attributes or field names to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to SharePoint fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The SharePoint data source field names must exist in your
        /// SharePoint custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> FieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the FieldMappings property is set.
        /// </summary>
        internal bool IsSetFieldMappings() => this.FieldMappings != null && (this.FieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain documents in your SharePoint.
        /// Documents that match the patterns are included in the index. Documents that don't
        /// match the patterns are excluded from the index. If a document matches both an inclusion
        /// and exclusion pattern, the exclusion pattern takes precedence and the document isn't
        /// included in the index.
        /// </para>
        ///  
        /// <para>
        /// The regex applies to the display URL of the SharePoint document.
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
        /// Gets and sets the property ProxyConfiguration. 
        /// <para>
        /// Configuration information to connect to your Microsoft SharePoint site URLs via instance
        /// via a web proxy. You can use this option for SharePoint Server.
        /// </para>
        ///  
        /// <para>
        /// You must provide the website host name and port number. For example, the host name
        /// of <i>https://a.example.com/page1.html</i> is "a.example.com" and the port is 443,
        /// the standard port for HTTPS.
        /// </para>
        ///  
        /// <para>
        /// Web proxy credentials are optional and you can use them to connect to a web proxy
        /// server that requires basic authentication of user name and password. To store web
        /// proxy credentials, you use a secret in Secrets Manager.
        /// </para>
        ///  
        /// <para>
        /// It is recommended that you follow best security practices when configuring your web
        /// proxy. This includes setting up throttling, setting up logging and monitoring, and
        /// applying security patches on a regular basis. If you use your web proxy with multiple
        /// data sources, sync jobs that occur at the same time could strain the load on your
        /// proxy. It is recommended you prepare your proxy beforehand for any security and load
        /// requirements.
        /// </para>
        /// </summary>
        public ProxyConfiguration ProxyConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProxyConfiguration property is set.
        /// </summary>
        internal bool IsSetProxyConfiguration() => this.ProxyConfiguration != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Secrets Manager secret that contains the user
        /// name and password required to connect to the SharePoint instance. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-sharepoint.html">Microsoft
        /// SharePoint</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1284)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property SharePointVersion. 
        /// <para>
        /// The version of Microsoft SharePoint that you use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SharePointVersion SharePointVersion { get; set; }

        /// <summary>
        /// Checks to see if the SharePointVersion property is set.
        /// </summary>
        internal bool IsSetSharePointVersion() => this.SharePointVersion != null;

        /// <summary>
        /// Gets and sets the property SslCertificateS3Path. 
        /// <para>
        /// The path to the SSL certificate stored in an Amazon S3 bucket. You use this to connect
        /// to SharePoint Server if you require a secure SSL connection.
        /// </para>
        ///  
        /// <para>
        /// You can generate a self-signed X509 certificate on any computer using OpenSSL. For
        /// an example of using OpenSSL to create an X509 certificate, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/configuring-https-ssl.html">Create
        /// and sign an X509 certificate</a>.
        /// </para>
        /// </summary>
        public S3Path SslCertificateS3Path { get; set; }

        /// <summary>
        /// Checks to see if the SslCertificateS3Path property is set.
        /// </summary>
        internal bool IsSetSslCertificateS3Path() => this.SslCertificateS3Path != null;

        /// <summary>
        /// Gets and sets the property Urls. 
        /// <para>
        /// The Microsoft SharePoint site URLs for the documents you want to index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<string> Urls { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Urls property is set.
        /// </summary>
        internal bool IsSetUrls() => this.Urls != null && (this.Urls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UseChangeLog. 
        /// <para>
        ///  <c>TRUE</c> to use the SharePoint change log to determine which documents require
        /// updating in the index. Depending on the change log's size, it may take longer for
        /// Amazon Kendra to use the change log than to scan all of your documents in SharePoint.
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
        /// Configuration information for an Amazon Virtual Private Cloud to connect to your Microsoft
        /// SharePoint. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/vpc-configuration.html">Configuring
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
