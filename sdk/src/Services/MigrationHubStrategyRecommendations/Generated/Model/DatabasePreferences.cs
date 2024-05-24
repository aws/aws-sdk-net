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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
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
namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Preferences on managing your databases on AWS.
    /// </summary>
    public partial class DatabasePreferences
    {
        private DatabaseManagementPreference _databaseManagementPreference;
        private DatabaseMigrationPreference _databaseMigrationPreference;

        /// <summary>
        /// Gets and sets the property DatabaseManagementPreference. 
        /// <para>
        ///  Specifies whether you're interested in self-managed databases or databases managed
        /// by AWS. 
        /// </para>
        /// </summary>
        public DatabaseManagementPreference DatabaseManagementPreference
        {
            get { return this._databaseManagementPreference; }
            set { this._databaseManagementPreference = value; }
        }

        // Check to see if DatabaseManagementPreference property is set
        internal bool IsSetDatabaseManagementPreference()
        {
            return this._databaseManagementPreference != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseMigrationPreference. 
        /// <para>
        ///  Specifies your preferred migration path. 
        /// </para>
        /// </summary>
        public DatabaseMigrationPreference DatabaseMigrationPreference
        {
            get { return this._databaseMigrationPreference; }
            set { this._databaseMigrationPreference = value; }
        }

        // Check to see if DatabaseMigrationPreference property is set
        internal bool IsSetDatabaseMigrationPreference()
        {
            return this._databaseMigrationPreference != null;
        }

    }
}