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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the GetModelInvocationJob operation.
    /// </summary>
    public partial class GetModelInvocationJobResponse : AmazonWebServiceResponse
    {
        private string _clientRequestToken;
        private DateTime? _endTime;
        private ModelInvocationJobInputDataConfig _inputDataConfig;
        private string _jobArn;
        private DateTime? _jobExpirationTime;
        private string _jobName;
        private DateTime? _lastModifiedTime;
        private string _message;
        private string _modelId;
        private ModelInvocationJobOutputDataConfig _outputDataConfig;
        private string _roleArn;
        private ModelInvocationJobStatus _status;
        private DateTime? _submitTime;
        private int? _timeoutDurationInHours;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request, but does not return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the batch inference job ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Details about the location of the input to the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelInvocationJobInputDataConfig InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1011)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobExpirationTime. 
        /// <para>
        /// The time at which the batch inference job times or timed out.
        /// </para>
        /// </summary>
        public DateTime? JobExpirationTime
        {
            get { return this._jobExpirationTime; }
            set { this._jobExpirationTime = value; }
        }

        // Check to see if JobExpirationTime property is set
        internal bool IsSetJobExpirationTime()
        {
            return this._jobExpirationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time at which the batch inference job was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If the batch inference job failed, this field contains a message describing why the
        /// job failed.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The unique identifier of the foundation model used for model inference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Details about the location of the output of the batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelInvocationJobOutputDataConfig OutputDataConfig
        {
            get { return this._outputDataConfig; }
            set { this._outputDataConfig = value; }
        }

        // Check to see if OutputDataConfig property is set
        internal bool IsSetOutputDataConfig()
        {
            return this._outputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service role with permissions to carry out and
        /// manage batch inference. You can use the console to create a default service role or
        /// follow the steps at <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-iam-sr.html">Create
        /// a service role for batch inference</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the batch inference job.
        /// </para>
        ///  
        /// <para>
        /// The following statuses are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Submitted – This job has been submitted to a queue for validation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Validating – This job is being validated for the requirements described in <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-data.html">Format
        /// and upload your batch inference data</a>. The criteria include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your IAM service role has access to the Amazon S3 buckets containing your files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your files are .jsonl files and each individual record is a JSON object in the correct
        /// format. Note that validation doesn't check if the <c>modelInput</c> value matches
        /// the request body for the model.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your files fulfill the requirements for file size and number of records. For more
        /// information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/quotas.html">Quotas
        /// for Amazon Bedrock</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Scheduled – This job has been validated and is now in a queue. The job will automatically
        /// start when it reaches its turn.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Expired – This job timed out because it was scheduled but didn't begin before the
        /// set timeout duration. Submit a new job request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InProgress – This job has begun. You can start viewing the results in the output S3
        /// location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Completed – This job has successfully completed. View the output files in the output
        /// S3 location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PartiallyCompleted – This job has partially completed. Not all of your records could
        /// be processed in time. View the output files in the output S3 location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed – This job has failed. Check the failure message for any further details. For
        /// further assistance, reach out to the <a href="https://console.aws.amazon.com/support/home/">Amazon
        /// Web ServicesSupport Center</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stopped – This job was stopped by a user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stopping – This job is being stopped by a user.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ModelInvocationJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SubmitTime. 
        /// <para>
        /// The time at which the batch inference job was submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? SubmitTime
        {
            get { return this._submitTime; }
            set { this._submitTime = value; }
        }

        // Check to see if SubmitTime property is set
        internal bool IsSetSubmitTime()
        {
            return this._submitTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutDurationInHours. 
        /// <para>
        /// The number of hours after which batch inference job was set to time out.
        /// </para>
        /// </summary>
        [AWSProperty(Min=24, Max=168)]
        public int? TimeoutDurationInHours
        {
            get { return this._timeoutDurationInHours; }
            set { this._timeoutDurationInHours = value; }
        }

        // Check to see if TimeoutDurationInHours property is set
        internal bool IsSetTimeoutDurationInHours()
        {
            return this._timeoutDurationInHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The configuration of the Virtual Private Cloud (VPC) for the data in the batch inference
        /// job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-vpc">Protect
        /// batch inference jobs using a VPC</a>.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}