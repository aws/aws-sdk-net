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
    /// Provides the configuration information to connect to Confluence as your data source.
    /// </summary>
    public partial class ConfluenceConfiguration
    {
        private ConfluenceAttachmentConfiguration _attachmentConfiguration;
        private ConfluenceAuthenticationType _authenticationType;
        private ConfluenceBlogConfiguration _blogConfiguration;
        private List<string> _exclusionPatterns = new List<string>();
        private List<string> _inclusionPatterns = new List<string>();
        private ConfluencePageConfiguration _pageConfiguration;
        private ProxyConfiguration _proxyConfiguration;
        private string _secretArn;
        private string _serverUrl;
        private ConfluenceSpaceConfiguration _spaceConfiguration;
        private ConfluenceVersion _version;
        private DataSourceVpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property AttachmentConfiguration. 
        /// <para>
        /// Configuration information for indexing attachments to Confluence blogs and pages.
        /// </para>
        /// </summary>
        public ConfluenceAttachmentConfiguration AttachmentConfiguration
        {
            get { return this._attachmentConfiguration; }
            set { this._attachmentConfiguration = value; }
        }

        // Check to see if AttachmentConfiguration property is set
        internal bool IsSetAttachmentConfiguration()
        {
            return this._attachmentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationType. 
        /// <para>
        /// Whether you want to connect to Confluence using basic authentication of user name
        /// and password, or a personal access token. You can use a personal access token for
        /// Confluence Server.
        /// </para>
        /// </summary>
        public ConfluenceAuthenticationType AuthenticationType
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
        /// Gets and sets the property BlogConfiguration. 
        /// <para>
        /// Configuration information for indexing Confluence blogs.
        /// </para>
        /// </summary>
        public ConfluenceBlogConfiguration BlogConfiguration
        {
            get { return this._blogConfiguration; }
            set { this._blogConfiguration = value; }
        }

        // Check to see if BlogConfiguration property is set
        internal bool IsSetBlogConfiguration()
        {
            return this._blogConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain blog posts, pages, spaces,
        /// or attachments in your Confluence. Content that matches the patterns are excluded
        /// from the index. Content that doesn't match the patterns is included in the index.
        /// If content matches both an inclusion and exclusion pattern, the exclusion pattern
        /// takes precedence and the content isn't included in the index.
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
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain blog posts, pages, spaces,
        /// or attachments in your Confluence. Content that matches the patterns are included
        /// in the index. Content that doesn't match the patterns is excluded from the index.
        /// If content matches both an inclusion and exclusion pattern, the exclusion pattern
        /// takes precedence and the content isn't included in the index.
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
        /// Gets and sets the property PageConfiguration. 
        /// <para>
        /// Configuration information for indexing Confluence pages.
        /// </para>
        /// </summary>
        public ConfluencePageConfiguration PageConfiguration
        {
            get { return this._pageConfiguration; }
            set { this._pageConfiguration = value; }
        }

        // Check to see if PageConfiguration property is set
        internal bool IsSetPageConfiguration()
        {
            return this._pageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ProxyConfiguration. 
        /// <para>
        /// Configuration information to connect to your Confluence URL instance via a web proxy.
        /// You can use this option for Confluence Server.
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
        /// name and password required to connect to the Confluence instance. If you use Confluence
        /// Cloud, you use a generated API token as the password.
        /// </para>
        ///  
        /// <para>
        /// You can also provide authentication credentials in the form of a personal access token.
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-confluence.html">Using
        /// a Confluence data source</a>.
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
        /// Gets and sets the property ServerUrl. 
        /// <para>
        /// The URL of your Confluence instance. Use the full URL of the server. For example,
        /// <i>https://server.example.com:port/</i>. You can also use an IP address, for example,
        /// <i>https://192.168.1.113/</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ServerUrl
        {
            get { return this._serverUrl; }
            set { this._serverUrl = value; }
        }

        // Check to see if ServerUrl property is set
        internal bool IsSetServerUrl()
        {
            return this._serverUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceConfiguration. 
        /// <para>
        /// Configuration information for indexing Confluence spaces.
        /// </para>
        /// </summary>
        public ConfluenceSpaceConfiguration SpaceConfiguration
        {
            get { return this._spaceConfiguration; }
            set { this._spaceConfiguration = value; }
        }

        // Check to see if SpaceConfiguration property is set
        internal bool IsSetSpaceConfiguration()
        {
            return this._spaceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version or the type of Confluence installation to connect to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfluenceVersion Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Configuration information for an Amazon Virtual Private Cloud to connect to your Confluence.
        /// For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/vpc-configuration.html">Configuring
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