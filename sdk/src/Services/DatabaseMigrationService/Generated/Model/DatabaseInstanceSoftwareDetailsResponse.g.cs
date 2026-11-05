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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Describes an inventory database instance for a Fleet Advisor collector.
    /// </summary>
    public partial class DatabaseInstanceSoftwareDetailsResponse
    {
        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine of a database in a Fleet Advisor collector inventory, for example
        /// <c>Microsoft SQL Server</c>.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineEdition. 
        /// <para>
        /// The database engine edition of a database in a Fleet Advisor collector inventory,
        /// for example <c>Express</c>.
        /// </para>
        /// </summary>
        public string EngineEdition { get; set; }

        /// <summary>
        /// Checks to see if the EngineEdition property is set.
        /// </summary>
        internal bool IsSetEngineEdition() => this.EngineEdition != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The database engine version of a database in a Fleet Advisor collector inventory,
        /// for example <c>2019</c>.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property OsArchitecture. 
        /// <para>
        /// The operating system architecture of the database.
        /// </para>
        /// </summary>
        public int? OsArchitecture { get; set; }

        /// <summary>
        /// Checks to see if the OsArchitecture property is set.
        /// </summary>
        internal bool IsSetOsArchitecture() => this.OsArchitecture.HasValue;

        /// <summary>
        /// Gets and sets the property ServicePack. 
        /// <para>
        /// The service pack level of the database.
        /// </para>
        /// </summary>
        public string ServicePack { get; set; }

        /// <summary>
        /// Checks to see if the ServicePack property is set.
        /// </summary>
        internal bool IsSetServicePack() => this.ServicePack != null;

        /// <summary>
        /// Gets and sets the property SupportLevel. 
        /// <para>
        /// The support level of the database, for example <c>Mainstream support</c>.
        /// </para>
        /// </summary>
        public string SupportLevel { get; set; }

        /// <summary>
        /// Checks to see if the SupportLevel property is set.
        /// </summary>
        internal bool IsSetSupportLevel() => this.SupportLevel != null;

        /// <summary>
        /// Gets and sets the property Tooltip. 
        /// <para>
        /// Information about the database engine software, for example <c>Mainstream support
        /// ends on November 14th, 2024</c>.
        /// </para>
        /// </summary>
        public string Tooltip { get; set; }

        /// <summary>
        /// Checks to see if the Tooltip property is set.
        /// </summary>
        internal bool IsSetTooltip() => this.Tooltip != null;
    }
}
