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
    /// This is the response object from the CreatePredictorBacktestExportJob operation.
    /// </summary>
    public partial class CreatePredictorBacktestExportJobResponse : AmazonWebServiceResponse
    {
        private string _predictorBacktestExportJobArn;

        /// <summary>
        /// Gets and sets the property PredictorBacktestExportJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the predictor backtest export job that you want
        /// to export.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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