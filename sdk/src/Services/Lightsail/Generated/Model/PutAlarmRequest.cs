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
    /// Container for the parameters to the PutAlarm operation.
    /// Creates or updates an alarm, and associates it with the specified metric.
    /// 
    ///  
    /// <para>
    /// An alarm is used to monitor a single metric for one of your resources. When a metric
    /// condition is met, the alarm can notify you by email, SMS text message, and a banner
    /// displayed on the Amazon Lightsail console. For more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-alarms">Alarms
    /// in Amazon Lightsail</a>.
    /// </para>
    ///  
    /// <para>
    /// When this action creates an alarm, the alarm state is immediately set to <c>INSUFFICIENT_DATA</c>.
    /// The alarm is then evaluated and its state is set appropriately. Any actions associated
    /// with the new state are then executed.
    /// </para>
    ///  
    /// <para>
    /// When you update an existing alarm, its state is left unchanged, but the update completely
    /// overwrites the previous configuration of the alarm. The alarm is then evaluated with
    /// the updated configuration.
    /// </para>
    /// </summary>
    public partial class PutAlarmRequest : AmazonLightsailRequest
    {
        private string _alarmName;
        private ComparisonOperator _comparisonOperator;
        private List<string> _contactProtocols = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _datapointsToAlarm;
        private int? _evaluationPeriods;
        private MetricName _metricName;
        private string _monitoredResourceName;
        private bool? _notificationEnabled;
        private List<string> _notificationTriggers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private double? _threshold;
        private TreatMissingData _treatMissingData;

        /// <summary>
        /// Gets and sets the property AlarmName. 
        /// <para>
        /// The name for the alarm. Specify the name of an existing alarm to update, and overwrite
        /// the previous configuration of the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AlarmName
        {
            get { return this._alarmName; }
            set { this._alarmName = value; }
        }

        // Check to see if AlarmName property is set
        internal bool IsSetAlarmName()
        {
            return this._alarmName != null;
        }

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The arithmetic operation to use when comparing the specified statistic to the threshold.
        /// The specified statistic value is used as the first operand.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The contact protocols to use for the alarm, such as <c>Email</c>, <c>SMS</c> (text
        /// messaging), or both.
        /// </para>
        ///  
        /// <para>
        /// A notification is sent via the specified contact protocol if notifications are enabled
        /// for the alarm, and when the alarm is triggered.
        /// </para>
        ///  
        /// <para>
        /// A notification is not sent if a contact protocol is not specified, if the specified
        /// contact protocol is not configured in the Amazon Web Services Region, or if notifications
        /// are not enabled for the alarm using the <c>notificationEnabled</c> paramater.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>CreateContactMethod</c> action to configure a contact protocol in an Amazon
        /// Web Services Region.
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
        /// Gets and sets the property DatapointsToAlarm. 
        /// <para>
        /// The number of data points that must be not within the specified threshold to trigger
        /// the alarm. If you are setting an "M out of N" alarm, this value (<c>datapointsToAlarm</c>)
        /// is the M.
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
        /// The number of most recent periods over which data is compared to the specified threshold.
        /// If you are setting an "M out of N" alarm, this value (<c>evaluationPeriods</c>) is
        /// the N.
        /// </para>
        ///  
        /// <para>
        /// If you are setting an alarm that requires that a number of consecutive data points
        /// be breaching to trigger the alarm, this value specifies the rolling period of time
        /// in which data points are evaluated.
        /// </para>
        ///  
        /// <para>
        /// Each evaluation period is five minutes long. For example, specify an evaluation period
        /// of 24 to evaluate a metric over a rolling period of two hours.
        /// </para>
        ///  
        /// <para>
        /// You can specify a minimum valuation period of 1 (5 minutes), and a maximum evaluation
        /// period of 288 (24 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric to associate with the alarm.
        /// </para>
        ///  
        /// <para>
        /// You can configure up to two alarms per metric.
        /// </para>
        ///  
        /// <para>
        /// The following metrics are available for each resource type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Instances</b>: <c>BurstCapacityPercentage</c>, <c>BurstCapacityTime</c>, <c>CPUUtilization</c>,
        /// <c>NetworkIn</c>, <c>NetworkOut</c>, <c>StatusCheckFailed</c>, <c>StatusCheckFailed_Instance</c>,
        /// and <c>StatusCheckFailed_System</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Load balancers</b>: <c>ClientTLSNegotiationErrorCount</c>, <c>HealthyHostCount</c>,
        /// <c>UnhealthyHostCount</c>, <c>HTTPCode_LB_4XX_Count</c>, <c>HTTPCode_LB_5XX_Count</c>,
        /// <c>HTTPCode_Instance_2XX_Count</c>, <c>HTTPCode_Instance_3XX_Count</c>, <c>HTTPCode_Instance_4XX_Count</c>,
        /// <c>HTTPCode_Instance_5XX_Count</c>, <c>InstanceResponseTime</c>, <c>RejectedConnectionCount</c>,
        /// and <c>RequestCount</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Relational databases</b>: <c>CPUUtilization</c>, <c>DatabaseConnections</c>, <c>DiskQueueDepth</c>,
        /// <c>FreeStorageSpace</c>, <c>NetworkReceiveThroughput</c>, and <c>NetworkTransmitThroughput</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about these metrics, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-resource-health-metrics#available-metrics">Metrics
        /// available in Lightsail</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property MonitoredResourceName. 
        /// <para>
        /// The name of the Lightsail resource that will be monitored.
        /// </para>
        ///  
        /// <para>
        /// Instances, load balancers, and relational databases are the only Lightsail resources
        /// that can currently be monitored by alarms.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MonitoredResourceName
        {
            get { return this._monitoredResourceName; }
            set { this._monitoredResourceName = value; }
        }

        // Check to see if MonitoredResourceName property is set
        internal bool IsSetMonitoredResourceName()
        {
            return this._monitoredResourceName != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationEnabled. 
        /// <para>
        /// Indicates whether the alarm is enabled.
        /// </para>
        ///  
        /// <para>
        /// Notifications are enabled by default if you don't specify this parameter.
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
        /// <para>
        /// When you specify a notification trigger, the <c>ALARM</c> state must be specified.
        /// The <c>INSUFFICIENT_DATA</c> and <c>OK</c> states can be specified in addition to
        /// the <c>ALARM</c> state.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify <c>OK</c> as an alarm trigger, a notification is sent when the alarm
        /// switches from an <c>ALARM</c> or <c>INSUFFICIENT_DATA</c> alarm state to an <c>OK</c>
        /// state. This can be thought of as an <i>all clear</i> alarm notification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>INSUFFICIENT_DATA</c> as the alarm trigger, a notification is sent
        /// when the alarm switches from an <c>OK</c> or <c>ALARM</c> alarm state to an <c>INSUFFICIENT_DATA</c>
        /// state.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The notification trigger defaults to <c>ALARM</c> if you don't specify this parameter.
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
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The value against which the specified statistic is compared.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Sets how this alarm will handle missing data points.
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
        /// <para>
        /// If <c>treatMissingData</c> is not specified, the default behavior of <c>missing</c>
        /// is used.
        /// </para>
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

    }
}