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
    /// Container for the parameters to the UpdateInferenceScheduler operation. Updates an
    /// inference scheduler.
    /// </summary>
    public partial class UpdateInferenceSchedulerRequest : AmazonLookoutEquipmentRequest
    {
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
        ///  Specifies information for the input data for the inference scheduler, including delimiter,
        /// format, and dataset location. 
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
        ///  Specifies information for the output results from the inference scheduler, including
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
        /// How often data is uploaded to the source S3 bucket for the input data. The value chosen
        /// is the length of time between data uploads. For instance, if you select 5 minutes,
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
        /// Gets and sets the property InferenceSchedulerName. 
        /// <para>
        /// The name of the inference scheduler to be updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string InferenceSchedulerName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSchedulerName property is set.
        /// </summary>
        internal bool IsSetInferenceSchedulerName() => this.InferenceSchedulerName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of a role with permission to access the data source
        /// for the inference scheduler. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
