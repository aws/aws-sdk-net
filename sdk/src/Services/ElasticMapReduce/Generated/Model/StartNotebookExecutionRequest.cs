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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
    /// Container for the parameters to the StartNotebookExecution operation.
    /// Starts a notebook execution.
    /// </summary>
    public partial class StartNotebookExecutionRequest : AmazonElasticMapReduceRequest
    {
        private string _editorId;
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ExecutionEngineConfig _executionEngine;
        private string _notebookExecutionName;
        private string _notebookInstanceSecurityGroupId;
        private string _notebookParams;
        private NotebookS3LocationFromInput _notebookS3Location;
        private OutputNotebookFormat _outputNotebookFormat;
        private OutputNotebookS3LocationFromInput _outputNotebookS3Location;
        private string _relativePath;
        private string _serviceRole;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property EditorId. 
        /// <para>
        /// The unique identifier of the Amazon EMR Notebook to use for notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string EditorId
        {
            get { return this._editorId; }
            set { this._editorId = value; }
        }

        // Check to see if EditorId property is set
        internal bool IsSetEditorId()
        {
            return this._editorId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// The environment variables associated with the notebook execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExecutionEngine. 
        /// <para>
        /// Specifies the execution engine (cluster) that runs the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutionEngineConfig ExecutionEngine
        {
            get { return this._executionEngine; }
            set { this._executionEngine = value; }
        }

        // Check to see if ExecutionEngine property is set
        internal bool IsSetExecutionEngine()
        {
            return this._executionEngine != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookExecutionName. 
        /// <para>
        /// An optional name for the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string NotebookExecutionName
        {
            get { return this._notebookExecutionName; }
            set { this._notebookExecutionName = value; }
        }

        // Check to see if NotebookExecutionName property is set
        internal bool IsSetNotebookExecutionName()
        {
            return this._notebookExecutionName != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookInstanceSecurityGroupId. 
        /// <para>
        /// The unique identifier of the Amazon EC2 security group to associate with the Amazon
        /// EMR Notebook for this notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string NotebookInstanceSecurityGroupId
        {
            get { return this._notebookInstanceSecurityGroupId; }
            set { this._notebookInstanceSecurityGroupId = value; }
        }

        // Check to see if NotebookInstanceSecurityGroupId property is set
        internal bool IsSetNotebookInstanceSecurityGroupId()
        {
            return this._notebookInstanceSecurityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookParams. 
        /// <para>
        /// Input parameters in JSON format passed to the Amazon EMR Notebook at runtime for execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string NotebookParams
        {
            get { return this._notebookParams; }
            set { this._notebookParams = value; }
        }

        // Check to see if NotebookParams property is set
        internal bool IsSetNotebookParams()
        {
            return this._notebookParams != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookS3Location. 
        /// <para>
        /// The Amazon S3 location for the notebook execution input.
        /// </para>
        /// </summary>
        public NotebookS3LocationFromInput NotebookS3Location
        {
            get { return this._notebookS3Location; }
            set { this._notebookS3Location = value; }
        }

        // Check to see if NotebookS3Location property is set
        internal bool IsSetNotebookS3Location()
        {
            return this._notebookS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property OutputNotebookFormat. 
        /// <para>
        /// The output format for the notebook execution.
        /// </para>
        /// </summary>
        public OutputNotebookFormat OutputNotebookFormat
        {
            get { return this._outputNotebookFormat; }
            set { this._outputNotebookFormat = value; }
        }

        // Check to see if OutputNotebookFormat property is set
        internal bool IsSetOutputNotebookFormat()
        {
            return this._outputNotebookFormat != null;
        }

        /// <summary>
        /// Gets and sets the property OutputNotebookS3Location. 
        /// <para>
        /// The Amazon S3 location for the notebook execution output.
        /// </para>
        /// </summary>
        public OutputNotebookS3LocationFromInput OutputNotebookS3Location
        {
            get { return this._outputNotebookS3Location; }
            set { this._outputNotebookS3Location = value; }
        }

        // Check to see if OutputNotebookS3Location property is set
        internal bool IsSetOutputNotebookS3Location()
        {
            return this._outputNotebookS3Location != null;
        }

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
        [AWSProperty(Min=0, Max=10280)]
        public string RelativePath
        {
            get { return this._relativePath; }
            set { this._relativePath = value; }
        }

        // Check to see if RelativePath property is set
        internal bool IsSetRelativePath()
        {
            return this._relativePath != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The name or ARN of the IAM role that is used as the service role for Amazon EMR (the
        /// Amazon EMR role) for the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10280)]
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with a notebook execution. Tags are user-defined key-value
        /// pairs that consist of a required key string with a maximum of 128 characters and an
        /// optional value string with a maximum of 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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