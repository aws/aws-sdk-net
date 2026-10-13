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
    /// The currently active data capture configuration used by your Endpoint.
    /// </summary>
    public partial class DataCaptureConfigSummary
    {
        /// <summary>
        /// Gets and sets the property CaptureStatus. 
        /// <para>
        /// Whether data capture is currently functional.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CaptureStatus CaptureStatus { get; set; }

        /// <summary>
        /// Checks to see if the CaptureStatus property is set.
        /// </summary>
        internal bool IsSetCaptureStatus() => this.CaptureStatus != null;

        /// <summary>
        /// Gets and sets the property CurrentSamplingPercentage. 
        /// <para>
        /// The percentage of requests being captured by your Endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public int? CurrentSamplingPercentage { get; set; }

        /// <summary>
        /// Checks to see if the CurrentSamplingPercentage property is set.
        /// </summary>
        internal bool IsSetCurrentSamplingPercentage() => this.CurrentSamplingPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationS3Uri. 
        /// <para>
        /// The Amazon S3 location being used to capture the data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 512)]
        public string DestinationS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the DestinationS3Uri property is set.
        /// </summary>
        internal bool IsSetDestinationS3Uri() => this.DestinationS3Uri != null;

        /// <summary>
        /// Gets and sets the property EnableCapture. 
        /// <para>
        /// Whether data capture is enabled or disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? EnableCapture { get; set; }

        /// <summary>
        /// Checks to see if the EnableCapture property is set.
        /// </summary>
        internal bool IsSetEnableCapture() => this.EnableCapture.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key being used to encrypt the data in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;
    }
}
