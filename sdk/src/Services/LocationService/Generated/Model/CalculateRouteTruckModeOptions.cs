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
    /// Contains details about additional route preferences for requests that specify <c>TravelMode</c>
    /// as <c>Truck</c>.
    /// </summary>
    public partial class CalculateRouteTruckModeOptions
    {
        private bool? _avoidFerries;
        private bool? _avoidTolls;
        private TruckDimensions _dimensions;
        private TruckWeight _weight;

        /// <summary>
        /// Gets and sets the property AvoidFerries. 
        /// <para>
        /// Avoids ferries when calculating routes.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>false</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>false</c> | <c>true</c> 
        /// </para>
        /// </summary>
        public bool? AvoidFerries
        {
            get { return this._avoidFerries; }
            set { this._avoidFerries = value; }
        }

        // Check to see if AvoidFerries property is set
        internal bool IsSetAvoidFerries()
        {
            return this._avoidFerries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvoidTolls. 
        /// <para>
        /// Avoids tolls when calculating routes.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>false</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>false</c> | <c>true</c> 
        /// </para>
        /// </summary>
        public bool? AvoidTolls
        {
            get { return this._avoidTolls; }
            set { this._avoidTolls = value; }
        }

        // Check to see if AvoidTolls property is set
        internal bool IsSetAvoidTolls()
        {
            return this._avoidTolls.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// Specifies the truck's dimension specifications including length, height, width, and
        /// unit of measurement. Used to avoid roads that can't support the truck's dimensions.
        /// </para>
        /// </summary>
        public TruckDimensions Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null;
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// Specifies the truck's weight specifications including total weight and unit of measurement.
        /// Used to avoid roads that can't support the truck's weight.
        /// </para>
        /// </summary>
        public TruckWeight Weight
        {
            get { return this._weight; }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight != null;
        }

    }
}