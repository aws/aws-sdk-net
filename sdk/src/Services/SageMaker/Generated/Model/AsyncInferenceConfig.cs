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
    /// Specifies configuration for how an endpoint performs asynchronous inference.
    /// </summary>
    public partial class AsyncInferenceConfig
    {
        private AsyncInferenceClientConfig _clientConfig;
        private AsyncInferenceOutputConfig _outputConfig;

        /// <summary>
        /// Gets and sets the property ClientConfig. 
        /// <para>
        /// Configures the behavior of the client used by SageMaker to interact with the model
        /// container during asynchronous inference.
        /// </para>
        /// </summary>
        public AsyncInferenceClientConfig ClientConfig
        {
            get { return this._clientConfig; }
            set { this._clientConfig = value; }
        }

        // Check to see if ClientConfig property is set
        internal bool IsSetClientConfig()
        {
            return this._clientConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Specifies the configuration for asynchronous inference invocation outputs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AsyncInferenceOutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

    }
}