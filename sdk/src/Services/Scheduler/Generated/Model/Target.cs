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
 * Do not modify this file. This file is generated from the scheduler-2021-06-30.normal.json service model.
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
namespace Amazon.Scheduler.Model
{
    /// <summary>
    /// The schedule's target. EventBridge Scheduler supports templated target that invoke
    /// common API operations, as well as universal targets that you can customize to invoke
    /// over 6,000 API operations across more than 270 services. You can only specify one
    /// templated or universal target for a schedule.
    /// </summary>
    public partial class Target
    {
        private string _arn;
        private DeadLetterConfig _deadLetterConfig;
        private EcsParameters _ecsParameters;
        private EventBridgeParameters _eventBridgeParameters;
        private string _input;
        private KinesisParameters _kinesisParameters;
        private RetryPolicy _retryPolicy;
        private string _roleArn;
        private SageMakerPipelineParameters _sageMakerPipelineParameters;
        private SqsParameters _sqsParameters;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DeadLetterConfig. 
        /// <para>
        /// An object that contains information about an Amazon SQS queue that EventBridge Scheduler
        /// uses as a dead-letter queue for your schedule. If specified, EventBridge Scheduler
        /// delivers failed events that could not be successfully delivered to a target to the
        /// queue.
        /// </para>
        /// </summary>
        public DeadLetterConfig DeadLetterConfig
        {
            get { return this._deadLetterConfig; }
            set { this._deadLetterConfig = value; }
        }

        // Check to see if DeadLetterConfig property is set
        internal bool IsSetDeadLetterConfig()
        {
            return this._deadLetterConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EcsParameters. 
        /// <para>
        /// The templated target type for the Amazon ECS <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_RunTask.html">
        /// <c>RunTask</c> </a> API operation.
        /// </para>
        /// </summary>
        public EcsParameters EcsParameters
        {
            get { return this._ecsParameters; }
            set { this._ecsParameters = value; }
        }

        // Check to see if EcsParameters property is set
        internal bool IsSetEcsParameters()
        {
            return this._ecsParameters != null;
        }

        /// <summary>
        /// Gets and sets the property EventBridgeParameters. 
        /// <para>
        /// The templated target type for the EventBridge <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_PutEvents.html">
        /// <c>PutEvents</c> </a> API operation.
        /// </para>
        /// </summary>
        public EventBridgeParameters EventBridgeParameters
        {
            get { return this._eventBridgeParameters; }
            set { this._eventBridgeParameters = value; }
        }

        // Check to see if EventBridgeParameters property is set
        internal bool IsSetEventBridgeParameters()
        {
            return this._eventBridgeParameters != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The text, or well-formed JSON, passed to the target. If you are configuring a templated
        /// Lambda, AWS Step Functions, or Amazon EventBridge target, the input must be a well-formed
        /// JSON. For all other target types, a JSON is not required. If you do not specify anything
        /// for this field, EventBridge Scheduler delivers a default notification to the target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisParameters. 
        /// <para>
        /// The templated target type for the Amazon Kinesis <a href="kinesis/latest/APIReference/API_PutRecord.html">
        /// <c>PutRecord</c> </a> API operation.
        /// </para>
        /// </summary>
        public KinesisParameters KinesisParameters
        {
            get { return this._kinesisParameters; }
            set { this._kinesisParameters = value; }
        }

        // Check to see if KinesisParameters property is set
        internal bool IsSetKinesisParameters()
        {
            return this._kinesisParameters != null;
        }

        /// <summary>
        /// Gets and sets the property RetryPolicy. 
        /// <para>
        /// A <c>RetryPolicy</c> object that includes information about the retry policy settings,
        /// including the maximum age of an event, and the maximum number of times EventBridge
        /// Scheduler will try to deliver the event to a target.
        /// </para>
        /// </summary>
        public RetryPolicy RetryPolicy
        {
            get { return this._retryPolicy; }
            set { this._retryPolicy = value; }
        }

        // Check to see if RetryPolicy property is set
        internal bool IsSetRetryPolicy()
        {
            return this._retryPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that EventBridge Scheduler will use
        /// for this target when the schedule is invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
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
        /// Gets and sets the property SageMakerPipelineParameters. 
        /// <para>
        /// The templated target type for the Amazon SageMaker <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_StartPipelineExecution.html">
        /// <c>StartPipelineExecution</c> </a> API operation.
        /// </para>
        /// </summary>
        public SageMakerPipelineParameters SageMakerPipelineParameters
        {
            get { return this._sageMakerPipelineParameters; }
            set { this._sageMakerPipelineParameters = value; }
        }

        // Check to see if SageMakerPipelineParameters property is set
        internal bool IsSetSageMakerPipelineParameters()
        {
            return this._sageMakerPipelineParameters != null;
        }

        /// <summary>
        /// Gets and sets the property SqsParameters. 
        /// <para>
        /// The templated target type for the Amazon SQS <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_SendMessage.html">
        /// <c>SendMessage</c> </a> API operation. Contains the message group ID to use when the
        /// target is a FIFO queue. If you specify an Amazon SQS FIFO queue as a target, the queue
        /// must have content-based deduplication enabled. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/using-messagededuplicationid-property.html">Using
        /// the Amazon SQS message deduplication ID</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        /// </summary>
        public SqsParameters SqsParameters
        {
            get { return this._sqsParameters; }
            set { this._sqsParameters = value; }
        }

        // Check to see if SqsParameters property is set
        internal bool IsSetSqsParameters()
        {
            return this._sqsParameters != null;
        }

    }
}