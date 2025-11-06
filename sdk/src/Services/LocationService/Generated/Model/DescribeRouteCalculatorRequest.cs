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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRouteCalculator operation.
    /// <important> 
    /// <para>
    /// This operation is no longer current and may be deprecated in the future. We recommend
    /// you upgrade to the Routes API V2 unless you require Grab data.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>DescribeRouteCalculator</c> is part of a previous Amazon Location Service Routes
    /// API (version 1) which has been superseded by a more intuitive, powerful, and complete
    /// API (version 2).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Routes API version 2 has a simplified interface that can be used without creating
    /// or managing route calculator resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you are using an Amazon Web Services SDK or the Amazon Web Services CLI, note that
    /// the Routes API version 2 is found under <c>geo-routes</c> or <c>geo_routes</c>, not
    /// under <c>location</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Since Grab is not yet fully supported in Routes API version 2, we recommend you continue
    /// using API version 1 when using Grab.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Start your version 2 API journey with the Routes V2 <a href="/location/latest/APIReference/API_Operations_Amazon_Location_Service_Routes_V2.html">API
    /// Reference</a> or the <a href="/location/latest/developerguide/routes.html">Developer
    /// Guide</a>.
    /// </para>
    ///  </li> </ul> </important> 
    /// <para>
    /// Retrieves the route calculator resource details.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class DescribeRouteCalculatorRequest : AmazonLocationServiceRequest
    {
        private string _calculatorName;

        /// <summary>
        /// Gets and sets the property CalculatorName. 
        /// <para>
        /// The name of the route calculator resource.
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