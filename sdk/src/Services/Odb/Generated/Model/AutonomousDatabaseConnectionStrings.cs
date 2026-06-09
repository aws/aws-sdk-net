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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// The connection strings used to connect to an Autonomous Database.
    /// </summary>
    public partial class AutonomousDatabaseConnectionStrings
    {
        private Dictionary<string, string> _allConnectionStrings = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _dedicated;
        private string _high;
        private string _low;
        private string _medium;
        private List<DatabaseConnectionStringProfile> _profiles = AWSConfigs.InitializeCollections ? new List<DatabaseConnectionStringProfile>() : null;

        /// <summary>
        /// Gets and sets the property AllConnectionStrings. 
        /// <para>
        /// The list of all connection strings that you can use to connect to the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AllConnectionStrings
        {
            get { return this._allConnectionStrings; }
            set { this._allConnectionStrings = value; }
        }

        // Check to see if AllConnectionStrings property is set
        internal bool IsSetAllConnectionStrings()
        {
            return this._allConnectionStrings != null && (this._allConnectionStrings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Dedicated. 
        /// <para>
        /// The connection string for connecting to the Autonomous Database with a dedicated service.
        /// </para>
        /// </summary>
        public string Dedicated
        {
            get { return this._dedicated; }
            set { this._dedicated = value; }
        }

        // Check to see if Dedicated property is set
        internal bool IsSetDedicated()
        {
            return this._dedicated != null;
        }

        /// <summary>
        /// Gets and sets the property High. 
        /// <para>
        /// The connection string for the high-priority database service.
        /// </para>
        /// </summary>
        public string High
        {
            get { return this._high; }
            set { this._high = value; }
        }

        // Check to see if High property is set
        internal bool IsSetHigh()
        {
            return this._high != null;
        }

        /// <summary>
        /// Gets and sets the property Low. 
        /// <para>
        /// The connection string for the low-priority database service.
        /// </para>
        /// </summary>
        public string Low
        {
            get { return this._low; }
            set { this._low = value; }
        }

        // Check to see if Low property is set
        internal bool IsSetLow()
        {
            return this._low != null;
        }

        /// <summary>
        /// Gets and sets the property Medium. 
        /// <para>
        /// The connection string for the medium-priority database service.
        /// </para>
        /// </summary>
        public string Medium
        {
            get { return this._medium; }
            set { this._medium = value; }
        }

        // Check to see if Medium property is set
        internal bool IsSetMedium()
        {
            return this._medium != null;
        }

        /// <summary>
        /// Gets and sets the property Profiles. 
        /// <para>
        /// The list of connection string profiles for the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DatabaseConnectionStringProfile> Profiles
        {
            get { return this._profiles; }
            set { this._profiles = value; }
        }

        // Check to see if Profiles property is set
        internal bool IsSetProfiles()
        {
            return this._profiles != null && (this._profiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}