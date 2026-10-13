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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Input object for the endpoint
    /// </summary>
    public partial class EndpointInput
    {
        /// <summary>
        /// Gets and sets the property EndTimeOffset. 
        /// <para>
        /// If specified, monitoring jobs substract this time from the end time. For information
        /// about using offsets for scheduling monitoring jobs, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor-model-quality-schedule.html">Schedule
        /// Model Quality Monitoring Jobs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public string EndTimeOffset { get; set; }

        /// <summary>
        /// Checks to see if the EndTimeOffset property is set.
        /// </summary>
        internal bool IsSetEndTimeOffset() => this.EndTimeOffset != null;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// An endpoint in customer's account which has enabled <c>DataCaptureConfig</c> enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property ExcludeFeaturesAttribute. 
        /// <para>
        /// The attributes of the input data to exclude from the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string ExcludeFeaturesAttribute { get; set; }

        /// <summary>
        /// Checks to see if the ExcludeFeaturesAttribute property is set.
        /// </summary>
        internal bool IsSetExcludeFeaturesAttribute() => this.ExcludeFeaturesAttribute != null;

        /// <summary>
        /// Gets and sets the property FeaturesAttribute. 
        /// <para>
        /// The attributes of the input data that are the input features.
        /// </para>
        /// </summary>
        public string FeaturesAttribute { get; set; }

        /// <summary>
        /// Checks to see if the FeaturesAttribute property is set.
        /// </summary>
        internal bool IsSetFeaturesAttribute() => this.FeaturesAttribute != null;

        /// <summary>
        /// Gets and sets the property InferenceAttribute. 
        /// <para>
        /// The attribute of the input data that represents the ground truth label.
        /// </para>
        /// </summary>
        public string InferenceAttribute { get; set; }

        /// <summary>
        /// Checks to see if the InferenceAttribute property is set.
        /// </summary>
        internal bool IsSetInferenceAttribute() => this.InferenceAttribute != null;

        /// <summary>
        /// Gets and sets the property LocalPath. 
        /// <para>
        /// Path to the filesystem where the endpoint data is available to the container.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string LocalPath { get; set; }

        /// <summary>
        /// Checks to see if the LocalPath property is set.
        /// </summary>
        internal bool IsSetLocalPath() => this.LocalPath != null;

        /// <summary>
        /// Gets and sets the property ProbabilityAttribute. 
        /// <para>
        /// In a classification problem, the attribute that represents the class probability.
        /// </para>
        /// </summary>
        public string ProbabilityAttribute { get; set; }

        /// <summary>
        /// Checks to see if the ProbabilityAttribute property is set.
        /// </summary>
        internal bool IsSetProbabilityAttribute() => this.ProbabilityAttribute != null;

        /// <summary>
        /// Gets and sets the property ProbabilityThresholdAttribute. 
        /// <para>
        /// The threshold for the class probability to be evaluated as a positive result.
        /// </para>
        /// </summary>
        public double? ProbabilityThresholdAttribute { get; set; }

        /// <summary>
        /// Checks to see if the ProbabilityThresholdAttribute property is set.
        /// </summary>
        internal bool IsSetProbabilityThresholdAttribute() => this.ProbabilityThresholdAttribute.HasValue;

        /// <summary>
        /// Gets and sets the property S3DataDistributionType. 
        /// <para>
        /// Whether input data distributed in Amazon S3 is fully replicated or sharded by an Amazon
        /// S3 key. Defaults to <c>FullyReplicated</c> 
        /// </para>
        /// </summary>
        public ProcessingS3DataDistributionType S3DataDistributionType { get; set; }

        /// <summary>
        /// Checks to see if the S3DataDistributionType property is set.
        /// </summary>
        internal bool IsSetS3DataDistributionType() => this.S3DataDistributionType != null;

        /// <summary>
        /// Gets and sets the property S3InputMode. 
        /// <para>
        /// Whether the <c>Pipe</c> or <c>File</c> is used as the input mode for transferring
        /// data for the monitoring job. <c>Pipe</c> mode is recommended for large datasets. <c>File</c>
        /// mode is useful for small files that fit in memory. Defaults to <c>File</c>.
        /// </para>
        /// </summary>
        public ProcessingS3InputMode S3InputMode { get; set; }

        /// <summary>
        /// Checks to see if the S3InputMode property is set.
        /// </summary>
        internal bool IsSetS3InputMode() => this.S3InputMode != null;

        /// <summary>
        /// Gets and sets the property StartTimeOffset. 
        /// <para>
        /// If specified, monitoring jobs substract this time from the start time. For information
        /// about using offsets for scheduling monitoring jobs, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor-model-quality-schedule.html">Schedule
        /// Model Quality Monitoring Jobs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public string StartTimeOffset { get; set; }

        /// <summary>
        /// Checks to see if the StartTimeOffset property is set.
        /// </summary>
        internal bool IsSetStartTimeOffset() => this.StartTimeOffset != null;
    }
}
