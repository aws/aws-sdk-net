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
    /// Provides the configuration information to connect to Box as your data source.
    /// </summary>
    public partial class BoxConfiguration
    {
        private List<DataSourceToIndexFieldMapping> _commentFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private bool? _crawlComments;
        private bool? _crawlTasks;
        private bool? _crawlWebLinks;
        private string _enterpriseId;
        private List<string> _exclusionPatterns = new List<string>();
        private List<DataSourceToIndexFieldMapping> _fileFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private List<string> _inclusionPatterns = new List<string>();
        private string _secretArn;
        private List<DataSourceToIndexFieldMapping> _taskFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private bool? _useChangeLog;
        private DataSourceVpcConfiguration _vpcConfiguration;
        private List<DataSourceToIndexFieldMapping> _webLinkFieldMappings = new List<DataSourceToIndexFieldMapping>();

        /// <summary>
        /// Gets and sets the property CommentFieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map attributes or
        /// field names of Box comments to Amazon Kendra index field names. To create custom fields,
        /// use the <code>UpdateIndex</code> API before you map to Box fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Box field names must exist in your Box custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> CommentFieldMappings
        {
            get { return this._commentFieldMappings; }
            set { this._commentFieldMappings = value; }
        }

        // Check to see if CommentFieldMappings property is set
        internal bool IsSetCommentFieldMappings()
        {
            return this._commentFieldMappings != null && this._commentFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CrawlComments. 
        /// <para>
        ///  <code>TRUE</code> to index comments.
        /// </para>
        /// </summary>
        public bool CrawlComments
        {
            get { return this._crawlComments.GetValueOrDefault(); }
            set { this._crawlComments = value; }
        }

        // Check to see if CrawlComments property is set
        internal bool IsSetCrawlComments()
        {
            return this._crawlComments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrawlTasks. 
        /// <para>
        ///  <code>TRUE</code> to index the contents of tasks.
        /// </para>
        /// </summary>
        public bool CrawlTasks
        {
            get { return this._crawlTasks.GetValueOrDefault(); }
            set { this._crawlTasks = value; }
        }

        // Check to see if CrawlTasks property is set
        internal bool IsSetCrawlTasks()
        {
            return this._crawlTasks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrawlWebLinks. 
        /// <para>
        ///  <code>TRUE</code> to index web links.
        /// </para>
        /// </summary>
        public bool CrawlWebLinks
        {
            get { return this._crawlWebLinks.GetValueOrDefault(); }
            set { this._crawlWebLinks = value; }
        }

        // Check to see if CrawlWebLinks property is set
        internal bool IsSetCrawlWebLinks()
        {
            return this._crawlWebLinks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnterpriseId. 
        /// <para>
        /// The identifier of the Box Enterprise platform. You can find the enterprise ID in the
        /// Box Developer Console settings or when you create an app in Box and download your
        /// authentication credentials. For example, <i>801234567</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EnterpriseId
        {
            get { return this._enterpriseId; }
            set { this._enterpriseId = value; }
        }

        // Check to see if EnterpriseId property is set
        internal bool IsSetEnterpriseId()
        {
            return this._enterpriseId != null;
        }

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain files and folders from your
        /// Box platform. Files and folders that match the patterns are excluded from the index.Files
        /// and folders that don't match the patterns are included in the index. If a file or
        /// folder matches both an inclusion and exclusion pattern, the exclusion pattern takes
        /// precedence and the file or folder isn't included in the index.
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
        /// Gets and sets the property FileFieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map attributes or
        /// field names of Box files to Amazon Kendra index field names. To create custom fields,
        /// use the <code>UpdateIndex</code> API before you map to Box fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Box field names must exist in your Box custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> FileFieldMappings
        {
            get { return this._fileFieldMappings; }
            set { this._fileFieldMappings = value; }
        }

        // Check to see if FileFieldMappings property is set
        internal bool IsSetFileFieldMappings()
        {
            return this._fileFieldMappings != null && this._fileFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain files and folders in your
        /// Box platform. Files and folders that match the patterns are included in the index.
        /// Files and folders that don't match the patterns are excluded from the index. If a
        /// file or folder matches both an inclusion and exclusion pattern, the exclusion pattern
        /// takes precedence and the file or folder isn't included in the index.
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
        /// Gets and sets the property TaskFieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map attributes or
        /// field names of Box tasks to Amazon Kendra index field names. To create custom fields,
        /// use the <code>UpdateIndex</code> API before you map to Box fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Box field names must exist in your Box custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> TaskFieldMappings
        {
            get { return this._taskFieldMappings; }
            set { this._taskFieldMappings = value; }
        }

        // Check to see if TaskFieldMappings property is set
        internal bool IsSetTaskFieldMappings()
        {
            return this._taskFieldMappings != null && this._taskFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UseChangeLog. 
        /// <para>
        ///  <code>TRUE</code> to use the Slack change log to determine which documents require
        /// updating in the index. Depending on the data source change log's size, it may take
        /// longer for Amazon Kendra to use the change log than to scan all of your documents.
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
        /// Configuration information for an Amazon VPC to connect to your Box. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/vpc-configuration.html">Configuring
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

        /// <summary>
        /// Gets and sets the property WebLinkFieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map attributes or
        /// field names of Box web links to Amazon Kendra index field names. To create custom
        /// fields, use the <code>UpdateIndex</code> API before you map to Box fields. For more
        /// information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Box field names must exist in your Box custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> WebLinkFieldMappings
        {
            get { return this._webLinkFieldMappings; }
            set { this._webLinkFieldMappings = value; }
        }

        // Check to see if WebLinkFieldMappings property is set
        internal bool IsSetWebLinkFieldMappings()
        {
            return this._webLinkFieldMappings != null && this._webLinkFieldMappings.Count > 0; 
        }

    }
}