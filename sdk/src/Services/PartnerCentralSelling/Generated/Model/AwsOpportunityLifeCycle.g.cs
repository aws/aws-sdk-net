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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Tracks the lifecycle of the AWS opportunity, including stages such as qualification,
    /// validation, and closure. This field helps partners understand the current status and
    /// progression of the opportunity.
    /// </summary>
    public partial class AwsOpportunityLifeCycle
    {
        /// <summary>
        /// Gets and sets the property ClosedLostReason. 
        /// <para>
        /// Indicates the reason why an opportunity was marked as <c>Closed Lost</c>. This helps
        /// in understanding the context behind the lost opportunity and aids in refining future
        /// strategies.
        /// </para>
        /// </summary>
        public AwsClosedLostReason ClosedLostReason { get; set; }

        /// <summary>
        /// Checks to see if the ClosedLostReason property is set.
        /// </summary>
        internal bool IsSetClosedLostReason() => this.ClosedLostReason != null;

        /// <summary>
        /// Gets and sets the property NextSteps. 
        /// <para>
        /// Specifies the immediate next steps required to progress the opportunity. These steps
        /// are based on AWS guidance and the current stage of the opportunity.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string NextSteps { get; set; }

        /// <summary>
        /// Checks to see if the NextSteps property is set.
        /// </summary>
        internal bool IsSetNextSteps() => this.NextSteps != null;

        /// <summary>
        /// Gets and sets the property NextStepsHistory. 
        /// <para>
        /// Provides a historical log of previous next steps that were taken to move the opportunity
        /// forward. This helps in tracking the decision-making process and identifying any delays
        /// or obstacles encountered.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<ProfileNextStepsHistory> NextStepsHistory { get; set; } = AWSConfigs.InitializeCollections ? new List<ProfileNextStepsHistory>() : null;

        /// <summary>
        /// Checks to see if the NextStepsHistory property is set.
        /// </summary>
        internal bool IsSetNextStepsHistory() => this.NextStepsHistory != null && (this.NextStepsHistory.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// Represents the current stage of the opportunity in its lifecycle, such as <c>Qualification</c>,
        /// <c>Validation</c>, or <c>Closed Won</c>. This helps in understanding the opportunity's
        /// progress.
        /// </para>
        /// </summary>
        public AwsOpportunityStage Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;

        /// <summary>
        /// Gets and sets the property TargetCloseDate. 
        /// <para>
        /// Indicates the expected date by which the opportunity is projected to close. This field
        /// helps in planning resources and timelines for both the partner and AWS.
        /// </para>
        /// </summary>
        public string TargetCloseDate { get; set; }

        /// <summary>
        /// Checks to see if the TargetCloseDate property is set.
        /// </summary>
        internal bool IsSetTargetCloseDate() => this.TargetCloseDate != null;
    }
}
