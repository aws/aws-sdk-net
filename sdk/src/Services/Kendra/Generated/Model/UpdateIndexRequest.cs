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
    /// Container for the parameters to the UpdateIndex operation.
    /// Updates an Amazon Kendra index.
    /// </summary>
    public partial class UpdateIndexRequest : AmazonKendraRequest
    {
        private CapacityUnitsConfiguration _capacityUnits;
        private string _description;
        private List<DocumentMetadataConfiguration> _documentMetadataConfigurationUpdates = AWSConfigs.InitializeCollections ? new List<DocumentMetadataConfiguration>() : null;
        private string _id;
        private string _name;
        private string _roleArn;
        private UserContextPolicy _userContextPolicy;
        private UserGroupResolutionConfiguration _userGroupResolutionConfiguration;
        private List<UserTokenConfiguration> _userTokenConfigurations = AWSConfigs.InitializeCollections ? new List<UserTokenConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property CapacityUnits. 
        /// <para>
        /// Sets the number of additional document storage and query capacity units that should
        /// be used by the index. You can change the capacity of the index up to 5 times per day,
        /// or make 5 API calls.
        /// </para>
        ///  
        /// <para>
        /// If you are using extra storage units, you can't reduce the storage capacity below
        /// what is required to meet the storage needs for your index.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the index.
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
        /// Gets and sets the property DocumentMetadataConfigurationUpdates. 
        /// <para>
        /// The document metadata configuration you want to update for the index. Document metadata
        /// are fields or attributes associated with your documents. For example, the company
        /// department name associated with each document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<DocumentMetadataConfiguration> DocumentMetadataConfigurationUpdates
        {
            get { return this._documentMetadataConfigurationUpdates; }
            set { this._documentMetadataConfigurationUpdates = value; }
        }

        // Check to see if DocumentMetadataConfigurationUpdates property is set
        internal bool IsSetDocumentMetadataConfigurationUpdates()
        {
            return this._documentMetadataConfigurationUpdates != null && (this._documentMetadataConfigurationUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the index you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A new name for the index.
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
        /// An Identity and Access Management (IAM) role that gives Amazon Kendra permission to
        /// access Amazon CloudWatch logs and metrics.
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
        ///  </important>
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