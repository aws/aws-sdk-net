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
    /// The collection of settings used by an AutoML job V2 for the text generation problem
    /// type.
    /// 
    ///  <note> 
    /// <para>
    /// The text generation models that support fine-tuning in Autopilot are currently accessible
    /// exclusively in regions supported by Canvas. Refer to the documentation of Canvas for
    /// the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/canvas.html">full list
    /// of its supported Regions</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class TextGenerationJobConfig
    {
        private string _baseModelName;
        private AutoMLJobCompletionCriteria _completionCriteria;

        /// <summary>
        /// Gets and sets the property BaseModelName. 
        /// <para>
        /// The name of the base model to fine-tune. Autopilot supports fine-tuning a variety
        /// of large language models. For information on the list of supported models, see <a
        /// href="https://docs.aws.amazon.com/sagemaker/src/AWSIronmanApiDoc/build/server-root/sagemaker/latest/dg/llms-finetuning-models.html#llms-finetuning-supported-llms">Text
        /// generation models supporting fine-tuning in Autopilot</a>. If no <code>BaseModelName</code>
        /// is provided, the default model used is Falcon-7B-Instruct. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string BaseModelName
        {
            get { return this._baseModelName; }
            set { this._baseModelName = value; }
        }

        // Check to see if BaseModelName property is set
        internal bool IsSetBaseModelName()
        {
            return this._baseModelName != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionCriteria.
        /// </summary>
        public AutoMLJobCompletionCriteria CompletionCriteria
        {
            get { return this._completionCriteria; }
            set { this._completionCriteria = value; }
        }

        // Check to see if CompletionCriteria property is set
        internal bool IsSetCompletionCriteria()
        {
            return this._completionCriteria != null;
        }

    }
}