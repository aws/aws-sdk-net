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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Defines the override behavior for jobs at the maximum priority (100) in weighted balanced
    /// scheduling.
    /// </summary>
    public partial class SchedulingMaxPriorityOverride
    {
        private SchedulingMaxPriorityOverrideAlwaysScheduleFirst _alwaysScheduleFirst;

        /// <summary>
        /// Gets and sets the property AlwaysScheduleFirst. 
        /// <para>
        /// Jobs at the maximum priority (100) are always scheduled before other jobs, regardless
        /// of the weighted scheduling formula. If multiple jobs have priority 100, ties are broken
        /// using the standard weighted formula.
        /// </para>
        /// </summary>
        public SchedulingMaxPriorityOverrideAlwaysScheduleFirst AlwaysScheduleFirst
        {
            get { return this._alwaysScheduleFirst; }
            set { this._alwaysScheduleFirst = value; }
        }

        // Check to see if AlwaysScheduleFirst property is set
        internal bool IsSetAlwaysScheduleFirst()
        {
            return this._alwaysScheduleFirst != null;
        }

    }
}