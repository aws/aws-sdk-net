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
    /// Container for the parameters to the DeleteAlarmMuteRule operation.
    /// Deletes a specific alarm mute rule.
    /// 
    ///  
    /// <para>
    /// When you delete a mute rule, any alarms that are currently being muted by that rule
    /// are immediately unmuted. If those alarms are in an ALARM state, their configured actions
    /// will trigger.
    /// </para>
    ///  
    /// <para>
    /// This operation is idempotent. If you delete a mute rule that does not exist, the operation
    /// succeeds without returning an error.
    /// </para>
    ///  
    /// <para>
    ///  <b>Permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To delete a mute rule, you need the <c>cloudwatch:DeleteAlarmMuteRule</c> permission
    /// on the alarm mute rule resource.
    /// </para>
    /// </summary>
    public partial class DeleteAlarmMuteRuleRequest : AmazonCloudWatchRequest
    {
        private string _alarmMuteRuleName;

        /// <summary>
        /// Gets and sets the property AlarmMuteRuleName. 
        /// <para>
        /// The name of the alarm mute rule to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AlarmMuteRuleName
        {
            get { return this._alarmMuteRuleName; }
            set { this._alarmMuteRuleName = value; }
        }

        // Check to see if AlarmMuteRuleName property is set
        internal bool IsSetAlarmMuteRuleName()
        {
            return this._alarmMuteRuleName != null;
        }

    }
}