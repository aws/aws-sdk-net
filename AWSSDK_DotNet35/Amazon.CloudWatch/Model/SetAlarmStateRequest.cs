/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the SetAlarmState operation.
    /// <para> Temporarily sets the state of an alarm. When the updated <c>StateValue</c> differs from the previous value, the action configured for
    /// the appropriate state is invoked. This is not a permanent change. The next periodic alarm check (in about a minute) will set the alarm to
    /// its actual state. </para>
    /// </summary>
    public partial class SetAlarmStateRequest : AmazonWebServiceRequest
    {
        private string alarmName;
        private StateValue stateValue;
        private string stateReason;
        private string stateReasonData;

        /// <summary>
        /// The descriptive name for the alarm. This name must be unique within the user's AWS account. The maximum length is 255 characters.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AlarmName
        {
            get { return this.alarmName; }
            set { this.alarmName = value; }
        }

        // Check to see if AlarmName property is set
        internal bool IsSetAlarmName()
        {
            return this.alarmName != null;
        }

        /// <summary>
        /// The value of the state.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>OK, ALARM, INSUFFICIENT_DATA</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public StateValue StateValue
        {
            get { return this.stateValue; }
            set { this.stateValue = value; }
        }

        // Check to see if StateValue property is set
        internal bool IsSetStateValue()
        {
            return this.stateValue != null;
        }

        /// <summary>
        /// The reason that this alarm is set to this specific state (in human-readable text format)
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1023</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StateReason
        {
            get { return this.stateReason; }
            set { this.stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this.stateReason != null;
        }

        /// <summary>
        /// The reason that this alarm is set to this specific state (in machine-readable JSON format)
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 4000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StateReasonData
        {
            get { return this.stateReasonData; }
            set { this.stateReasonData = value; }
        }

        // Check to see if StateReasonData property is set
        internal bool IsSetStateReasonData()
        {
            return this.stateReasonData != null;
        }

    }
}
    
