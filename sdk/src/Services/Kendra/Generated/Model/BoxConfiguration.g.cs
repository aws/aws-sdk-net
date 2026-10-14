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
    /// Provides the configuration information to connect to Box as your data source.
    /// </summary>
    public partial class BoxConfiguration
    {
        /// <summary>
        /// Gets and sets the property CommentFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of Box comments to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to Box fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Box field names must exist in your Box custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> CommentFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the CommentFieldMappings property is set.
        /// </summary>
        internal bool IsSetCommentFieldMappings() => this.CommentFieldMappings != null && (this.CommentFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CrawlComments. 
        /// <para>
        ///  <c>TRUE</c> to index comments.
        /// </para>
        /// </summary>
        public bool? CrawlComments { get; set; }

        /// <summary>
        /// Checks to see if the CrawlComments property is set.
        /// </summary>
        internal bool IsSetCrawlComments() => this.CrawlComments.HasValue;

        /// <summary>
        /// Gets and sets the property CrawlTasks. 
        /// <para>
        ///  <c>TRUE</c> to index the contents of tasks.
        /// </para>
        /// </summary>
        public bool? CrawlTasks { get; set; }

        /// <summary>
        /// Checks to see if the CrawlTasks property is set.
        /// </summary>
        internal bool IsSetCrawlTasks() => this.CrawlTasks.HasValue;

        /// <summary>
        /// Gets and sets the property CrawlWebLinks. 
        /// <para>
        ///  <c>TRUE</c> to index web links.
        /// </para>
        /// </summary>
        public bool? CrawlWebLinks { get; set; }

        /// <summary>
        /// Checks to see if the CrawlWebLinks property is set.
        /// </summary>
        internal bool IsSetCrawlWebLinks() => this.CrawlWebLinks.HasValue;

        /// <summary>
        /// Gets and sets the property EnterpriseId. 
        /// <para>
        /// The identifier of the Box Enterprise platform. You can find the enterprise ID in the
        /// Box Developer Console settings or when you create an app in Box and download your
        /// authentication credentials. For example, <i>801234567</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// Checks to see if the EnterpriseId property is set.
        /// </summary>
        internal bool IsSetEnterpriseId() => this.EnterpriseId != null;

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain files and folders from your
        /// Box platform. Files and folders that match the patterns are excluded from the index.Files
        /// and folders that don't match the patterns are included in the index. If a file or
        /// folder matches both an inclusion and exclusion pattern, the exclusion pattern takes
        /// precedence and the file or folder isn't included in the index.
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
        /// Gets and sets the property FileFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of Box files to Amazon Kendra index field names. To create custom fields, use
        /// the <c>UpdateIndex</c> API before you map to Box fields. For more information, see
        /// <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Box field names must exist in your Box custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> FileFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the FileFieldMappings property is set.
        /// </summary>
        internal bool IsSetFileFieldMappings() => this.FileFieldMappings != null && (this.FileFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain files and folders in your
        /// Box platform. Files and folders that match the patterns are included in the index.
        /// Files and folders that don't match the patterns are excluded from the index. If a
        /// file or folder matches both an inclusion and exclusion pattern, the exclusion pattern
        /// takes precedence and the file or folder isn't included in the index.
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
        /// pairs required to connect to your Box platform. The secret must contain a JSON structure
        /// with the following keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// clientID—The identifier of the client OAuth 2.0 authentication application created
        /// in Box.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// clientSecret—A set of characters known only to the OAuth 2.0 authentication application
        /// created in Box.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// publicKeyId—The identifier of the public key contained within an identity certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// privateKey—A set of characters that make up an encryption key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// passphrase—A set of characters that act like a password.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You create an application in Box to generate the keys or credentials required for
        /// the secret. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-box.html">Using
        /// a Box data source</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1284)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property TaskFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of Box tasks to Amazon Kendra index field names. To create custom fields, use
        /// the <c>UpdateIndex</c> API before you map to Box fields. For more information, see
        /// <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Box field names must exist in your Box custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> TaskFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the TaskFieldMappings property is set.
        /// </summary>
        internal bool IsSetTaskFieldMappings() => this.TaskFieldMappings != null && (this.TaskFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UseChangeLog. 
        /// <para>
        ///  <c>TRUE</c> to use the Slack change log to determine which documents require updating
        /// in the index. Depending on the data source change log's size, it may take longer for
        /// Amazon Kendra to use the change log than to scan all of your documents.
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
        /// Configuration information for an Amazon VPC to connect to your Box. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/vpc-configuration.html">Configuring
        /// a VPC</a>.
        /// </para>
        /// </summary>
        public DataSourceVpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;

        /// <summary>
        /// Gets and sets the property WebLinkFieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map attributes or field
        /// names of Box web links to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to Box fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Box field names must exist in your Box custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> WebLinkFieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the WebLinkFieldMappings property is set.
        /// </summary>
        internal bool IsSetWebLinkFieldMappings() => this.WebLinkFieldMappings != null && (this.WebLinkFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
