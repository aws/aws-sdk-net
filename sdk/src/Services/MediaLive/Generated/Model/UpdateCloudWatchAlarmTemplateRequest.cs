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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCloudWatchAlarmTemplate operation.
    /// Updates the specified cloudwatch alarm template.
    /// </summary>
    public partial class UpdateCloudWatchAlarmTemplateRequest : AmazonMediaLiveRequest
    {
        private CloudWatchAlarmTemplateComparisonOperator _comparisonOperator;
        private int? _datapointsToAlarm;
        private string _description;
        private int? _evaluationPeriods;
        private string _groupIdentifier;
        private string _identifier;
        private string _metricName;
        private string _name;
        private int? _period;
        private CloudWatchAlarmTemplateStatistic _statistic;
        private CloudWatchAlarmTemplateTargetResourceType _targetResourceType;
        private double? _threshold;
        private CloudWatchAlarmTemplateTreatMissingData _treatMissingData;

        /// <summary>
        /// Gets and sets the property ComparisonOperator.
        /// </summary>
        public CloudWatchAlarmTemplateComparisonOperator ComparisonOperator
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
        /// Gets and sets the property DatapointsToAlarm. The number of datapoints within the
        /// evaluation period that must be breaching to trigger the alarm.
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property Description. A resource's optional description.
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationPeriods. The number of periods over which data
        /// is compared to the specified threshold.
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property GroupIdentifier. A cloudwatch alarm template group's identifier.
        /// Can be either be its id or current name.
        /// </summary>
        public string GroupIdentifier
        {
            get { return this._groupIdentifier; }
            set { this._groupIdentifier = value; }
        }

        // Check to see if GroupIdentifier property is set
        internal bool IsSetGroupIdentifier()
        {
            return this._groupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. A cloudwatch alarm template's identifier. Can
        /// be either be its id or current name.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. The name of the metric associated with the
        /// alarm. Must be compatible with targetResourceType.
        /// </summary>
        [AWSProperty(Max=64)]
        public string MetricName
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
        /// Gets and sets the property Name. A resource's name. Names must be unique within the
        /// scope of a resource type in a specific region.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Period. The period, in seconds, over which the specified
        /// statistic is applied.
        /// </summary>
        [AWSProperty(Min=10, Max=86400)]
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
        /// Gets and sets the property Statistic.
        /// </summary>
        public CloudWatchAlarmTemplateStatistic Statistic
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
        /// Gets and sets the property TargetResourceType.
        /// </summary>
        public CloudWatchAlarmTemplateTargetResourceType TargetResourceType
        {
            get { return this._targetResourceType; }
            set { this._targetResourceType = value; }
        }

        // Check to see if TargetResourceType property is set
        internal bool IsSetTargetResourceType()
        {
            return this._targetResourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Threshold. The threshold value to compare with the specified
        /// statistic.
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
        /// </summary>
        public CloudWatchAlarmTemplateTreatMissingData TreatMissingData
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