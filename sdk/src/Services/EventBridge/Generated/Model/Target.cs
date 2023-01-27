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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Targets are the resources to be invoked when a rule is triggered. For a complete list
    /// of services and resources that can be set as a target, see <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_PutTargets.html">PutTargets</a>.
    /// 
    ///  
    /// <para>
    /// If you are setting the event bus of another account as the target, and that account
    /// granted permission to your account through an organization instead of directly by
    /// the account ID, then you must specify a <code>RoleArn</code> with proper permissions
    /// in the <code>Target</code> structure. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-cross-account-event-delivery.html">Sending
    /// and Receiving Events Between Amazon Web Services Accounts</a> in the <i>Amazon EventBridge
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class Target
    {
        private string _arn;
        private BatchParameters _batchParameters;
        private DeadLetterConfig _deadLetterConfig;
        private EcsParameters _ecsParameters;
        private HttpParameters _httpParameters;
        private string _id;
        private string _input;
        private string _inputPath;
        private InputTransformer _inputTransformer;
        private KinesisParameters _kinesisParameters;
        private RedshiftDataParameters _redshiftDataParameters;
        private RetryPolicy _retryPolicy;
        private string _roleArn;
        private RunCommandParameters _runCommandParameters;
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
        /// Gets and sets the property BatchParameters. 
        /// <para>
        /// If the event target is an Batch job, this contains the job definition, job name, and
        /// other parameters. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/jobs.html">Jobs</a>
        /// in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public BatchParameters BatchParameters
        {
            get { return this._batchParameters; }
            set { this._batchParameters = value; }
        }

        // Check to see if BatchParameters property is set
        internal bool IsSetBatchParameters()
        {
            return this._batchParameters != null;
        }

        /// <summary>
        /// Gets and sets the property DeadLetterConfig. 
        /// <para>
        /// The <code>DeadLetterConfig</code> that defines the target queue to send dead-letter
        /// queue events to.
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
        /// Contains the Amazon ECS task definition and task count to be used, if the event target
        /// is an Amazon ECS task. For more information about Amazon ECS tasks, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_defintions.html">Task
        /// Definitions </a> in the <i>Amazon EC2 Container Service Developer Guide</i>.
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
        /// Gets and sets the property HttpParameters. 
        /// <para>
        /// Contains the HTTP parameters to use when the target is a API Gateway endpoint or EventBridge
        /// ApiDestination.
        /// </para>
        ///  
        /// <para>
        /// If you specify an API Gateway API or EventBridge ApiDestination as a target, you can
        /// use this parameter to specify headers, path parameters, and query string keys/values
        /// as part of your target invoking request. If you're using ApiDestinations, the corresponding
        /// Connection can also have these values configured. In case of any conflicting keys,
        /// values from the Connection take precedence.
        /// </para>
        /// </summary>
        public HttpParameters HttpParameters
        {
            get { return this._httpParameters; }
            set { this._httpParameters = value; }
        }

        // Check to see if HttpParameters property is set
        internal bool IsSetHttpParameters()
        {
            return this._httpParameters != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the target within the specified rule. Use this ID to reference the target
        /// when updating the rule. We recommend using a memorable and unique string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Valid JSON text passed to the target. In this case, nothing from the event itself
        /// is passed to the target. For more information, see <a href="http://www.rfc-editor.org/rfc/rfc7159.txt">The
        /// JavaScript Object Notation (JSON) Data Interchange Format</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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
        /// Gets and sets the property InputPath. 
        /// <para>
        /// The value of the JSONPath that is used for extracting part of the matched event when
        /// passing it to the target. You may use JSON dot notation or bracket notation. For more
        /// information about JSON paths, see <a href="http://goessner.net/articles/JsonPath/">JSONPath</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string InputPath
        {
            get { return this._inputPath; }
            set { this._inputPath = value; }
        }

        // Check to see if InputPath property is set
        internal bool IsSetInputPath()
        {
            return this._inputPath != null;
        }

        /// <summary>
        /// Gets and sets the property InputTransformer. 
        /// <para>
        /// Settings to enable you to provide custom input to a target based on certain event
        /// data. You can extract one or more key-value pairs from the event and then use that
        /// data to send customized input to the target.
        /// </para>
        /// </summary>
        public InputTransformer InputTransformer
        {
            get { return this._inputTransformer; }
            set { this._inputTransformer = value; }
        }

        // Check to see if InputTransformer property is set
        internal bool IsSetInputTransformer()
        {
            return this._inputTransformer != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisParameters. 
        /// <para>
        /// The custom parameter you can use to control the shard assignment, when the target
        /// is a Kinesis data stream. If you do not include this parameter, the default is to
        /// use the <code>eventId</code> as the partition key.
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
        /// Gets and sets the property RedshiftDataParameters. 
        /// <para>
        /// Contains the Amazon Redshift Data API parameters to use when the target is a Amazon
        /// Redshift cluster.
        /// </para>
        ///  
        /// <para>
        /// If you specify a Amazon Redshift Cluster as a Target, you can use this to specify
        /// parameters to invoke the Amazon Redshift Data API ExecuteStatement based on EventBridge
        /// events.
        /// </para>
        /// </summary>
        public RedshiftDataParameters RedshiftDataParameters
        {
            get { return this._redshiftDataParameters; }
            set { this._redshiftDataParameters = value; }
        }

        // Check to see if RedshiftDataParameters property is set
        internal bool IsSetRedshiftDataParameters()
        {
            return this._redshiftDataParameters != null;
        }

        /// <summary>
        /// Gets and sets the property RetryPolicy. 
        /// <para>
        /// The <code>RetryPolicy</code> object that contains the retry policy configuration to
        /// use for the dead-letter queue.
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
        /// The Amazon Resource Name (ARN) of the IAM role to be used for this target when the
        /// rule is triggered. If one rule triggers multiple targets, you can use a different
        /// IAM role for each target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
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
        /// Gets and sets the property RunCommandParameters. 
        /// <para>
        /// Parameters used when you are using the rule to invoke Amazon EC2 Run Command.
        /// </para>
        /// </summary>
        public RunCommandParameters RunCommandParameters
        {
            get { return this._runCommandParameters; }
            set { this._runCommandParameters = value; }
        }

        // Check to see if RunCommandParameters property is set
        internal bool IsSetRunCommandParameters()
        {
            return this._runCommandParameters != null;
        }

        /// <summary>
        /// Gets and sets the property SageMakerPipelineParameters. 
        /// <para>
        /// Contains the SageMaker Model Building Pipeline parameters to start execution of a
        /// SageMaker Model Building Pipeline.
        /// </para>
        ///  
        /// <para>
        /// If you specify a SageMaker Model Building Pipeline as a target, you can use this to
        /// specify parameters to start a pipeline execution based on EventBridge events.
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
        /// Contains the message group ID to use when the target is a FIFO queue.
        /// </para>
        ///  
        /// <para>
        /// If you specify an SQS FIFO queue as a target, the queue must have content-based deduplication
        /// enabled.
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