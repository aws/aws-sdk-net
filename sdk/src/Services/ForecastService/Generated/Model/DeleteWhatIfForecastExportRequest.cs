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
    /// Container for the parameters to the DeleteWhatIfForecastExport operation.
    /// Deletes a what-if forecast export created using the <a>CreateWhatIfForecastExport</a>
    /// operation. You can delete only what-if forecast exports that have a status of <c>ACTIVE</c>
    /// or <c>CREATE_FAILED</c>. To get the status, use the <a>DescribeWhatIfForecastExport</a>
    /// operation.
    /// </summary>
    public partial class DeleteWhatIfForecastExportRequest : AmazonForecastServiceRequest
    {
        private string _whatIfForecastExportArn;

        /// <summary>
        /// Gets and sets the property WhatIfForecastExportArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the what-if forecast export that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=300)]
        public string WhatIfForecastExportArn
        {
            get { return this._whatIfForecastExportArn; }
            set { this._whatIfForecastExportArn = value; }
        }

        // Check to see if WhatIfForecastExportArn property is set
        internal bool IsSetWhatIfForecastExportArn()
        {
            return this._whatIfForecastExportArn != null;
        }

    }
}