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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// The physical specification details for a server in a quote option.
    /// </summary>
    public partial class ServerSpecificationDetails
    {
        /// <summary>
        /// Gets and sets the property EC2Capacities. 
        /// <para>
        /// The Amazon EC2 capacities for the server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EC2Capacity> EC2Capacities { get; set; } = AWSConfigs.InitializeCollections ? new List<EC2Capacity>() : null;

        /// <summary>
        /// Checks to see if the EC2Capacities property is set.
        /// </summary>
        internal bool IsSetEC2Capacities() => this.EC2Capacities != null && (this.EC2Capacities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RackUnitHeight. 
        /// <para>
        /// The rack unit height of the server.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HEIGHT_2U</c> - 2 rack units.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HEIGHT_1U</c> - 1 rack unit.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RackUnitHeight RackUnitHeight { get; set; }

        /// <summary>
        /// Checks to see if the RackUnitHeight property is set.
        /// </summary>
        internal bool IsSetRackUnitHeight() => this.RackUnitHeight != null;

        /// <summary>
        /// Gets and sets the property ServerDepthInches. 
        /// <para>
        /// The depth of the server in inches.
        /// </para>
        /// </summary>
        public float? ServerDepthInches { get; set; }

        /// <summary>
        /// Checks to see if the ServerDepthInches property is set.
        /// </summary>
        internal bool IsSetServerDepthInches() => this.ServerDepthInches.HasValue;

        /// <summary>
        /// Gets and sets the property ServerHeightInches. 
        /// <para>
        /// The height of the server in inches.
        /// </para>
        /// </summary>
        public float? ServerHeightInches { get; set; }

        /// <summary>
        /// Checks to see if the ServerHeightInches property is set.
        /// </summary>
        internal bool IsSetServerHeightInches() => this.ServerHeightInches.HasValue;

        /// <summary>
        /// Gets and sets the property ServerPowerDrawKva. 
        /// <para>
        /// The maximum power draw of the server in kVA.
        /// </para>
        /// </summary>
        public float? ServerPowerDrawKva { get; set; }

        /// <summary>
        /// Checks to see if the ServerPowerDrawKva property is set.
        /// </summary>
        internal bool IsSetServerPowerDrawKva() => this.ServerPowerDrawKva.HasValue;

        /// <summary>
        /// Gets and sets the property ServerWeightLbs. 
        /// <para>
        /// The weight of the server in pounds.
        /// </para>
        /// </summary>
        public float? ServerWeightLbs { get; set; }

        /// <summary>
        /// Checks to see if the ServerWeightLbs property is set.
        /// </summary>
        internal bool IsSetServerWeightLbs() => this.ServerWeightLbs.HasValue;

        /// <summary>
        /// Gets and sets the property ServerWidthInches. 
        /// <para>
        /// The width of the server in inches.
        /// </para>
        /// </summary>
        public float? ServerWidthInches { get; set; }

        /// <summary>
        /// Checks to see if the ServerWidthInches property is set.
        /// </summary>
        internal bool IsSetServerWidthInches() => this.ServerWidthInches.HasValue;
    }
}
