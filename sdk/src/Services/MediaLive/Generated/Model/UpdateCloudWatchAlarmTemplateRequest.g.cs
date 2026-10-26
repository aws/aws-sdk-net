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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateCloudWatchAlarmTemplate operation. Updates
    /// the specified cloudwatch alarm template.
    /// </summary>
    public partial class UpdateCloudWatchAlarmTemplateRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property ComparisonOperator.
        /// </summary>
        public CloudWatchAlarmTemplateComparisonOperator ComparisonOperator { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonOperator property is set.
        /// </summary>
        internal bool IsSetComparisonOperator() => this.ComparisonOperator != null;

        /// <summary>
        /// Gets and sets the property DatapointsToAlarm. The number of datapoints within the
        /// evaluation period that must be breaching to trigger the alarm.
        /// </summary>
        public int? DatapointsToAlarm { get; set; }

        /// <summary>
        /// Checks to see if the DatapointsToAlarm property is set.
        /// </summary>
        internal bool IsSetDatapointsToAlarm() => this.DatapointsToAlarm.HasValue;

        /// <summary>
        /// Gets and sets the property Description. A resource's optional description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EvaluationPeriods. The number of periods over which data
        /// is compared to the specified threshold.
        /// </summary>
        public int? EvaluationPeriods { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationPeriods property is set.
        /// </summary>
        internal bool IsSetEvaluationPeriods() => this.EvaluationPeriods.HasValue;

        /// <summary>
        /// Gets and sets the property GroupIdentifier. A cloudwatch alarm template group's identifier.
        /// Can be either be its id or current name.
        /// </summary>
        public string GroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GroupIdentifier property is set.
        /// </summary>
        internal bool IsSetGroupIdentifier() => this.GroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property Identifier. A cloudwatch alarm template's identifier. Can
        /// be either be its id or current name.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property MetricName. The name of the metric associated with the
        /// alarm. Must be compatible with targetResourceType.
        /// </summary>
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Name. A resource's name. Names must be unique within the
        /// scope of a resource type in a specific region.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Period. The period, in seconds, over which the specified
        /// statistic is applied.
        /// </summary>
        public int? Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period.HasValue;

        /// <summary>
        /// Gets and sets the property Statistic.
        /// </summary>
        public CloudWatchAlarmTemplateStatistic Statistic { get; set; }

        /// <summary>
        /// Checks to see if the Statistic property is set.
        /// </summary>
        internal bool IsSetStatistic() => this.Statistic != null;

        /// <summary>
        /// Gets and sets the property TargetResourceType.
        /// </summary>
        public CloudWatchAlarmTemplateTargetResourceType TargetResourceType { get; set; }

        /// <summary>
        /// Checks to see if the TargetResourceType property is set.
        /// </summary>
        internal bool IsSetTargetResourceType() => this.TargetResourceType != null;

        /// <summary>
        /// Gets and sets the property Threshold. The threshold value to compare with the specified
        /// statistic.
        /// </summary>
        public double? Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold.HasValue;

        /// <summary>
        /// Gets and sets the property TreatMissingData.
        /// </summary>
        public CloudWatchAlarmTemplateTreatMissingData TreatMissingData { get; set; }

        /// <summary>
        /// Checks to see if the TreatMissingData property is set.
        /// </summary>
        internal bool IsSetTreatMissingData() => this.TreatMissingData != null;
    }
}
