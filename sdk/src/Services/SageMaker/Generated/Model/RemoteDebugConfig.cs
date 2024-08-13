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
    /// Configuration for remote debugging for the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingJob.html">CreateTrainingJob</a>
    /// API. To learn more about the remote debugging functionality of SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/train-remote-debugging.html">Access
    /// a training container through Amazon Web Services Systems Manager (SSM) for remote
    /// debugging</a>.
    /// </summary>
    public partial class RemoteDebugConfig
    {
        private bool? _enableRemoteDebug;

        /// <summary>
        /// Gets and sets the property EnableRemoteDebug. 
        /// <para>
        /// If set to True, enables remote debugging.
        /// </para>
        /// </summary>
        public bool? EnableRemoteDebug
        {
            get { return this._enableRemoteDebug; }
            set { this._enableRemoteDebug = value; }
        }

        // Check to see if EnableRemoteDebug property is set
        internal bool IsSetEnableRemoteDebug()
        {
            return this._enableRemoteDebug.HasValue; 
        }

    }
}