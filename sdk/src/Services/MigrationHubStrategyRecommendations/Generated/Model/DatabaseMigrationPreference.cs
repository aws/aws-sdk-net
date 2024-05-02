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
    /// Preferences for migrating a database to AWS.
    /// </summary>
    public partial class DatabaseMigrationPreference
    {
        private Heterogeneous _heterogeneous;
        private Homogeneous _homogeneous;
        private NoDatabaseMigrationPreference _noPreference;

        /// <summary>
        /// Gets and sets the property Heterogeneous. 
        /// <para>
        ///  Indicates whether you are interested in moving from one type of database to another.
        /// For example, from SQL Server to Amazon Aurora MySQL-Compatible Edition. 
        /// </para>
        /// </summary>
        public Heterogeneous Heterogeneous
        {
            get { return this._heterogeneous; }
            set { this._heterogeneous = value; }
        }

        // Check to see if Heterogeneous property is set
        internal bool IsSetHeterogeneous()
        {
            return this._heterogeneous != null;
        }

        /// <summary>
        /// Gets and sets the property Homogeneous. 
        /// <para>
        ///  Indicates whether you are interested in moving to the same type of database into
        /// AWS. For example, from SQL Server in your environment to SQL Server on AWS. 
        /// </para>
        /// </summary>
        public Homogeneous Homogeneous
        {
            get { return this._homogeneous; }
            set { this._homogeneous = value; }
        }

        // Check to see if Homogeneous property is set
        internal bool IsSetHomogeneous()
        {
            return this._homogeneous != null;
        }

        /// <summary>
        /// Gets and sets the property NoPreference. 
        /// <para>
        ///  Indicated that you do not prefer heterogeneous or homogeneous. 
        /// </para>
        /// </summary>
        public NoDatabaseMigrationPreference NoPreference
        {
            get { return this._noPreference; }
            set { this._noPreference = value; }
        }

        // Check to see if NoPreference property is set
        internal bool IsSetNoPreference()
        {
            return this._noPreference != null;
        }

    }
}