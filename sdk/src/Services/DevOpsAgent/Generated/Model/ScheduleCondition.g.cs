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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Expression-based schedule condition. CreateTrigger callers using this condition supply
    /// expression and omit spec. Trigger responses always use this condition, include the
    /// persisted or derived expression, and also include spec when the trigger was created
    /// from a structured schedule.
    /// </summary>
    public partial class ScheduleCondition
    {
        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// EventBridge cron or rate expression. Required for existing request and response compatibility.
        /// For a structured schedule response, this is the expression derived by Backlog.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Expression { get; set; }

        /// <summary>
        /// Checks to see if the Expression property is set.
        /// </summary>
        internal bool IsSetExpression() => this.Expression != null;

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// Structured schedule source of truth (cron | timeRange). On CreateTrigger supply exactly
        /// one of spec or expression. Present in responses together with the derived expression
        /// for structured triggers.
        /// </para>
        /// </summary>
        public ScheduleSpec Spec { get; set; }

        /// <summary>
        /// Checks to see if the Spec property is set.
        /// </summary>
        internal bool IsSetSpec() => this.Spec != null;
    }
}
