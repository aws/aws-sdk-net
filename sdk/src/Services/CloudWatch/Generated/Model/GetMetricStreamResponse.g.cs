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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This is the response object from the GetMetricStream operation.
    /// </summary>
    public partial class GetMetricStreamResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the metric stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date that the metric stream was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property ExcludeFilters. 
        /// <para>
        /// If this array of metric namespaces is present, then these namespaces are the only
        /// metric namespaces that are not streamed by this metric stream. In this case, all other
        /// metric namespaces in the account are streamed by this metric stream.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricStreamFilter> ExcludeFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricStreamFilter>() : null;

        /// <summary>
        /// Checks to see if the ExcludeFilters property is set.
        /// </summary>
        internal bool IsSetExcludeFilters() => this.ExcludeFilters != null && (this.ExcludeFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FirehoseArn. 
        /// <para>
        /// The ARN of the Amazon Kinesis Data Firehose delivery stream that is used by this metric
        /// stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string FirehoseArn { get; set; }

        /// <summary>
        /// Checks to see if the FirehoseArn property is set.
        /// </summary>
        internal bool IsSetFirehoseArn() => this.FirehoseArn != null;

        /// <summary>
        /// Gets and sets the property IncludeFilters. 
        /// <para>
        /// If this array of metric namespaces is present, then these namespaces are the only
        /// metric namespaces that are streamed by this metric stream.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricStreamFilter> IncludeFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricStreamFilter>() : null;

        /// <summary>
        /// Checks to see if the IncludeFilters property is set.
        /// </summary>
        internal bool IsSetIncludeFilters() => this.IncludeFilters != null && (this.IncludeFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncludeLinkedAccountsMetrics. 
        /// <para>
        /// If this is <c>true</c> and this metric stream is in a monitoring account, then the
        /// stream includes metrics from source accounts that the monitoring account is linked
        /// to.
        /// </para>
        /// </summary>
        public bool? IncludeLinkedAccountsMetrics { get; set; }

        /// <summary>
        /// Checks to see if the IncludeLinkedAccountsMetrics property is set.
        /// </summary>
        internal bool IsSetIncludeLinkedAccountsMetrics() => this.IncludeLinkedAccountsMetrics.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateDate. 
        /// <para>
        /// The date of the most recent update to the metric stream's configuration.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateDate property is set.
        /// </summary>
        internal bool IsSetLastUpdateDate() => this.LastUpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metric stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// The output format for the stream. Valid values are <c>json</c>, <c>opentelemetry1.0</c>,
        /// and <c>opentelemetry0.7</c>. For more information about metric stream output formats,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-metric-streams-formats.html">Metric
        /// streams output formats</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public MetricStreamOutputFormat OutputFormat { get; set; }

        /// <summary>
        /// Checks to see if the OutputFormat property is set.
        /// </summary>
        internal bool IsSetOutputFormat() => this.OutputFormat != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that is used by this metric stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the metric stream. The possible values are <c>running</c> and <c>stopped</c>.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StatisticsConfigurations. 
        /// <para>
        /// Each entry in this array displays information about one or more metrics that include
        /// additional statistics in the metric stream. For more information about the additional
        /// statistics, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Statistics-definitions.html">
        /// CloudWatch statistics definitions</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricStreamStatisticsConfiguration> StatisticsConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<MetricStreamStatisticsConfiguration>() : null;

        /// <summary>
        /// Checks to see if the StatisticsConfigurations property is set.
        /// </summary>
        internal bool IsSetStatisticsConfigurations() => this.StatisticsConfigurations != null && (this.StatisticsConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
