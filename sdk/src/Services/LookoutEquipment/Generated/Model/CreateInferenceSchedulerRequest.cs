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
    /// Container for the parameters to the CreateInferenceScheduler operation.
    /// Creates a scheduled inference. Scheduling an inference is setting up a continuous
    /// real-time inference plan to analyze new measurement data. When setting up the schedule,
    /// you provide an S3 bucket location for the input data, assign it a delimiter between
    /// separate entries in the data, set an offset delay if desired, and set the frequency
    /// of inferencing. You must also provide an S3 bucket location for the output data.
    /// </summary>
    public partial class CreateInferenceSchedulerRequest : AmazonLookoutEquipmentRequest
    {
        private string _clientToken;
        private long? _dataDelayOffsetInMinutes;
        private InferenceInputConfiguration _dataInputConfiguration;
        private InferenceOutputConfiguration _dataOutputConfiguration;
        private DataUploadFrequency _dataUploadFrequency;
        private string _inferenceSchedulerName;
        private string _modelName;
        private string _roleArn;
        private string _serverSideKmsKeyId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique identifier for the request. If you do not set the client request token,
        /// Amazon Lookout for Equipment generates one. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

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
        /// Specifies configuration information for the input data for the inference scheduler,
        /// including delimiter, format, and dataset location. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Specifies configuration information for the output results for the inference scheduler,
        /// including the S3 location for the output. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// The name of the inference scheduler being created. 
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
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the previously trained machine learning model being used to create the
        /// inference scheduler. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a role with permission to access the data source
        /// being used for the inference. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property ServerSideKmsKeyId. 
        /// <para>
        /// Provides the identifier of the KMS key used to encrypt inference scheduler data by
        /// Amazon Lookout for Equipment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ServerSideKmsKeyId
        {
            get { return this._serverSideKmsKeyId; }
            set { this._serverSideKmsKeyId = value; }
        }

        // Check to see if ServerSideKmsKeyId property is set
        internal bool IsSetServerSideKmsKeyId()
        {
            return this._serverSideKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags associated with the inference scheduler. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}