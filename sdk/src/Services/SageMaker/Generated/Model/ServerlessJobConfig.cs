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
    /// The configuration for the serverless training job.
    /// </summary>
    public partial class ServerlessJobConfig
    {
        private bool? _acceptEula;
        private string _baseModelArn;
        private CustomizationTechnique _customizationTechnique;
        private EvaluationType _evaluationType;
        private string _evaluatorArn;
        private ServerlessJobType _jobType;
        private Peft _peft;

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
        public bool AcceptEula
        {
            get { return this._acceptEula.GetValueOrDefault(); }
            set { this._acceptEula = value; }
        }

        // Check to see if AcceptEula property is set
        internal bool IsSetAcceptEula()
        {
            return this._acceptEula.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BaseModelArn. 
        /// <para>
        ///  The base model Amazon Resource Name (ARN) in <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/jumpstart-foundation-models-use.html">SageMaker
        /// Public Hub</a>. SageMaker always selects the latest version of the provided model.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string BaseModelArn
        {
            get { return this._baseModelArn; }
            set { this._baseModelArn = value; }
        }

        // Check to see if BaseModelArn property is set
        internal bool IsSetBaseModelArn()
        {
            return this._baseModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property CustomizationTechnique. 
        /// <para>
        ///  The model customization technique. 
        /// </para>
        /// </summary>
        public CustomizationTechnique CustomizationTechnique
        {
            get { return this._customizationTechnique; }
            set { this._customizationTechnique = value; }
        }

        // Check to see if CustomizationTechnique property is set
        internal bool IsSetCustomizationTechnique()
        {
            return this._customizationTechnique != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationType. 
        /// <para>
        ///  The evaluation job type. Required when serverless job type is <c>Evaluation</c>.
        /// 
        /// </para>
        /// </summary>
        public EvaluationType EvaluationType
        {
            get { return this._evaluationType; }
            set { this._evaluationType = value; }
        }

        // Check to see if EvaluationType property is set
        internal bool IsSetEvaluationType()
        {
            return this._evaluationType != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatorArn. 
        /// <para>
        ///  The evaluator Amazon Resource Name (ARN) used as reward function or reward prompt.
        /// 
        /// </para>
        /// </summary>
        public string EvaluatorArn
        {
            get { return this._evaluatorArn; }
            set { this._evaluatorArn = value; }
        }

        // Check to see if EvaluatorArn property is set
        internal bool IsSetEvaluatorArn()
        {
            return this._evaluatorArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        ///  The serverless training job type. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServerlessJobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

        /// <summary>
        /// Gets and sets the property Peft. 
        /// <para>
        ///  The parameter-efficient fine-tuning configuration. 
        /// </para>
        /// </summary>
        public Peft Peft
        {
            get { return this._peft; }
            set { this._peft = value; }
        }

        // Check to see if Peft property is set
        internal bool IsSetPeft()
        {
            return this._peft != null;
        }

    }
}