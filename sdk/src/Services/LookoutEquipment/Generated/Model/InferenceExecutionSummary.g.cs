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
    /// Contains information about the specific inference execution, including input and output
    /// data configuration, inference scheduling information, status, and so on.
    /// </summary>
    public partial class InferenceExecutionSummary
    {
        /// <summary>
        /// Gets and sets the property CustomerResultObject. 
        /// <para>
        /// The S3 object that the inference execution results were uploaded to.
        /// </para>
        /// </summary>
        public S3Object CustomerResultObject { get; set; }

        /// <summary>
        /// Checks to see if the CustomerResultObject property is set.
        /// </summary>
        internal bool IsSetCustomerResultObject() => this.CustomerResultObject != null;

        /// <summary>
        /// Gets and sets the property DataEndTime. 
        /// <para>
        /// Indicates the time reference in the dataset at which the inference execution stopped.
        /// 
        /// </para>
        /// </summary>
        public DateTime? DataEndTime { get; set; }

        /// <summary>
        /// Checks to see if the DataEndTime property is set.
        /// </summary>
        internal bool IsSetDataEndTime() => this.DataEndTime.HasValue;

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
        ///  Specifies configuration information for the output results from for the inference
        /// execution, including the output Amazon S3 location. 
        /// </para>
        /// </summary>
        public InferenceOutputConfiguration DataOutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataOutputConfiguration property is set.
        /// </summary>
        internal bool IsSetDataOutputConfiguration() => this.DataOutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataStartTime. 
        /// <para>
        /// Indicates the time reference in the dataset at which the inference execution began.
        /// 
        /// </para>
        /// </summary>
        public DateTime? DataStartTime { get; set; }

        /// <summary>
        /// Checks to see if the DataStartTime property is set.
        /// </summary>
        internal bool IsSetDataStartTime() => this.DataStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailedReason. 
        /// <para>
        ///  Specifies the reason for failure when an inference execution has failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5000)]
        public string FailedReason { get; set; }

        /// <summary>
        /// Checks to see if the FailedReason property is set.
        /// </summary>
        internal bool IsSetFailedReason() => this.FailedReason != null;

        /// <summary>
        /// Gets and sets the property InferenceSchedulerArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the inference scheduler being used for the inference
        /// execution. 
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
        /// The name of the inference scheduler being used for the inference execution. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string InferenceSchedulerName { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSchedulerName property is set.
        /// </summary>
        internal bool IsSetInferenceSchedulerName() => this.InferenceSchedulerName != null;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the machine learning model used for the inference
        /// execution. 
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
        /// The name of the machine learning model being used for the inference execution. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The model version used for the inference execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? ModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelVersion property is set.
        /// </summary>
        internal bool IsSetModelVersion() => this.ModelVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ModelVersionArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the model version used for the inference execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ModelVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelVersionArn property is set.
        /// </summary>
        internal bool IsSetModelVersionArn() => this.ModelVersionArn != null;

        /// <summary>
        /// Gets and sets the property ScheduledStartTime. 
        /// <para>
        /// Indicates the start time at which the inference scheduler began the specific inference
        /// execution. 
        /// </para>
        /// </summary>
        public DateTime? ScheduledStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledStartTime property is set.
        /// </summary>
        internal bool IsSetScheduledStartTime() => this.ScheduledStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of the inference execution. 
        /// </para>
        /// </summary>
        public InferenceExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
