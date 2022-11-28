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
    /// Container for the parameters to the PutMetricStream operation.
    /// Creates or updates a metric stream. Metric streams can automatically stream CloudWatch
    /// metrics to Amazon Web Services destinations, including Amazon S3, and to many third-party
    /// solutions.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Metric-Streams.html">
    /// Using Metric Streams</a>.
    /// </para>
    ///  
    /// <para>
    /// To create a metric stream, you must be signed in to an account that has the <code>iam:PassRole</code>
    /// permission and either the <code>CloudWatchFullAccess</code> policy or the <code>cloudwatch:PutMetricStream</code>
    /// permission.
    /// </para>
    ///  
    /// <para>
    /// When you create or update a metric stream, you choose one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Stream metrics from all metric namespaces in the account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Stream metrics from all metric namespaces in the account, except for the namespaces
    /// that you list in <code>ExcludeFilters</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Stream metrics from only the metric namespaces that you list in <code>IncludeFilters</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// By default, a metric stream always sends the <code>MAX</code>, <code>MIN</code>, <code>SUM</code>,
    /// and <code>SAMPLECOUNT</code> statistics for each metric that is streamed. You can
    /// use the <code>StatisticsConfigurations</code> parameter to have the metric stream
    /// send additional statistics in the stream. Streaming additional statistics incurs additional
    /// costs. For more information, see <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon
    /// CloudWatch Pricing</a>. 
    /// </para>
    ///  
    /// <para>
    /// When you use <code>PutMetricStream</code> to create a new metric stream, the stream
    /// is created in the <code>running</code> state. If you use it to update an existing
    /// stream, the state of the stream is not changed.
    /// </para>
    /// </summary>
    public partial class PutMetricStreamRequest : AmazonCloudWatchRequest
    {
        private List<MetricStreamFilter> _excludeFilters = new List<MetricStreamFilter>();
        private string _firehoseArn;
        private List<MetricStreamFilter> _includeFilters = new List<MetricStreamFilter>();
        private string _name;
        private MetricStreamOutputFormat _outputFormat;
        private string _roleArn;
        private List<MetricStreamStatisticsConfiguration> _statisticsConfigurations = new List<MetricStreamStatisticsConfiguration>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ExcludeFilters. 
        /// <para>
        /// If you specify this parameter, the stream sends metrics from all metric namespaces
        /// except for the namespaces that you specify here.
        /// </para>
        ///  
        /// <para>
        /// You cannot include <code>ExcludeFilters</code> and <code>IncludeFilters</code> in
        /// the same operation.
        /// </para>
        /// </summary>
        public List<MetricStreamFilter> ExcludeFilters
        {
            get { return this._excludeFilters; }
            set { this._excludeFilters = value; }
        }

        // Check to see if ExcludeFilters property is set
        internal bool IsSetExcludeFilters()
        {
            return this._excludeFilters != null && this._excludeFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FirehoseArn. 
        /// <para>
        /// The ARN of the Amazon Kinesis Data Firehose delivery stream to use for this metric
        /// stream. This Amazon Kinesis Data Firehose delivery stream must already exist and must
        /// be in the same account as the metric stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string FirehoseArn
        {
            get { return this._firehoseArn; }
            set { this._firehoseArn = value; }
        }

        // Check to see if FirehoseArn property is set
        internal bool IsSetFirehoseArn()
        {
            return this._firehoseArn != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeFilters. 
        /// <para>
        /// If you specify this parameter, the stream sends only the metrics from the metric namespaces
        /// that you specify here.
        /// </para>
        ///  
        /// <para>
        /// You cannot include <code>IncludeFilters</code> and <code>ExcludeFilters</code> in
        /// the same operation.
        /// </para>
        /// </summary>
        public List<MetricStreamFilter> IncludeFilters
        {
            get { return this._includeFilters; }
            set { this._includeFilters = value; }
        }

        // Check to see if IncludeFilters property is set
        internal bool IsSetIncludeFilters()
        {
            return this._includeFilters != null && this._includeFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// If you are creating a new metric stream, this is the name for the new stream. The
        /// name must be different than the names of other metric streams in this account and
        /// Region.
        /// </para>
        ///  
        /// <para>
        /// If you are updating a metric stream, specify the name of that stream here.
        /// </para>
        ///  
        /// <para>
        /// Valid characters are A-Z, a-z, 0-9, "-" and "_".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// The output format for the stream. Valid values are <code>json</code> and <code>opentelemetry0.7</code>.
        /// For more information about metric stream output formats, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-metric-streams-formats.html">
        /// Metric streams output formats</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public MetricStreamOutputFormat OutputFormat
        {
            get { return this._outputFormat; }
            set { this._outputFormat = value; }
        }

        // Check to see if OutputFormat property is set
        internal bool IsSetOutputFormat()
        {
            return this._outputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of an IAM role that this metric stream will use to access Amazon Kinesis Data
        /// Firehose resources. This IAM role must already exist and must be in the same account
        /// as the metric stream. This IAM role must include the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// firehose:PutRecord
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// firehose:PutRecordBatch
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StatisticsConfigurations. 
        /// <para>
        /// By default, a metric stream always sends the <code>MAX</code>, <code>MIN</code>, <code>SUM</code>,
        /// and <code>SAMPLECOUNT</code> statistics for each metric that is streamed. You can
        /// use this parameter to have the metric stream also send additional statistics in the
        /// stream. This array can have up to 100 members.
        /// </para>
        ///  
        /// <para>
        /// For each entry in this array, you specify one or more metrics and the list of additional
        /// statistics to stream for those metrics. The additional statistics that you can stream
        /// depend on the stream's <code>OutputFormat</code>. If the <code>OutputFormat</code>
        /// is <code>json</code>, you can stream any additional statistic that is supported by
        /// CloudWatch, listed in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Statistics-definitions.html.html">
        /// CloudWatch statistics definitions</a>. If the <code>OutputFormat</code> is <code>opentelemetry0.7</code>,
        /// you can stream percentile statistics such as p95, p99.9, and so on.
        /// </para>
        /// </summary>
        public List<MetricStreamStatisticsConfiguration> StatisticsConfigurations
        {
            get { return this._statisticsConfigurations; }
            set { this._statisticsConfigurations = value; }
        }

        // Check to see if StatisticsConfigurations property is set
        internal bool IsSetStatisticsConfigurations()
        {
            return this._statisticsConfigurations != null && this._statisticsConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the metric stream. You can associate as
        /// many as 50 tags with a metric stream.
        /// </para>
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// You can use this parameter only when you are creating a new metric stream. If you
        /// are using this operation to update an existing metric stream, any tags you specify
        /// in this parameter are ignored. To change the tags of an existing metric stream, use
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_TagResource.html">TagResource</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_UntagResource.html">UntagResource</a>.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}