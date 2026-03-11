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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Hyperparameters for controlling the reinforcement fine-tuning training process, including
    /// learning settings and evaluation intervals.
    /// </summary>
    public partial class RFTHyperParameters
    {
        private int? _batchSize;
        private int? _epochCount;
        private int? _evalInterval;
        private int? _inferenceMaxTokens;
        private float? _learningRate;
        private int? _maxPromptLength;
        private ReasoningEffort _reasoningEffort;
        private int? _trainingSamplePerPrompt;

        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        ///  Number of training samples processed in each batch during reinforcement fine-tuning
        /// (RFT) training. Larger batches may improve training stability. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=512)]
        public int? BatchSize
        {
            get { return this._batchSize; }
            set { this._batchSize = value; }
        }

        // Check to see if BatchSize property is set
        internal bool IsSetBatchSize()
        {
            return this._batchSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EpochCount. 
        /// <para>
        ///  Number of training epochs to run during reinforcement fine-tuning. Higher values
        /// may improve performance but increase training time. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? EpochCount
        {
            get { return this._epochCount; }
            set { this._epochCount = value; }
        }

        // Check to see if EpochCount property is set
        internal bool IsSetEpochCount()
        {
            return this._epochCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvalInterval. 
        /// <para>
        ///  Interval between evaluation runs during RFT training, measured in training steps.
        /// More frequent evaluation provides better monitoring. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? EvalInterval
        {
            get { return this._evalInterval; }
            set { this._evalInterval = value; }
        }

        // Check to see if EvalInterval property is set
        internal bool IsSetEvalInterval()
        {
            return this._evalInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InferenceMaxTokens. 
        /// <para>
        ///  Maximum number of tokens the model can generate in response to each prompt during
        /// RFT training. 
        /// </para>
        /// </summary>
        public int? InferenceMaxTokens
        {
            get { return this._inferenceMaxTokens; }
            set { this._inferenceMaxTokens = value; }
        }

        // Check to see if InferenceMaxTokens property is set
        internal bool IsSetInferenceMaxTokens()
        {
            return this._inferenceMaxTokens.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LearningRate. 
        /// <para>
        ///  Learning rate for the reinforcement fine-tuning. Controls how quickly the model adapts
        /// to reward signals. 
        /// </para>
        /// </summary>
        public float? LearningRate
        {
            get { return this._learningRate; }
            set { this._learningRate = value; }
        }

        // Check to see if LearningRate property is set
        internal bool IsSetLearningRate()
        {
            return this._learningRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxPromptLength. 
        /// <para>
        ///  Maximum length of input prompts during RFT training, measured in tokens. Longer prompts
        /// allow more context but increase memory usage and training-time. 
        /// </para>
        /// </summary>
        public int? MaxPromptLength
        {
            get { return this._maxPromptLength; }
            set { this._maxPromptLength = value; }
        }

        // Check to see if MaxPromptLength property is set
        internal bool IsSetMaxPromptLength()
        {
            return this._maxPromptLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReasoningEffort. 
        /// <para>
        ///  Level of reasoning effort applied during RFT training. Higher values may improve
        /// response quality but increase training time. 
        /// </para>
        /// </summary>
        public ReasoningEffort ReasoningEffort
        {
            get { return this._reasoningEffort; }
            set { this._reasoningEffort = value; }
        }

        // Check to see if ReasoningEffort property is set
        internal bool IsSetReasoningEffort()
        {
            return this._reasoningEffort != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingSamplePerPrompt. 
        /// <para>
        ///  Number of response samples generated per prompt during RFT training. More samples
        /// provide better reward signal estimation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=16)]
        public int? TrainingSamplePerPrompt
        {
            get { return this._trainingSamplePerPrompt; }
            set { this._trainingSamplePerPrompt = value; }
        }

        // Check to see if TrainingSamplePerPrompt property is set
        internal bool IsSetTrainingSamplePerPrompt()
        {
            return this._trainingSamplePerPrompt.HasValue; 
        }

    }
}