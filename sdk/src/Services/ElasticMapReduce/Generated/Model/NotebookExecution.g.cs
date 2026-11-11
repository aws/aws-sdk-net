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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// A notebook execution. An execution is a specific instance that an Amazon EMR Notebook
    /// is run using the <c>StartNotebookExecution</c> action.
    /// </summary>
    public partial class NotebookExecution
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property EditorId. 
        /// <para>
        /// The unique identifier of the Amazon EMR Notebook that is used for the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EditorId { get; set; }

        /// <summary>
        /// Checks to see if the EditorId property is set.
        /// </summary>
        internal bool IsSetEditorId() => this.EditorId != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when notebook execution ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// The environment variables associated with the notebook execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> EnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetEnvironmentVariables() => this.EnvironmentVariables != null && (this.EnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExecutionEngine. 
        /// <para>
        /// The execution engine, such as an Amazon EMR cluster, used to run the Amazon EMR notebook
        /// and perform the notebook execution.
        /// </para>
        /// </summary>
        public ExecutionEngineConfig ExecutionEngine { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionEngine property is set.
        /// </summary>
        internal bool IsSetExecutionEngine() => this.ExecutionEngine != null;

        /// <summary>
        /// Gets and sets the property LastStateChangeReason. 
        /// <para>
        /// The reason for the latest status change of the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string LastStateChangeReason { get; set; }

        /// <summary>
        /// Checks to see if the LastStateChangeReason property is set.
        /// </summary>
        internal bool IsSetLastStateChangeReason() => this.LastStateChangeReason != null;

        /// <summary>
        /// Gets and sets the property NotebookExecutionId. 
        /// <para>
        /// The unique identifier of a notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NotebookExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the NotebookExecutionId property is set.
        /// </summary>
        internal bool IsSetNotebookExecutionId() => this.NotebookExecutionId != null;

        /// <summary>
        /// Gets and sets the property NotebookExecutionName. 
        /// <para>
        /// A name for the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NotebookExecutionName { get; set; }

        /// <summary>
        /// Checks to see if the NotebookExecutionName property is set.
        /// </summary>
        internal bool IsSetNotebookExecutionName() => this.NotebookExecutionName != null;

        /// <summary>
        /// Gets and sets the property NotebookInstanceSecurityGroupId. 
        /// <para>
        /// The unique identifier of the Amazon EC2 security group associated with the Amazon
        /// EMR Notebook instance. For more information see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-managed-notebooks-security-groups.html">Specifying
        /// Amazon EC2 Security Groups for Amazon EMR Notebooks</a> in the <i>Amazon EMR Management
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NotebookInstanceSecurityGroupId { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceSecurityGroupId property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceSecurityGroupId() => this.NotebookInstanceSecurityGroupId != null;

        /// <summary>
        /// Gets and sets the property NotebookParams. 
        /// <para>
        /// Input parameters in JSON format passed to the Amazon EMR Notebook at runtime for execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string NotebookParams { get; set; }

        /// <summary>
        /// Checks to see if the NotebookParams property is set.
        /// </summary>
        internal bool IsSetNotebookParams() => this.NotebookParams != null;

        /// <summary>
        /// Gets and sets the property NotebookS3Location. 
        /// <para>
        /// The Amazon S3 location that stores the notebook execution input.
        /// </para>
        /// </summary>
        public NotebookS3LocationForOutput NotebookS3Location { get; set; }

        /// <summary>
        /// Checks to see if the NotebookS3Location property is set.
        /// </summary>
        internal bool IsSetNotebookS3Location() => this.NotebookS3Location != null;

        /// <summary>
        /// Gets and sets the property OutputNotebookFormat. 
        /// <para>
        /// The output format for the notebook execution.
        /// </para>
        /// </summary>
        public OutputNotebookFormat OutputNotebookFormat { get; set; }

        /// <summary>
        /// Checks to see if the OutputNotebookFormat property is set.
        /// </summary>
        internal bool IsSetOutputNotebookFormat() => this.OutputNotebookFormat != null;

        /// <summary>
        /// Gets and sets the property OutputNotebookS3Location. 
        /// <para>
        /// The Amazon S3 location for the notebook execution output.
        /// </para>
        /// </summary>
        public OutputNotebookS3LocationForOutput OutputNotebookS3Location { get; set; }

        /// <summary>
        /// Checks to see if the OutputNotebookS3Location property is set.
        /// </summary>
        internal bool IsSetOutputNotebookS3Location() => this.OutputNotebookS3Location != null;

        /// <summary>
        /// Gets and sets the property OutputNotebookURI. 
        /// <para>
        /// The location of the notebook execution's output file in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string OutputNotebookURI { get; set; }

        /// <summary>
        /// Checks to see if the OutputNotebookURI property is set.
        /// </summary>
        internal bool IsSetOutputNotebookURI() => this.OutputNotebookURI != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when notebook execution started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the notebook execution.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>START_PENDING</c> indicates that the cluster has received the execution request
        /// but execution has not begun.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STARTING</c> indicates that the execution is starting on the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c> indicates that the execution is being processed by the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FINISHING</c> indicates that execution processing is in the final stages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FINISHED</c> indicates that the execution has completed without error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILING</c> indicates that the execution is failing and will not finish successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> indicates that the execution failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOP_PENDING</c> indicates that the cluster has received a <c>StopNotebookExecution</c>
        /// request and the stop is pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPING</c> indicates that the cluster is in the process of stopping the execution
        /// as a result of a <c>StopNotebookExecution</c> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPED</c> indicates that the execution stopped because of a <c>StopNotebookExecution</c>
        /// request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public NotebookExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with a notebook execution. Tags are user-defined key-value
        /// pairs that consist of a required key string with a maximum of 128 characters and an
        /// optional value string with a maximum of 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
