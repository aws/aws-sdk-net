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
    /// Container for the parameters to the DisableAlarmActions operation.
    /// <para> Disables actions for the specified alarms. When an alarm's actions are disabled the alarm's state may change, but none of the alarm's
    /// actions will execute. </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.DisableAlarmActions"/>
    public class DisableAlarmActionsRequest : AmazonWebServiceRequest
    {
        private List<string> alarmNames = new List<string>();

        /// <summary>
        /// The names of the alarms to disable actions for.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> AlarmNames
        {
            get { return this.alarmNames; }
            set { this.alarmNames = value; }
        }
        /// <summary>
        /// Adds elements to the AlarmNames collection
        /// </summary>
        /// <param name="alarmNames">The values to add to the AlarmNames collection </param>
        /// <returns>this instance</returns>
        public DisableAlarmActionsRequest WithAlarmNames(params string[] alarmNames)
        {
            foreach (string element in alarmNames)
            {
                this.alarmNames.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the AlarmNames collection
        /// </summary>
        /// <param name="alarmNames">The values to add to the AlarmNames collection </param>
        /// <returns>this instance</returns>
        public DisableAlarmActionsRequest WithAlarmNames(IEnumerable<string> alarmNames)
        {
            foreach (string element in alarmNames)
            {
                this.alarmNames.Add(element);
            }

            return this;
        }

        // Check to see if AlarmNames property is set
        internal bool IsSetAlarmNames()
        {
            return this.alarmNames.Count > 0;       
        }
    }
}
    
