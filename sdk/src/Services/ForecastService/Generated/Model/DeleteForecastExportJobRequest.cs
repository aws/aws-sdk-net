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
    /// Container for the parameters to the DeleteForecastExportJob operation.
    /// Deletes a forecast export job created using the <a>CreateForecastExportJob</a> operation.
    /// You can delete only export jobs that have a status of <c>ACTIVE</c> or <c>CREATE_FAILED</c>.
    /// To get the status, use the <a>DescribeForecastExportJob</a> operation.
    /// </summary>
    public partial class DeleteForecastExportJobRequest : AmazonForecastServiceRequest
    {
        private string _forecastExportJobArn;

        /// <summary>
        /// Gets and sets the property ForecastExportJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the forecast export job to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ForecastExportJobArn
        {
            get { return this._forecastExportJobArn; }
            set { this._forecastExportJobArn = value; }
        }

        // Check to see if ForecastExportJobArn property is set
        internal bool IsSetForecastExportJobArn()
        {
            return this._forecastExportJobArn != null;
        }

    }
}