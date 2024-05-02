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
    /// Configures the timeout and maximum number of retries for processing a transform job
    /// invocation.
    /// </summary>
    public partial class ModelClientConfig
    {
        private int? _invocationsMaxRetries;
        private int? _invocationsTimeoutInSeconds;

        /// <summary>
        /// Gets and sets the property InvocationsMaxRetries. 
        /// <para>
        /// The maximum number of retries when invocation requests are failing. The default value
        /// is 3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public int? InvocationsMaxRetries
        {
            get { return this._invocationsMaxRetries; }
            set { this._invocationsMaxRetries = value; }
        }

        // Check to see if InvocationsMaxRetries property is set
        internal bool IsSetInvocationsMaxRetries()
        {
            return this._invocationsMaxRetries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InvocationsTimeoutInSeconds. 
        /// <para>
        /// The timeout value in seconds for an invocation request. The default value is 600.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3600)]
        public int? InvocationsTimeoutInSeconds
        {
            get { return this._invocationsTimeoutInSeconds; }
            set { this._invocationsTimeoutInSeconds = value; }
        }

        // Check to see if InvocationsTimeoutInSeconds property is set
        internal bool IsSetInvocationsTimeoutInSeconds()
        {
            return this._invocationsTimeoutInSeconds.HasValue; 
        }

    }
}