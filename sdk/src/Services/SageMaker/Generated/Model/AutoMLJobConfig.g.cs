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
    /// A collection of settings used for an AutoML job.
    /// </summary>
    public partial class AutoMLJobConfig
    {
        /// <summary>
        /// Gets and sets the property CandidateGenerationConfig. 
        /// <para>
        /// The configuration for generating a candidate for an AutoML job (optional). 
        /// </para>
        /// </summary>
        public AutoMLCandidateGenerationConfig CandidateGenerationConfig { get; set; }

        /// <summary>
        /// Checks to see if the CandidateGenerationConfig property is set.
        /// </summary>
        internal bool IsSetCandidateGenerationConfig() => this.CandidateGenerationConfig != null;

        /// <summary>
        /// Gets and sets the property CompletionCriteria. 
        /// <para>
        /// How long an AutoML job is allowed to run, or how many candidates a job is allowed
        /// to generate.
        /// </para>
        /// </summary>
        public AutoMLJobCompletionCriteria CompletionCriteria { get; set; }

        /// <summary>
        /// Checks to see if the CompletionCriteria property is set.
        /// </summary>
        internal bool IsSetCompletionCriteria() => this.CompletionCriteria != null;

        /// <summary>
        /// Gets and sets the property DataSplitConfig. 
        /// <para>
        /// The configuration for splitting the input training dataset.
        /// </para>
        ///  
        /// <para>
        /// Type: AutoMLDataSplitConfig
        /// </para>
        /// </summary>
        public AutoMLDataSplitConfig DataSplitConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataSplitConfig property is set.
        /// </summary>
        internal bool IsSetDataSplitConfig() => this.DataSplitConfig != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The method that Autopilot uses to train the data. You can either specify the mode
        /// manually or let Autopilot choose for you based on the dataset size by selecting <c>AUTO</c>.
        /// In <c>AUTO</c> mode, Autopilot chooses <c>ENSEMBLING</c> for datasets smaller than
        /// 100 MB, and <c>HYPERPARAMETER_TUNING</c> for larger ones.
        /// </para>
        ///  
        /// <para>
        /// The <c>ENSEMBLING</c> mode uses a multi-stack ensemble model to predict classification
        /// and regression tasks directly from your dataset. This machine learning mode combines
        /// several base models to produce an optimal predictive model. It then uses a stacking
        /// ensemble method to combine predictions from contributing members. A multi-stack ensemble
        /// model can provide better performance over a single model by combining the predictive
        /// capabilities of multiple models. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-model-support-validation.html#autopilot-algorithm-support">Autopilot
        /// algorithm support</a> for a list of algorithms supported by <c>ENSEMBLING</c> mode.
        /// </para>
        ///  
        /// <para>
        /// The <c>HYPERPARAMETER_TUNING</c> (HPO) mode uses the best hyperparameters to train
        /// the best version of a model. HPO automatically selects an algorithm for the type of
        /// problem you want to solve. Then HPO finds the best hyperparameters according to your
        /// objective metric. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-model-support-validation.html#autopilot-algorithm-support">Autopilot
        /// algorithm support</a> for a list of algorithms supported by <c>HYPERPARAMETER_TUNING</c>
        /// mode.
        /// </para>
        /// </summary>
        public AutoMLMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property SecurityConfig. 
        /// <para>
        /// The security configuration for traffic encryption or Amazon VPC settings.
        /// </para>
        /// </summary>
        public AutoMLSecurityConfig SecurityConfig { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfig property is set.
        /// </summary>
        internal bool IsSetSecurityConfig() => this.SecurityConfig != null;
    }
}
