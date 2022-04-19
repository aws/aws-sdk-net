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
        /// A list of field mappings to apply when indexing Quip attachments.
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
        /// Specify whether to crawl attachments in your Quip data source. You can specify one
        /// or more of these options.
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
        /// Specify whether to crawl chat rooms in your Quip data source. You can specify one
        /// or more of these options.
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
        /// Specify whether to crawl file comments in your Quip data source. You can specify one
        /// or more of these options.
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
        /// The configuration information to connect to your Quip data source domain.
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
        /// The identifier of the Quip folder IDs to index.
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
        /// A list of field mappings to apply when indexing Quip messages.
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
        /// pairs that are required to connect to your Quip file system. Windows is currently
        /// the only supported type. The secret must contain a JSON structure with the following
        /// keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// username—The Active Directory user name, along with the Domain Name System (DNS) domain
        /// name. For example, <i>user@corp.example.com</i>. The Active Directory user account
        /// must have read and mounting access to the Quip file system for Windows.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// password—The password of the Active Directory user account with read and mounting
        /// access to the Quip Windows file system.
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
        /// A list of field mappings to apply when indexing Quip threads.
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
        /// Configuration information for connecting to an Amazon Virtual Private Cloud (VPC)
        /// for your Quip. Your Quip instance must reside inside your VPC.
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