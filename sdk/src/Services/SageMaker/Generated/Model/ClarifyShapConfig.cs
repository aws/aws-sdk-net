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
    /// The configuration for SHAP analysis using SageMaker Clarify Explainer.
    /// </summary>
    public partial class ClarifyShapConfig
    {
        private int? _numberOfSamples;
        private int? _seed;
        private ClarifyShapBaselineConfig _shapBaselineConfig;
        private ClarifyTextConfig _textConfig;
        private bool? _useLogit;

        /// <summary>
        /// Gets and sets the property NumberOfSamples. 
        /// <para>
        /// The number of samples to be used for analysis by the Kernal SHAP algorithm. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The number of samples determines the size of the synthetic dataset, which has an impact
        /// on latency of explainability requests. For more information, see the <b>Synthetic
        /// data</b> of <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/clarify-online-explainability-create-endpoint.html">Configure
        /// and create an endpoint</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? NumberOfSamples
        {
            get { return this._numberOfSamples; }
            set { this._numberOfSamples = value; }
        }

        // Check to see if NumberOfSamples property is set
        internal bool IsSetNumberOfSamples()
        {
            return this._numberOfSamples.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Seed. 
        /// <para>
        /// The starting value used to initialize the random number generator in the explainer.
        /// Provide a value for this parameter to obtain a deterministic SHAP result.
        /// </para>
        /// </summary>
        public int? Seed
        {
            get { return this._seed; }
            set { this._seed = value; }
        }

        // Check to see if Seed property is set
        internal bool IsSetSeed()
        {
            return this._seed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShapBaselineConfig. 
        /// <para>
        /// The configuration for the SHAP baseline of the Kernal SHAP algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClarifyShapBaselineConfig ShapBaselineConfig
        {
            get { return this._shapBaselineConfig; }
            set { this._shapBaselineConfig = value; }
        }

        // Check to see if ShapBaselineConfig property is set
        internal bool IsSetShapBaselineConfig()
        {
            return this._shapBaselineConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TextConfig. 
        /// <para>
        /// A parameter that indicates if text features are treated as text and explanations are
        /// provided for individual units of text. Required for natural language processing (NLP)
        /// explainability only.
        /// </para>
        /// </summary>
        public ClarifyTextConfig TextConfig
        {
            get { return this._textConfig; }
            set { this._textConfig = value; }
        }

        // Check to see if TextConfig property is set
        internal bool IsSetTextConfig()
        {
            return this._textConfig != null;
        }

        /// <summary>
        /// Gets and sets the property UseLogit. 
        /// <para>
        /// A Boolean toggle to indicate if you want to use the logit function (true) or log-odds
        /// units (false) for model predictions. Defaults to false.
        /// </para>
        /// </summary>
        public bool? UseLogit
        {
            get { return this._useLogit; }
            set { this._useLogit = value; }
        }

        // Check to see if UseLogit property is set
        internal bool IsSetUseLogit()
        {
            return this._useLogit.HasValue; 
        }

    }
}