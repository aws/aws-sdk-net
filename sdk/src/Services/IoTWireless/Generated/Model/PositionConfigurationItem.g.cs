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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// The wrapper for a position configuration.
    /// </summary>
    public partial class PositionConfigurationItem
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The position data destination that describes the AWS IoT rule that processes the device's
        /// position data for use by AWS IoT Core for LoRaWAN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// Resource identifier for the position configuration.
        /// </para>
        /// </summary>
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Resource type of the resource for the position configuration.
        /// </para>
        /// </summary>
        public PositionResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Solvers. 
        /// <para>
        /// The details of the positioning solver object used to compute the location.
        /// </para>
        /// </summary>
        public PositionSolverDetails Solvers { get; set; }

        /// <summary>
        /// Checks to see if the Solvers property is set.
        /// </summary>
        internal bool IsSetSolvers() => this.Solvers != null;
    }
}
