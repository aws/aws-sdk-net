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
    /// Container for the parameters to the UpdateRecommendationLifecycle operation. Update
    /// the lifecyle of a Recommendation. This API only supports prioritized recommendations
    /// and updates global priority recommendations, eliminating the need to call the API
    /// in each AWS Region.
    /// </summary>
    public partial class UpdateRecommendationLifecycleRequest : AmazonTrustedAdvisorRequest
    {
        /// <summary>
        /// Gets and sets the property LifecycleStage. 
        /// <para>
        /// The new lifecycle stage
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UpdateRecommendationLifecycleStage LifecycleStage { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleStage property is set.
        /// </summary>
        internal bool IsSetLifecycleStage() => this.LifecycleStage != null;

        /// <summary>
        /// Gets and sets the property RecommendationIdentifier. 
        /// <para>
        /// The Recommendation identifier for AWS Trusted Advisor Priority recommendations
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 200)]
        public string RecommendationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationIdentifier property is set.
        /// </summary>
        internal bool IsSetRecommendationIdentifier() => this.RecommendationIdentifier != null;

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
    }
}
