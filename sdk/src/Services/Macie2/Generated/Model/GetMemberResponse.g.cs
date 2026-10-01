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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetMember operation.
    /// </summary>
    public partial class GetMemberResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the account.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AdministratorAccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the administrator account.
        /// </para>
        /// </summary>
        public string AdministratorAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AdministratorAccountId property is set.
        /// </summary>
        internal bool IsSetAdministratorAccountId() => this.AdministratorAccountId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the account.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address for the account. This value is null if the account is associated
        /// with the administrator account through Organizations.
        /// </para>
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property InvitedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when an Amazon Macie membership
        /// invitation was last sent to the account. This value is null if a Macie membership
        /// invitation hasn't been sent to the account.
        /// </para>
        /// </summary>
        public DateTime? InvitedAt { get; set; }

        /// <summary>
        /// Checks to see if the InvitedAt property is set.
        /// </summary>
        internal bool IsSetInvitedAt() => this.InvitedAt.HasValue;

        /// <summary>
        /// Gets and sets the property MasterAccountId. 
        /// <para>
        /// (Deprecated) The Amazon Web Services account ID for the administrator account. This
        /// property has been replaced by the administratorAccountId property and is retained
        /// only for backward compatibility.
        /// </para>
        /// </summary>
        public string MasterAccountId { get; set; }

        /// <summary>
        /// Checks to see if the MasterAccountId property is set.
        /// </summary>
        internal bool IsSetMasterAccountId() => this.MasterAccountId != null;

        /// <summary>
        /// Gets and sets the property RelationshipStatus. 
        /// <para>
        /// The current status of the relationship between the account and the administrator account.
        /// </para>
        /// </summary>
        public RelationshipStatus RelationshipStatus { get; set; }

        /// <summary>
        /// Checks to see if the RelationshipStatus property is set.
        /// </summary>
        internal bool IsSetRelationshipStatus() => this.RelationshipStatus != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs that specifies which tags (keys and values) are associated
        /// with the account in Amazon Macie.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, of the most recent change
        /// to the status of the relationship between the account and the administrator account.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
