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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAlarms operation.
    /// Deletes the specified alarms. You can delete up to 100 alarms in one operation. However,
    /// this total can include no more than one composite alarm. For example, you could delete
    /// 99 metric alarms and one composite alarms with one operation, but you can't delete
    /// two composite alarms with one operation.
    /// 
    ///  
    /// <para>
    ///  In the event of an error, no alarms are deleted.
    /// </para>
    ///  <note> 
    /// <para>
    /// It is possible to create a loop or cycle of composite alarms, where composite alarm
    /// A depends on composite alarm B, and composite alarm B also depends on composite alarm
    /// A. In this scenario, you can't delete any composite alarm that is part of the cycle
    /// because there is always still a composite alarm that depends on that alarm that you
    /// want to delete.
    /// </para>
    ///  
    /// <para>
    /// To get out of such a situation, you must break the cycle by changing the rule of one
    /// of the composite alarms in the cycle to remove a dependency that creates the cycle.
    /// The simplest change to make to break a cycle is to change the <code>AlarmRule</code>
    /// of one of the alarms to <code>false</code>. 
    /// </para>
    ///  
    /// <para>
    /// Additionally, the evaluation of composite alarms stops if CloudWatch detects a cycle
    /// in the evaluation path. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteAlarmsRequest : AmazonCloudWatchRequest
    {
        private List<string> _alarmNames = new List<string>();

        /// <summary>
        /// Gets and sets the property AlarmNames. 
        /// <para>
        /// The alarms to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
        public List<string> AlarmNames
        {
            get { return this._alarmNames; }
            set { this._alarmNames = value; }
        }

        // Check to see if AlarmNames property is set
        internal bool IsSetAlarmNames()
        {
            return this._alarmNames != null && this._alarmNames.Count > 0; 
        }

    }
}