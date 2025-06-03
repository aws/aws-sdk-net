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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// This structure contains the status information about a canary run.
    /// </summary>
    public partial class CanaryRunStatus
    {
        private CanaryRunState _state;
        private string _stateReason;
        private CanaryRunStateReasonCode _stateReasonCode;
        private CanaryRunTestResult _testResult;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the run.
        /// </para>
        /// </summary>
        public CanaryRunState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// If run of the canary failed, this field contains the reason for the error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

        /// <summary>
        /// Gets and sets the property StateReasonCode. 
        /// <para>
        /// If this value is <c>CANARY_FAILURE</c>, either the canary script failed or Synthetics
        /// ran into a fatal error when running the canary. For example, a canary timeout misconfiguration
        /// setting can cause the canary to timeout before Synthetics can evaluate its status.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  If this value is <c>EXECUTION_FAILURE</c>, a non-critical failure occurred such as
        /// failing to save generated debug artifacts (for example, screenshots or har files).
        /// </para>
        ///  
        /// <para>
        /// If both types of failures occurred, the <c>CANARY_FAILURE</c> takes precedence. To
        /// understand the exact error, use the <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_CanaryRunStatus.html">StateReason</a>
        /// API.
        /// </para>
        /// </summary>
        public CanaryRunStateReasonCode StateReasonCode
        {
            get { return this._stateReasonCode; }
            set { this._stateReasonCode = value; }
        }

        // Check to see if StateReasonCode property is set
        internal bool IsSetStateReasonCode()
        {
            return this._stateReasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property TestResult. 
        /// <para>
        /// Specifies the status of canary script for this run. When Synthetics tries to determine
        /// the status but fails, the result is marked as <c>UNKNOWN</c>. For the overall status
        /// of canary run, see <a href="https://docs.aws.amazon.com/AmazonSynthetics/latest/APIReference/API_CanaryRunStatus.html">State</a>.
        /// </para>
        /// </summary>
        public CanaryRunTestResult TestResult
        {
            get { return this._testResult; }
            set { this._testResult = value; }
        }

        // Check to see if TestResult property is set
        internal bool IsSetTestResult()
        {
            return this._testResult != null;
        }

    }
}