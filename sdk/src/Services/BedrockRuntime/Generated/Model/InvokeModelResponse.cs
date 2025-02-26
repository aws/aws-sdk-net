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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// This is the response object from the InvokeModel operation.
    /// </summary>
    public partial class InvokeModelResponse : AmazonWebServiceResponse
    {
        private MemoryStream _body;
        private string _contentType;
        private PerformanceConfigLatency _performanceConfigLatency;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// Inference response from the model in the format specified in the <c>contentType</c>
        /// header. To see the format and content of the request and response bodies for different
        /// models, refer to <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters.html">Inference
        /// parameters</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=25000000)]
        public MemoryStream Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The MIME type of the inference result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceConfigLatency. 
        /// <para>
        /// Model performance settings for the request.
        /// </para>
        /// </summary>
        public PerformanceConfigLatency PerformanceConfigLatency
        {
            get { return this._performanceConfigLatency; }
            set { this._performanceConfigLatency = value; }
        }

        // Check to see if PerformanceConfigLatency property is set
        internal bool IsSetPerformanceConfigLatency()
        {
            return this._performanceConfigLatency != null;
        }

    }
}