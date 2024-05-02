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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
    /// Container for the parameters to the UpdateInferenceScheduler operation.
    /// Updates an inference scheduler.
    /// </summary>
    public partial class UpdateInferenceSchedulerRequest : AmazonLookoutEquipmentRequest
    {
        private long? _dataDelayOffsetInMinutes;
        private InferenceInputConfiguration _dataInputConfiguration;
        private InferenceOutputConfiguration _dataOutputConfiguration;
        private DataUploadFrequency _dataUploadFrequency;
        private string _inferenceSchedulerName;
        private string _roleArn;

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
        [AWSProperty(Min=0, Max=60)]
        public long? DataDelayOffsetInMinutes
        {
            get { return this._dataDelayOffsetInMinutes; }
            set { this._dataDelayOffsetInMinutes = value; }
        }

        // Check to see if DataDelayOffsetInMinutes property is set
        internal bool IsSetDataDelayOffsetInMinutes()
        {
            return this._dataDelayOffsetInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataInputConfiguration. 
        /// <para>
        ///  Specifies information for the input data for the inference scheduler, including delimiter,
        /// format, and dataset location. 
        /// </para>
        /// </summary>
        public InferenceInputConfiguration DataInputConfiguration
        {
            get { return this._dataInputConfiguration; }
            set { this._dataInputConfiguration = value; }
        }

        // Check to see if DataInputConfiguration property is set
        internal bool IsSetDataInputConfiguration()
        {
            return this._dataInputConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DataOutputConfiguration. 
        /// <para>
        ///  Specifies information for the output results from the inference scheduler, including
        /// the output S3 location. 
        /// </para>
        /// </summary>
        public InferenceOutputConfiguration DataOutputConfiguration
        {
            get { return this._dataOutputConfiguration; }
            set { this._dataOutputConfiguration = value; }
        }

        // Check to see if DataOutputConfiguration property is set
        internal bool IsSetDataOutputConfiguration()
        {
            return this._dataOutputConfiguration != null;
        }

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
        public DataUploadFrequency DataUploadFrequency
        {
            get { return this._dataUploadFrequency; }
            set { this._dataUploadFrequency = value; }
        }

        // Check to see if DataUploadFrequency property is set
        internal bool IsSetDataUploadFrequency()
        {
            return this._dataUploadFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceSchedulerName. 
        /// <para>
        /// The name of the inference scheduler to be updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string InferenceSchedulerName
        {
            get { return this._inferenceSchedulerName; }
            set { this._inferenceSchedulerName = value; }
        }

        // Check to see if InferenceSchedulerName property is set
        internal bool IsSetInferenceSchedulerName()
        {
            return this._inferenceSchedulerName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of a role with permission to access the data source
        /// for the inference scheduler. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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

    }
}