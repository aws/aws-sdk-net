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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAnomaly operation. Use this operation to
    /// <i>suppress</i> anomaly detection for a specified anomaly or pattern. If you suppress
    /// an anomaly, CloudWatch Logs won't report new occurrences of that anomaly and won't
    /// update that anomaly with new data. If you suppress a pattern, CloudWatch Logs won't
    /// report any anomalies related to that pattern. <para> You must specify either <c>anomalyId</c>
    /// or <c>patternId</c>, but you can't specify both parameters in the same operation.
    /// </para> <para> If you have previously used this operation to suppress detection of
    /// a pattern or anomaly, you can use it again to cause CloudWatch Logs to end the suppression.
    /// To do this, use this operation and specify the anomaly or pattern to stop suppressing,
    /// and omit the <c>suppressionType</c> and <c>suppressionPeriod</c> parameters. </para>
    /// </summary>
    public partial class UpdateAnomalyRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// The ARN of the anomaly detector that this operation is to act on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string AnomalyDetectorArn { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyDetectorArn property is set.
        /// </summary>
        internal bool IsSetAnomalyDetectorArn() => this.AnomalyDetectorArn != null;

        /// <summary>
        /// Gets and sets the property AnomalyId. 
        /// <para>
        /// If you are suppressing or unsuppressing an anomaly, specify its unique ID here. You
        /// can find anomaly IDs by using the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_ListAnomalies.html">ListAnomalies</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string AnomalyId { get; set; }

        /// <summary>
        /// Checks to see if the AnomalyId property is set.
        /// </summary>
        internal bool IsSetAnomalyId() => this.AnomalyId != null;

        /// <summary>
        /// Gets and sets the property Baseline. 
        /// <para>
        /// Set this to <c>true</c> to prevent CloudWatch Logs from displaying this behavior as
        /// an anomaly in the future. The behavior is then treated as baseline behavior. However,
        /// if similar but more severe occurrences of this behavior occur in the future, those
        /// will still be reported as anomalies. 
        /// </para>
        ///  
        /// <para>
        /// The default is <c>false</c> 
        /// </para>
        /// </summary>
        public bool? Baseline { get; set; }

        /// <summary>
        /// Checks to see if the Baseline property is set.
        /// </summary>
        internal bool IsSetBaseline() => this.Baseline.HasValue;

        /// <summary>
        /// Gets and sets the property PatternId. 
        /// <para>
        /// If you are suppressing or unsuppressing an pattern, specify its unique ID here. You
        /// can find pattern IDs by using the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_ListAnomalies.html">ListAnomalies</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 32)]
        public string PatternId { get; set; }

        /// <summary>
        /// Checks to see if the PatternId property is set.
        /// </summary>
        internal bool IsSetPatternId() => this.PatternId != null;

        /// <summary>
        /// Gets and sets the property SuppressionPeriod. 
        /// <para>
        /// If you are temporarily suppressing an anomaly or pattern, use this structure to specify
        /// how long the suppression is to last.
        /// </para>
        /// </summary>
        public SuppressionPeriod SuppressionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the SuppressionPeriod property is set.
        /// </summary>
        internal bool IsSetSuppressionPeriod() => this.SuppressionPeriod != null;

        /// <summary>
        /// Gets and sets the property SuppressionType. 
        /// <para>
        /// Use this to specify whether the suppression to be temporary or infinite. If you specify
        /// <c>LIMITED</c>, you must also specify a <c>suppressionPeriod</c>. If you specify <c>INFINITE</c>,
        /// any value for <c>suppressionPeriod</c> is ignored. 
        /// </para>
        /// </summary>
        public SuppressionType SuppressionType { get; set; }

        /// <summary>
        /// Checks to see if the SuppressionType property is set.
        /// </summary>
        internal bool IsSetSuppressionType() => this.SuppressionType != null;
    }
}
