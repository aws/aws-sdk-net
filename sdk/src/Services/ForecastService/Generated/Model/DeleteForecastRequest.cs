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
    /// Container for the parameters to the DeleteForecast operation.
    /// Deletes a forecast created using the <a>CreateForecast</a> operation. You can delete
    /// only forecasts that have a status of <c>ACTIVE</c> or <c>CREATE_FAILED</c>. To get
    /// the status, use the <a>DescribeForecast</a> operation.
    /// 
    ///  
    /// <para>
    /// You can't delete a forecast while it is being exported. After a forecast is deleted,
    /// you can no longer query the forecast.
    /// </para>
    /// </summary>
    public partial class DeleteForecastRequest : AmazonForecastServiceRequest
    {
        private string _forecastArn;

        /// <summary>
        /// Gets and sets the property ForecastArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the forecast to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ForecastArn
        {
            get { return this._forecastArn; }
            set { this._forecastArn = value; }
        }

        // Check to see if ForecastArn property is set
        internal bool IsSetForecastArn()
        {
            return this._forecastArn != null;
        }

    }
}