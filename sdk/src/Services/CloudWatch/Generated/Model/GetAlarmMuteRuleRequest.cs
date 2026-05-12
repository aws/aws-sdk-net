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
    /// Container for the parameters to the GetAlarmMuteRule operation.
    /// Retrieves details for a specific alarm mute rule.
    /// 
    ///  
    /// <para>
    /// This operation returns complete information about the mute rule, including its configuration,
    /// status, targeted alarms, and metadata.
    /// </para>
    ///  
    /// <para>
    /// The returned status indicates the current state of the mute rule:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>SCHEDULED</b>: The mute rule is configured and will become active in the future
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>ACTIVE</b>: The mute rule is currently muting alarm actions
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>EXPIRED</b>: The mute rule has passed its expiration date and will no longer become
    /// active
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To retrieve details for a mute rule, you need the <c>cloudwatch:GetAlarmMuteRule</c>
    /// permission on the alarm mute rule resource.
    /// </para>
    /// </summary>
    public partial class GetAlarmMuteRuleRequest : AmazonCloudWatchRequest
    {
        private string _alarmMuteRuleName;

        /// <summary>
        /// Gets and sets the property AlarmMuteRuleName. 
        /// <para>
        /// The name of the alarm mute rule to retrieve.
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