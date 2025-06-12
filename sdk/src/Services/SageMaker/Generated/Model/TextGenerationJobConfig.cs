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
        private ModelAccessConfig _modelAccessConfig;
        private Dictionary<string, string> _textGenerationHyperParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property BaseModelName. 
        /// <para>
        /// The name of the base model to fine-tune. Autopilot supports fine-tuning a variety
        /// of large language models. For information on the list of supported models, see <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-llms-finetuning-models.html#autopilot-llms-finetuning-supported-llms">Text
        /// generation models supporting fine-tuning in Autopilot</a>. If no <c>BaseModelName</c>
        /// is provided, the default model used is <b>Falcon7BInstruct</b>. 
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
        /// <para>
        /// How long a fine-tuning job is allowed to run. For <c>TextGenerationJobConfig</c> problem
        /// types, the <c>MaxRuntimePerTrainingJobInSeconds</c> attribute of <c>AutoMLJobCompletionCriteria</c>
        /// defaults to 72h (259200s).
        /// </para>
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

        /// <summary>
        /// Gets and sets the property ModelAccessConfig.
        /// </summary>
        public ModelAccessConfig ModelAccessConfig
        {
            get { return this._modelAccessConfig; }
            set { this._modelAccessConfig = value; }
        }

        // Check to see if ModelAccessConfig property is set
        internal bool IsSetModelAccessConfig()
        {
            return this._modelAccessConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TextGenerationHyperParameters. 
        /// <para>
        /// The hyperparameters used to configure and optimize the learning process of the base
        /// model. You can set any combination of the following hyperparameters for all base models.
        /// For more information on each supported hyperparameter, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-llms-finetuning-set-hyperparameters.html">Optimize
        /// the learning process of your text generation models with hyperparameters</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"epochCount"</c>: The number of times the model goes through the entire training
        /// dataset. Its value should be a string containing an integer value within the range
        /// of "1" to "10".
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"batchSize"</c>: The number of data samples used in each iteration of training.
        /// Its value should be a string containing an integer value within the range of "1" to
        /// "64".
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"learningRate"</c>: The step size at which a model's parameters are updated during
        /// training. Its value should be a string containing a floating-point value within the
        /// range of "0" to "1".
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"learningRateWarmupSteps"</c>: The number of training steps during which the learning
        /// rate gradually increases before reaching its target or maximum value. Its value should
        /// be a string containing an integer value within the range of "0" to "250".
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Here is an example where all four hyperparameters are configured.
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "epochCount":"5", "learningRate":"0.5", "batchSize": "32", "learningRateWarmupSteps":
        /// "10" }</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public Dictionary<string, string> TextGenerationHyperParameters
        {
            get { return this._textGenerationHyperParameters; }
            set { this._textGenerationHyperParameters = value; }
        }

        // Check to see if TextGenerationHyperParameters property is set
        internal bool IsSetTextGenerationHyperParameters()
        {
            return this._textGenerationHyperParameters != null && (this._textGenerationHyperParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}