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
    /// Container for the parameters to the CreateIndex operation.
    /// Creates an Amazon Kendra index. Index creation is an asynchronous API. To determine
    /// if index creation has completed, check the <code>Status</code> field returned from
    /// a call to <code>DescribeIndex</code>. The <code>Status</code> field is set to <code>ACTIVE</code>
    /// when the index is ready to use.
    /// 
    ///  
    /// <para>
    /// Once the index is active you can index your documents using the <code>BatchPutDocument</code>
    /// API or using one of the supported data sources.
    /// </para>
    ///  
    /// <para>
    /// For an example of creating an index and data source using the Python SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-python.html">Getting
    /// started with Python SDK</a>. For an example of creating an index and data source using
    /// the Java SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-java.html">Getting
    /// started with Java SDK</a>.
    /// </para>
    /// </summary>
    public partial class CreateIndexRequest : AmazonKendraRequest
    {
        private string _clientToken;
        private string _description;
        private IndexEdition _edition;
        private string _name;
        private string _roleArn;
        private ServerSideEncryptionConfiguration _serverSideEncryptionConfiguration;
        private List<Tag> _tags = new List<Tag>();
        private UserContextPolicy _userContextPolicy;
        private UserGroupResolutionConfiguration _userGroupResolutionConfiguration;
        private List<UserTokenConfiguration> _userTokenConfigurations = new List<UserTokenConfiguration>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that you provide to identify the request to create an index. Multiple calls
        /// to the <code>CreateIndex</code> API with the same client token will create only one
        /// index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the index.
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
        /// Gets and sets the property Edition. 
        /// <para>
        /// The Amazon Kendra edition to use for the index. Choose <code>DEVELOPER_EDITION</code>
        /// for indexes intended for development, testing, or proof of concept. Use <code>ENTERPRISE_EDITION</code>
        /// for production. Once you set the edition for an index, it can't be changed.
        /// </para>
        ///  
        /// <para>
        /// The <code>Edition</code> parameter is optional. If you don't supply a value, the default
        /// is <code>ENTERPRISE_EDITION</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information on quota limits for Enterprise and Developer editions, see <a
        /// href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the index.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
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
        /// The Amazon Resource Name (ARN) of an IAM role with permission to access your Amazon
        /// CloudWatch logs and metrics. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/iam-roles.html">IAM
        /// access roles for Amazon Kendra</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1284)]
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
        /// The identifier of the KMS customer managed key (CMK) that's used to encrypt data indexed
        /// by Amazon Kendra. Amazon Kendra doesn't support asymmetric CMKs.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that identify or categorize the index. You can also use
        /// tags to help control access to the index. Tag keys and values can consist of Unicode
        /// letters, digits, white space, and any of the following symbols: _ . : / = + - @.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserContextPolicy. 
        /// <para>
        /// The user context policy.
        /// </para>
        ///  <dl> <dt>ATTRIBUTE_FILTER</dt> <dd> 
        /// <para>
        /// All indexed content is searchable and displayable for all users. If you want to filter
        /// search results on user context, you can use the attribute filters of <code>_user_id</code>
        /// and <code>_group_ids</code> or you can provide user and group information in <code>UserContext</code>.
        /// 
        /// </para>
        ///  </dd> <dt>USER_TOKEN</dt> <dd> 
        /// <para>
        /// Enables token-based user access control to filter search results on user context.
        /// All documents with no access control and all documents accessible to the user will
        /// be searchable and displayable. 
        /// </para>
        ///  </dd> </dl>
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
        /// Gets users and groups from IAM Identity Center (successor to Single Sign-On) identity
        /// source. To configure this, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_UserGroupResolutionConfiguration.html">UserGroupResolutionConfiguration</a>.
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
        /// The user token configuration.
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