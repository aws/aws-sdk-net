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
    /// The physical specification details for a rack in a quote option.
    /// </summary>
    public partial class RackSpecificationDetails
    {
        /// <summary>
        /// Gets and sets the property EC2Capacities. 
        /// <para>
        /// The Amazon EC2 capacities for the rack.
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
        /// Gets and sets the property RackDepthInches. 
        /// <para>
        /// The depth of the rack in inches.
        /// </para>
        /// </summary>
        public float? RackDepthInches { get; set; }

        /// <summary>
        /// Checks to see if the RackDepthInches property is set.
        /// </summary>
        internal bool IsSetRackDepthInches() => this.RackDepthInches.HasValue;

        /// <summary>
        /// Gets and sets the property RackHeightInches. 
        /// <para>
        /// The height of the rack in inches.
        /// </para>
        /// </summary>
        public float? RackHeightInches { get; set; }

        /// <summary>
        /// Checks to see if the RackHeightInches property is set.
        /// </summary>
        internal bool IsSetRackHeightInches() => this.RackHeightInches.HasValue;

        /// <summary>
        /// Gets and sets the property RackId. 
        /// <para>
        /// The ID of the rack.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 20)]
        public string RackId { get; set; }

        /// <summary>
        /// Checks to see if the RackId property is set.
        /// </summary>
        internal bool IsSetRackId() => this.RackId != null;

        /// <summary>
        /// Gets and sets the property RackPowerDrawKva. 
        /// <para>
        /// The maximum power draw of the rack in kVA.
        /// </para>
        /// </summary>
        public float? RackPowerDrawKva { get; set; }

        /// <summary>
        /// Checks to see if the RackPowerDrawKva property is set.
        /// </summary>
        internal bool IsSetRackPowerDrawKva() => this.RackPowerDrawKva.HasValue;

        /// <summary>
        /// Gets and sets the property RackUnitHeight. 
        /// <para>
        /// The rack unit height.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HEIGHT_42U</c> - 42 rack units.
        /// </para>
        ///  </li> <li> 
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
        /// Gets and sets the property RackUse. 
        /// <para>
        /// The use of the rack. Valid values are <c>COMPUTE</c> and <c>NETWORKING</c>.
        /// </para>
        /// </summary>
        public QuoteRackUseType RackUse { get; set; }

        /// <summary>
        /// Checks to see if the RackUse property is set.
        /// </summary>
        internal bool IsSetRackUse() => this.RackUse != null;

        /// <summary>
        /// Gets and sets the property RackWeightLbs. 
        /// <para>
        /// The weight of the rack in pounds.
        /// </para>
        /// </summary>
        public float? RackWeightLbs { get; set; }

        /// <summary>
        /// Checks to see if the RackWeightLbs property is set.
        /// </summary>
        internal bool IsSetRackWeightLbs() => this.RackWeightLbs.HasValue;

        /// <summary>
        /// Gets and sets the property RackWidthInches. 
        /// <para>
        /// The width of the rack in inches.
        /// </para>
        /// </summary>
        public float? RackWidthInches { get; set; }

        /// <summary>
        /// Checks to see if the RackWidthInches property is set.
        /// </summary>
        internal bool IsSetRackWidthInches() => this.RackWidthInches.HasValue;
    }
}
