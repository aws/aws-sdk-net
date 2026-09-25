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
    /// Contains details about the truck dimensions in the unit of measurement that you specify.
    /// Used to filter out roads that can't support or allow the specified dimensions for
    /// requests that specify <c>TravelMode</c> as <c>Truck</c>.
    /// </summary>
    public partial class TruckDimensions
    {
        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// The height of the truck.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For example, <c>4.5</c>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  For routes calculated with a HERE resource, this value must be between 0 and 50 meters.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0)]
        public double? Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height.HasValue;

        /// <summary>
        /// Gets and sets the property Length. 
        /// <para>
        /// The length of the truck.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For example, <c>15.5</c>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  For routes calculated with a HERE resource, this value must be between 0 and 300
        /// meters. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0)]
        public double? Length { get; set; }

        /// <summary>
        /// Checks to see if the Length property is set.
        /// </summary>
        internal bool IsSetLength() => this.Length.HasValue;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        ///  Specifies the unit of measurement for the truck dimensions.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>Meters</c> 
        /// </para>
        /// </summary>
        public DimensionUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// The width of the truck.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For example, <c>4.5</c>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  For routes calculated with a HERE resource, this value must be between 0 and 50 meters.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0)]
        public double? Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width.HasValue;
    }
}
