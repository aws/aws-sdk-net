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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
        private StatusRecord _awsSesManagedStatus;
        private StatusRecord _customerManagedStatus;
        private string _reputationEntityReference;
        private ReputationEntityType _reputationEntityType;
        private RecommendationImpact _reputationImpact;
        private string _reputationManagementPolicy;
        private SendingStatus _sendingStatusAggregate;

        /// <summary>
        /// Gets and sets the property AwsSesManagedStatus. 
        /// <para>
        /// The Amazon Web Services Amazon SES-managed status record for this reputation entity,
        /// including the current status, cause description, and last updated timestamp.
        /// </para>
        /// </summary>
        public StatusRecord AwsSesManagedStatus
        {
            get { return this._awsSesManagedStatus; }
            set { this._awsSesManagedStatus = value; }
        }

        // Check to see if AwsSesManagedStatus property is set
        internal bool IsSetAwsSesManagedStatus()
        {
            return this._awsSesManagedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerManagedStatus. 
        /// <para>
        /// The customer-managed status record for this reputation entity, including the current
        /// status, cause description, and last updated timestamp.
        /// </para>
        /// </summary>
        public StatusRecord CustomerManagedStatus
        {
            get { return this._customerManagedStatus; }
            set { this._customerManagedStatus = value; }
        }

        // Check to see if CustomerManagedStatus property is set
        internal bool IsSetCustomerManagedStatus()
        {
            return this._customerManagedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ReputationEntityReference. 
        /// <para>
        /// The unique identifier for the reputation entity. For resource-type entities, this
        /// is the Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ReputationEntityReference
        {
            get { return this._reputationEntityReference; }
            set { this._reputationEntityReference = value; }
        }

        // Check to see if ReputationEntityReference property is set
        internal bool IsSetReputationEntityReference()
        {
            return this._reputationEntityReference != null;
        }

        /// <summary>
        /// Gets and sets the property ReputationEntityType. 
        /// <para>
        /// The type of reputation entity. Currently, only <c>RESOURCE</c> type entities are supported.
        /// </para>
        /// </summary>
        public ReputationEntityType ReputationEntityType
        {
            get { return this._reputationEntityType; }
            set { this._reputationEntityType = value; }
        }

        // Check to see if ReputationEntityType property is set
        internal bool IsSetReputationEntityType()
        {
            return this._reputationEntityType != null;
        }

        /// <summary>
        /// Gets and sets the property ReputationImpact. 
        /// <para>
        /// The reputation impact level for this entity, representing the highest impact reputation
        /// finding currently active. Reputation findings can be retrieved using the <c>ListRecommendations</c>
        /// operation.
        /// </para>
        /// </summary>
        public RecommendationImpact ReputationImpact
        {
            get { return this._reputationImpact; }
            set { this._reputationImpact = value; }
        }

        // Check to see if ReputationImpact property is set
        internal bool IsSetReputationImpact()
        {
            return this._reputationImpact != null;
        }

        /// <summary>
        /// Gets and sets the property ReputationManagementPolicy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the reputation management policy applied to this
        /// entity. This is an Amazon Web Services Amazon SES-managed policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ReputationManagementPolicy
        {
            get { return this._reputationManagementPolicy; }
            set { this._reputationManagementPolicy = value; }
        }

        // Check to see if ReputationManagementPolicy property is set
        internal bool IsSetReputationManagementPolicy()
        {
            return this._reputationManagementPolicy != null;
        }

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
        public SendingStatus SendingStatusAggregate
        {
            get { return this._sendingStatusAggregate; }
            set { this._sendingStatusAggregate = value; }
        }

        // Check to see if SendingStatusAggregate property is set
        internal bool IsSetSendingStatusAggregate()
        {
            return this._sendingStatusAggregate != null;
        }

    }
}