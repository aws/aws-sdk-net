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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
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
namespace Amazon.TrustedAdvisor.Model
{
    /// <summary>
    /// Summary of an AccountRecommendationLifecycle for an Organization Recommendation
    /// </summary>
    public partial class AccountRecommendationLifecycleSummary
    {
        private string _accountId;
        private string _accountRecommendationArn;
        private DateTime? _lastUpdatedAt;
        private RecommendationLifecycleStage _lifecycleStage;
        private string _updatedOnBehalfOf;
        private string _updatedOnBehalfOfJobTitle;
        private string _updateReason;
        private UpdateRecommendationLifecycleStageReasonCode _updateReasonCode;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AccountRecommendationArn. 
        /// <para>
        /// The Recommendation ARN
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string AccountRecommendationArn
        {
            get { return this._accountRecommendationArn; }
            set { this._accountRecommendationArn = value; }
        }

        // Check to see if AccountRecommendationArn property is set
        internal bool IsSetAccountRecommendationArn()
        {
            return this._accountRecommendationArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// When the Recommendation was last updated
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LifecycleStage. 
        /// <para>
        /// The lifecycle stage from AWS Trusted Advisor Priority
        /// </para>
        /// </summary>
        public RecommendationLifecycleStage LifecycleStage
        {
            get { return this._lifecycleStage; }
            set { this._lifecycleStage = value; }
        }

        // Check to see if LifecycleStage property is set
        internal bool IsSetLifecycleStage()
        {
            return this._lifecycleStage != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedOnBehalfOf. 
        /// <para>
        /// The person on whose behalf a Technical Account Manager (TAM) updated the recommendation.
        /// This information is only available when a Technical Account Manager takes an action
        /// on a recommendation managed by AWS Trusted Advisor Priority 
        /// </para>
        /// </summary>
        public string UpdatedOnBehalfOf
        {
            get { return this._updatedOnBehalfOf; }
            set { this._updatedOnBehalfOf = value; }
        }

        // Check to see if UpdatedOnBehalfOf property is set
        internal bool IsSetUpdatedOnBehalfOf()
        {
            return this._updatedOnBehalfOf != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedOnBehalfOfJobTitle. 
        /// <para>
        /// The job title of the person on whose behalf a Technical Account Manager (TAM) updated
        /// the recommendation. This information is only available when a Technical Account Manager
        /// takes an action on a recommendation managed by AWS Trusted Advisor Priority 
        /// </para>
        /// </summary>
        public string UpdatedOnBehalfOfJobTitle
        {
            get { return this._updatedOnBehalfOfJobTitle; }
            set { this._updatedOnBehalfOfJobTitle = value; }
        }

        // Check to see if UpdatedOnBehalfOfJobTitle property is set
        internal bool IsSetUpdatedOnBehalfOfJobTitle()
        {
            return this._updatedOnBehalfOfJobTitle != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateReason. 
        /// <para>
        /// Reason for the lifecycle stage change
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=10, Max=4096)]
        public string UpdateReason
        {
            get { return this._updateReason; }
            set { this._updateReason = value; }
        }

        // Check to see if UpdateReason property is set
        internal bool IsSetUpdateReason()
        {
            return this._updateReason != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateReasonCode. 
        /// <para>
        /// Reason code for the lifecycle state change
        /// </para>
        /// </summary>
        public UpdateRecommendationLifecycleStageReasonCode UpdateReasonCode
        {
            get { return this._updateReasonCode; }
            set { this._updateReasonCode = value; }
        }

        // Check to see if UpdateReasonCode property is set
        internal bool IsSetUpdateReasonCode()
        {
            return this._updateReasonCode != null;
        }

    }
}