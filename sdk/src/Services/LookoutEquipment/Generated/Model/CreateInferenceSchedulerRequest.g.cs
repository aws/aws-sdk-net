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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInferenceScheduler operation. Creates a
    /// scheduled inference. Scheduling an inference is setting up a continuous real-time
    /// inference plan to analyze new measurement data. When setting up the schedule, you
    /// provide an S3 bucket location for the input data, assign it a delimiter between separate
    /// entries in the data, set an offset delay if desired, and set the frequency of inferencing.
    /// You must also provide an S3 bucket location for the output data.
    /// </summary>
    public partial class CreateInferenceSchedulerRequest : AmazonLookoutEquipmentRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique identifier for the request. If you do not set the client request token,
        /// Amazon Lookout for Equipment generates one. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DataDelayOffsetInMinutes. 
        /// <para>
        /// The interval (in minutes) of planned delay at the start of each inference segment.
        /// For example, if inference is set to run every ten minutes, the delay is set to five
        /// minutes and the time is 09:08. The inference scheduler will wake up at the configured
        /// interval (which, without a delay configured, would be 09:10) plus the additional five
        /// minute delay time (so 09:15) to check your Amazon S3 bucket. The delay provides a
        /// buffer for you to upload data at the same frequency, so that you don't have to stop
        /// and restart the scheduler when uploading new data.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lookout-for-equipment/latest/ug/understanding-inference-process.html">Understanding
        /// the inference process</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 60)]
        public long? DataDelayOffsetInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the DataDelayOffsetInMinutes property is set.
        /// </summary>
        internal bool IsSetDataDelayOffsetInMinutes() => this.DataDelayOffsetInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property DataInputConfiguration. 
        /// <para>
        /// Specifies configuration information for the input data for the inference scheduler,
        /// including delimiter, format, and dataset location. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InferenceInputConfiguration DataInputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataInputConfiguration property is set.
        /// </summary>
        internal bool IsSetDataInputConfiguration() => this.DataInputConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataOutputConfiguration. 
        /// <para>
        /// Specifies configuration information for the output results for the inference scheduler,
        /// including the S3 location for the output. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InferenceOutputConfiguration DataOutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataOutputConfiguration property is set.
        /// </summary>
        internal bool IsSetDataOutputConfiguration() => this.DataOutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataUploadFrequency. 
        /// <para>
        ///  How often data is uploaded to the source Amazon S3 bucket for the input data. The
        /// value chosen is the length of time between data uploads. For instance, if you select
        /// 5 minutes, Amazon Lookout for Equipment will upload the real-time data to the source
        /// bucket once every 5 minutes. This frequency also determines how often Amazon Lookout
        /// for Equipment runs inference on your data.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lookout-for-equipment/latest/ug/understanding-inference-process.html">Understanding
        /// the inference process</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataUploadFrequency DataUploadFrequency { get; set; }

        /// <summary>
        /// Checks to see if the DataUploadFrequency property is set.
        /// </summary>
        internal bool IsSetDataUploadFrequency() => this.DataUploadFrequency != null;

        /// <summary>
        /// Gets and sets the property InferenceSchedulerName. 
        /// <para>
        /// The name of the inference scheduler being created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string InferenceSchedulerName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSchedulerName property is set.
        /// </summary>
        internal bool IsSetInferenceSchedulerName() => this.InferenceSchedulerName != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the previously trained machine learning model being used to create the
        /// inference scheduler. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a role with permission to access the data source
        /// being used for the inference. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property ServerSideKmsKeyId. 
        /// <para>
        /// Provides the identifier of the KMS key used to encrypt inference scheduler data by
        /// Amazon Lookout for Equipment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ServerSideKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideKmsKeyId property is set.
        /// </summary>
        internal bool IsSetServerSideKmsKeyId() => this.ServerSideKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags associated with the inference scheduler. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
