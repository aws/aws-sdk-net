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
    /// Container for the parameters to the StartNotebookExecution operation. Starts a notebook
    /// execution.
    /// </summary>
    public partial class StartNotebookExecutionRequest : AmazonElasticMapReduceRequest
    {
        /// <summary>
        /// Gets and sets the property EditorId. 
        /// <para>
        /// The unique identifier of the Amazon EMR Notebook to use for notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EditorId { get; set; }

        /// <summary>
        /// Checks to see if the EditorId property is set.
        /// </summary>
        internal bool IsSetEditorId() => this.EditorId != null;

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
        /// Specifies the execution engine (cluster) that runs the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExecutionEngineConfig ExecutionEngine { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionEngine property is set.
        /// </summary>
        internal bool IsSetExecutionEngine() => this.ExecutionEngine != null;

        /// <summary>
        /// Gets and sets the property NotebookExecutionName. 
        /// <para>
        /// An optional name for the notebook execution.
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
        /// The unique identifier of the Amazon EC2 security group to associate with the Amazon
        /// EMR Notebook for this notebook execution.
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
        /// The Amazon S3 location for the notebook execution input.
        /// </para>
        /// </summary>
        public NotebookS3LocationFromInput NotebookS3Location { get; set; }

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
        public OutputNotebookS3LocationFromInput OutputNotebookS3Location { get; set; }

        /// <summary>
        /// Checks to see if the OutputNotebookS3Location property is set.
        /// </summary>
        internal bool IsSetOutputNotebookS3Location() => this.OutputNotebookS3Location != null;

        /// <summary>
        /// Gets and sets the property RelativePath. 
        /// <para>
        /// The path and file name of the notebook file for this execution, relative to the path
        /// specified for the Amazon EMR Notebook. For example, if you specify a path of <c>s3://MyBucket/MyNotebooks</c>
        /// when you create an Amazon EMR Notebook for a notebook with an ID of <c>e-ABCDEFGHIJK1234567890ABCD</c>
        /// (the <c>EditorID</c> of this request), and you specify a <c>RelativePath</c> of <c>my_notebook_executions/notebook_execution.ipynb</c>,
        /// the location of the file for the notebook execution is <c>s3://MyBucket/MyNotebooks/e-ABCDEFGHIJK1234567890ABCD/my_notebook_executions/notebook_execution.ipynb</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string RelativePath { get; set; }

        /// <summary>
        /// Checks to see if the RelativePath property is set.
        /// </summary>
        internal bool IsSetRelativePath() => this.RelativePath != null;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The name or ARN of the IAM role that is used as the service role for Amazon EMR (the
        /// Amazon EMR role) for the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10280)]
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

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
