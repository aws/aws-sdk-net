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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Configuration settings for integrating Deepgram speech-to-text models with Amazon
    /// Lex.
    /// </summary>
    public partial class DeepgramSpeechModelConfig
    {
        private string _apiTokenSecretArn;
        private string _modelId;

        /// <summary>
        /// Gets and sets the property ApiTokenSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Secrets Manager secret that contains the Deepgram
        /// API token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ApiTokenSecretArn
        {
            get { return this._apiTokenSecretArn; }
            set { this._apiTokenSecretArn = value; }
        }

        // Check to see if ApiTokenSecretArn property is set
        internal bool IsSetApiTokenSecretArn()
        {
            return this._apiTokenSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The identifier of the Deepgram speech-to-text model to use for processing speech input.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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

    }
}