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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribePredictor operation.
    /// Describes a predictor created using the <a>CreatePredictor</a> operation.
    /// 
    ///  
    /// <para>
    /// In addition to listing the properties provided in the <code>CreatePredictor</code>
    /// request, this operation lists the following properties:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>DatasetImportJobArns</code> - The dataset import jobs used to import training
    /// data.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AutoMLAlgorithmArns</code> - If AutoML is performed, the algorithms that were
    /// evaluated.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CreationTime</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>LastModificationTime</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Status</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Message</code> - If an error occurred, information about the error.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribePredictorRequest : AmazonForecastServiceRequest
    {
        private string _predictorArn;

        /// <summary>
        /// Gets and sets the property PredictorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the predictor that you want information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string PredictorArn
        {
            get { return this._predictorArn; }
            set { this._predictorArn = value; }
        }

        // Check to see if PredictorArn property is set
        internal bool IsSetPredictorArn()
        {
            return this._predictorArn != null;
        }

    }
}