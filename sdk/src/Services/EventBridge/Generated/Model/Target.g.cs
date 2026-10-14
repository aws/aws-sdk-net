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
    /// the account ID, then you must specify a <c>RoleArn</c> with proper permissions in
    /// the <c>Target</c> structure. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-cross-account-event-delivery.html">Sending
    /// and Receiving Events Between Amazon Web Services Accounts</a> in the <i>Amazon EventBridge
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class Target
    {
        /// <summary>
        /// Gets and sets the property AppSyncParameters. 
        /// <para>
        /// Contains the GraphQL operation to be parsed and executed, if the event target is an
        /// AppSync API.
        /// </para>
        /// </summary>
        public AppSyncParameters AppSyncParameters { get; set; }

        /// <summary>
        /// Checks to see if the AppSyncParameters property is set.
        /// </summary>
        internal bool IsSetAppSyncParameters() => this.AppSyncParameters != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BatchParameters. 
        /// <para>
        /// If the event target is an Batch job, this contains the job definition, job name, and
        /// other parameters. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/jobs.html">Jobs</a>
        /// in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public BatchParameters BatchParameters { get; set; }

        /// <summary>
        /// Checks to see if the BatchParameters property is set.
        /// </summary>
        internal bool IsSetBatchParameters() => this.BatchParameters != null;

        /// <summary>
        /// Gets and sets the property DeadLetterConfig. 
        /// <para>
        /// The <c>DeadLetterConfig</c> that defines the target queue to send dead-letter queue
        /// events to.
        /// </para>
        /// </summary>
        public DeadLetterConfig DeadLetterConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeadLetterConfig property is set.
        /// </summary>
        internal bool IsSetDeadLetterConfig() => this.DeadLetterConfig != null;

        /// <summary>
        /// Gets and sets the property EcsParameters. 
        /// <para>
        /// Contains the Amazon ECS task definition and task count to be used, if the event target
        /// is an Amazon ECS task. For more information about Amazon ECS tasks, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_defintions.html">Task
        /// Definitions </a> in the <i>Amazon EC2 Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public EcsParameters EcsParameters { get; set; }

        /// <summary>
        /// Checks to see if the EcsParameters property is set.
        /// </summary>
        internal bool IsSetEcsParameters() => this.EcsParameters != null;

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
        public HttpParameters HttpParameters { get; set; }

        /// <summary>
        /// Checks to see if the HttpParameters property is set.
        /// </summary>
        internal bool IsSetHttpParameters() => this.HttpParameters != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the target within the specified rule. Use this ID to reference the target
        /// when updating the rule. We recommend using a memorable and unique string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Valid JSON text passed to the target. In this case, nothing from the event itself
        /// is passed to the target. For more information, see <a href="http://www.rfc-editor.org/rfc/rfc7159.txt">The
        /// JavaScript Object Notation (JSON) Data Interchange Format</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property InputPath. 
        /// <para>
        /// The value of the JSONPath that is used for extracting part of the matched event when
        /// passing it to the target. You may use JSON dot notation or bracket notation. For more
        /// information about JSON paths, see <a href="http://goessner.net/articles/JsonPath/">JSONPath</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string InputPath { get; set; }

        /// <summary>
        /// Checks to see if the InputPath property is set.
        /// </summary>
        internal bool IsSetInputPath() => this.InputPath != null;

        /// <summary>
        /// Gets and sets the property InputTransformer. 
        /// <para>
        /// Settings to enable you to provide custom input to a target based on certain event
        /// data. You can extract one or more key-value pairs from the event and then use that
        /// data to send customized input to the target.
        /// </para>
        /// </summary>
        public InputTransformer InputTransformer { get; set; }

        /// <summary>
        /// Checks to see if the InputTransformer property is set.
        /// </summary>
        internal bool IsSetInputTransformer() => this.InputTransformer != null;

        /// <summary>
        /// Gets and sets the property KinesisParameters. 
        /// <para>
        /// The custom parameter you can use to control the shard assignment, when the target
        /// is a Kinesis data stream. If you do not include this parameter, the default is to
        /// use the <c>eventId</c> as the partition key.
        /// </para>
        /// </summary>
        public KinesisParameters KinesisParameters { get; set; }

        /// <summary>
        /// Checks to see if the KinesisParameters property is set.
        /// </summary>
        internal bool IsSetKinesisParameters() => this.KinesisParameters != null;

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
        public RedshiftDataParameters RedshiftDataParameters { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftDataParameters property is set.
        /// </summary>
        internal bool IsSetRedshiftDataParameters() => this.RedshiftDataParameters != null;

        /// <summary>
        /// Gets and sets the property RetryPolicy. 
        /// <para>
        /// The retry policy configuration to use for the dead-letter queue.
        /// </para>
        /// </summary>
        public RetryPolicy RetryPolicy { get; set; }

        /// <summary>
        /// Checks to see if the RetryPolicy property is set.
        /// </summary>
        internal bool IsSetRetryPolicy() => this.RetryPolicy != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to be used for this target when the
        /// rule is triggered. If one rule triggers multiple targets, you can use a different
        /// IAM role for each target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property RunCommandParameters. 
        /// <para>
        /// Parameters used when you are using the rule to invoke Amazon EC2 Run Command.
        /// </para>
        /// </summary>
        public RunCommandParameters RunCommandParameters { get; set; }

        /// <summary>
        /// Checks to see if the RunCommandParameters property is set.
        /// </summary>
        internal bool IsSetRunCommandParameters() => this.RunCommandParameters != null;

        /// <summary>
        /// Gets and sets the property SageMakerPipelineParameters. 
        /// <para>
        /// Contains the SageMaker AI Model Building Pipeline parameters to start execution of
        /// a SageMaker AI Model Building Pipeline.
        /// </para>
        ///  
        /// <para>
        /// If you specify a SageMaker AI Model Building Pipeline as a target, you can use this
        /// to specify parameters to start a pipeline execution based on EventBridge events.
        /// </para>
        /// </summary>
        public SageMakerPipelineParameters SageMakerPipelineParameters { get; set; }

        /// <summary>
        /// Checks to see if the SageMakerPipelineParameters property is set.
        /// </summary>
        internal bool IsSetSageMakerPipelineParameters() => this.SageMakerPipelineParameters != null;

        /// <summary>
        /// Gets and sets the property SqsParameters. 
        /// <para>
        /// Contains the message group ID to use when the target is an Amazon SQS fair or FIFO
        /// queue.
        /// </para>
        ///  
        /// <para>
        /// If you specify a fair or FIFO queue as a target, the queue must have content-based
        /// deduplication enabled.
        /// </para>
        /// </summary>
        public SqsParameters SqsParameters { get; set; }

        /// <summary>
        /// Checks to see if the SqsParameters property is set.
        /// </summary>
        internal bool IsSetSqsParameters() => this.SqsParameters != null;
    }
}
