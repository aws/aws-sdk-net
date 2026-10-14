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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
    /// The result when DevOps Agent investigates a resilience test run. The verdict is advisory
    /// and builds on the test run's own result, which remains authoritative.
    /// </summary>
    public partial class DevOpsAgentInvestigation
    {
        private DevOpsAgentConfidence _confidence;
        private string _deepLink;
        private DevOpsAgentInvestigationStatus _status;
        private string _summary;
        private DevOpsAgentVerdict _verdict;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence level of the verdict. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// HIGH - The verdict is highly reliable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MEDIUM - The verdict has moderate reliability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LOW - The verdict has low reliability.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DevOpsAgentConfidence Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence != null;
        }

        /// <summary>
        /// Gets and sets the property DeepLink. 
        /// <para>
        /// A deep link to the interactive DevOps Agent investigation session.
        /// </para>
        /// </summary>
        public string DeepLink
        {
            get { return this._deepLink; }
            set { this._deepLink = value; }
        }

        // Check to see if DeepLink property is set
        internal bool IsSetDeepLink()
        {
            return this._deepLink != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The lifecycle status of the investigation. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING - The investigation has been created but has not started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IN_PROGRESS - The investigation is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// COMPLETED - The investigation finished successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED - The investigation failed to complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TIMED_OUT - The investigation did not complete within the allotted time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CANCELED - The investigation was canceled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DevOpsAgentInvestigationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// The DevOps Agent analysis summary for the investigation.
        /// </para>
        /// </summary>
        public string Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

        /// <summary>
        /// Gets and sets the property Verdict. 
        /// <para>
        /// The investigation verdict. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PASS - The resilience test run passed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAIL - The resilience test run failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INCONCLUSIVE - The investigation could not determine a clear outcome.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DevOpsAgentVerdict Verdict
        {
            get { return this._verdict; }
            set { this._verdict = value; }
        }

        // Check to see if Verdict property is set
        internal bool IsSetVerdict()
        {
            return this._verdict != null;
        }

    }
}