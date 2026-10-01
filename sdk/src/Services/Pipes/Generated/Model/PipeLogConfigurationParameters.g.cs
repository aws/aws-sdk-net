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

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// Specifies the logging configuration settings for the pipe.
    /// 
    ///  
    /// <para>
    /// When you call <c>UpdatePipe</c>, EventBridge updates the fields in the <c>PipeLogConfigurationParameters</c>
    /// object atomically as one and overrides existing values. This is by design. If you
    /// don't specify an optional field in any of the Amazon Web Services service parameters
    /// objects (<c>CloudwatchLogsLogDestinationParameters</c>, <c>FirehoseLogDestinationParameters</c>,
    /// or <c>S3LogDestinationParameters</c>), EventBridge sets that field to its system-default
    /// value during the update. 
    /// </para>
    ///  
    /// <para>
    /// For example, suppose when you created the pipe you specified a Firehose stream log
    /// destination. You then update the pipe to add an Amazon S3 log destination. In addition
    /// to specifying the <c>S3LogDestinationParameters</c> for the new log destination, you
    /// must also specify the fields in the <c>FirehoseLogDestinationParameters</c> object
    /// in order to retain the Firehose stream log destination. 
    /// </para>
    ///  
    /// <para>
    /// For more information on generating pipe log records, see <a href="eventbridge/latest/userguide/eb-pipes-logs.html">Log
    /// EventBridge Pipes</a> in the <i>Amazon EventBridge User Guide</i>.
    /// </para>
    /// </summary>
    public partial class PipeLogConfigurationParameters
    {
        /// <summary>
        /// Gets and sets the property CloudwatchLogsLogDestination. 
        /// <para>
        /// The Amazon CloudWatch Logs logging configuration settings for the pipe.
        /// </para>
        /// </summary>
        public CloudwatchLogsLogDestinationParameters CloudwatchLogsLogDestination { get; set; }

        /// <summary>
        /// Checks to see if the CloudwatchLogsLogDestination property is set.
        /// </summary>
        internal bool IsSetCloudwatchLogsLogDestination() => this.CloudwatchLogsLogDestination != null;

        /// <summary>
        /// Gets and sets the property FirehoseLogDestination. 
        /// <para>
        /// The Amazon Data Firehose logging configuration settings for the pipe.
        /// </para>
        /// </summary>
        public FirehoseLogDestinationParameters FirehoseLogDestination { get; set; }

        /// <summary>
        /// Checks to see if the FirehoseLogDestination property is set.
        /// </summary>
        internal bool IsSetFirehoseLogDestination() => this.FirehoseLogDestination != null;

        /// <summary>
        /// Gets and sets the property IncludeExecutionData. 
        /// <para>
        /// Specify <c>ALL</c> to include the execution data (specifically, the <c>payload</c>,
        /// <c>awsRequest</c>, and <c>awsResponse</c> fields) in the log messages for this pipe.
        /// </para>
        ///  
        /// <para>
        /// This applies to all log destinations for the pipe.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes-logs.html#eb-pipes-logs-execution-data">Including
        /// execution data in logs</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, execution data is not included.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IncludeExecutionData { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IncludeExecutionData property is set.
        /// </summary>
        internal bool IsSetIncludeExecutionData() => this.IncludeExecutionData != null && (this.IncludeExecutionData.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// The level of logging detail to include. This applies to all log destinations for the
        /// pipe.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes-logs.html#eb-pipes-logs-level">Specifying
        /// EventBridge Pipes log level</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LogLevel Level { get; set; }

        /// <summary>
        /// Checks to see if the Level property is set.
        /// </summary>
        internal bool IsSetLevel() => this.Level != null;

        /// <summary>
        /// Gets and sets the property S3LogDestination. 
        /// <para>
        /// The Amazon S3 logging configuration settings for the pipe.
        /// </para>
        /// </summary>
        public S3LogDestinationParameters S3LogDestination { get; set; }

        /// <summary>
        /// Checks to see if the S3LogDestination property is set.
        /// </summary>
        internal bool IsSetS3LogDestination() => this.S3LogDestination != null;
    }
}
