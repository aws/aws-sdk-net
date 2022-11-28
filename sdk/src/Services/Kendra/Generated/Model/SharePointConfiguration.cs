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
    /// Provides the configuration information to connect to Microsoft SharePoint as your
    /// data source.
    /// </summary>
    public partial class SharePointConfiguration
    {
        private SharePointOnlineAuthenticationType _authenticationType;
        private bool? _crawlAttachments;
        private bool? _disableLocalGroups;
        private string _documentTitleFieldName;
        private List<string> _exclusionPatterns = new List<string>();
        private List<DataSourceToIndexFieldMapping> _fieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<string> _inclusionPatterns = new List<string>();
        private ProxyConfiguration _proxyConfiguration;
        private string _secretArn;
        private SharePointVersion _sharePointVersion;
        private S3Path _sslCertificateS3Path;
        private List<string> _urls = new List<string>();
        private bool? _useChangeLog;
        private DataSourceVpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// Whether you want to connect to SharePoint using basic authentication of user name
        /// and password, or OAuth authentication of user name, password, client ID, and client
        /// secret. You can use OAuth authentication for SharePoint Online.
        /// </para>
        /// </summary>
        public SharePointOnlineAuthenticationType AuthenticationType
        {
            get { return this._authenticationType; }
            set { this._authenticationType = value; }
        }

        // Check to see if AuthenticationType property is set
        internal bool IsSetAuthenticationType()
        {
            return this._authenticationType != null;
        }

        /// <summary>
        /// Gets and sets the property CrawlAttachments. 
        /// <para>
        ///  <code>TRUE</code> to index document attachments.
        /// </para>
        /// </summary>
        public bool CrawlAttachments
        {
            get { return this._crawlAttachments.GetValueOrDefault(); }
            set { this._crawlAttachments = value; }
        }

        // Check to see if CrawlAttachments property is set
        internal bool IsSetCrawlAttachments()
        {
            return this._crawlAttachments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisableLocalGroups. 
        /// <para>
        ///  <code>TRUE</code> to disable local groups information.
        /// </para>
        /// </summary>
        public bool DisableLocalGroups
        {
            get { return this._disableLocalGroups.GetValueOrDefault(); }
            set { this._disableLocalGroups = value; }
        }

        // Check to see if DisableLocalGroups property is set
        internal bool IsSetDisableLocalGroups()
        {
            return this._disableLocalGroups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DocumentTitleFieldName. 
        /// <para>
        /// The Microsoft SharePoint attribute field that contains the title of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DocumentTitleFieldName
        {
            get { return this._documentTitleFieldName; }
            set { this._documentTitleFieldName = value; }
        }

        // Check to see if DocumentTitleFieldName property is set
        internal bool IsSetDocumentTitleFieldName()
        {
            return this._documentTitleFieldName != null;
        }

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
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ExclusionPatterns
        {
            get { return this._exclusionPatterns; }
            set { this._exclusionPatterns = value; }
        }

        // Check to see if ExclusionPatterns property is set
        internal bool IsSetExclusionPatterns()
        {
            return this._exclusionPatterns != null && this._exclusionPatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map SharePoint data
        /// source attributes or field names to Amazon Kendra index field names. To create custom
        /// fields, use the <code>UpdateIndex</code> API before you map to SharePoint fields.
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The SharePoint data source field names must exist in your
        /// SharePoint custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> FieldMappings
        {
            get { return this._fieldMappings; }
            set { this._fieldMappings = value; }
        }

        // Check to see if FieldMappings property is set
        internal bool IsSetFieldMappings()
        {
            return this._fieldMappings != null && this._fieldMappings.Count > 0; 
        }

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
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> InclusionPatterns
        {
            get { return this._inclusionPatterns; }
            set { this._inclusionPatterns = value; }
        }

        // Check to see if InclusionPatterns property is set
        internal bool IsSetInclusionPatterns()
        {
            return this._inclusionPatterns != null && this._inclusionPatterns.Count > 0; 
        }

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
        public ProxyConfiguration ProxyConfiguration
        {
            get { return this._proxyConfiguration; }
            set { this._proxyConfiguration = value; }
        }

        // Check to see if ProxyConfiguration property is set
        internal bool IsSetProxyConfiguration()
        {
            return this._proxyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Secrets Manager secret that contains the user
        /// name and password required to connect to the SharePoint instance. If you use SharePoint
        /// Server, you also need to provide the sever domain name as part of the credentials.
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-sharepoint.html">Using
        /// a Microsoft SharePoint Data Source</a>.
        /// </para>
        ///  
        /// <para>
        /// You can also provide OAuth authentication credentials of user name, password, client
        /// ID, and client secret. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-sharepoint.html">Using
        /// a SharePoint data source</a>.
        /// </para>
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
        /// Gets and sets the property SharePointVersion. 
        /// <para>
        /// The version of Microsoft SharePoint that you use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SharePointVersion SharePointVersion
        {
            get { return this._sharePointVersion; }
            set { this._sharePointVersion = value; }
        }

        // Check to see if SharePointVersion property is set
        internal bool IsSetSharePointVersion()
        {
            return this._sharePointVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SslCertificateS3Path. 
        /// <para>
        /// The path to the SSL certificate stored in an Amazon S3 bucket. You use this to connect
        /// to SharePoint Server if you require a secure SSL connection.
        /// </para>
        ///  
        /// <para>
        /// You can simply generate a self-signed X509 certificate on any computer using OpenSSL.
        /// For an example of using OpenSSL to create an X509 certificate, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/configuring-https-ssl.html">Create
        /// and sign an X509 certificate</a>.
        /// </para>
        /// </summary>
        public S3Path SslCertificateS3Path
        {
            get { return this._sslCertificateS3Path; }
            set { this._sslCertificateS3Path = value; }
        }

        // Check to see if SslCertificateS3Path property is set
        internal bool IsSetSslCertificateS3Path()
        {
            return this._sslCertificateS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property Urls. 
        /// <para>
        /// The Microsoft SharePoint site URLs for the documents you want to index.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> Urls
        {
            get { return this._urls; }
            set { this._urls = value; }
        }

        // Check to see if Urls property is set
        internal bool IsSetUrls()
        {
            return this._urls != null && this._urls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UseChangeLog. 
        /// <para>
        ///  <code>TRUE</code> to use the SharePoint change log to determine which documents require
        /// updating in the index. Depending on the change log's size, it may take longer for
        /// Amazon Kendra to use the change log than to scan all of your documents in SharePoint.
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
        /// Configuration information for an Amazon Virtual Private Cloud to connect to your Microsoft
        /// SharePoint. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/vpc-configuration.html">Configuring
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