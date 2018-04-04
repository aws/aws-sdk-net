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
    /// Container for the parameters to the CreateNotebookInstanceLifecycleConfig operation.
    /// Creates a lifecycle configuration that you can associate with a notebook instance.
    /// A <i>lifecycle configuration</i> is a collection of shell scripts that run when you
    /// create or start a notebook instance.
    /// 
    ///  
    /// <para>
    /// Each lifecycle configuration script has a limit of 16384 characters.
    /// </para>
    ///  
    /// <para>
    /// The value of the <code>$PATH</code> environment variable that is available to both
    /// scripts is <code>/sbin:bin:/usr/sbin:/usr/bin</code>.
    /// </para>
    ///  
    /// <para>
    /// View CloudWatch Logs for notebook instance lifecycle configurations in log group <code>/aws/sagemaker/NotebookInstances</code>
    /// in log stream <code>[notebook-instance-name]/[LifecycleConfigHook]</code>.
    /// </para>
    ///  
    /// <para>
    /// Lifecycle configuration scripts cannot run for longer than 5 minutes. If a script
    /// runs for longer than 5 minutes, it fails and the notebook instance is not created
    /// or started.
    /// </para>
    ///  
    /// <para>
    /// For information about notebook instance lifestyle configurations, see <a>notebook-lifecycle-config</a>.
    /// </para>
    /// </summary>
    public partial class CreateNotebookInstanceLifecycleConfigRequest : AmazonSageMakerRequest
    {
        private string _notebookInstanceLifecycleConfigName;
        private List<NotebookInstanceLifecycleHook> _onCreate = new List<NotebookInstanceLifecycleHook>();
        private List<NotebookInstanceLifecycleHook> _onStart = new List<NotebookInstanceLifecycleHook>();

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
        /// A shell script that runs only once, when you create a notebook instance.
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
        /// A shell script that runs every time you start a notebook instance, including when
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