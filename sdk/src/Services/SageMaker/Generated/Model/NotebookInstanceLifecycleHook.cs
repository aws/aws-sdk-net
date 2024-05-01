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
    /// Contains the notebook instance lifecycle configuration script.
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
    public partial class NotebookInstanceLifecycleHook
    {
        private string _content;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// A base64-encoded string that contains a shell script for a notebook instance lifecycle
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16384)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

    }
}