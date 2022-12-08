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

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// This is the response object from the GetPortfolioPreferences operation.
    /// </summary>
    public partial class GetPortfolioPreferencesResponse : AmazonWebServiceResponse
    {
        private ApplicationMode _applicationMode;
        private ApplicationPreferences _applicationPreferences;
        private DatabasePreferences _databasePreferences;
        private PrioritizeBusinessGoals _prioritizeBusinessGoals;

        /// <summary>
        /// Gets and sets the property ApplicationMode. 
        /// <para>
        /// The classification for application component types.
        /// </para>
        /// </summary>
        public ApplicationMode ApplicationMode
        {
            get { return this._applicationMode; }
            set { this._applicationMode = value; }
        }

        // Check to see if ApplicationMode property is set
        internal bool IsSetApplicationMode()
        {
            return this._applicationMode != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationPreferences. 
        /// <para>
        ///  The transformation preferences for non-database applications. 
        /// </para>
        /// </summary>
        public ApplicationPreferences ApplicationPreferences
        {
            get { return this._applicationPreferences; }
            set { this._applicationPreferences = value; }
        }

        // Check to see if ApplicationPreferences property is set
        internal bool IsSetApplicationPreferences()
        {
            return this._applicationPreferences != null;
        }

        /// <summary>
        /// Gets and sets the property DatabasePreferences. 
        /// <para>
        ///  The transformation preferences for database applications. 
        /// </para>
        /// </summary>
        public DatabasePreferences DatabasePreferences
        {
            get { return this._databasePreferences; }
            set { this._databasePreferences = value; }
        }

        // Check to see if DatabasePreferences property is set
        internal bool IsSetDatabasePreferences()
        {
            return this._databasePreferences != null;
        }

        /// <summary>
        /// Gets and sets the property PrioritizeBusinessGoals. 
        /// <para>
        ///  The rank of business goals based on priority. 
        /// </para>
        /// </summary>
        public PrioritizeBusinessGoals PrioritizeBusinessGoals
        {
            get { return this._prioritizeBusinessGoals; }
            set { this._prioritizeBusinessGoals = value; }
        }

        // Check to see if PrioritizeBusinessGoals property is set
        internal bool IsSetPrioritizeBusinessGoals()
        {
            return this._prioritizeBusinessGoals != null;
        }

    }
}