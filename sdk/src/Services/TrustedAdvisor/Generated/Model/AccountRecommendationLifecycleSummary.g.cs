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

namespace Amazon.TrustedAdvisor.Model
{
    /// <summary>
    /// Summary of an AccountRecommendationLifecycle for an Organization Recommendation
    /// </summary>
    public partial class AccountRecommendationLifecycleSummary
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountRecommendationArn. 
        /// <para>
        /// The Recommendation ARN
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string AccountRecommendationArn { get; set; }

        /// <summary>
        /// Checks to see if the AccountRecommendationArn property is set.
        /// </summary>
        internal bool IsSetAccountRecommendationArn() => this.AccountRecommendationArn != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// When the Recommendation was last updated
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LifecycleStage. 
        /// <para>
        /// The lifecycle stage from AWS Trusted Advisor Priority
        /// </para>
        /// </summary>
        public RecommendationLifecycleStage LifecycleStage { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleStage property is set.
        /// </summary>
        internal bool IsSetLifecycleStage() => this.LifecycleStage != null;

        /// <summary>
        /// Gets and sets the property UpdateReason. 
        /// <para>
        /// Reason for the lifecycle stage change
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 10, Max = 4096)]
        public string UpdateReason { get; set; }

        /// <summary>
        /// Checks to see if the UpdateReason property is set.
        /// </summary>
        internal bool IsSetUpdateReason() => this.UpdateReason != null;

        /// <summary>
        /// Gets and sets the property UpdateReasonCode. 
        /// <para>
        /// Reason code for the lifecycle state change
        /// </para>
        /// </summary>
        public UpdateRecommendationLifecycleStageReasonCode UpdateReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the UpdateReasonCode property is set.
        /// </summary>
        internal bool IsSetUpdateReasonCode() => this.UpdateReasonCode != null;

        /// <summary>
        /// Gets and sets the property UpdatedOnBehalfOf. 
        /// <para>
        /// The person on whose behalf a Technical Account Manager (TAM) updated the recommendation.
        /// This information is only available when a Technical Account Manager takes an action
        /// on a recommendation managed by AWS Trusted Advisor Priority 
        /// </para>
        /// </summary>
        public string UpdatedOnBehalfOf { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedOnBehalfOf property is set.
        /// </summary>
        internal bool IsSetUpdatedOnBehalfOf() => this.UpdatedOnBehalfOf != null;

        /// <summary>
        /// Gets and sets the property UpdatedOnBehalfOfJobTitle. 
        /// <para>
        /// The job title of the person on whose behalf a Technical Account Manager (TAM) updated
        /// the recommendation. This information is only available when a Technical Account Manager
        /// takes an action on a recommendation managed by AWS Trusted Advisor Priority 
        /// </para>
        /// </summary>
        public string UpdatedOnBehalfOfJobTitle { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedOnBehalfOfJobTitle property is set.
        /// </summary>
        internal bool IsSetUpdatedOnBehalfOfJobTitle() => this.UpdatedOnBehalfOfJobTitle != null;
    }
}
