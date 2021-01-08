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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the StartNotebookExecution operation.
    /// Starts a notebook execution.
    /// </summary>
    public partial class StartNotebookExecutionRequest : AmazonElasticMapReduceRequest
    {
        private string _editorId;
        private ExecutionEngineConfig _executionEngine;
        private string _notebookExecutionName;
        private string _notebookInstanceSecurityGroupId;
        private string _notebookParams;
        private string _relativePath;
        private string _serviceRole;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property EditorId. 
        /// <para>
        /// The unique identifier of the EMR Notebook to use for notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// The unique identifier of the Amazon EC2 security group to associate with the EMR Notebook
        /// for this notebook execution.
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
        /// Input parameters in JSON format passed to the EMR Notebook at runtime for execution.
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
        /// Gets and sets the property RelativePath. 
        /// <para>
        /// The path and file name of the notebook file for this execution, relative to the path
        /// specified for the EMR Notebook. For example, if you specify a path of <code>s3://MyBucket/MyNotebooks</code>
        /// when you create an EMR Notebook for a notebook with an ID of <code>e-ABCDEFGHIJK1234567890ABCD</code>
        /// (the <code>EditorID</code> of this request), and you specify a <code>RelativePath</code>
        /// of <code>my_notebook_executions/notebook_execution.ipynb</code>, the location of the
        /// file for the notebook execution is <code>s3://MyBucket/MyNotebooks/e-ABCDEFGHIJK1234567890ABCD/my_notebook_executions/notebook_execution.ipynb</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10280)]
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
        /// EMR role) for the notebook execution.
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
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}