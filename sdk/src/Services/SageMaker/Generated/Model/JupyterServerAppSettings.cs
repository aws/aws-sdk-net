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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The JupyterServer app settings.
    /// </summary>
    public partial class JupyterServerAppSettings
    {
        private List<CodeRepository> _codeRepositories = new List<CodeRepository>();
        private ResourceSpec _defaultResourceSpec;
        private List<string> _lifecycleConfigArns = new List<string>();

        /// <summary>
        /// Gets and sets the property CodeRepositories. 
        /// <para>
        /// A list of Git repositories that SageMaker automatically displays to users for cloning
        /// in the JupyterServer application.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public List<CodeRepository> CodeRepositories
        {
            get { return this._codeRepositories; }
            set { this._codeRepositories = value; }
        }

        // Check to see if CodeRepositories property is set
        internal bool IsSetCodeRepositories()
        {
            return this._codeRepositories != null && this._codeRepositories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DefaultResourceSpec. 
        /// <para>
        /// The default instance type and the Amazon Resource Name (ARN) of the default SageMaker
        /// image used by the JupyterServer app. If you use the <code>LifecycleConfigArns</code>
        /// parameter, then this parameter is also required.
        /// </para>
        /// </summary>
        public ResourceSpec DefaultResourceSpec
        {
            get { return this._defaultResourceSpec; }
            set { this._defaultResourceSpec = value; }
        }

        // Check to see if DefaultResourceSpec property is set
        internal bool IsSetDefaultResourceSpec()
        {
            return this._defaultResourceSpec != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleConfigArns. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Lifecycle Configurations attached to the JupyterServerApp.
        /// If you use this parameter, the <code>DefaultResourceSpec</code> parameter is also
        /// required.
        /// </para>
        ///  <note> 
        /// <para>
        /// To remove a Lifecycle Config, you must set <code>LifecycleConfigArns</code> to an
        /// empty list.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> LifecycleConfigArns
        {
            get { return this._lifecycleConfigArns; }
            set { this._lifecycleConfigArns = value; }
        }

        // Check to see if LifecycleConfigArns property is set
        internal bool IsSetLifecycleConfigArns()
        {
            return this._lifecycleConfigArns != null && this._lifecycleConfigArns.Count > 0; 
        }

    }
}