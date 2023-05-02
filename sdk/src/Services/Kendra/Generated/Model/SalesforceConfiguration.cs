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
    /// Provides the configuration information to connect to Salesforce as your data source.
    /// </summary>
    public partial class SalesforceConfiguration
    {
        private SalesforceChatterFeedConfiguration _chatterFeedConfiguration;
        private bool? _crawlAttachments;
        private List<string> _excludeAttachmentFilePatterns = new List<string>();
        private List<string> _includeAttachmentFilePatterns = new List<string>();
        private SalesforceKnowledgeArticleConfiguration _knowledgeArticleConfiguration;
        private string _secretArn;
        private string _serverUrl;
        private SalesforceStandardObjectAttachmentConfiguration _standardObjectAttachmentConfiguration;
        private List<SalesforceStandardObjectConfiguration> _standardObjectConfigurations = new List<SalesforceStandardObjectConfiguration>();

        /// <summary>
        /// Gets and sets the property ChatterFeedConfiguration. 
        /// <para>
        /// Configuration information for Salesforce chatter feeds.
        /// </para>
        /// </summary>
        public SalesforceChatterFeedConfiguration ChatterFeedConfiguration
        {
            get { return this._chatterFeedConfiguration; }
            set { this._chatterFeedConfiguration = value; }
        }

        // Check to see if ChatterFeedConfiguration property is set
        internal bool IsSetChatterFeedConfiguration()
        {
            return this._chatterFeedConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CrawlAttachments. 
        /// <para>
        /// Indicates whether Amazon Kendra should index attachments to Salesforce objects.
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
        /// Gets and sets the property ExcludeAttachmentFilePatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain documents in your Salesforce.
        /// Documents that match the patterns are excluded from the index. Documents that don't
        /// match the patterns are included in the index. If a document matches both an inclusion
        /// and exclusion pattern, the exclusion pattern takes precedence and the document isn't
        /// included in the index.
        /// </para>
        ///  
        /// <para>
        /// The pattern is applied to the name of the attached file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ExcludeAttachmentFilePatterns
        {
            get { return this._excludeAttachmentFilePatterns; }
            set { this._excludeAttachmentFilePatterns = value; }
        }

        // Check to see if ExcludeAttachmentFilePatterns property is set
        internal bool IsSetExcludeAttachmentFilePatterns()
        {
            return this._excludeAttachmentFilePatterns != null && this._excludeAttachmentFilePatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncludeAttachmentFilePatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain documents in your Salesforce.
        /// Documents that match the patterns are included in the index. Documents that don't
        /// match the patterns are excluded from the index. If a document matches both an inclusion
        /// and exclusion pattern, the exclusion pattern takes precedence and the document isn't
        /// included in the index.
        /// </para>
        ///  
        /// <para>
        /// The pattern is applied to the name of the attached file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> IncludeAttachmentFilePatterns
        {
            get { return this._includeAttachmentFilePatterns; }
            set { this._includeAttachmentFilePatterns = value; }
        }

        // Check to see if IncludeAttachmentFilePatterns property is set
        internal bool IsSetIncludeAttachmentFilePatterns()
        {
            return this._includeAttachmentFilePatterns != null && this._includeAttachmentFilePatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KnowledgeArticleConfiguration. 
        /// <para>
        /// Configuration information for the knowledge article types that Amazon Kendra indexes.
        /// Amazon Kendra indexes standard knowledge articles and the standard fields of knowledge
        /// articles, or the custom fields of custom knowledge articles, but not both.
        /// </para>
        /// </summary>
        public SalesforceKnowledgeArticleConfiguration KnowledgeArticleConfiguration
        {
            get { return this._knowledgeArticleConfiguration; }
            set { this._knowledgeArticleConfiguration = value; }
        }

        // Check to see if KnowledgeArticleConfiguration property is set
        internal bool IsSetKnowledgeArticleConfiguration()
        {
            return this._knowledgeArticleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Secrets Managersecret that contains the key/value
        /// pairs required to connect to your Salesforce instance. The secret must contain a JSON
        /// structure with the following keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// authenticationUrl - The OAUTH endpoint that Amazon Kendra connects to get an OAUTH
        /// token. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// consumerKey - The application public key generated when you created your Salesforce
        /// application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// consumerSecret - The application private key generated when you created your Salesforce
        /// application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// password - The password associated with the user logging in to the Salesforce instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// securityToken - The token associated with the user logging in to the Salesforce instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// username - The user name of the user logging in to the Salesforce instance.
        /// </para>
        ///  </li> </ul>
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
        /// The instance URL for the Salesforce site that you want to index.
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
        /// Gets and sets the property StandardObjectAttachmentConfiguration. 
        /// <para>
        /// Configuration information for processing attachments to Salesforce standard objects.
        /// 
        /// </para>
        /// </summary>
        public SalesforceStandardObjectAttachmentConfiguration StandardObjectAttachmentConfiguration
        {
            get { return this._standardObjectAttachmentConfiguration; }
            set { this._standardObjectAttachmentConfiguration = value; }
        }

        // Check to see if StandardObjectAttachmentConfiguration property is set
        internal bool IsSetStandardObjectAttachmentConfiguration()
        {
            return this._standardObjectAttachmentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StandardObjectConfigurations. 
        /// <para>
        /// Configuration of the Salesforce standard objects that Amazon Kendra indexes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=17)]
        public List<SalesforceStandardObjectConfiguration> StandardObjectConfigurations
        {
            get { return this._standardObjectConfigurations; }
            set { this._standardObjectConfigurations = value; }
        }

        // Check to see if StandardObjectConfigurations property is set
        internal bool IsSetStandardObjectConfigurations()
        {
            return this._standardObjectConfigurations != null && this._standardObjectConfigurations.Count > 0; 
        }

    }
}