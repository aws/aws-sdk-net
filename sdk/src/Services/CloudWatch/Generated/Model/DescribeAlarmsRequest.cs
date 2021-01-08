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
    /// Container for the parameters to the DescribeAlarms operation.
    /// Retrieves the specified alarms. You can filter the results by specifying a prefix
    /// for the alarm name, the alarm state, or a prefix for any action.
    /// </summary>
    public partial class DescribeAlarmsRequest : AmazonCloudWatchRequest
    {
        private string _actionPrefix;
        private string _alarmNamePrefix;
        private List<string> _alarmNames = new List<string>();
        private List<string> _alarmTypes = new List<string>();
        private string _childrenOfAlarmName;
        private int? _maxRecords;
        private string _nextToken;
        private string _parentsOfAlarmName;
        private StateValue _stateValue;

        /// <summary>
        /// Gets and sets the property ActionPrefix. 
        /// <para>
        /// Use this parameter to filter the results of the operation to only those alarms that
        /// use a certain alarm action. For example, you could specify the ARN of an SNS topic
        /// to find all alarms that send notifications to that topic.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// An alarm name prefix. If you specify this parameter, you receive information about
        /// all alarms that have names that start with this prefix.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is specified, you cannot specify <code>AlarmNames</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The names of the alarms to retrieve information about.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
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
        /// Gets and sets the property AlarmTypes. 
        /// <para>
        /// Use this parameter to specify whether you want the operation to return metric alarms
        /// or composite alarms. If you omit this parameter, only metric alarms are returned.
        /// </para>
        /// </summary>
        public List<string> AlarmTypes
        {
            get { return this._alarmTypes; }
            set { this._alarmTypes = value; }
        }

        // Check to see if AlarmTypes property is set
        internal bool IsSetAlarmTypes()
        {
            return this._alarmTypes != null && this._alarmTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ChildrenOfAlarmName. 
        /// <para>
        /// If you use this parameter and specify the name of a composite alarm, the operation
        /// returns information about the "children" alarms of the alarm you specify. These are
        /// the metric alarms and composite alarms referenced in the <code>AlarmRule</code> field
        /// of the composite alarm that you specify in <code>ChildrenOfAlarmName</code>. Information
        /// about the composite alarm that you name in <code>ChildrenOfAlarmName</code> is not
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>ChildrenOfAlarmName</code>, you cannot specify any other parameters
        /// in the request except for <code>MaxRecords</code> and <code>NextToken</code>. If you
        /// do so, you receive a validation error.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only the <code>Alarm Name</code>, <code>ARN</code>, <code>StateValue</code> (OK/ALARM/INSUFFICIENT_DATA),
        /// and <code>StateUpdatedTimestamp</code> information are returned by this operation
        /// when you use this parameter. To get complete information about these alarms, perform
        /// another <code>DescribeAlarms</code> operation and specify the parent alarm names in
        /// the <code>AlarmNames</code> parameter.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ChildrenOfAlarmName
        {
            get { return this._childrenOfAlarmName; }
            set { this._childrenOfAlarmName = value; }
        }

        // Check to see if ChildrenOfAlarmName property is set
        internal bool IsSetChildrenOfAlarmName()
        {
            return this._childrenOfAlarmName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of alarm descriptions to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The token returned by a previous call to indicate that there is more data available.
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
        /// Gets and sets the property ParentsOfAlarmName. 
        /// <para>
        /// If you use this parameter and specify the name of a metric or composite alarm, the
        /// operation returns information about the "parent" alarms of the alarm you specify.
        /// These are the composite alarms that have <code>AlarmRule</code> parameters that reference
        /// the alarm named in <code>ParentsOfAlarmName</code>. Information about the alarm that
        /// you specify in <code>ParentsOfAlarmName</code> is not returned.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>ParentsOfAlarmName</code>, you cannot specify any other parameters
        /// in the request except for <code>MaxRecords</code> and <code>NextToken</code>. If you
        /// do so, you receive a validation error.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only the Alarm Name and ARN are returned by this operation when you use this parameter.
        /// To get complete information about these alarms, perform another <code>DescribeAlarms</code>
        /// operation and specify the parent alarm names in the <code>AlarmNames</code> parameter.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ParentsOfAlarmName
        {
            get { return this._parentsOfAlarmName; }
            set { this._parentsOfAlarmName = value; }
        }

        // Check to see if ParentsOfAlarmName property is set
        internal bool IsSetParentsOfAlarmName()
        {
            return this._parentsOfAlarmName != null;
        }

        /// <summary>
        /// Gets and sets the property StateValue. 
        /// <para>
        /// Specify this parameter to receive information only about alarms that are currently
        /// in the state that you specify.
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