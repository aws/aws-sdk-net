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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRouteCalculator operation.
    /// Deletes a route calculator resource from your Amazon Web Services account.
    /// 
    ///  <note> 
    /// <para>
    /// This operation deletes the resource permanently.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteRouteCalculatorRequest : AmazonLocationServiceRequest
    {
        private string _calculatorName;

        /// <summary>
        /// Gets and sets the property CalculatorName. 
        /// <para>
        /// The name of the route calculator resource to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string CalculatorName
        {
            get { return this._calculatorName; }
            set { this._calculatorName = value; }
        }

        // Check to see if CalculatorName property is set
        internal bool IsSetCalculatorName()
        {
            return this._calculatorName != null;
        }

    }
}