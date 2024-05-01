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
    /// Contains details about the truck's weight specifications. Used to avoid roads that
    /// can't support or allow the total weight for requests that specify <c>TravelMode</c>
    /// as <c>Truck</c>.
    /// </summary>
    public partial class TruckWeight
    {
        private double? _total;
        private VehicleWeightUnit _unit;

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total weight of the truck. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For example, <c>3500</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0)]
        public double? Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measurement to use for the truck weight.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>Kilograms</c> 
        /// </para>
        /// </summary>
        public VehicleWeightUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}