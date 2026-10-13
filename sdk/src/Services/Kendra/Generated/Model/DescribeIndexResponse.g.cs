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
    /// This is the response object from the DescribeIndex operation.
    /// </summary>
    public partial class DescribeIndexResponse : AmazonWebServiceResponse
    {
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
        public CapacityUnitsConfiguration CapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the CapacityUnits property is set.
        /// </summary>
        internal bool IsSetCapacityUnits() => this.CapacityUnits != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when the index was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DocumentMetadataConfigurations. 
        /// <para>
        /// Configuration information for document metadata or fields. Document metadata are fields
        /// or attributes associated with your documents. For example, the company department
        /// name associated with each document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public List<DocumentMetadataConfiguration> DocumentMetadataConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentMetadataConfiguration>() : null;

        /// <summary>
        /// Checks to see if the DocumentMetadataConfigurations property is set.
        /// </summary>
        internal bool IsSetDocumentMetadataConfigurations() => this.DocumentMetadataConfigurations != null && (this.DocumentMetadataConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Edition. 
        /// <para>
        /// The Amazon Kendra edition used for the index. You decide the edition when you create
        /// the index.
        /// </para>
        /// </summary>
        public IndexEdition Edition { get; set; }

        /// <summary>
        /// Checks to see if the Edition property is set.
        /// </summary>
        internal bool IsSetEdition() => this.Edition != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// When the <c>Status</c> field value is <c>FAILED</c>, the <c>ErrorMessage</c> field
        /// contains a message that explains why.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IndexStatistics. 
        /// <para>
        /// Provides information about the number of FAQ questions and answers and the number
        /// of text documents indexed.
        /// </para>
        /// </summary>
        public IndexStatistics IndexStatistics { get; set; }

        /// <summary>
        /// Checks to see if the IndexStatistics property is set.
        /// </summary>
        internal bool IsSetIndexStatistics() => this.IndexStatistics != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the index.
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
        /// The Amazon Resource Name (ARN) of the IAM role that gives Amazon Kendra permission
        /// to write to your Amazon CloudWatch logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// The identifier of the KMS customer master key (CMK) that is used to encrypt your data.
        /// Amazon Kendra doesn't support asymmetric CMKs.
        /// </para>
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetServerSideEncryptionConfiguration() => this.ServerSideEncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the index. When the value is <c>ACTIVE</c>, the index is ready
        /// for use. If the <c>Status</c> field value is <c>FAILED</c>, the <c>ErrorMessage</c>
        /// field contains a message that explains why.
        /// </para>
        /// </summary>
        public IndexStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp when the index was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UserContextPolicy. 
        /// <para>
        /// The user context policy for the Amazon Kendra index.
        /// </para>
        /// </summary>
        public UserContextPolicy UserContextPolicy { get; set; }

        /// <summary>
        /// Checks to see if the UserContextPolicy property is set.
        /// </summary>
        internal bool IsSetUserContextPolicy() => this.UserContextPolicy != null;

        /// <summary>
        /// Gets and sets the property UserGroupResolutionConfiguration. 
        /// <para>
        /// Whether you have enabled IAM Identity Center identity source for your users and groups.
        /// This is useful for user context filtering, where search results are filtered based
        /// on the user or their group access to documents.
        /// </para>
        /// </summary>
        public UserGroupResolutionConfiguration UserGroupResolutionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the UserGroupResolutionConfiguration property is set.
        /// </summary>
        internal bool IsSetUserGroupResolutionConfiguration() => this.UserGroupResolutionConfiguration != null;

        /// <summary>
        /// Gets and sets the property UserTokenConfigurations. 
        /// <para>
        /// The user token configuration for the Amazon Kendra index.
        /// </para>
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
