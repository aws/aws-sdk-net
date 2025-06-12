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
    /// Container for the parameters to the StartAsyncInvoke operation.
    /// Starts an asynchronous invocation.
    /// 
    ///  
    /// <para>
    /// This operation requires permission for the <c>bedrock:InvokeModel</c> action.
    /// </para>
    ///  <important> 
    /// <para>
    /// To deny all inference access to resources that you specify in the modelId field, you
    /// need to deny access to the <c>bedrock:InvokeModel</c> and <c>bedrock:InvokeModelWithResponseStream</c>
    /// actions. Doing this also denies access to the resource through the Converse API actions
    /// (<a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_Converse.html">Converse</a>
    /// and <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_ConverseStream.html">ConverseStream</a>).
    /// For more information see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/security_iam_id-based-policy-examples.html#security_iam_id-based-policy-examples-deny-inference">Deny
    /// access for inference on specific models</a>. 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class StartAsyncInvokeRequest : AmazonBedrockRuntimeRequest
    {
        private string _clientRequestToken;
        private string _modelId;
        private Amazon.Runtime.Documents.Document _modelInput;
        private AsyncInvokeOutputDataConfig _outputDataConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Specify idempotency token to ensure that requests are not duplicated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The model to invoke.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property ModelInput. 
        /// <para>
        /// Input to send to the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public Amazon.Runtime.Documents.Document ModelInput
        {
            get { return this._modelInput; }
            set { this._modelInput = value; }
        }

        // Check to see if ModelInput property is set
        internal bool IsSetModelInput()
        {
            return !this._modelInput.IsNull();
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Where to store the output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AsyncInvokeOutputDataConfig OutputDataConfig
        {
            get { return this._outputDataConfig; }
            set { this._outputDataConfig = value; }
        }

        // Check to see if OutputDataConfig property is set
        internal bool IsSetOutputDataConfig()
        {
            return this._outputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to apply to the invocation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}