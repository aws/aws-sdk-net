/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAlarms operation.
    /// Retrieves alarms with the specified names. If no name is specified, all alarms for
    /// the user are returned. Alarms can be retrieved by using only a prefix for the alarm
    /// name, the alarm state, or a prefix for any action.
    /// </summary>
    public partial class DescribeAlarmsRequest : AmazonCloudWatchRequest
    {
        private string _actionPrefix;
        private string _alarmNamePrefix;
        private List<string> _alarmNames = new List<string>();
        private int? _maxRecords;
        private string _nextToken;
        private StateValue _stateValue;

        /// <summary>
        /// Gets and sets the property ActionPrefix. 
        /// <para>
        ///  The action name prefix. 
        /// </para>
        /// </summary>
        public string ActionPrefix
        {
            get { return this._actionPrefix; }
            set { this._actionPrefix = value; }
        }

        // Check to see if ActionPrefix property is set
        internal bool IsSetActionPrefix()
        {
            return this._actionPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmNamePrefix. 
        /// <para>
        ///  The alarm name prefix. <code>AlarmNames</code> cannot be specified if this parameter
        /// is specified. 
        /// </para>
        /// </summary>
        public string AlarmNamePrefix
        {
            get { return this._alarmNamePrefix; }
            set { this._alarmNamePrefix = value; }
        }

        // Check to see if AlarmNamePrefix property is set
        internal bool IsSetAlarmNamePrefix()
        {
            return this._alarmNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmNames. 
        /// <para>
        ///  A list of alarm names to retrieve information for. 
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        ///  The maximum number of alarm descriptions to retrieve. 
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token returned by a previous call to indicate that there is more data available.
        /// 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StateValue. 
        /// <para>
        ///  The state value to be used in matching alarms. 
        /// </para>
        /// </summary>
        public StateValue StateValue
        {
            get { return this._stateValue; }
            set { this._stateValue = value; }
        }

        // Check to see if StateValue property is set
        internal bool IsSetStateValue()
        {
            return this._stateValue != null;
        }

    }
}