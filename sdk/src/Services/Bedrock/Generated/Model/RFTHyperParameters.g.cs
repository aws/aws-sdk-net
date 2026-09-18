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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        ///  Number of training samples processed in each batch during reinforcement fine-tuning
        /// (RFT) training. Larger batches may improve training stability. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 512)]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Checks to see if the BatchSize property is set.
        /// </summary>
        internal bool IsSetBatchSize() => this.BatchSize.HasValue;

        /// <summary>
        /// Gets and sets the property EpochCount. 
        /// <para>
        ///  Number of training epochs to run during reinforcement fine-tuning. Higher values
        /// may improve performance but increase training time. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? EpochCount { get; set; }

        /// <summary>
        /// Checks to see if the EpochCount property is set.
        /// </summary>
        internal bool IsSetEpochCount() => this.EpochCount.HasValue;

        /// <summary>
        /// Gets and sets the property EvalInterval. 
        /// <para>
        ///  Interval between evaluation runs during RFT training, measured in training steps.
        /// More frequent evaluation provides better monitoring. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? EvalInterval { get; set; }

        /// <summary>
        /// Checks to see if the EvalInterval property is set.
        /// </summary>
        internal bool IsSetEvalInterval() => this.EvalInterval.HasValue;

        /// <summary>
        /// Gets and sets the property InferenceMaxTokens. 
        /// <para>
        ///  Maximum number of tokens the model can generate in response to each prompt during
        /// RFT training. 
        /// </para>
        /// </summary>
        public int? InferenceMaxTokens { get; set; }

        /// <summary>
        /// Checks to see if the InferenceMaxTokens property is set.
        /// </summary>
        internal bool IsSetInferenceMaxTokens() => this.InferenceMaxTokens.HasValue;

        /// <summary>
        /// Gets and sets the property LearningRate. 
        /// <para>
        ///  Learning rate for the reinforcement fine-tuning. Controls how quickly the model adapts
        /// to reward signals. 
        /// </para>
        /// </summary>
        public float? LearningRate { get; set; }

        /// <summary>
        /// Checks to see if the LearningRate property is set.
        /// </summary>
        internal bool IsSetLearningRate() => this.LearningRate.HasValue;

        /// <summary>
        /// Gets and sets the property MaxPromptLength. 
        /// <para>
        ///  Maximum length of input prompts during RFT training, measured in tokens. Longer prompts
        /// allow more context but increase memory usage and training-time. 
        /// </para>
        /// </summary>
        public int? MaxPromptLength { get; set; }

        /// <summary>
        /// Checks to see if the MaxPromptLength property is set.
        /// </summary>
        internal bool IsSetMaxPromptLength() => this.MaxPromptLength.HasValue;

        /// <summary>
        /// Gets and sets the property ReasoningEffort. 
        /// <para>
        ///  Level of reasoning effort applied during RFT training. Higher values may improve
        /// response quality but increase training time. 
        /// </para>
        /// </summary>
        public ReasoningEffort ReasoningEffort { get; set; }

        /// <summary>
        /// Checks to see if the ReasoningEffort property is set.
        /// </summary>
        internal bool IsSetReasoningEffort() => this.ReasoningEffort != null;

        /// <summary>
        /// Gets and sets the property TrainingSamplePerPrompt. 
        /// <para>
        ///  Number of response samples generated per prompt during RFT training. More samples
        /// provide better reward signal estimation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 16)]
        public int? TrainingSamplePerPrompt { get; set; }

        /// <summary>
        /// Checks to see if the TrainingSamplePerPrompt property is set.
        /// </summary>
        internal bool IsSetTrainingSamplePerPrompt() => this.TrainingSamplePerPrompt.HasValue;
    }
}
