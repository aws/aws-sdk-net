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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// The value of the <c>$PATH</c> environment variable that is available to both scripts
    /// is <c>/sbin:bin:/usr/sbin:/usr/bin</c>.
    /// </para>
    ///  
    /// <para>
    /// View Amazon CloudWatch Logs for notebook instance lifecycle configurations in log
    /// group <c>/aws/sagemaker/NotebookInstances</c> in log stream <c>[notebook-instance-name]/[LifecycleConfigHook]</c>.
    /// </para>
    ///  
    /// <para>
    /// Lifecycle configuration scripts cannot run for longer than 5 minutes. If a script
    /// runs for longer than 5 minutes, it fails and the notebook instance is not created
    /// or started.
    /// </para>
    ///  
    /// <para>
    /// For information about notebook instance lifestyle configurations, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
    /// 2.1: (Optional) Customize a Notebook Instance</a>.
    /// </para>
    /// </summary>
    public partial class CreateNotebookInstanceLifecycleConfigRequest : AmazonSageMakerRequest
    {
        private string _notebookInstanceLifecycleConfigName;
        private List<NotebookInstanceLifecycleHook> _onCreate = AWSConfigs.InitializeCollections ? new List<NotebookInstanceLifecycleHook>() : null;
        private List<NotebookInstanceLifecycleHook> _onStart = AWSConfigs.InitializeCollections ? new List<NotebookInstanceLifecycleHook>() : null;

        /// <summary>
        /// Gets and sets the property NotebookInstanceLifecycleConfigName. 
        /// <para>
        /// The name of the lifecycle configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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
        /// A shell script that runs only once, when you create a notebook instance. The shell
        /// script must be a base64-encoded string.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<NotebookInstanceLifecycleHook> OnCreate
        {
            get { return this._onCreate; }
            set { this._onCreate = value; }
        }

        // Check to see if OnCreate property is set
        internal bool IsSetOnCreate()
        {
            return this._onCreate != null && (this._onCreate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OnStart. 
        /// <para>
        /// A shell script that runs every time you start a notebook instance, including when
        /// you create the notebook instance. The shell script must be a base64-encoded string.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<NotebookInstanceLifecycleHook> OnStart
        {
            get { return this._onStart; }
            set { this._onStart = value; }
        }

        // Check to see if OnStart property is set
        internal bool IsSetOnStart()
        {
            return this._onStart != null && (this._onStart.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}