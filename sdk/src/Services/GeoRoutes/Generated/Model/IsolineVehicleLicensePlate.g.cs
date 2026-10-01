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
    /// License plate information used in regions where road access or routing restrictions
    /// are based on license plate numbers.
    /// </summary>
    public partial class IsolineVehicleLicensePlate
    {
        /// <summary>
        /// Gets and sets the property LastCharacter. 
        /// <para>
        /// The last character of the vehicle's license plate. Used to determine road access restrictions
        /// in regions with license plate-based traffic management systems.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public string LastCharacter { get; set; }

        /// <summary>
        /// Checks to see if the LastCharacter property is set.
        /// </summary>
        internal bool IsSetLastCharacter() => this.LastCharacter != null;
    }
}
