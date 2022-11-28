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
    /// Provides the configuration information to connect to Quip as your data source.
    /// </summary>
    public partial class QuipConfiguration
    {
        private List<DataSourceToIndexFieldMapping> _attachmentFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private bool? _crawlAttachments;
        private bool? _crawlChatRooms;
        private bool? _crawlFileComments;
        private string _domain;
        private List<string> _exclusionPatterns = new List<string>();
        private List<string> _folderIds = new List<string>();
        private List<string> _inclusionPatterns = new List<string>();
        private List<DataSourceToIndexFieldMapping> _messageFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private string _secretArn;
        private List<DataSourceToIndexFieldMapping> _threadFieldMappings = new List<DataSourceToIndexFieldMapping>();
        private DataSourceVpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property AttachmentFieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map attributes or
        /// field names of Quip attachments to Amazon Kendra index field names. To create custom
        /// fields, use the <code>UpdateIndex</code> API before you map to Quip fields. For more
        /// information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Quip field names must exist in your Quip custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> AttachmentFieldMappings
        {
            get { return this._attachmentFieldMappings; }
            set { this._attachmentFieldMappings = value; }
        }

        // Check to see if AttachmentFieldMappings property is set
        internal bool IsSetAttachmentFieldMappings()
        {
            return this._attachmentFieldMappings != null && this._attachmentFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CrawlAttachments. 
        /// <para>
        ///  <code>TRUE</code> to index attachments.
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
        /// Gets and sets the property CrawlChatRooms. 
        /// <para>
        ///  <code>TRUE</code> to index the contents of chat rooms.
        /// </para>
        /// </summary>
        public bool CrawlChatRooms
        {
            get { return this._crawlChatRooms.GetValueOrDefault(); }
            set { this._crawlChatRooms = value; }
        }

        // Check to see if CrawlChatRooms property is set
        internal bool IsSetCrawlChatRooms()
        {
            return this._crawlChatRooms.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrawlFileComments. 
        /// <para>
        ///  <code>TRUE</code> to index file comments.
        /// </para>
        /// </summary>
        public bool CrawlFileComments
        {
            get { return this._crawlFileComments.GetValueOrDefault(); }
            set { this._crawlFileComments = value; }
        }

        // Check to see if CrawlFileComments property is set
        internal bool IsSetCrawlFileComments()
        {
            return this._crawlFileComments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The Quip site domain. For example, <i>https://quip-company.quipdomain.com/browse</i>.
        /// The domain in this example is "quipdomain".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain files in your Quip file system.
        /// Files that match the patterns are excluded from the index. Files that don’t match
        /// the patterns are included in the index. If a file matches both an inclusion pattern
        /// and an exclusion pattern, the exclusion pattern takes precedence, and the file isn't
        /// included in the index.
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
        /// Gets and sets the property FolderIds. 
        /// <para>
        /// The identifiers of the Quip folders you want to index. You can find the folder ID
        /// in your browser URL when you access your folder in Quip. For example, <i>https://quip-company.quipdomain.com/zlLuOVNSarTL/folder-name</i>.
        /// The folder ID in this example is "zlLuOVNSarTL".
        /// </para>
        /// </summary>
        public List<string> FolderIds
        {
            get { return this._folderIds; }
            set { this._folderIds = value; }
        }

        // Check to see if FolderIds property is set
        internal bool IsSetFolderIds()
        {
            return this._folderIds != null && this._folderIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain files in your Quip file system.
        /// Files that match the patterns are included in the index. Files that don't match the
        /// patterns are excluded from the index. If a file matches both an inclusion pattern
        /// and an exclusion pattern, the exclusion pattern takes precedence, and the file isn't
        /// included in the index.
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
        /// Gets and sets the property MessageFieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map attributes or
        /// field names of Quip messages to Amazon Kendra index field names. To create custom
        /// fields, use the <code>UpdateIndex</code> API before you map to Quip fields. For more
        /// information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Quip field names must exist in your Quip custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> MessageFieldMappings
        {
            get { return this._messageFieldMappings; }
            set { this._messageFieldMappings = value; }
        }

        // Check to see if MessageFieldMappings property is set
        internal bool IsSetMessageFieldMappings()
        {
            return this._messageFieldMappings != null && this._messageFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Secrets Manager secret that contains the key-value
        /// pairs that are required to connect to your Quip. The secret must contain a JSON structure
        /// with the following keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// accessToken—The token created in Quip. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-source-slack.html">Using
        /// a Quip data source</a>.
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
        /// Gets and sets the property ThreadFieldMappings. 
        /// <para>
        /// A list of <code>DataSourceToIndexFieldMapping</code> objects that map attributes or
        /// field names of Quip threads to Amazon Kendra index field names. To create custom fields,
        /// use the <code>UpdateIndex</code> API before you map to Quip fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Quip field names must exist in your Quip custom metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> ThreadFieldMappings
        {
            get { return this._threadFieldMappings; }
            set { this._threadFieldMappings = value; }
        }

        // Check to see if ThreadFieldMappings property is set
        internal bool IsSetThreadFieldMappings()
        {
            return this._threadFieldMappings != null && this._threadFieldMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Configuration information for an Amazon Virtual Private Cloud (VPC) to connect to
        /// your Quip. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/vpc-configuration.html">Configuring
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