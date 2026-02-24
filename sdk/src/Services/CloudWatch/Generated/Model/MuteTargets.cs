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
    /// Specifies which alarms an alarm mute rule applies to.
    /// 
    ///  
    /// <para>
    /// You can target up to 100 specific alarms by name. When a mute rule is active, the
    /// targeted alarms continue to evaluate metrics and transition between states, but their
    /// configured actions are muted.
    /// </para>
    /// </summary>
    public partial class MuteTargets
    {
        private List<string> _alarmNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AlarmNames. 
        /// <para>
        /// The list of alarm names that this mute rule targets. You can specify up to 100 alarm
        /// names.
        /// </para>
        ///  
        /// <para>
        /// Each alarm name must be between 1 and 255 characters in length. The alarm names must
        /// match existing alarms in your Amazon Web Services account and region.
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
            return this._alarmNames != null && (this._alarmNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}