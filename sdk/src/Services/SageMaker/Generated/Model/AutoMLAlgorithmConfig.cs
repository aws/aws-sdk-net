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
    /// The selection of algorithms trained on your dataset to generate the model candidates
    /// for an Autopilot job.
    /// </summary>
    public partial class AutoMLAlgorithmConfig
    {
        private List<string> _autoMLAlgorithms = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AutoMLAlgorithms. 
        /// <para>
        /// The selection of algorithms trained on your dataset to generate the model candidates
        /// for an Autopilot job.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>For the tabular problem type <c>TabularJobConfig</c>:</b> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Selected algorithms must belong to the list corresponding to the training mode set
        /// in <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AutoMLJobConfig.html#sagemaker-Type-AutoMLJobConfig-Mode">AutoMLJobConfig.Mode</a>
        /// (<c>ENSEMBLING</c> or <c>HYPERPARAMETER_TUNING</c>). Choose a minimum of 1 algorithm.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// In <c>ENSEMBLING</c> mode:
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
        /// In <c>HYPERPARAMETER_TUNING</c> mode:
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
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        ///  <b>For the time-series forecasting problem type <c>TimeSeriesForecastingJobConfig</c>:</b>
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Choose your algorithms from this list.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// "cnn-qr"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "deepar"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "prophet"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "arima"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "npts"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "ets"
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=11)]
        public List<string> AutoMLAlgorithms
        {
            get { return this._autoMLAlgorithms; }
            set { this._autoMLAlgorithms = value; }
        }

        // Check to see if AutoMLAlgorithms property is set
        internal bool IsSetAutoMLAlgorithms()
        {
            return this._autoMLAlgorithms != null && (this._autoMLAlgorithms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}