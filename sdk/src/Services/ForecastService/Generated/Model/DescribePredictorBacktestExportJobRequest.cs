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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribePredictorBacktestExportJob operation.
    /// Describes a predictor backtest export job created using the <a>CreatePredictorBacktestExportJob</a>
    /// operation.
    /// 
    ///  
    /// <para>
    /// In addition to listing the properties provided by the user in the <c>CreatePredictorBacktestExportJob</c>
    /// request, this operation lists the following properties:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>CreationTime</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>LastModificationTime</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Status</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Message</c> (if an error occurred)
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribePredictorBacktestExportJobRequest : AmazonForecastServiceRequest
    {
        private string _predictorBacktestExportJobArn;

        /// <summary>
        /// Gets and sets the property PredictorBacktestExportJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the predictor backtest export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string PredictorBacktestExportJobArn
        {
            get { return this._predictorBacktestExportJobArn; }
            set { this._predictorBacktestExportJobArn = value; }
        }

        // Check to see if PredictorBacktestExportJobArn property is set
        internal bool IsSetPredictorBacktestExportJobArn()
        {
            return this._predictorBacktestExportJobArn != null;
        }

    }
}