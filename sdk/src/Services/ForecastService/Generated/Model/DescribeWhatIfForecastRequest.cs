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
    /// Container for the parameters to the DescribeWhatIfForecast operation.
    /// Describes the what-if forecast created using the <a>CreateWhatIfForecast</a> operation.
    /// 
    ///  
    /// <para>
    /// In addition to listing the properties provided in the <c>CreateWhatIfForecast</c>
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
    ///  <c>Message</c> - If an error occurred, information about the error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Status</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeWhatIfForecastRequest : AmazonForecastServiceRequest
    {
        private string _whatIfForecastArn;

        /// <summary>
        /// Gets and sets the property WhatIfForecastArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the what-if forecast that you are interested in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=300)]
        public string WhatIfForecastArn
        {
            get { return this._whatIfForecastArn; }
            set { this._whatIfForecastArn = value; }
        }

        // Check to see if WhatIfForecastArn property is set
        internal bool IsSetWhatIfForecastArn()
        {
            return this._whatIfForecastArn != null;
        }

    }
}