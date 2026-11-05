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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The configuration for the serverless training job.
    /// </summary>
    public partial class ServerlessJobConfig
    {
        /// <summary>
        /// Gets and sets the property AcceptEula. 
        /// <para>
        ///  Specifies agreement to the model end-user license agreement (EULA). The <c>AcceptEula</c>
        /// value must be explicitly defined as <c>True</c> in order to accept the EULA that this
        /// model requires. You are responsible for reviewing and complying with any applicable
        /// license terms and making sure they are acceptable for your use case before downloading
        /// or using a model. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/jumpstart-foundation-models-choose.html#jumpstart-foundation-models-choose-eula">End-user
        /// license agreements</a> section for more details on accepting the EULA. 
        /// </para>
        /// </summary>
        public bool? AcceptEula { get; set; }

        /// <summary>
        /// Checks to see if the AcceptEula property is set.
        /// </summary>
        internal bool IsSetAcceptEula() => this.AcceptEula.HasValue;

        /// <summary>
        /// Gets and sets the property BaseModelArn. 
        /// <para>
        ///  The base model Amazon Resource Name (ARN) in <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/jumpstart-foundation-models-use.html">SageMaker
        /// Public Hub</a>. SageMaker always selects the latest version of the provided model.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string BaseModelArn { get; set; }

        /// <summary>
        /// Checks to see if the BaseModelArn property is set.
        /// </summary>
        internal bool IsSetBaseModelArn() => this.BaseModelArn != null;

        /// <summary>
        /// Gets and sets the property CustomizationTechnique. 
        /// <para>
        ///  The model customization technique. 
        /// </para>
        /// </summary>
        public CustomizationTechnique CustomizationTechnique { get; set; }

        /// <summary>
        /// Checks to see if the CustomizationTechnique property is set.
        /// </summary>
        internal bool IsSetCustomizationTechnique() => this.CustomizationTechnique != null;

        /// <summary>
        /// Gets and sets the property EvaluationType. 
        /// <para>
        ///  The evaluation job type. Required when serverless job type is <c>Evaluation</c>.
        /// 
        /// </para>
        /// </summary>
        public EvaluationType EvaluationType { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationType property is set.
        /// </summary>
        internal bool IsSetEvaluationType() => this.EvaluationType != null;

        /// <summary>
        /// Gets and sets the property EvaluatorArn. 
        /// <para>
        ///  The evaluator Amazon Resource Name (ARN) used as reward function or reward prompt.
        /// 
        /// </para>
        /// </summary>
        public string EvaluatorArn { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorArn property is set.
        /// </summary>
        internal bool IsSetEvaluatorArn() => this.EvaluatorArn != null;

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        ///  The serverless training job type. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServerlessJobType JobType { get; set; }

        /// <summary>
        /// Checks to see if the JobType property is set.
        /// </summary>
        internal bool IsSetJobType() => this.JobType != null;

        /// <summary>
        /// Gets and sets the property Peft. 
        /// <para>
        ///  The parameter-efficient fine-tuning configuration. 
        /// </para>
        /// </summary>
        public Peft Peft { get; set; }

        /// <summary>
        /// Checks to see if the Peft property is set.
        /// </summary>
        internal bool IsSetPeft() => this.Peft != null;

        /// <summary>
        /// Gets and sets the property SequenceLength. 
        /// <para>
        ///  The maximum sequence length, in tokens, that the customization job supports. SageMaker
        /// uses this value to select a training configuration for the base model that you specify.
        /// The value must be an integer value from <c>1K</c> to <c>1024K</c> (for example, <c>32K</c>).
        /// 
        /// </para>
        ///  
        /// <para>
        ///  If you don't specify a value, SageMaker selects a training configuration based on
        /// the other values that you specify. The selection is not restricted to a particular
        /// sequence length. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string SequenceLength { get; set; }

        /// <summary>
        /// Checks to see if the SequenceLength property is set.
        /// </summary>
        internal bool IsSetSequenceLength() => this.SequenceLength != null;
    }
}
