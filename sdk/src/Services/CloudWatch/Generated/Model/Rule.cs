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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Defines the schedule configuration for an alarm mute rule.
    /// 
    ///  
    /// <para>
    /// The rule contains a schedule that specifies when and how long alarms should be muted.
    /// The schedule can be a recurring pattern using cron expressions or a one-time mute
    /// window using at expressions.
    /// </para>
    /// </summary>
    public partial class Rule
    {
        private Schedule _schedule;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule configuration that defines when the mute rule activates and how long
        /// it remains active.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Schedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

    }
}