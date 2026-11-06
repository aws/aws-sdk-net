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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// This is the response object from the GetGeoLocation operation.
    /// </summary>
    public partial class GetGeoLocationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property GeoLocationDetails. 
        /// <para>
        /// A complex type that contains the codes and full continent, country, and subdivision
        /// names for the specified geolocation code.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GeoLocationDetails GeoLocationDetails { get; set; }

        /// <summary>
        /// Checks to see if the GeoLocationDetails property is set.
        /// </summary>
        internal bool IsSetGeoLocationDetails() => this.GeoLocationDetails != null;
    }
}
