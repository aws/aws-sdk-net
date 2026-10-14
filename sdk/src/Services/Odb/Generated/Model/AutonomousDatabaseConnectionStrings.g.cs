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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// The connection strings used to connect to an Autonomous Database.
    /// </summary>
    public partial class AutonomousDatabaseConnectionStrings
    {
        /// <summary>
        /// Gets and sets the property AllConnectionStrings. 
        /// <para>
        /// The list of all connection strings that you can use to connect to the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AllConnectionStrings { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AllConnectionStrings property is set.
        /// </summary>
        internal bool IsSetAllConnectionStrings() => this.AllConnectionStrings != null && (this.AllConnectionStrings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Dedicated. 
        /// <para>
        /// The connection string for connecting to the Autonomous Database with a dedicated service.
        /// </para>
        /// </summary>
        public string Dedicated { get; set; }

        /// <summary>
        /// Checks to see if the Dedicated property is set.
        /// </summary>
        internal bool IsSetDedicated() => this.Dedicated != null;

        /// <summary>
        /// Gets and sets the property High. 
        /// <para>
        /// The connection string for the high-priority database service.
        /// </para>
        /// </summary>
        public string High { get; set; }

        /// <summary>
        /// Checks to see if the High property is set.
        /// </summary>
        internal bool IsSetHigh() => this.High != null;

        /// <summary>
        /// Gets and sets the property Low. 
        /// <para>
        /// The connection string for the low-priority database service.
        /// </para>
        /// </summary>
        public string Low { get; set; }

        /// <summary>
        /// Checks to see if the Low property is set.
        /// </summary>
        internal bool IsSetLow() => this.Low != null;

        /// <summary>
        /// Gets and sets the property Medium. 
        /// <para>
        /// The connection string for the medium-priority database service.
        /// </para>
        /// </summary>
        public string Medium { get; set; }

        /// <summary>
        /// Checks to see if the Medium property is set.
        /// </summary>
        internal bool IsSetMedium() => this.Medium != null;

        /// <summary>
        /// Gets and sets the property Profiles. 
        /// <para>
        /// The list of connection string profiles for the Autonomous Database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DatabaseConnectionStringProfile> Profiles { get; set; } = AWSConfigs.InitializeCollections ? new List<DatabaseConnectionStringProfile>() : null;

        /// <summary>
        /// Checks to see if the Profiles property is set.
        /// </summary>
        internal bool IsSetProfiles() => this.Profiles != null && (this.Profiles.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
