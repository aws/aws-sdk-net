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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Defines the specific triggers that cause instances to be retained in a Retained state
    /// rather than terminated. Each trigger corresponds to a different failure scenario during
    /// the instance lifecycle. This allows fine-grained control over when to preserve instances
    /// for manual intervention.
    /// </summary>
    public partial class RetentionTriggers
    {
        private RetentionAction _terminateHookAbandon;

        /// <summary>
        /// Gets and sets the property TerminateHookAbandon. 
        /// <para>
        ///  Specifies the action when a termination lifecycle hook is abandoned due to failure,
        /// timeout, or explicit abandonment (calling CompleteLifecycleAction). 
        /// </para>
        ///  
        /// <para>
        ///  Set to <c>Retain</c> to move instances to a <c>Retained</c> state. Set to <c>Terminate</c>
        /// for default termination behavior. 
        /// </para>
        ///  
        /// <para>
        ///  Retained instances don't count toward desired capacity and remain until you call
        /// <c>TerminateInstanceInAutoScalingGroup</c>. 
        /// </para>
        /// </summary>
        public RetentionAction TerminateHookAbandon
        {
            get { return this._terminateHookAbandon; }
            set { this._terminateHookAbandon = value; }
        }

        // Check to see if TerminateHookAbandon property is set
        internal bool IsSetTerminateHookAbandon()
        {
            return this._terminateHookAbandon != null;
        }

    }
}