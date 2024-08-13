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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
        private string _engine;
        private string _engineEdition;
        private string _engineVersion;
        private int? _osArchitecture;
        private string _servicePack;
        private string _supportLevel;
        private string _tooltip;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine of a database in a Fleet Advisor collector inventory, for example
        /// <c>Microsoft SQL Server</c>.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineEdition. 
        /// <para>
        /// The database engine edition of a database in a Fleet Advisor collector inventory,
        /// for example <c>Express</c>.
        /// </para>
        /// </summary>
        public string EngineEdition
        {
            get { return this._engineEdition; }
            set { this._engineEdition = value; }
        }

        // Check to see if EngineEdition property is set
        internal bool IsSetEngineEdition()
        {
            return this._engineEdition != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The database engine version of a database in a Fleet Advisor collector inventory,
        /// for example <c>2019</c>.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OsArchitecture. 
        /// <para>
        /// The operating system architecture of the database.
        /// </para>
        /// </summary>
        public int? OsArchitecture
        {
            get { return this._osArchitecture; }
            set { this._osArchitecture = value; }
        }

        // Check to see if OsArchitecture property is set
        internal bool IsSetOsArchitecture()
        {
            return this._osArchitecture.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServicePack. 
        /// <para>
        /// The service pack level of the database.
        /// </para>
        /// </summary>
        public string ServicePack
        {
            get { return this._servicePack; }
            set { this._servicePack = value; }
        }

        // Check to see if ServicePack property is set
        internal bool IsSetServicePack()
        {
            return this._servicePack != null;
        }

        /// <summary>
        /// Gets and sets the property SupportLevel. 
        /// <para>
        /// The support level of the database, for example <c>Mainstream support</c>.
        /// </para>
        /// </summary>
        public string SupportLevel
        {
            get { return this._supportLevel; }
            set { this._supportLevel = value; }
        }

        // Check to see if SupportLevel property is set
        internal bool IsSetSupportLevel()
        {
            return this._supportLevel != null;
        }

        /// <summary>
        /// Gets and sets the property Tooltip. 
        /// <para>
        /// Information about the database engine software, for example <c>Mainstream support
        /// ends on November 14th, 2024</c>.
        /// </para>
        /// </summary>
        public string Tooltip
        {
            get { return this._tooltip; }
            set { this._tooltip = value; }
        }

        // Check to see if Tooltip property is set
        internal bool IsSetTooltip()
        {
            return this._tooltip != null;
        }

    }
}