/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeNotebookInstanceLifecycleConfig operation.
    /// </summary>
    public partial class DescribeNotebookInstanceLifecycleConfigResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private DateTime? _lastModifiedTime;
        private string _notebookInstanceLifecycleConfigArn;
        private string _notebookInstanceLifecycleConfigName;
        private List<NotebookInstanceLifecycleHook> _onCreate = new List<NotebookInstanceLifecycleHook>();
        private List<NotebookInstanceLifecycleHook> _onStart = new List<NotebookInstanceLifecycleHook>();

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that tells when the lifecycle configuration was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp that tells when the lifecycle configuration was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotebookInstanceLifecycleConfigArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the lifecycle configuration.
        /// </para>
        /// </summary>
        public string NotebookInstanceLifecycleConfigArn
        {
            get { return this._notebookInstanceLifecycleConfigArn; }
            set { this._notebookInstanceLifecycleConfigArn = value; }
        }

        // Check to see if NotebookInstanceLifecycleConfigArn property is set
        internal bool IsSetNotebookInstanceLifecycleConfigArn()
        {
            return this._notebookInstanceLifecycleConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookInstanceLifecycleConfigName. 
        /// <para>
        /// The name of the lifecycle configuration.
        /// </para>
        /// </summary>
        public string NotebookInstanceLifecycleConfigName
        {
            get { return this._notebookInstanceLifecycleConfigName; }
            set { this._notebookInstanceLifecycleConfigName = value; }
        }

        // Check to see if NotebookInstanceLifecycleConfigName property is set
        internal bool IsSetNotebookInstanceLifecycleConfigName()
        {
            return this._notebookInstanceLifecycleConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property OnCreate. 
        /// <para>
        /// The shell script that runs only once, when you create a notebook instance.
        /// </para>
        /// </summary>
        public List<NotebookInstanceLifecycleHook> OnCreate
        {
            get { return this._onCreate; }
            set { this._onCreate = value; }
        }

        // Check to see if OnCreate property is set
        internal bool IsSetOnCreate()
        {
            return this._onCreate != null && this._onCreate.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OnStart. 
        /// <para>
        /// The shell script that runs every time you start a notebook instance, including when
        /// you create the notebook instance.
        /// </para>
        /// </summary>
        public List<NotebookInstanceLifecycleHook> OnStart
        {
            get { return this._onStart; }
            set { this._onStart = value; }
        }

        // Check to see if OnStart property is set
        internal bool IsSetOnStart()
        {
            return this._onStart != null && this._onStart.Count > 0; 
        }

    }
}