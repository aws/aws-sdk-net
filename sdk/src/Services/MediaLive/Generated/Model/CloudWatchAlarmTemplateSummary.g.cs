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
    /// Placeholder documentation for CloudWatchAlarmTemplateSummary
    /// </summary>
    public partial class CloudWatchAlarmTemplateSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. A cloudwatch alarm template's ARN (Amazon Resource
        /// Name)
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ComparisonOperator.
        /// </summary>
        [AWSProperty(Required = true)]
        public CloudWatchAlarmTemplateComparisonOperator ComparisonOperator { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonOperator property is set.
        /// </summary>
        internal bool IsSetComparisonOperator() => this.ComparisonOperator != null;

        /// <summary>
        /// Gets and sets the property CreatedAt.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

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
        [AWSProperty(Required = true)]
        public int? EvaluationPeriods { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationPeriods property is set.
        /// </summary>
        internal bool IsSetEvaluationPeriods() => this.EvaluationPeriods.HasValue;

        /// <summary>
        /// Gets and sets the property GroupId. A cloudwatch alarm template group's id. AWS provided
        /// template groups have ids that start with `aws-`
        /// </summary>
        [AWSProperty(Required = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property Id. A cloudwatch alarm template's id. AWS provided templates
        /// have ids that start with `aws-`
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MetricName. The name of the metric associated with the
        /// alarm. Must be compatible with targetResourceType.
        /// </summary>
        [AWSProperty(Required = true)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt.
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. A resource's name. Names must be unique within the
        /// scope of a resource type in a specific region.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Period. The period, in seconds, over which the specified
        /// statistic is applied.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period.HasValue;

        /// <summary>
        /// Gets and sets the property Statistic.
        /// </summary>
        [AWSProperty(Required = true)]
        public CloudWatchAlarmTemplateStatistic Statistic { get; set; }

        /// <summary>
        /// Checks to see if the Statistic property is set.
        /// </summary>
        internal bool IsSetStatistic() => this.Statistic != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetResourceType.
        /// </summary>
        [AWSProperty(Required = true)]
        public CloudWatchAlarmTemplateTargetResourceType TargetResourceType { get; set; }

        /// <summary>
        /// Checks to see if the TargetResourceType property is set.
        /// </summary>
        internal bool IsSetTargetResourceType() => this.TargetResourceType != null;

        /// <summary>
        /// Gets and sets the property Threshold. The threshold value to compare with the specified
        /// statistic.
        /// </summary>
        [AWSProperty(Required = true)]
        public double? Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold.HasValue;

        /// <summary>
        /// Gets and sets the property TreatMissingData.
        /// </summary>
        [AWSProperty(Required = true)]
        public CloudWatchAlarmTemplateTreatMissingData TreatMissingData { get; set; }

        /// <summary>
        /// Checks to see if the TreatMissingData property is set.
        /// </summary>
        internal bool IsSetTreatMissingData() => this.TreatMissingData != null;
    }
}
