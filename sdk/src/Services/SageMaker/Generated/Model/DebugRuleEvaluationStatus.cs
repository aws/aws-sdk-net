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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Information about the status of the rule evaluation.
    /// </summary>
    public partial class DebugRuleEvaluationStatus
    {
        private DateTime? _lastModifiedTime;
        private string _ruleConfigurationName;
        private string _ruleEvaluationJobArn;
        private RuleEvaluationStatus _ruleEvaluationStatus;
        private string _statusDetails;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Timestamp when the rule evaluation status was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleConfigurationName. 
        /// <para>
        /// The name of the rule configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RuleConfigurationName
        {
            get { return this._ruleConfigurationName; }
            set { this._ruleConfigurationName = value; }
        }

        // Check to see if RuleConfigurationName property is set
        internal bool IsSetRuleConfigurationName()
        {
            return this._ruleConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property RuleEvaluationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the rule evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string RuleEvaluationJobArn
        {
            get { return this._ruleEvaluationJobArn; }
            set { this._ruleEvaluationJobArn = value; }
        }

        // Check to see if RuleEvaluationJobArn property is set
        internal bool IsSetRuleEvaluationJobArn()
        {
            return this._ruleEvaluationJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property RuleEvaluationStatus. 
        /// <para>
        /// Status of the rule evaluation.
        /// </para>
        /// </summary>
        public RuleEvaluationStatus RuleEvaluationStatus
        {
            get { return this._ruleEvaluationStatus; }
            set { this._ruleEvaluationStatus = value; }
        }

        // Check to see if RuleEvaluationStatus property is set
        internal bool IsSetRuleEvaluationStatus()
        {
            return this._ruleEvaluationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Details from the rule evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

    }
}