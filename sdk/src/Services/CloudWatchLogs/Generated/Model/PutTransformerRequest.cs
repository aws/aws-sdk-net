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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the PutTransformer operation.
    /// Creates or updates a <i>log transformer</i> for a single log group. You use log transformers
    /// to transform log events into a different format, making them easier for you to process
    /// and analyze. You can also transform logs from different sources into standardized
    /// formats that contains relevant, source-specific information.
    /// 
    ///  
    /// <para>
    /// After you have created a transformer, CloudWatch Logs performs the transformations
    /// at the time of log ingestion. You can then refer to the transformed versions of the
    /// logs during operations such as querying with CloudWatch Logs Insights or creating
    /// metric filters or subscription filers.
    /// </para>
    ///  
    /// <para>
    /// You can also use a transformer to copy metadata from metadata keys into the log events
    /// themselves. This metadata can include log group name, log stream name, account ID
    /// and Region.
    /// </para>
    ///  
    /// <para>
    /// A transformer for a log group is a series of processors, where each processor applies
    /// one type of transformation to the log events ingested into this log group. The processors
    /// work one after another, in the order that you list them, like a pipeline. For more
    /// information about the available processors to use in a transformer, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-Processors">
    /// Processors that you can use</a>.
    /// </para>
    ///  
    /// <para>
    /// Having log events in standardized format enables visibility across your applications
    /// for your log analysis, reporting, and alarming needs. CloudWatch Logs provides transformation
    /// for common log types with out-of-the-box transformation templates for major Amazon
    /// Web Services log sources such as VPC flow logs, Lambda, and Amazon RDS. You can use
    /// pre-built transformation templates or create custom transformation policies.
    /// </para>
    ///  
    /// <para>
    /// You can create transformers only for the log groups in the Standard log class.
    /// </para>
    ///  
    /// <para>
    /// You can also set up a transformer at the account level. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutAccountPolicy.html">PutAccountPolicy</a>.
    /// If there is both a log-group level transformer created with <c>PutTransformer</c>
    /// and an account-level transformer that could apply to the same log group, the log group
    /// uses only the log-group level transformer. It ignores the account-level transformer.
    /// </para>
    /// </summary>
    public partial class PutTransformerRequest : AmazonCloudWatchLogsRequest
    {
        private string _logGroupIdentifier;
        private List<Processor> _transformerConfig = AWSConfigs.InitializeCollections ? new List<Processor>() : null;

        /// <summary>
        /// Gets and sets the property LogGroupIdentifier. 
        /// <para>
        /// Specify either the name or ARN of the log group to create the transformer for. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string LogGroupIdentifier
        {
            get { return this._logGroupIdentifier; }
            set { this._logGroupIdentifier = value; }
        }

        // Check to see if LogGroupIdentifier property is set
        internal bool IsSetLogGroupIdentifier()
        {
            return this._logGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TransformerConfig. 
        /// <para>
        /// This structure contains the configuration of this log transformer. A log transformer
        /// is an array of processors, where each processor applies one type of transformation
        /// to the log events that are ingested.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<Processor> TransformerConfig
        {
            get { return this._transformerConfig; }
            set { this._transformerConfig = value; }
        }

        // Check to see if TransformerConfig property is set
        internal bool IsSetTransformerConfig()
        {
            return this._transformerConfig != null && (this._transformerConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}