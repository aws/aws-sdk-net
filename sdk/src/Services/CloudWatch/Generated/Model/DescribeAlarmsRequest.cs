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
    /// Container for the parameters to the DescribeAlarms operation.
    /// Retrieves the specified alarms. You can filter the results by specifying a prefix
    /// for the alarm name, the alarm state, or a prefix for any action.
    /// 
    ///  
    /// <para>
    /// To use this operation and return information about composite alarms, you must be signed
    /// on with the <c>cloudwatch:DescribeAlarms</c> permission that is scoped to <c>*</c>.
    /// You can't return information about composite alarms if your <c>cloudwatch:DescribeAlarms</c>
    /// permission has a narrower scope.
    /// </para>
    /// </summary>
    public partial class DescribeAlarmsRequest : AmazonCloudWatchRequest
    {
        private string _actionPrefix;
        private string _alarmNamePrefix;
        private List<string> _alarmNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _alarmTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
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
        /// If this parameter is specified, you cannot specify <c>AlarmNames</c>.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._alarmNames != null && (this._alarmNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AlarmTypes. 
        /// <para>
        /// Use this parameter to specify whether you want the operation to return metric alarms
        /// or composite alarms. If you omit this parameter, only metric alarms are returned,
        /// even if composite alarms exist in the account.
        /// </para>
        ///  
        /// <para>
        /// For example, if you omit this parameter or specify <c>MetricAlarms</c>, the operation
        /// returns only a list of metric alarms. It does not return any composite alarms, even
        /// if composite alarms exist in the account.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>CompositeAlarms</c>, the operation returns only a list of composite
        /// alarms, and does not return any metric alarms.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AlarmTypes
        {
            get { return this._alarmTypes; }
            set { this._alarmTypes = value; }
        }

        // Check to see if AlarmTypes property is set
        internal bool IsSetAlarmTypes()
        {
            return this._alarmTypes != null && (this._alarmTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ChildrenOfAlarmName. 
        /// <para>
        /// If you use this parameter and specify the name of a composite alarm, the operation
        /// returns information about the "children" alarms of the alarm you specify. These are
        /// the metric alarms and composite alarms referenced in the <c>AlarmRule</c> field of
        /// the composite alarm that you specify in <c>ChildrenOfAlarmName</c>. Information about
        /// the composite alarm that you name in <c>ChildrenOfAlarmName</c> is not returned.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>ChildrenOfAlarmName</c>, you cannot specify any other parameters
        /// in the request except for <c>MaxRecords</c> and <c>NextToken</c>. If you do so, you
        /// receive a validation error.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only the <c>Alarm Name</c>, <c>ARN</c>, <c>StateValue</c> (OK/ALARM/INSUFFICIENT_DATA),
        /// and <c>StateUpdatedTimestamp</c> information are returned by this operation when you
        /// use this parameter. To get complete information about these alarms, perform another
        /// <c>DescribeAlarms</c> operation and specify the parent alarm names in the <c>AlarmNames</c>
        /// parameter.
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
        public int? MaxRecords
        {
            get { return this._maxRecords; }
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
        /// These are the composite alarms that have <c>AlarmRule</c> parameters that reference
        /// the alarm named in <c>ParentsOfAlarmName</c>. Information about the alarm that you
        /// specify in <c>ParentsOfAlarmName</c> is not returned.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>ParentsOfAlarmName</c>, you cannot specify any other parameters
        /// in the request except for <c>MaxRecords</c> and <c>NextToken</c>. If you do so, you
        /// receive a validation error.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only the Alarm Name and ARN are returned by this operation when you use this parameter.
        /// To get complete information about these alarms, perform another <c>DescribeAlarms</c>
        /// operation and specify the parent alarm names in the <c>AlarmNames</c> parameter.
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