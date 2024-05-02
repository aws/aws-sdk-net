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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that identifies ways in which you want to restrict distribution of
    /// your content.
    /// </summary>
    public partial class Restrictions
    {
        private GeoRestriction _geoRestriction;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Restrictions() { }

        /// <summary>
        /// Instantiates Restrictions with the parameterized properties
        /// </summary>
        /// <param name="geoRestriction">A complex type that controls the countries in which your content is distributed. CloudFront determines the location of your users using <c>MaxMind</c> GeoIP databases.</param>
        public Restrictions(GeoRestriction geoRestriction)
        {
            _geoRestriction = geoRestriction;
        }

        /// <summary>
        /// Gets and sets the property GeoRestriction. 
        /// <para>
        /// A complex type that controls the countries in which your content is distributed. CloudFront
        /// determines the location of your users using <c>MaxMind</c> GeoIP databases.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GeoRestriction GeoRestriction
        {
            get { return this._geoRestriction; }
            set { this._geoRestriction = value; }
        }

        // Check to see if GeoRestriction property is set
        internal bool IsSetGeoRestriction()
        {
            return this._geoRestriction != null;
        }

    }
}