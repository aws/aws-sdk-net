/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para>The Alarm data type.</para>
    /// </summary>
    public class Alarm  
    {
        
        private string alarmName;
        private string alarmARN;

        /// <summary>
        /// The name of the alarm
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AlarmName
        {
            get { return this.alarmName; }
            set { this.alarmName = value; }
        }

        /// <summary>
        /// Sets the AlarmName property
        /// </summary>
        /// <param name="alarmName">The value to set for the AlarmName property </param>
        /// <returns>this instance</returns>
        public Alarm WithAlarmName(string alarmName)
        {
            this.alarmName = alarmName;
            return this;
        }
            

        // Check to see if AlarmName property is set
        internal bool IsSetAlarmName()
        {
            return this.alarmName != null;       
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the alarm.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1600</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AlarmARN
        {
            get { return this.alarmARN; }
            set { this.alarmARN = value; }
        }

        /// <summary>
        /// Sets the AlarmARN property
        /// </summary>
        /// <param name="alarmARN">The value to set for the AlarmARN property </param>
        /// <returns>this instance</returns>
        public Alarm WithAlarmARN(string alarmARN)
        {
            this.alarmARN = alarmARN;
            return this;
        }
            

        // Check to see if AlarmARN property is set
        internal bool IsSetAlarmARN()
        {
            return this.alarmARN != null;       
        }
    }
}
