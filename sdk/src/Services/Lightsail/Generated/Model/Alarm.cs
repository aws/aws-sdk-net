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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes an alarm.
    /// 
    ///  
    /// <para>
    /// An alarm is a way to monitor your Lightsail resource metrics. For more information,
    /// see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-alarms">Alarms
    /// in Amazon Lightsail</a>.
    /// </para>
    /// </summary>
    public partial class Alarm
    {
        private string _arn;
        private ComparisonOperator _comparisonOperator;
        private List<string> _contactProtocols = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdAt;
        private int? _datapointsToAlarm;
        private int? _evaluationPeriods;
        private ResourceLocation _location;
        private MetricName _metricName;
        private MonitoredResourceInfo _monitoredResourceInfo;
        private string _name;
        private bool? _notificationEnabled;
        private List<string> _notificationTriggers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _period;
        private ResourceType _resourceType;
        private AlarmState _state;
        private MetricStatistic _statistic;
        private string _supportCode;
        private double? _threshold;
        private TreatMissingData _treatMissingData;
        private MetricUnit _unit;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the alarm.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The arithmetic operation used when comparing the specified statistic and threshold.
        /// </para>
        /// </summary>
        public ComparisonOperator ComparisonOperator
        {
            get { return this._comparisonOperator; }
            set { this._comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this._comparisonOperator != null;
        }

        /// <summary>
        /// Gets and sets the property ContactProtocols. 
        /// <para>
        /// The contact protocols for the alarm, such as <c>Email</c>, <c>SMS</c> (text messaging),
        /// or both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ContactProtocols
        {
            get { return this._contactProtocols; }
            set { this._contactProtocols = value; }
        }

        // Check to see if ContactProtocols property is set
        internal bool IsSetContactProtocols()
        {
            return this._contactProtocols != null && (this._contactProtocols.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the alarm was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatapointsToAlarm. 
        /// <para>
        /// The number of data points that must not within the specified threshold to trigger
        /// the alarm.
        /// </para>
        /// </summary>
        public int? DatapointsToAlarm
        {
            get { return this._datapointsToAlarm; }
            set { this._datapointsToAlarm = value; }
        }

        // Check to see if DatapointsToAlarm property is set
        internal bool IsSetDatapointsToAlarm()
        {
            return this._datapointsToAlarm.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationPeriods. 
        /// <para>
        /// The number of periods over which data is compared to the specified threshold.
        /// </para>
        /// </summary>
        public int? EvaluationPeriods
        {
            get { return this._evaluationPeriods; }
            set { this._evaluationPeriods = value; }
        }

        // Check to see if EvaluationPeriods property is set
        internal bool IsSetEvaluationPeriods()
        {
            return this._evaluationPeriods.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// An object that lists information about the location of the alarm.
        /// </para>
        /// </summary>
        public ResourceLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric associated with the alarm.
        /// </para>
        /// </summary>
        public MetricName MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoredResourceInfo. 
        /// <para>
        /// An object that lists information about the resource monitored by the alarm.
        /// </para>
        /// </summary>
        public MonitoredResourceInfo MonitoredResourceInfo
        {
            get { return this._monitoredResourceInfo; }
            set { this._monitoredResourceInfo = value; }
        }

        // Check to see if MonitoredResourceInfo property is set
        internal bool IsSetMonitoredResourceInfo()
        {
            return this._monitoredResourceInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the alarm.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationEnabled. 
        /// <para>
        /// Indicates whether the alarm is enabled.
        /// </para>
        /// </summary>
        public bool? NotificationEnabled
        {
            get { return this._notificationEnabled; }
            set { this._notificationEnabled = value; }
        }

        // Check to see if NotificationEnabled property is set
        internal bool IsSetNotificationEnabled()
        {
            return this._notificationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotificationTriggers. 
        /// <para>
        /// The alarm states that trigger a notification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NotificationTriggers
        {
            get { return this._notificationTriggers; }
            set { this._notificationTriggers = value; }
        }

        // Check to see if NotificationTriggers property is set
        internal bool IsSetNotificationTriggers()
        {
            return this._notificationTriggers != null && (this._notificationTriggers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The period, in seconds, over which the statistic is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=86400)]
        public int? Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type of the alarm.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the alarm.
        /// </para>
        ///  
        /// <para>
        /// An alarm has the following possible states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALARM</c> - The metric is outside of the defined threshold.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_DATA</c> - The alarm has just started, the metric is not available,
        /// or not enough data is available for the metric to determine the alarm state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OK</c> - The metric is within the defined threshold.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AlarmState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Statistic. 
        /// <para>
        /// The statistic for the metric associated with the alarm.
        /// </para>
        ///  
        /// <para>
        /// The following statistics are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Minimum</c> - The lowest value observed during the specified period. Use this
        /// value to determine low volumes of activity for your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Maximum</c> - The highest value observed during the specified period. Use this
        /// value to determine high volumes of activity for your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Sum</c> - All values submitted for the matching metric added together. You can
        /// use this statistic to determine the total volume of a metric.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Average</c> - The value of Sum / SampleCount during the specified period. By comparing
        /// this statistic with the Minimum and Maximum values, you can determine the full scope
        /// of a metric and how close the average use is to the Minimum and Maximum values. This
        /// comparison helps you to know when to increase or decrease your resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SampleCount</c> - The count, or number, of data points used for the statistical
        /// calculation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MetricStatistic Statistic
        {
            get { return this._statistic; }
            set { this._statistic = value; }
        }

        // Check to see if Statistic property is set
        internal bool IsSetStatistic()
        {
            return this._statistic != null;
        }

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code. Include this code in your email to support when you have questions
        /// about your Lightsail alarm. This code enables our support team to look up your Lightsail
        /// information more easily.
        /// </para>
        /// </summary>
        public string SupportCode
        {
            get { return this._supportCode; }
            set { this._supportCode = value; }
        }

        // Check to see if SupportCode property is set
        internal bool IsSetSupportCode()
        {
            return this._supportCode != null;
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The value against which the specified statistic is compared.
        /// </para>
        /// </summary>
        public double? Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TreatMissingData. 
        /// <para>
        /// Specifies how the alarm handles missing data points.
        /// </para>
        ///  
        /// <para>
        /// An alarm can treat missing data in the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>breaching</c> - Assume the missing data is not within the threshold. Missing data
        /// counts towards the number of times the metric is not within the threshold.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>notBreaching</c> - Assume the missing data is within the threshold. Missing data
        /// does not count towards the number of times the metric is not within the threshold.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ignore</c> - Ignore the missing data. Maintains the current alarm state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>missing</c> - Missing data is treated as missing.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TreatMissingData TreatMissingData
        {
            get { return this._treatMissingData; }
            set { this._treatMissingData = value; }
        }

        // Check to see if TreatMissingData property is set
        internal bool IsSetTreatMissingData()
        {
            return this._treatMissingData != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of the metric associated with the alarm.
        /// </para>
        /// </summary>
        public MetricUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}