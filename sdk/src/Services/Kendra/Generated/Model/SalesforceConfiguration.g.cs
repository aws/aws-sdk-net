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
    /// Provides the configuration information to connect to Salesforce as your data source.
    /// </summary>
    public partial class SalesforceConfiguration
    {
        /// <summary>
        /// Gets and sets the property ChatterFeedConfiguration. 
        /// <para>
        /// Configuration information for Salesforce chatter feeds.
        /// </para>
        /// </summary>
        public SalesforceChatterFeedConfiguration ChatterFeedConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ChatterFeedConfiguration property is set.
        /// </summary>
        internal bool IsSetChatterFeedConfiguration() => this.ChatterFeedConfiguration != null;

        /// <summary>
        /// Gets and sets the property CrawlAttachments. 
        /// <para>
        /// Indicates whether Amazon Kendra should index attachments to Salesforce objects.
        /// </para>
        /// </summary>
        public bool? CrawlAttachments { get; set; }

        /// <summary>
        /// Checks to see if the CrawlAttachments property is set.
        /// </summary>
        internal bool IsSetCrawlAttachments() => this.CrawlAttachments.HasValue;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public List<string> ExcludeAttachmentFilePatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludeAttachmentFilePatterns property is set.
        /// </summary>
        internal bool IsSetExcludeAttachmentFilePatterns() => this.ExcludeAttachmentFilePatterns != null && (this.ExcludeAttachmentFilePatterns.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public List<string> IncludeAttachmentFilePatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IncludeAttachmentFilePatterns property is set.
        /// </summary>
        internal bool IsSetIncludeAttachmentFilePatterns() => this.IncludeAttachmentFilePatterns != null && (this.IncludeAttachmentFilePatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KnowledgeArticleConfiguration. 
        /// <para>
        /// Configuration information for the knowledge article types that Amazon Kendra indexes.
        /// Amazon Kendra indexes standard knowledge articles and the standard fields of knowledge
        /// articles, or the custom fields of custom knowledge articles, but not both.
        /// </para>
        /// </summary>
        public SalesforceKnowledgeArticleConfiguration KnowledgeArticleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeArticleConfiguration property is set.
        /// </summary>
        internal bool IsSetKnowledgeArticleConfiguration() => this.KnowledgeArticleConfiguration != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 1284)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property ServerUrl. 
        /// <para>
        /// The instance URL for the Salesforce site that you want to index.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ServerUrl { get; set; }

        /// <summary>
        /// Checks to see if the ServerUrl property is set.
        /// </summary>
        internal bool IsSetServerUrl() => this.ServerUrl != null;

        /// <summary>
        /// Gets and sets the property StandardObjectAttachmentConfiguration. 
        /// <para>
        /// Configuration information for processing attachments to Salesforce standard objects.
        /// 
        /// </para>
        /// </summary>
        public SalesforceStandardObjectAttachmentConfiguration StandardObjectAttachmentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StandardObjectAttachmentConfiguration property is set.
        /// </summary>
        internal bool IsSetStandardObjectAttachmentConfiguration() => this.StandardObjectAttachmentConfiguration != null;

        /// <summary>
        /// Gets and sets the property StandardObjectConfigurations. 
        /// <para>
        /// Configuration of the Salesforce standard objects that Amazon Kendra indexes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 17)]
        public List<SalesforceStandardObjectConfiguration> StandardObjectConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<SalesforceStandardObjectConfiguration>() : null;

        /// <summary>
        /// Checks to see if the StandardObjectConfigurations property is set.
        /// </summary>
        internal bool IsSetStandardObjectConfigurations() => this.StandardObjectConfigurations != null && (this.StandardObjectConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
