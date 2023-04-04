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
    /// Specifies the configuration for notifications of inference results for asynchronous
    /// inference.
    /// </summary>
    public partial class AsyncInferenceNotificationConfig
    {
        private string _errorTopic;
        private List<string> _includeInferenceResponseIn = new List<string>();
        private string _successTopic;

        /// <summary>
        /// Gets and sets the property ErrorTopic. 
        /// <para>
        /// Amazon SNS topic to post a notification to when inference fails. If no topic is provided,
        /// no notification is sent on failure.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string ErrorTopic
        {
            get { return this._errorTopic; }
            set { this._errorTopic = value; }
        }

        // Check to see if ErrorTopic property is set
        internal bool IsSetErrorTopic()
        {
            return this._errorTopic != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeInferenceResponseIn. 
        /// <para>
        /// The Amazon SNS topics where you want the inference response to be included.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> IncludeInferenceResponseIn
        {
            get { return this._includeInferenceResponseIn; }
            set { this._includeInferenceResponseIn = value; }
        }

        // Check to see if IncludeInferenceResponseIn property is set
        internal bool IsSetIncludeInferenceResponseIn()
        {
            return this._includeInferenceResponseIn != null && this._includeInferenceResponseIn.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SuccessTopic. 
        /// <para>
        /// Amazon SNS topic to post a notification to when inference completes successfully.
        /// If no topic is provided, no notification is sent on success.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string SuccessTopic
        {
            get { return this._successTopic; }
            set { this._successTopic = value; }
        }

        // Check to see if SuccessTopic property is set
        internal bool IsSetSuccessTopic()
        {
            return this._successTopic != null;
        }

    }
}