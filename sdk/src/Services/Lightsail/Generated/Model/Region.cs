/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the AWS Region.
    /// </summary>
    public partial class Region
    {
        private List<AvailabilityZone> _availabilityZones = new List<AvailabilityZone>();
        private string _continentCode;
        private string _description;
        private string _displayName;
        private RegionName _name;
        private List<AvailabilityZone> _relationalDatabaseAvailabilityZones = new List<AvailabilityZone>();

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones. Follows the format <code>us-east-2a</code> (case-sensitive).
        /// </para>
        /// </summary>
        public List<AvailabilityZone> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ContinentCode. 
        /// <para>
        /// The continent code (e.g., <code>NA</code>, meaning North America).
        /// </para>
        /// </summary>
        public string ContinentCode
        {
            get { return this._continentCode; }
            set { this._continentCode = value; }
        }

        // Check to see if ContinentCode property is set
        internal bool IsSetContinentCode()
        {
            return this._continentCode != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the AWS Region (e.g., <code>This region is recommended to serve
        /// users in the eastern United States and eastern Canada</code>).
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name (e.g., <code>Ohio</code>).
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The region name (e.g., <code>us-east-2</code>).
        /// </para>
        /// </summary>
        public RegionName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseAvailabilityZones. 
        /// <para>
        /// The Availability Zones for databases. Follows the format <code>us-east-2a</code> (case-sensitive).
        /// </para>
        /// </summary>
        public List<AvailabilityZone> RelationalDatabaseAvailabilityZones
        {
            get { return this._relationalDatabaseAvailabilityZones; }
            set { this._relationalDatabaseAvailabilityZones = value; }
        }

        // Check to see if RelationalDatabaseAvailabilityZones property is set
        internal bool IsSetRelationalDatabaseAvailabilityZones()
        {
            return this._relationalDatabaseAvailabilityZones != null && this._relationalDatabaseAvailabilityZones.Count > 0; 
        }

    }
}