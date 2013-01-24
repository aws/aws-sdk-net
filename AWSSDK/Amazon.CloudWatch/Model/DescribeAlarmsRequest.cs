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
    /// Container for the parameters to the DescribeAlarms operation.
    /// <para> Retrieves alarms with the specified names. If no name is specified, all alarms for the user are returned. Alarms can be retrieved by
    /// using only a prefix for the alarm name, the alarm state, or a prefix for any action. </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.DescribeAlarms"/>
    public class DescribeAlarmsRequest : AmazonWebServiceRequest
    {
        private List<string> alarmNames = new List<string>();
        private string alarmNamePrefix;
        private string stateValue;
        private string actionPrefix;
        private int? maxRecords;
        private string nextToken;

        /// <summary>
        /// A list of alarm names to retrieve information for.
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
        public DescribeAlarmsRequest WithAlarmNames(params string[] alarmNames)
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
        public DescribeAlarmsRequest WithAlarmNames(IEnumerable<string> alarmNames)
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

        /// <summary>
        /// The alarm name prefix. <c>AlarmNames</c> cannot be specified if this parameter is specified.
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
        public string AlarmNamePrefix
        {
            get { return this.alarmNamePrefix; }
            set { this.alarmNamePrefix = value; }
        }

        /// <summary>
        /// Sets the AlarmNamePrefix property
        /// </summary>
        /// <param name="alarmNamePrefix">The value to set for the AlarmNamePrefix property </param>
        /// <returns>this instance</returns>
        public DescribeAlarmsRequest WithAlarmNamePrefix(string alarmNamePrefix)
        {
            this.alarmNamePrefix = alarmNamePrefix;
            return this;
        }
            

        // Check to see if AlarmNamePrefix property is set
        internal bool IsSetAlarmNamePrefix()
        {
            return this.alarmNamePrefix != null;       
        }

        /// <summary>
        /// The state value to be used in matching alarms.
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
        public string StateValue
        {
            get { return this.stateValue; }
            set { this.stateValue = value; }
        }

        /// <summary>
        /// Sets the StateValue property
        /// </summary>
        /// <param name="stateValue">The value to set for the StateValue property </param>
        /// <returns>this instance</returns>
        public DescribeAlarmsRequest WithStateValue(string stateValue)
        {
            this.stateValue = stateValue;
            return this;
        }
            

        // Check to see if StateValue property is set
        internal bool IsSetStateValue()
        {
            return this.stateValue != null;       
        }

        /// <summary>
        /// The action name prefix.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ActionPrefix
        {
            get { return this.actionPrefix; }
            set { this.actionPrefix = value; }
        }

        /// <summary>
        /// Sets the ActionPrefix property
        /// </summary>
        /// <param name="actionPrefix">The value to set for the ActionPrefix property </param>
        /// <returns>this instance</returns>
        public DescribeAlarmsRequest WithActionPrefix(string actionPrefix)
        {
            this.actionPrefix = actionPrefix;
            return this;
        }
            

        // Check to see if ActionPrefix property is set
        internal bool IsSetActionPrefix()
        {
            return this.actionPrefix != null;       
        }

        /// <summary>
        /// The maximum number of alarm descriptions to retrieve.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        public DescribeAlarmsRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;       
        }

        /// <summary>
        /// The token returned by a previous call to indicate that there is more data available.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        public DescribeAlarmsRequest WithNextToken(string nextToken)
        {
            this.nextToken = nextToken;
            return this;
        }
            

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;       
        }
    }
}
    
