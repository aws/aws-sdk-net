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
    /// Container for the parameters to the StopResource operation.
    /// Stops a resource.
    /// 
    ///  
    /// <para>
    /// The resource undergoes the following states: <c>CREATE_STOPPING</c> and <c>CREATE_STOPPED</c>.
    /// You cannot resume a resource once it has been stopped.
    /// </para>
    ///  
    /// <para>
    /// This operation can be applied to the following resources (and their corresponding
    /// child resources):
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Dataset Import Job
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Predictor Job
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Forecast Job
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Forecast Export Job
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Predictor Backtest Export Job
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Explainability Job
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Explainability Export Job
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StopResourceRequest : AmazonForecastServiceRequest
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the resource to stop. The supported
        /// ARNs are <c>DatasetImportJobArn</c>, <c>PredictorArn</c>, <c>PredictorBacktestExportJobArn</c>,
        /// <c>ForecastArn</c>, <c>ForecastExportJobArn</c>, <c>ExplainabilityArn</c>, and <c>ExplainabilityExportArn</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}