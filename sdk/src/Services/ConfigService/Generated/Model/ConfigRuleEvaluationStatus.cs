/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Status information for your AWS managed Config rules. The status includes information
    /// such as the last time the rule ran, the last time it failed, and the related error
    /// for the last failure.
    /// 
    ///  
    /// <para>
    /// This action does not return status information about custom AWS Config rules.
    /// </para>
    /// </summary>
    public partial class ConfigRuleEvaluationStatus
    {
        private string _configRuleArn;
        private string _configRuleId;
        private string _configRuleName;
        private DateTime? _firstActivatedTime;
        private bool? _firstEvaluationStarted;
        private string _lastErrorCode;
        private string _lastErrorMessage;
        private DateTime? _lastFailedEvaluationTime;
        private DateTime? _lastFailedInvocationTime;
        private DateTime? _lastSuccessfulEvaluationTime;
        private DateTime? _lastSuccessfulInvocationTime;

        /// <summary>
        /// Gets and sets the property ConfigRuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Config rule.
        /// </para>
        /// </summary>
        public string ConfigRuleArn
        {
            get { return this._configRuleArn; }
            set { this._configRuleArn = value; }
        }

        // Check to see if ConfigRuleArn property is set
        internal bool IsSetConfigRuleArn()
        {
            return this._configRuleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleId. 
        /// <para>
        /// The ID of the AWS Config rule.
        /// </para>
        /// </summary>
        public string ConfigRuleId
        {
            get { return this._configRuleId; }
            set { this._configRuleId = value; }
        }

        // Check to see if ConfigRuleId property is set
        internal bool IsSetConfigRuleId()
        {
            return this._configRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of the AWS Config rule.
        /// </para>
        /// </summary>
        public string ConfigRuleName
        {
            get { return this._configRuleName; }
            set { this._configRuleName = value; }
        }

        // Check to see if ConfigRuleName property is set
        internal bool IsSetConfigRuleName()
        {
            return this._configRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property FirstActivatedTime. 
        /// <para>
        /// The time that you first activated the AWS Config rule.
        /// </para>
        /// </summary>
        public DateTime FirstActivatedTime
        {
            get { return this._firstActivatedTime.GetValueOrDefault(); }
            set { this._firstActivatedTime = value; }
        }

        // Check to see if FirstActivatedTime property is set
        internal bool IsSetFirstActivatedTime()
        {
            return this._firstActivatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FirstEvaluationStarted. 
        /// <para>
        /// Indicates whether AWS Config has evaluated your resources against the rule at least
        /// once.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>true</code> - AWS Config has evaluated your AWS resources against the rule
        /// at least once.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>false</code> - AWS Config has not once finished evaluating your AWS resources
        /// against the rule.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool FirstEvaluationStarted
        {
            get { return this._firstEvaluationStarted.GetValueOrDefault(); }
            set { this._firstEvaluationStarted = value; }
        }

        // Check to see if FirstEvaluationStarted property is set
        internal bool IsSetFirstEvaluationStarted()
        {
            return this._firstEvaluationStarted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastErrorCode. 
        /// <para>
        /// The error code that AWS Config returned when the rule last failed.
        /// </para>
        /// </summary>
        public string LastErrorCode
        {
            get { return this._lastErrorCode; }
            set { this._lastErrorCode = value; }
        }

        // Check to see if LastErrorCode property is set
        internal bool IsSetLastErrorCode()
        {
            return this._lastErrorCode != null;
        }

        /// <summary>
        /// Gets and sets the property LastErrorMessage. 
        /// <para>
        /// The error message that AWS Config returned when the rule last failed.
        /// </para>
        /// </summary>
        public string LastErrorMessage
        {
            get { return this._lastErrorMessage; }
            set { this._lastErrorMessage = value; }
        }

        // Check to see if LastErrorMessage property is set
        internal bool IsSetLastErrorMessage()
        {
            return this._lastErrorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastFailedEvaluationTime. 
        /// <para>
        /// The time that AWS Config last failed to evaluate your AWS resources against the rule.
        /// </para>
        /// </summary>
        public DateTime LastFailedEvaluationTime
        {
            get { return this._lastFailedEvaluationTime.GetValueOrDefault(); }
            set { this._lastFailedEvaluationTime = value; }
        }

        // Check to see if LastFailedEvaluationTime property is set
        internal bool IsSetLastFailedEvaluationTime()
        {
            return this._lastFailedEvaluationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastFailedInvocationTime. 
        /// <para>
        /// The time that AWS Config last failed to invoke the AWS Config rule to evaluate your
        /// AWS resources.
        /// </para>
        /// </summary>
        public DateTime LastFailedInvocationTime
        {
            get { return this._lastFailedInvocationTime.GetValueOrDefault(); }
            set { this._lastFailedInvocationTime = value; }
        }

        // Check to see if LastFailedInvocationTime property is set
        internal bool IsSetLastFailedInvocationTime()
        {
            return this._lastFailedInvocationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulEvaluationTime. 
        /// <para>
        /// The time that AWS Config last successfully evaluated your AWS resources against the
        /// rule.
        /// </para>
        /// </summary>
        public DateTime LastSuccessfulEvaluationTime
        {
            get { return this._lastSuccessfulEvaluationTime.GetValueOrDefault(); }
            set { this._lastSuccessfulEvaluationTime = value; }
        }

        // Check to see if LastSuccessfulEvaluationTime property is set
        internal bool IsSetLastSuccessfulEvaluationTime()
        {
            return this._lastSuccessfulEvaluationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulInvocationTime. 
        /// <para>
        /// The time that AWS Config last successfully invoked the AWS Config rule to evaluate
        /// your AWS resources.
        /// </para>
        /// </summary>
        public DateTime LastSuccessfulInvocationTime
        {
            get { return this._lastSuccessfulInvocationTime.GetValueOrDefault(); }
            set { this._lastSuccessfulInvocationTime = value; }
        }

        // Check to see if LastSuccessfulInvocationTime property is set
        internal bool IsSetLastSuccessfulInvocationTime()
        {
            return this._lastSuccessfulInvocationTime.HasValue; 
        }

    }
}