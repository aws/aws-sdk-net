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
    /// This is the response object from the DescribeThesaurus operation.
    /// </summary>
    public partial class DescribeThesaurusResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _description;
        private string _errorMessage;
        private long? _fileSizeBytes;
        private string _id;
        private string _indexId;
        private string _name;
        private string _roleArn;
        private S3Path _sourceS3Path;
        private ThesaurusStatus _status;
        private long? _synonymRuleCount;
        private long? _termCount;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when the thesaurus was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The thesaurus description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// When the <code>Status</code> field value is <code>FAILED</code>, the <code>ErrorMessage</code>
        /// field provides more information. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property FileSizeBytes. 
        /// <para>
        /// The size of the thesaurus file in bytes.
        /// </para>
        /// </summary>
        public long FileSizeBytes
        {
            get { return this._fileSizeBytes.GetValueOrDefault(); }
            set { this._fileSizeBytes = value; }
        }

        // Check to see if FileSizeBytes property is set
        internal bool IsSetFileSizeBytes()
        {
            return this._fileSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the thesaurus.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index for the thesaurus.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The thesaurus name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// An IAM role that gives Amazon Kendra permissions to access thesaurus file specified
        /// in <code>SourceS3Path</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceS3Path.
        /// </summary>
        public S3Path SourceS3Path
        {
            get { return this._sourceS3Path; }
            set { this._sourceS3Path = value; }
        }

        // Check to see if SourceS3Path property is set
        internal bool IsSetSourceS3Path()
        {
            return this._sourceS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the thesaurus. When the value is <code>ACTIVE</code>, queries
        /// are able to use the thesaurus. If the <code>Status</code> field value is <code>FAILED</code>,
        /// the <code>ErrorMessage</code> field provides more information. 
        /// </para>
        ///  
        /// <para>
        /// If the status is <code>ACTIVE_BUT_UPDATE_FAILED</code>, it means that Amazon Kendra
        /// could not ingest the new thesaurus file. The old thesaurus file is still active. 
        /// </para>
        /// </summary>
        public ThesaurusStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SynonymRuleCount. 
        /// <para>
        /// The number of synonym rules in the thesaurus file.
        /// </para>
        /// </summary>
        public long SynonymRuleCount
        {
            get { return this._synonymRuleCount.GetValueOrDefault(); }
            set { this._synonymRuleCount = value; }
        }

        // Check to see if SynonymRuleCount property is set
        internal bool IsSetSynonymRuleCount()
        {
            return this._synonymRuleCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TermCount. 
        /// <para>
        /// The number of unique terms in the thesaurus file. For example, the synonyms <code>a,b,c</code>
        /// and <code>a=&gt;d</code>, the term count would be 4. 
        /// </para>
        /// </summary>
        public long TermCount
        {
            get { return this._termCount.GetValueOrDefault(); }
            set { this._termCount = value; }
        }

        // Check to see if TermCount property is set
        internal bool IsSetTermCount()
        {
            return this._termCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp when the thesaurus was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}