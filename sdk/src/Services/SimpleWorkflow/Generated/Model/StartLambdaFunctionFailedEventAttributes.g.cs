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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides the details of the <c>StartLambdaFunctionFailed</c> event. It isn't set for
    /// other event types.
    /// </summary>
    public partial class StartLambdaFunctionFailedEventAttributes
    {
        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        /// The cause of the failure. To help diagnose issues, use this information to trace back
        /// the chain of events leading up to this event.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>cause</c> is set to <c>OPERATION_NOT_PERMITTED</c>, the decision failed because
        /// the IAM role attached to the execution lacked sufficient permissions. For details
        /// and example IAM policies, see <a href="https://docs.aws.amazon.com/amazonswf/latest/developerguide/lambda-task.html">Lambda
        /// Tasks</a> in the <i>Amazon SWF Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public StartLambdaFunctionFailedCause Cause { get; set; }

        /// <summary>
        /// Checks to see if the Cause property is set.
        /// </summary>
        internal bool IsSetCause() => this.Cause != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description that can help diagnose the cause of the fault.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1728)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property ScheduledEventId. 
        /// <para>
        /// The ID of the <c>ActivityTaskScheduled</c> event that was recorded when this activity
        /// task was scheduled. To help diagnose issues, use this information to trace back the
        /// chain of events leading up to this event.
        /// </para>
        /// </summary>
        public long? ScheduledEventId { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledEventId property is set.
        /// </summary>
        internal bool IsSetScheduledEventId() => this.ScheduledEventId.HasValue;
    }
}
