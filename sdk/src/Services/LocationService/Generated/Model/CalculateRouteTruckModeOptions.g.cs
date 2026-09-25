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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Contains details about additional route preferences for requests that specify <c>TravelMode</c>
    /// as <c>Truck</c>.
    /// </summary>
    public partial class CalculateRouteTruckModeOptions
    {
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
        [AWSProperty(Sensitive = true)]
        public bool? AvoidFerries { get; set; }

        /// <summary>
        /// Checks to see if the AvoidFerries property is set.
        /// </summary>
        internal bool IsSetAvoidFerries() => this.AvoidFerries.HasValue;

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
        [AWSProperty(Sensitive = true)]
        public bool? AvoidTolls { get; set; }

        /// <summary>
        /// Checks to see if the AvoidTolls property is set.
        /// </summary>
        internal bool IsSetAvoidTolls() => this.AvoidTolls.HasValue;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// Specifies the truck's dimension specifications including length, height, width, and
        /// unit of measurement. Used to avoid roads that can't support the truck's dimensions.
        /// </para>
        /// </summary>
        public TruckDimensions Dimensions { get; set; }

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null;

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// Specifies the truck's weight specifications including total weight and unit of measurement.
        /// Used to avoid roads that can't support the truck's weight.
        /// </para>
        /// </summary>
        public TruckWeight Weight { get; set; }

        /// <summary>
        /// Checks to see if the Weight property is set.
        /// </summary>
        internal bool IsSetWeight() => this.Weight != null;
    }
}
