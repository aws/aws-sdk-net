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
    /// Contains the notebook instance lifecycle configuration script.
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