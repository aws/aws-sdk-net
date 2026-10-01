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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The preference hierarchy for the geocode preference.
    /// </summary>
    public partial class GeocoderHierarchy
    {
        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city value for the preference hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3000)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country value for the preference hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3000)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property County. 
        /// <para>
        /// The county/district value for the preference hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3000)]
        public string County { get; set; }

        /// <summary>
        /// Checks to see if the County property is set.
        /// </summary>
        internal bool IsSetCounty() => this.County != null;

        /// <summary>
        /// Gets and sets the property PostCode. 
        /// <para>
        /// The postcode value for the preference hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3000)]
        public string PostCode { get; set; }

        /// <summary>
        /// Checks to see if the PostCode property is set.
        /// </summary>
        internal bool IsSetPostCode() => this.PostCode != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state/region value for the preference hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3000)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
