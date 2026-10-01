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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains information about a reputation entity, including its reference,
    /// type, policy, status records, and reputation impact.
    /// </summary>
    public partial class ReputationEntity
    {
        /// <summary>
        /// Gets and sets the property AwsSesManagedStatus. 
        /// <para>
        /// The Amazon Web Services Amazon SES-managed status record for this reputation entity,
        /// including the current status, cause description, and last updated timestamp.
        /// </para>
        /// </summary>
        public StatusRecord AwsSesManagedStatus { get; set; }

        /// <summary>
        /// Checks to see if the AwsSesManagedStatus property is set.
        /// </summary>
        internal bool IsSetAwsSesManagedStatus() => this.AwsSesManagedStatus != null;

        /// <summary>
        /// Gets and sets the property CustomerManagedStatus. 
        /// <para>
        /// The customer-managed status record for this reputation entity, including the current
        /// status, cause description, and last updated timestamp.
        /// </para>
        /// </summary>
        public StatusRecord CustomerManagedStatus { get; set; }

        /// <summary>
        /// Checks to see if the CustomerManagedStatus property is set.
        /// </summary>
        internal bool IsSetCustomerManagedStatus() => this.CustomerManagedStatus != null;

        /// <summary>
        /// Gets and sets the property ReputationEntityReference. 
        /// <para>
        /// The unique identifier for the reputation entity. For resource-type entities, this
        /// is the Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ReputationEntityReference { get; set; }

        /// <summary>
        /// Checks to see if the ReputationEntityReference property is set.
        /// </summary>
        internal bool IsSetReputationEntityReference() => this.ReputationEntityReference != null;

        /// <summary>
        /// Gets and sets the property ReputationEntityType. 
        /// <para>
        /// The type of reputation entity. Currently, only <c>RESOURCE</c> type entities are supported.
        /// </para>
        /// </summary>
        public ReputationEntityType ReputationEntityType { get; set; }

        /// <summary>
        /// Checks to see if the ReputationEntityType property is set.
        /// </summary>
        internal bool IsSetReputationEntityType() => this.ReputationEntityType != null;

        /// <summary>
        /// Gets and sets the property ReputationImpact. 
        /// <para>
        /// The reputation impact level for this entity, representing the highest impact reputation
        /// finding currently active. Reputation findings can be retrieved using the <c>ListRecommendations</c>
        /// operation.
        /// </para>
        /// </summary>
        public RecommendationImpact ReputationImpact { get; set; }

        /// <summary>
        /// Checks to see if the ReputationImpact property is set.
        /// </summary>
        internal bool IsSetReputationImpact() => this.ReputationImpact != null;

        /// <summary>
        /// Gets and sets the property ReputationManagementPolicy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the reputation management policy applied to this
        /// entity. This is an Amazon Web Services Amazon SES-managed policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ReputationManagementPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ReputationManagementPolicy property is set.
        /// </summary>
        internal bool IsSetReputationManagementPolicy() => this.ReputationManagementPolicy != null;

        /// <summary>
        /// Gets and sets the property SendingStatusAggregate. 
        /// <para>
        /// The aggregate sending status that determines whether the entity is allowed to send
        /// emails. This status is derived from both the customer-managed and Amazon Web Services
        /// Amazon SES-managed statuses. If either the customer-managed status or the Amazon Web
        /// Services Amazon SES-managed status is <c>DISABLED</c>, the aggregate status will be
        /// <c>DISABLED</c> and the entity will not be allowed to send emails. When the customer-managed
        /// status is set to <c>REINSTATED</c>, the entity can continue sending even if there
        /// are active reputation findings, provided the Amazon Web Services Amazon SES-managed
        /// status also permits sending. The entity can only send emails when both statuses permit
        /// sending.
        /// </para>
        /// </summary>
        public SendingStatus SendingStatusAggregate { get; set; }

        /// <summary>
        /// Checks to see if the SendingStatusAggregate property is set.
        /// </summary>
        internal bool IsSetSendingStatusAggregate() => this.SendingStatusAggregate != null;
    }
}
