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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIndex operation.
    /// Creates an Amazon Kendra index. Index creation is an asynchronous API. To determine
    /// if index creation has completed, check the <c>Status</c> field returned from a call
    /// to <c>DescribeIndex</c>. The <c>Status</c> field is set to <c>ACTIVE</c> when the
    /// index is ready to use.
    /// 
    ///  
    /// <para>
    /// Once the index is active, you can index your documents using the <c>BatchPutDocument</c>
    /// API or using one of the supported <a href="https://docs.aws.amazon.com/kendra/latest/dg/data-sources.html">data
    /// sources</a>.
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
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private UserContextPolicy _userContextPolicy;
        private UserGroupResolutionConfiguration _userGroupResolutionConfiguration;
        private List<UserTokenConfiguration> _userTokenConfigurations = AWSConfigs.InitializeCollections ? new List<UserTokenConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that you provide to identify the request to create an index. Multiple calls
        /// to the <c>CreateIndex</c> API with the same client token will create only one index.
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
        /// The Amazon Kendra edition to use for the index. Choose <c>DEVELOPER_EDITION</c> for
        /// indexes intended for development, testing, or proof of concept. Use <c>ENTERPRISE_EDITION</c>
        /// for production. Use <c>GEN_AI_ENTERPRISE_EDITION</c> for creating generative AI applications.
        /// Once you set the edition for an index, it can't be changed. 
        /// </para>
        ///  
        /// <para>
        /// The <c>Edition</c> parameter is optional. If you don't supply a value, the default
        /// is <c>ENTERPRISE_EDITION</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information on quota limits for Gen AI Enterprise Edition, Enterprise Edition,
        /// and Developer Edition indices, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserContextPolicy. 
        /// <para>
        /// The user context policy.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you're using an Amazon Kendra Gen AI Enterprise Edition index, you can only use
        /// <c>ATTRIBUTE_FILTER</c> to filter search results by user context. If you're using
        /// an Amazon Kendra Gen AI Enterprise Edition index and you try to use <c>USER_TOKEN</c>
        /// to configure user context policy, Amazon Kendra returns a <c>ValidationException</c>
        /// error.
        /// </para>
        ///  </important> <dl> <dt>ATTRIBUTE_FILTER</dt> <dd> 
        /// <para>
        /// All indexed content is searchable and displayable for all users. If you want to filter
        /// search results on user context, you can use the attribute filters of <c>_user_id</c>
        /// and <c>_group_ids</c> or you can provide user and group information in <c>UserContext</c>.
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
        /// Gets users and groups from IAM Identity Center identity source. To configure this,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_UserGroupResolutionConfiguration.html">UserGroupResolutionConfiguration</a>.
        /// This is useful for user context filtering, where search results are filtered based
        /// on the user or their group access to documents.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you're using an Amazon Kendra Gen AI Enterprise Edition index, <c>UserGroupResolutionConfiguration</c>
        /// isn't supported.
        /// </para>
        ///  </important>
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
        ///  <important> 
        /// <para>
        /// If you're using an Amazon Kendra Gen AI Enterprise Edition index and you try to use
        /// <c>UserTokenConfigurations</c> to configure user context policy, Amazon Kendra returns
        /// a <c>ValidationException</c> error.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._userTokenConfigurations != null && (this._userTokenConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}