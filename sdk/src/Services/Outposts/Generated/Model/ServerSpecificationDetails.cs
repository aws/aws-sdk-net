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
    /// The physical specification details for a server in a quote option.
    /// </summary>
    public partial class ServerSpecificationDetails
    {
        private List<EC2Capacity> _ec2Capacities = AWSConfigs.InitializeCollections ? new List<EC2Capacity>() : null;
        private RackUnitHeight _rackUnitHeight;
        private float? _serverDepthInches;
        private float? _serverHeightInches;
        private float? _serverPowerDrawKva;
        private float? _serverWeightLbs;
        private float? _serverWidthInches;

        /// <summary>
        /// Gets and sets the property EC2Capacities. 
        /// <para>
        /// The Amazon EC2 capacities for the server.
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
        /// Gets and sets the property ServerDepthInches. 
        /// <para>
        /// The depth of the server in inches.
        /// </para>
        /// </summary>
        public float? ServerDepthInches
        {
            get { return this._serverDepthInches; }
            set { this._serverDepthInches = value; }
        }

        // Check to see if ServerDepthInches property is set
        internal bool IsSetServerDepthInches()
        {
            return this._serverDepthInches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerHeightInches. 
        /// <para>
        /// The height of the server in inches.
        /// </para>
        /// </summary>
        public float? ServerHeightInches
        {
            get { return this._serverHeightInches; }
            set { this._serverHeightInches = value; }
        }

        // Check to see if ServerHeightInches property is set
        internal bool IsSetServerHeightInches()
        {
            return this._serverHeightInches.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerPowerDrawKva. 
        /// <para>
        /// The maximum power draw of the server in kVA.
        /// </para>
        /// </summary>
        public float? ServerPowerDrawKva
        {
            get { return this._serverPowerDrawKva; }
            set { this._serverPowerDrawKva = value; }
        }

        // Check to see if ServerPowerDrawKva property is set
        internal bool IsSetServerPowerDrawKva()
        {
            return this._serverPowerDrawKva.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerWeightLbs. 
        /// <para>
        /// The weight of the server in pounds.
        /// </para>
        /// </summary>
        public float? ServerWeightLbs
        {
            get { return this._serverWeightLbs; }
            set { this._serverWeightLbs = value; }
        }

        // Check to see if ServerWeightLbs property is set
        internal bool IsSetServerWeightLbs()
        {
            return this._serverWeightLbs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerWidthInches. 
        /// <para>
        /// The width of the server in inches.
        /// </para>
        /// </summary>
        public float? ServerWidthInches
        {
            get { return this._serverWidthInches; }
            set { this._serverWidthInches = value; }
        }

        // Check to see if ServerWidthInches property is set
        internal bool IsSetServerWidthInches()
        {
            return this._serverWidthInches.HasValue; 
        }

    }
}