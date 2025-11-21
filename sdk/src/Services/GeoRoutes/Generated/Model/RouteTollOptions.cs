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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
        private bool? _allTransponders;
        private bool? _allVignettes;
        private string _currency;
        private RouteEmissionType _emissionType;
        private RouteTollVehicleCategory _vehicleCategory;

        /// <summary>
        /// Gets and sets the property AllTransponders. 
        /// <para>
        /// Specifies if the user has valid transponder with access to all toll systems. This
        /// impacts toll calculation, and if true the price with transponders is used.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? AllTransponders
        {
            get { return this._allTransponders; }
            set { this._allTransponders = value; }
        }

        // Check to see if AllTransponders property is set
        internal bool IsSetAllTransponders()
        {
            return this._allTransponders.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllVignettes. 
        /// <para>
        /// Specifies if the user has valid vignettes with access for all toll roads. If a user
        /// has a vignette for a toll road, then toll cost for that road is omitted since no further
        /// payment is necessary.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? AllVignettes
        {
            get { return this._allVignettes; }
            set { this._allVignettes = value; }
        }

        // Check to see if AllVignettes property is set
        internal bool IsSetAllVignettes()
        {
            return this._allVignettes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// Currency code corresponding to the price. This is the same as Currency specified in
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=3)]
        public string Currency
        {
            get { return this._currency; }
            set { this._currency = value; }
        }

        // Check to see if Currency property is set
        internal bool IsSetCurrency()
        {
            return this._currency != null;
        }

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
        public RouteEmissionType EmissionType
        {
            get { return this._emissionType; }
            set { this._emissionType = value; }
        }

        // Check to see if EmissionType property is set
        internal bool IsSetEmissionType()
        {
            return this._emissionType != null;
        }

        /// <summary>
        /// Gets and sets the property VehicleCategory. 
        /// <para>
        /// Vehicle category for toll cost calculation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RouteTollVehicleCategory VehicleCategory
        {
            get { return this._vehicleCategory; }
            set { this._vehicleCategory = value; }
        }

        // Check to see if VehicleCategory property is set
        internal bool IsSetVehicleCategory()
        {
            return this._vehicleCategory != null;
        }

    }
}