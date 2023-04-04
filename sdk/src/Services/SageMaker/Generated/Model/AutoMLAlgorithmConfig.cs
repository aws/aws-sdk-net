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
    /// The collection of algorithms run on a dataset for training the model candidates of
    /// an Autopilot job.
    /// </summary>
    public partial class AutoMLAlgorithmConfig
    {
        private List<string> _autoMLAlgorithms = new List<string>();

        /// <summary>
        /// Gets and sets the property AutoMLAlgorithms. 
        /// <para>
        /// The selection of algorithms run on a dataset to train the model candidates of an Autopilot
        /// job. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Selected algorithms must belong to the list corresponding to the training mode set
        /// in <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AutoMLJobConfig.html#sagemaker-Type-AutoMLJobConfig-Mode">AutoMLJobConfig.Mode</a>
        /// (<code>ENSEMBLING</code> or <code>HYPERPARAMETER_TUNING</code>). Choose a minimum
        /// of 1 algorithm. 
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// In <code>ENSEMBLING</code> mode:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// "catboost"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "extra-trees"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "fastai"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "lightgbm"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "linear-learner"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "nn-torch"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "randomforest"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "xgboost"
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// In <code>HYPERPARAMETER_TUNING</code> mode:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// "linear-learner"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "mlp"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "xgboost"
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=11)]
        public List<string> AutoMLAlgorithms
        {
            get { return this._autoMLAlgorithms; }
            set { this._autoMLAlgorithms = value; }
        }

        // Check to see if AutoMLAlgorithms property is set
        internal bool IsSetAutoMLAlgorithms()
        {
            return this._autoMLAlgorithms != null && this._autoMLAlgorithms.Count > 0; 
        }

    }
}