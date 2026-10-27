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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Summary information about a success criteria alarm snapshot captured for a test run.
    /// </summary>
    public partial class TestRunSuccessCriteriaAlarmSummary
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID that owns the CloudWatch alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AlarmArn. 
        /// <para>
        /// The ARN of the CloudWatch alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 31, Max = 1024)]
        public string AlarmArn { get; set; }

        /// <summary>
        /// Checks to see if the AlarmArn property is set.
        /// </summary>
        internal bool IsSetAlarmArn() => this.AlarmArn != null;

        /// <summary>
        /// Gets and sets the property AlarmName. 
        /// <para>
        /// The name of the CloudWatch alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AlarmName { get; set; }

        /// <summary>
        /// Checks to see if the AlarmName property is set.
        /// </summary>
        internal bool IsSetAlarmName() => this.AlarmName != null;

        /// <summary>
        /// Gets and sets the property Outcome. 
        /// <para>
        /// The evaluation outcome of the source. Absent while the source has not yet been evaluated;
        /// set to the terminal outcome afterwards.
        /// </para>
        /// </summary>
        public TestSourceOutcome Outcome { get; set; }

        /// <summary>
        /// Checks to see if the Outcome property is set.
        /// </summary>
        internal bool IsSetOutcome() => this.Outcome != null;

        /// <summary>
        /// Gets and sets the property OutcomeReason. 
        /// <para>
        /// A human-readable reason for the outcome.
        /// </para>
        /// </summary>
        public string OutcomeReason { get; set; }

        /// <summary>
        /// Checks to see if the OutcomeReason property is set.
        /// </summary>
        internal bool IsSetOutcomeReason() => this.OutcomeReason != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region of the CloudWatch alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;
    }
}
