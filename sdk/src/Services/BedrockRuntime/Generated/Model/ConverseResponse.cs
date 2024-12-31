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
    /// This is the response object from the Converse operation.
    /// </summary>
    public partial class ConverseResponse : AmazonWebServiceResponse
    {
        private Amazon.Runtime.Documents.Document _additionalModelResponseFields;
        private ConverseMetrics _metrics;
        private ConverseOutput _output;
        private PerformanceConfiguration _performanceConfig;
        private StopReason _stopReason;
        private ConverseTrace _trace;
        private TokenUsage _usage;

        /// <summary>
        /// Gets and sets the property AdditionalModelResponseFields. 
        /// <para>
        /// Additional fields in the response that are unique to the model. 
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document AdditionalModelResponseFields
        {
            get { return this._additionalModelResponseFields; }
            set { this._additionalModelResponseFields = value; }
        }

        // Check to see if AdditionalModelResponseFields property is set
        internal bool IsSetAdditionalModelResponseFields()
        {
            return !this._additionalModelResponseFields.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// Metrics for the call to <c>Converse</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConverseMetrics Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null;
        }

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// The result from the call to <c>Converse</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConverseOutput Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceConfig. 
        /// <para>
        /// Model performance settings for the request.
        /// </para>
        /// </summary>
        public PerformanceConfiguration PerformanceConfig
        {
            get { return this._performanceConfig; }
            set { this._performanceConfig = value; }
        }

        // Check to see if PerformanceConfig property is set
        internal bool IsSetPerformanceConfig()
        {
            return this._performanceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property StopReason. 
        /// <para>
        /// The reason why the model stopped generating output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StopReason StopReason
        {
            get { return this._stopReason; }
            set { this._stopReason = value; }
        }

        // Check to see if StopReason property is set
        internal bool IsSetStopReason()
        {
            return this._stopReason != null;
        }

        /// <summary>
        /// Gets and sets the property Trace. 
        /// <para>
        /// A trace object that contains information about the Guardrail behavior.
        /// </para>
        /// </summary>
        public ConverseTrace Trace
        {
            get { return this._trace; }
            set { this._trace = value; }
        }

        // Check to see if Trace property is set
        internal bool IsSetTrace()
        {
            return this._trace != null;
        }

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        /// The total number of tokens used in the call to <c>Converse</c>. The total includes
        /// the tokens input to the model and the tokens generated by the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TokenUsage Usage
        {
            get { return this._usage; }
            set { this._usage = value; }
        }

        // Check to see if Usage property is set
        internal bool IsSetUsage()
        {
            return this._usage != null;
        }

    }
}