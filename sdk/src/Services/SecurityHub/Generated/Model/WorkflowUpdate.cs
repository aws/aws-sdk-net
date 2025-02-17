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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Used to update information about the investigation into the finding.
    /// </summary>
    public partial class WorkflowUpdate
    {
        private WorkflowStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the investigation into the finding. The workflow status is specific
        /// to an individual finding. It does not affect the generation of new findings. For example,
        /// setting the workflow status to <c>SUPPRESSED</c> or <c>RESOLVED</c> does not prevent
        /// a new finding for the same issue.
        /// </para>
        ///  
        /// <para>
        /// The allowed values are the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NEW</c> - The initial state of a finding, before it is reviewed.
        /// </para>
        ///  
        /// <para>
        /// Security Hub also resets <c>WorkFlowStatus</c> from <c>NOTIFIED</c> or <c>RESOLVED</c>
        /// to <c>NEW</c> in the following cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The record state changes from <c>ARCHIVED</c> to <c>ACTIVE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The compliance status changes from <c>PASSED</c> to either <c>WARNING</c>, <c>FAILED</c>,
        /// or <c>NOT_AVAILABLE</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>NOTIFIED</c> - Indicates that you notified the resource owner about the security
        /// issue. Used when the initial reviewer is not the resource owner, and needs intervention
        /// from the resource owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOLVED</c> - The finding was reviewed and remediated and is now considered resolved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUPPRESSED</c> - Indicates that you reviewed the finding and don't believe that
        /// any action is needed. The finding is no longer updated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WorkflowStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}