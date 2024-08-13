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
    /// Contains information about the specific inference execution, including input and output
    /// data configuration, inference scheduling information, status, and so on.
    /// </summary>
    public partial class InferenceExecutionSummary
    {
        private S3Object _customerResultObject;
        private DateTime? _dataEndTime;
        private InferenceInputConfiguration _dataInputConfiguration;
        private InferenceOutputConfiguration _dataOutputConfiguration;
        private DateTime? _dataStartTime;
        private string _failedReason;
        private string _inferenceSchedulerArn;
        private string _inferenceSchedulerName;
        private string _modelArn;
        private string _modelName;
        private long? _modelVersion;
        private string _modelVersionArn;
        private DateTime? _scheduledStartTime;
        private InferenceExecutionStatus _status;

        /// <summary>
        /// Gets and sets the property CustomerResultObject. 
        /// <para>
        /// The S3 object that the inference execution results were uploaded to.
        /// </para>
        /// </summary>
        public S3Object CustomerResultObject
        {
            get { return this._customerResultObject; }
            set { this._customerResultObject = value; }
        }

        // Check to see if CustomerResultObject property is set
        internal bool IsSetCustomerResultObject()
        {
            return this._customerResultObject != null;
        }

        /// <summary>
        /// Gets and sets the property DataEndTime. 
        /// <para>
        /// Indicates the time reference in the dataset at which the inference execution stopped.
        /// 
        /// </para>
        /// </summary>
        public DateTime? DataEndTime
        {
            get { return this._dataEndTime; }
            set { this._dataEndTime = value; }
        }

        // Check to see if DataEndTime property is set
        internal bool IsSetDataEndTime()
        {
            return this._dataEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataInputConfiguration. 
        /// <para>
        ///  Specifies configuration information for the input data for the inference scheduler,
        /// including delimiter, format, and dataset location. 
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
        ///  Specifies configuration information for the output results from for the inference
        /// execution, including the output Amazon S3 location. 
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
        /// Gets and sets the property DataStartTime. 
        /// <para>
        /// Indicates the time reference in the dataset at which the inference execution began.
        /// 
        /// </para>
        /// </summary>
        public DateTime? DataStartTime
        {
            get { return this._dataStartTime; }
            set { this._dataStartTime = value; }
        }

        // Check to see if DataStartTime property is set
        internal bool IsSetDataStartTime()
        {
            return this._dataStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedReason. 
        /// <para>
        ///  Specifies the reason for failure when an inference execution has failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public string FailedReason
        {
            get { return this._failedReason; }
            set { this._failedReason = value; }
        }

        // Check to see if FailedReason property is set
        internal bool IsSetFailedReason()
        {
            return this._failedReason != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceSchedulerArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the inference scheduler being used for the inference
        /// execution. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string InferenceSchedulerArn
        {
            get { return this._inferenceSchedulerArn; }
            set { this._inferenceSchedulerArn = value; }
        }

        // Check to see if InferenceSchedulerArn property is set
        internal bool IsSetInferenceSchedulerArn()
        {
            return this._inferenceSchedulerArn != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceSchedulerName. 
        /// <para>
        /// The name of the inference scheduler being used for the inference execution. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the machine learning model used for the inference
        /// execution. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the machine learning model being used for the inference execution. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The model version used for the inference execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelVersionArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the model version used for the inference execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ModelVersionArn
        {
            get { return this._modelVersionArn; }
            set { this._modelVersionArn = value; }
        }

        // Check to see if ModelVersionArn property is set
        internal bool IsSetModelVersionArn()
        {
            return this._modelVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledStartTime. 
        /// <para>
        /// Indicates the start time at which the inference scheduler began the specific inference
        /// execution. 
        /// </para>
        /// </summary>
        public DateTime? ScheduledStartTime
        {
            get { return this._scheduledStartTime; }
            set { this._scheduledStartTime = value; }
        }

        // Check to see if ScheduledStartTime property is set
        internal bool IsSetScheduledStartTime()
        {
            return this._scheduledStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of the inference execution. 
        /// </para>
        /// </summary>
        public InferenceExecutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}