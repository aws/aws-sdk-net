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
    /// Container for the parameters to the UpdateOrganizationRecommendationLifecycle operation.
    /// Update the lifecycle of a Recommendation within an Organization. This API only supports
    /// prioritized recommendations.
    /// </summary>
    public partial class UpdateOrganizationRecommendationLifecycleRequest : AmazonTrustedAdvisorRequest
    {
        private UpdateRecommendationLifecycleStage _lifecycleStage;
        private string _organizationRecommendationIdentifier;
        private string _updateReason;
        private UpdateRecommendationLifecycleStageReasonCode _updateReasonCode;

        /// <summary>
        /// Gets and sets the property LifecycleStage. 
        /// <para>
        /// The new lifecycle stage
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateRecommendationLifecycleStage LifecycleStage
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
        /// Gets and sets the property OrganizationRecommendationIdentifier. 
        /// <para>
        /// The Recommendation identifier for AWS Trusted Advisor Priority recommendations
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=200)]
        public string OrganizationRecommendationIdentifier
        {
            get { return this._organizationRecommendationIdentifier; }
            set { this._organizationRecommendationIdentifier = value; }
        }

        // Check to see if OrganizationRecommendationIdentifier property is set
        internal bool IsSetOrganizationRecommendationIdentifier()
        {
            return this._organizationRecommendationIdentifier != null;
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