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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
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
namespace Amazon.WAF.Model
{
    /// <summary>
    /// This is the response object from the GetGeoMatchSet operation.
    /// </summary>
    public partial class GetGeoMatchSetResponse : AmazonWebServiceResponse
    {
        private GeoMatchSet _geoMatchSet;

        /// <summary>
        /// Gets and sets the property GeoMatchSet. 
        /// <para>
        /// Information about the <a>GeoMatchSet</a> that you specified in the <c>GetGeoMatchSet</c>
        /// request. This includes the <c>Type</c>, which for a <c>GeoMatchContraint</c> is always
        /// <c>Country</c>, as well as the <c>Value</c>, which is the identifier for a specific
        /// country.
        /// </para>
        /// </summary>
        public GeoMatchSet GeoMatchSet
        {
            get { return this._geoMatchSet; }
            set { this._geoMatchSet = value; }
        }

        // Check to see if GeoMatchSet property is set
        internal bool IsSetGeoMatchSet()
        {
            return this._geoMatchSet != null;
        }

    }
}