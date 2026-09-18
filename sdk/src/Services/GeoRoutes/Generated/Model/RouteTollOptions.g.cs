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

namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Options related to Tolls on a route.
    /// </summary>
    public partial class RouteTollOptions
    {
        /// <summary>
        /// Gets and sets the property AllTransponders. 
        /// <para>
        /// Specifies if the user has valid transponder with access to all toll systems. This
        /// impacts toll calculation, and if true the price with transponders is used.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? AllTransponders { get; set; }

        /// <summary>
        /// Checks to see if the AllTransponders property is set.
        /// </summary>
        internal bool IsSetAllTransponders() => this.AllTransponders.HasValue;

        /// <summary>
        /// Gets and sets the property AllVignettes. 
        /// <para>
        /// Specifies if the user has valid vignettes with access for all toll roads. If a user
        /// has a vignette for a toll road, then toll cost for that road is omitted since no further
        /// payment is necessary.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? AllVignettes { get; set; }

        /// <summary>
        /// Checks to see if the AllVignettes property is set.
        /// </summary>
        internal bool IsSetAllVignettes() => this.AllVignettes.HasValue;

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// Currency code corresponding to the price. This is the same as Currency specified in
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 3)]
        public string Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property EmissionType. 
        /// <para>
        /// Emission type of the vehicle for toll cost calculation.
        /// </para>
        ///  
        /// <para>
        ///  <b>Valid values</b>: <c>Euro1, Euro2, Euro3, Euro4, Euro5, Euro6, EuroEev</c> 
        /// </para>
        /// </summary>
        public RouteEmissionType EmissionType { get; set; }

        /// <summary>
        /// Checks to see if the EmissionType property is set.
        /// </summary>
        internal bool IsSetEmissionType() => this.EmissionType != null;

        /// <summary>
        /// Gets and sets the property VehicleCategory. 
        /// <para>
        /// Vehicle category for toll cost calculation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RouteTollVehicleCategory VehicleCategory { get; set; }

        /// <summary>
        /// Checks to see if the VehicleCategory property is set.
        /// </summary>
        internal bool IsSetVehicleCategory() => this.VehicleCategory != null;
    }
}
