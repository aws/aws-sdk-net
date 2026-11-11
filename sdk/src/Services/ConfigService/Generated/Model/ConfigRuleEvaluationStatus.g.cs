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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Status information for your Config Managed rules and Config Custom Policy rules. The
    /// status includes information such as the last time the rule ran, the last time it failed,
    /// and the related error for the last failure.
    /// 
    ///  
    /// <para>
    /// This operation does not return status information about Config Custom Lambda rules.
    /// </para>
    /// </summary>
    public partial class ConfigRuleEvaluationStatus
    {
        /// <summary>
        /// Gets and sets the property ConfigRuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Config rule.
        /// </para>
        /// </summary>
        public string ConfigRuleArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfigRuleArn property is set.
        /// </summary>
        internal bool IsSetConfigRuleArn() => this.ConfigRuleArn != null;

        /// <summary>
        /// Gets and sets the property ConfigRuleId. 
        /// <para>
        /// The ID of the Config rule.
        /// </para>
        /// </summary>
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigRuleId property is set.
        /// </summary>
        internal bool IsSetConfigRuleId() => this.ConfigRuleId != null;

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of the Config rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ConfigRuleName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigRuleName property is set.
        /// </summary>
        internal bool IsSetConfigRuleName() => this.ConfigRuleName != null;

        /// <summary>
        /// Gets and sets the property FirstActivatedTime. 
        /// <para>
        /// The time that you first activated the Config rule.
        /// </para>
        /// </summary>
        public DateTime? FirstActivatedTime { get; set; }

        /// <summary>
        /// Checks to see if the FirstActivatedTime property is set.
        /// </summary>
        internal bool IsSetFirstActivatedTime() => this.FirstActivatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property FirstEvaluationStarted. 
        /// <para>
        /// Indicates whether Config has evaluated your resources against the rule at least once.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>true</c> - Config has evaluated your Amazon Web Services resources against the
        /// rule at least once.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>false</c> - Config has not finished evaluating your Amazon Web Services resources
        /// against the rule at least once.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? FirstEvaluationStarted { get; set; }

        /// <summary>
        /// Checks to see if the FirstEvaluationStarted property is set.
        /// </summary>
        internal bool IsSetFirstEvaluationStarted() => this.FirstEvaluationStarted.HasValue;

        /// <summary>
        /// Gets and sets the property LastDeactivatedTime. 
        /// <para>
        /// The time that you last turned off the Config rule.
        /// </para>
        /// </summary>
        public DateTime? LastDeactivatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastDeactivatedTime property is set.
        /// </summary>
        internal bool IsSetLastDeactivatedTime() => this.LastDeactivatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastDebugLogDeliveryStatus. 
        /// <para>
        /// The status of the last attempted delivery of a debug log for your Config Custom Policy
        /// rules. Either <c>Successful</c> or <c>Failed</c>.
        /// </para>
        /// </summary>
        public string LastDebugLogDeliveryStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastDebugLogDeliveryStatus property is set.
        /// </summary>
        internal bool IsSetLastDebugLogDeliveryStatus() => this.LastDebugLogDeliveryStatus != null;

        /// <summary>
        /// Gets and sets the property LastDebugLogDeliveryStatusReason. 
        /// <para>
        /// The reason Config was not able to deliver a debug log. This is for the last failed
        /// attempt to retrieve a debug log for your Config Custom Policy rules.
        /// </para>
        /// </summary>
        public string LastDebugLogDeliveryStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the LastDebugLogDeliveryStatusReason property is set.
        /// </summary>
        internal bool IsSetLastDebugLogDeliveryStatusReason() => this.LastDebugLogDeliveryStatusReason != null;

        /// <summary>
        /// Gets and sets the property LastDebugLogDeliveryTime. 
        /// <para>
        /// The time Config last attempted to deliver a debug log for your Config Custom Policy
        /// rules.
        /// </para>
        /// </summary>
        public DateTime? LastDebugLogDeliveryTime { get; set; }

        /// <summary>
        /// Checks to see if the LastDebugLogDeliveryTime property is set.
        /// </summary>
        internal bool IsSetLastDebugLogDeliveryTime() => this.LastDebugLogDeliveryTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastErrorCode. 
        /// <para>
        /// The error code that Config returned when the rule last failed.
        /// </para>
        /// </summary>
        public string LastErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the LastErrorCode property is set.
        /// </summary>
        internal bool IsSetLastErrorCode() => this.LastErrorCode != null;

        /// <summary>
        /// Gets and sets the property LastErrorMessage. 
        /// <para>
        /// The error message that Config returned when the rule last failed.
        /// </para>
        /// </summary>
        public string LastErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the LastErrorMessage property is set.
        /// </summary>
        internal bool IsSetLastErrorMessage() => this.LastErrorMessage != null;

        /// <summary>
        /// Gets and sets the property LastFailedEvaluationTime. 
        /// <para>
        /// The time that Config last failed to evaluate your Amazon Web Services resources against
        /// the rule.
        /// </para>
        /// </summary>
        public DateTime? LastFailedEvaluationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastFailedEvaluationTime property is set.
        /// </summary>
        internal bool IsSetLastFailedEvaluationTime() => this.LastFailedEvaluationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastFailedInvocationTime. 
        /// <para>
        /// The time that Config last failed to invoke the Config rule to evaluate your Amazon
        /// Web Services resources.
        /// </para>
        /// </summary>
        public DateTime? LastFailedInvocationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastFailedInvocationTime property is set.
        /// </summary>
        internal bool IsSetLastFailedInvocationTime() => this.LastFailedInvocationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastSuccessfulEvaluationTime. 
        /// <para>
        /// The time that Config last successfully evaluated your Amazon Web Services resources
        /// against the rule.
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulEvaluationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulEvaluationTime property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulEvaluationTime() => this.LastSuccessfulEvaluationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastSuccessfulInvocationTime. 
        /// <para>
        /// The time that Config last successfully invoked the Config rule to evaluate your Amazon
        /// Web Services resources.
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulInvocationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulInvocationTime property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulInvocationTime() => this.LastSuccessfulInvocationTime.HasValue;
    }
}
