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

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// This is the response object from the GetEarthObservationJob operation.
    /// </summary>
    public partial class GetEarthObservationJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Earth Observation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the initiated Earth Observation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The duration of Earth Observation job, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? DurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationInSeconds property is set.
        /// </summary>
        internal bool IsSetDurationInSeconds() => this.DurationInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// Details about the errors generated during the Earth Observation job.
        /// </para>
        /// </summary>
        public EarthObservationJobErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that you specified for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property ExportErrorDetails. 
        /// <para>
        /// Details about the errors generated during ExportEarthObservationJob.
        /// </para>
        /// </summary>
        public ExportErrorDetails ExportErrorDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExportErrorDetails property is set.
        /// </summary>
        internal bool IsSetExportErrorDetails() => this.ExportErrorDetails != null;

        /// <summary>
        /// Gets and sets the property ExportStatus. 
        /// <para>
        /// The status of the Earth Observation job.
        /// </para>
        /// </summary>
        public EarthObservationJobExportStatus ExportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExportStatus property is set.
        /// </summary>
        internal bool IsSetExportStatus() => this.ExportStatus != null;

        /// <summary>
        /// Gets and sets the property InputConfig. 
        /// <para>
        /// Input data for the Earth Observation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InputConfigOutput InputConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputConfig property is set.
        /// </summary>
        internal bool IsSetInputConfig() => this.InputConfig != null;

        /// <summary>
        /// Gets and sets the property JobConfig. 
        /// <para>
        /// An object containing information about the job configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobConfigInput JobConfig { get; set; }

        /// <summary>
        /// Checks to see if the JobConfig property is set.
        /// </summary>
        internal bool IsSetJobConfig() => this.JobConfig != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Key Management Service key ID for server-side encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Earth Observation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputBands. 
        /// <para>
        /// Bands available in the output of an operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputBand> OutputBands { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputBand>() : null;

        /// <summary>
        /// Checks to see if the OutputBands property is set.
        /// </summary>
        internal bool IsSetOutputBands() => this.OutputBands != null && (this.OutputBands.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a previously initiated Earth Observation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EarthObservationJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Each tag consists of a key and a value.
        /// </para>
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
    }
}
