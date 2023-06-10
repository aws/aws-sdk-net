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
    /// This is the response object from the DescribeIndex operation.
    /// </summary>
    public partial class DescribeIndexResponse : AmazonWebServiceResponse
    {
        private CapacityUnitsConfiguration _capacityUnits;
        private DateTime? _createdAt;
        private string _description;
        private List<DocumentMetadataConfiguration> _documentMetadataConfigurations = new List<DocumentMetadataConfiguration>();
        private IndexEdition _edition;
        private string _errorMessage;
        private string _id;
        private IndexStatistics _indexStatistics;
        private string _name;
        private string _roleArn;
        private ServerSideEncryptionConfiguration _serverSideEncryptionConfiguration;
        private IndexStatus _status;
        private DateTime? _updatedAt;
        private UserContextPolicy _userContextPolicy;
        private UserGroupResolutionConfiguration _userGroupResolutionConfiguration;
        private List<UserTokenConfiguration> _userTokenConfigurations = new List<UserTokenConfiguration>();

        /// <summary>
        /// Gets and sets the property CapacityUnits. 
        /// <para>
        /// For Enterprise Edition indexes, you can choose to use additional capacity to meet
        /// the needs of your application. This contains the capacity units used for the index.
        /// A query or document storage capacity of zero indicates that the index is using the
        /// default capacity. For more information on the default capacity for an index and adjusting
        /// this, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/adjusting-capacity.html">Adjusting
        /// capacity</a>.
        /// </para>
        /// </summary>
        public CapacityUnitsConfiguration CapacityUnits
        {
            get { return this._capacityUnits; }
            set { this._capacityUnits = value; }
        }

        // Check to see if CapacityUnits property is set
        internal bool IsSetCapacityUnits()
        {
            return this._capacityUnits != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when the index was created.
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
        /// The description for the index.
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
        /// Gets and sets the property DocumentMetadataConfigurations. 
        /// <para>
        /// Configuration information for document metadata or fields. Document metadata are fields
        /// or attributes associated with your documents. For example, the company department
        /// name associated with each document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<DocumentMetadataConfiguration> DocumentMetadataConfigurations
        {
            get { return this._documentMetadataConfigurations; }
            set { this._documentMetadataConfigurations = value; }
        }

        // Check to see if DocumentMetadataConfigurations property is set
        internal bool IsSetDocumentMetadataConfigurations()
        {
            return this._documentMetadataConfigurations != null && this._documentMetadataConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Edition. 
        /// <para>
        /// The Amazon Kendra edition used for the index. You decide the edition when you create
        /// the index.
        /// </para>
        /// </summary>
        public IndexEdition Edition
        {
            get { return this._edition; }
            set { this._edition = value; }
        }

        // Check to see if Edition property is set
        internal bool IsSetEdition()
        {
            return this._edition != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// When the <code>Status</code> field value is <code>FAILED</code>, the <code>ErrorMessage</code>
        /// field contains a message that explains why.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property IndexStatistics. 
        /// <para>
        /// Provides information about the number of FAQ questions and answers and the number
        /// of text documents indexed.
        /// </para>
        /// </summary>
        public IndexStatistics IndexStatistics
        {
            get { return this._indexStatistics; }
            set { this._indexStatistics = value; }
        }

        // Check to see if IndexStatistics property is set
        internal bool IsSetIndexStatistics()
        {
            return this._indexStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// The Amazon Resource Name (ARN) of the IAM role that gives Amazon Kendra permission
        /// to write to your Amazon Cloudwatch logs.
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
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// The identifier of the KMScustomer master key (CMK) that is used to encrypt your data.
        /// Amazon Kendra doesn't support asymmetric CMKs.
        /// </para>
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration
        {
            get { return this._serverSideEncryptionConfiguration; }
            set { this._serverSideEncryptionConfiguration = value; }
        }

        // Check to see if ServerSideEncryptionConfiguration property is set
        internal bool IsSetServerSideEncryptionConfiguration()
        {
            return this._serverSideEncryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the index. When the value is <code>ACTIVE</code>, the index
        /// is ready for use. If the <code>Status</code> field value is <code>FAILED</code>, the
        /// <code>ErrorMessage</code> field contains a message that explains why.
        /// </para>
        /// </summary>
        public IndexStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix when the index was last updated.
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

        /// <summary>
        /// Gets and sets the property UserContextPolicy. 
        /// <para>
        /// The user context policy for the Amazon Kendra index.
        /// </para>
        /// </summary>
        public UserContextPolicy UserContextPolicy
        {
            get { return this._userContextPolicy; }
            set { this._userContextPolicy = value; }
        }

        // Check to see if UserContextPolicy property is set
        internal bool IsSetUserContextPolicy()
        {
            return this._userContextPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property UserGroupResolutionConfiguration. 
        /// <para>
        /// Whether you have enabled the configuration for fetching access levels of groups and
        /// users from an IAM Identity Center (successor to Single Sign-On) identity source.
        /// </para>
        /// </summary>
        public UserGroupResolutionConfiguration UserGroupResolutionConfiguration
        {
            get { return this._userGroupResolutionConfiguration; }
            set { this._userGroupResolutionConfiguration = value; }
        }

        // Check to see if UserGroupResolutionConfiguration property is set
        internal bool IsSetUserGroupResolutionConfiguration()
        {
            return this._userGroupResolutionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property UserTokenConfigurations. 
        /// <para>
        /// The user token configuration for the Amazon Kendra index.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<UserTokenConfiguration> UserTokenConfigurations
        {
            get { return this._userTokenConfigurations; }
            set { this._userTokenConfigurations = value; }
        }

        // Check to see if UserTokenConfigurations property is set
        internal bool IsSetUserTokenConfigurations()
        {
            return this._userTokenConfigurations != null && this._userTokenConfigurations.Count > 0; 
        }

    }
}