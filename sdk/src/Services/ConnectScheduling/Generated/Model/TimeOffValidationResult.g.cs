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

namespace Amazon.ConnectScheduling.Model
{
    /// <summary>
    /// A warning or failure produced while processing the time off request.
    /// </summary>
    public partial class TimeOffValidationResult
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The specific reason for the validation result. New values may be added, so treat an
        /// unrecognized value as a generic failure of the reported severity.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_USER_TIME_OFF_BALANCE</c>: the user's time off balance for the activity
        /// is less than the time this request deducts. Connect Customer deducts only working
        /// time in the window. For details, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/upload-timeoff-balance.html#how-system-calculates-time-off-deductions">How
        /// the system calculates time off deductions</a> in the <i>Connect Customer Administrator
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_GROUP_TIME_OFF_ALLOWANCE</c>: the time off allowance of the user's
        /// forecast group or demand group for the activity is too low for this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_STAFFING_GROUP_TIME_OFF_ALLOWANCE</c>: the daily time off allowance
        /// of the user's staffing group for the activity is too low for this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONFLICTING_TIME_OFF_REQUEST</c>: the request overlaps another time off request
        /// for the user that is <c>APPROVED</c> or being approved. Requests in <c>AWAITING_APPROVAL</c>
        /// don't count. For <c>CreateTimeOff</c> with <c>AUTOMATIC</c>, overlapping overtime
        /// and voluntary time off also count.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeOffValidationCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the validation result. <c>WARNING</c> is a breach of the configured
        /// rules that is not enough to reject the request, either because of the rules configuration
        /// or because the caller sent <c>RuleFailureAction</c> <c>OVERRIDE</c>. <c>ERROR</c>
        /// is a reason the request was rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeOffValidationSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;
    }
}
