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
    /// This is the response object from the DescribeInferenceScheduler operation.
    /// </summary>
    public partial class DescribeInferenceSchedulerResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Specifies the time at which the inference scheduler was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataDelayOffsetInMinutes. 
        /// <para>
        ///  A period of time (in minutes) by which inference on the data is delayed after the
        /// data starts. For instance, if you select an offset delay time of five minutes, inference
        /// will not begin on the data until the first data measurement after the five minute
        /// mark. For example, if five minutes is selected, the inference scheduler will wake
        /// up at the configured frequency with the additional five minute delay time to check
        /// the customer S3 bucket. The customer can upload data at the same frequency and they
        /// don't need to stop and restart the scheduler when uploading new data.
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
        ///  Specifies configuration information for the input data for the inference scheduler,
        /// including delimiter, format, and dataset location. 
        /// </para>
        /// </summary>
        public InferenceInputConfiguration DataInputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataInputConfiguration property is set.
        /// </summary>
        internal bool IsSetDataInputConfiguration() => this.DataInputConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataOutputConfiguration. 
        /// <para>
        ///  Specifies information for the output results for the inference scheduler, including
        /// the output S3 location. 
        /// </para>
        /// </summary>
        public InferenceOutputConfiguration DataOutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataOutputConfiguration property is set.
        /// </summary>
        internal bool IsSetDataOutputConfiguration() => this.DataOutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataUploadFrequency. 
        /// <para>
        /// Specifies how often data is uploaded to the source S3 bucket for the input data. This
        /// value is the length of time between data uploads. For instance, if you select 5 minutes,
        /// Amazon Lookout for Equipment will upload the real-time data to the source bucket once
        /// every 5 minutes. This frequency also determines how often Amazon Lookout for Equipment
        /// starts a scheduled inference on your data. In this example, it starts once every 5
        /// minutes. 
        /// </para>
        /// </summary>
        public DataUploadFrequency DataUploadFrequency { get; set; }

        /// <summary>
        /// Checks to see if the DataUploadFrequency property is set.
        /// </summary>
        internal bool IsSetDataUploadFrequency() => this.DataUploadFrequency != null;

        /// <summary>
        /// Gets and sets the property InferenceSchedulerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the inference scheduler being described. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string InferenceSchedulerArn { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSchedulerArn property is set.
        /// </summary>
        internal bool IsSetInferenceSchedulerArn() => this.InferenceSchedulerArn != null;

        /// <summary>
        /// Gets and sets the property InferenceSchedulerName. 
        /// <para>
        /// The name of the inference scheduler being described. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string InferenceSchedulerName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSchedulerName property is set.
        /// </summary>
        internal bool IsSetInferenceSchedulerName() => this.InferenceSchedulerName != null;

        /// <summary>
        /// Gets and sets the property LatestInferenceResult. 
        /// <para>
        /// Indicates whether the latest execution for the inference scheduler was Anomalous (anomalous
        /// events found) or Normal (no anomalous events found).
        /// </para>
        /// </summary>
        public LatestInferenceResult LatestInferenceResult { get; set; }

        /// <summary>
        /// Checks to see if the LatestInferenceResult property is set.
        /// </summary>
        internal bool IsSetLatestInferenceResult() => this.LatestInferenceResult != null;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the machine learning model of the inference scheduler
        /// being described. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the machine learning model of the inference scheduler being described.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of a role with permission to access the data source
        /// for the inference scheduler being described. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
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
        [AWSProperty(Min = 1, Max = 1024)]
        public string ServerSideKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideKmsKeyId property is set.
        /// </summary>
        internal bool IsSetServerSideKmsKeyId() => this.ServerSideKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of the inference scheduler. 
        /// </para>
        /// </summary>
        public InferenceSchedulerStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Specifies the time at which the inference scheduler was last updated, if it was. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
