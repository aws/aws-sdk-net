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
    /// Container for the parameters to the UpdateIndex operation. Updates an Amazon Kendra
    /// index.
    /// </summary>
    public partial class UpdateIndexRequest : AmazonKendraRequest
    {
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
        public CapacityUnitsConfiguration CapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the CapacityUnits property is set.
        /// </summary>
        internal bool IsSetCapacityUnits() => this.CapacityUnits != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description for the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DocumentMetadataConfigurationUpdates. 
        /// <para>
        /// The document metadata configuration you want to update for the index. Document metadata
        /// are fields or attributes associated with your documents. For example, the company
        /// department name associated with each document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public List<DocumentMetadataConfiguration> DocumentMetadataConfigurationUpdates { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentMetadataConfiguration>() : null;

        /// <summary>
        /// Checks to see if the DocumentMetadataConfigurationUpdates property is set.
        /// </summary>
        internal bool IsSetDocumentMetadataConfigurationUpdates() => this.DocumentMetadataConfigurationUpdates != null && (this.DocumentMetadataConfigurationUpdates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the index you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A new name for the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// An Identity and Access Management (IAM) role that gives Amazon Kendra permission to
        /// access Amazon CloudWatch logs and metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

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
        public UserContextPolicy UserContextPolicy { get; set; }

        /// <summary>
        /// Checks to see if the UserContextPolicy property is set.
        /// </summary>
        internal bool IsSetUserContextPolicy() => this.UserContextPolicy != null;

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
        public UserGroupResolutionConfiguration UserGroupResolutionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the UserGroupResolutionConfiguration property is set.
        /// </summary>
        internal bool IsSetUserGroupResolutionConfiguration() => this.UserGroupResolutionConfiguration != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<UserTokenConfiguration> UserTokenConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<UserTokenConfiguration>() : null;

        /// <summary>
        /// Checks to see if the UserTokenConfigurations property is set.
        /// </summary>
        internal bool IsSetUserTokenConfigurations() => this.UserTokenConfigurations != null && (this.UserTokenConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
