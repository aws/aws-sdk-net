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
    /// Configures the behavior of the client used by SageMaker to interact with the model
    /// container during asynchronous inference.
    /// </summary>
    public partial class AsyncInferenceClientConfig
    {
        private int? _maxConcurrentInvocationsPerInstance;

        /// <summary>
        /// Gets and sets the property MaxConcurrentInvocationsPerInstance. 
        /// <para>
        /// The maximum number of concurrent requests sent by the SageMaker client to the model
        /// container. If no value is provided, SageMaker chooses an optimal value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxConcurrentInvocationsPerInstance
        {
            get { return this._maxConcurrentInvocationsPerInstance; }
            set { this._maxConcurrentInvocationsPerInstance = value; }
        }

        // Check to see if MaxConcurrentInvocationsPerInstance property is set
        internal bool IsSetMaxConcurrentInvocationsPerInstance()
        {
            return this._maxConcurrentInvocationsPerInstance.HasValue; 
        }

    }
}