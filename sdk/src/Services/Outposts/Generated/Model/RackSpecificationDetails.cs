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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
        private List<EC2Capacity> _ec2Capacities = AWSConfigs.InitializeCollections ? new List<EC2Capacity>() : null;
        private float? _rackDepthInches;
        private float? _rackHeightInches;
        private string _rackId;
        private float? _rackPowerDrawKva;
        private RackUnitHeight _rackUnitHeight;
        private QuoteRackUseType _rackUse;
        private float? _rackWeightLbs;
        private float? _rackWidthInches;

        /// <summary>
        /// Gets and sets the property EC2Capacities. 
        /// <para>
        /// The Amazon EC2 capacities for the rack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EC2Capacity> EC2Capacities
        {
            get { return this._ec2Capacities; }
            set { this._ec2Capacities = value; }
        }

        // Check to see if EC2Capacities property is set
        internal bool IsSetEC2Capacities()
        {
            return this._ec2Capacities != null && (this._ec2Capacities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RackDepthInches. 
        /// <para>
        /// The depth of the rack in inches.
        /// </para>
        /// </summary>
        public float? RackDepthInches
        {
            get { return this._rackDepthInches; }
            set { this._rackDepthInches = value; }
        }

        // Check to see if RackDepthInches property is set
        internal bool IsSetRackDepthInches()
        {
            return this._rackDepthInches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RackHeightInches. 
        /// <para>
        /// The height of the rack in inches.
        /// </para>
        /// </summary>
        public float? RackHeightInches
        {
            get { return this._rackHeightInches; }
            set { this._rackHeightInches = value; }
        }

        // Check to see if RackHeightInches property is set
        internal bool IsSetRackHeightInches()
        {
            return this._rackHeightInches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RackId. 
        /// <para>
        /// The ID of the rack.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=20)]
        public string RackId
        {
            get { return this._rackId; }
            set { this._rackId = value; }
        }

        // Check to see if RackId property is set
        internal bool IsSetRackId()
        {
            return this._rackId != null;
        }

        /// <summary>
        /// Gets and sets the property RackPowerDrawKva. 
        /// <para>
        /// The maximum power draw of the rack in kVA.
        /// </para>
        /// </summary>
        public float? RackPowerDrawKva
        {
            get { return this._rackPowerDrawKva; }
            set { this._rackPowerDrawKva = value; }
        }

        // Check to see if RackPowerDrawKva property is set
        internal bool IsSetRackPowerDrawKva()
        {
            return this._rackPowerDrawKva.HasValue; 
        }

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
        public RackUnitHeight RackUnitHeight
        {
            get { return this._rackUnitHeight; }
            set { this._rackUnitHeight = value; }
        }

        // Check to see if RackUnitHeight property is set
        internal bool IsSetRackUnitHeight()
        {
            return this._rackUnitHeight != null;
        }

        /// <summary>
        /// Gets and sets the property RackUse. 
        /// <para>
        /// The use of the rack. Valid values are <c>COMPUTE</c> and <c>NETWORKING</c>.
        /// </para>
        /// </summary>
        public QuoteRackUseType RackUse
        {
            get { return this._rackUse; }
            set { this._rackUse = value; }
        }

        // Check to see if RackUse property is set
        internal bool IsSetRackUse()
        {
            return this._rackUse != null;
        }

        /// <summary>
        /// Gets and sets the property RackWeightLbs. 
        /// <para>
        /// The weight of the rack in pounds.
        /// </para>
        /// </summary>
        public float? RackWeightLbs
        {
            get { return this._rackWeightLbs; }
            set { this._rackWeightLbs = value; }
        }

        // Check to see if RackWeightLbs property is set
        internal bool IsSetRackWeightLbs()
        {
            return this._rackWeightLbs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RackWidthInches. 
        /// <para>
        /// The width of the rack in inches.
        /// </para>
        /// </summary>
        public float? RackWidthInches
        {
            get { return this._rackWidthInches; }
            set { this._rackWidthInches = value; }
        }

        // Check to see if RackWidthInches property is set
        internal bool IsSetRackWidthInches()
        {
            return this._rackWidthInches.HasValue; 
        }

    }
}