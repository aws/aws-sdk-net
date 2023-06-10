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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that describes a recommendation of a target engine.
    /// 
    ///  
    /// <para>
    /// A <i>recommendation</i> is a set of possible Amazon Web Services target engines that
    /// you can choose to migrate your source on-premises database. In this set, Fleet Advisor
    /// suggests a single target engine as the right sized migration destination. To determine
    /// this rightsized migration destination, Fleet Advisor uses the inventory metadata and
    /// metrics from data collector. You can use recommendations before the start of migration
    /// to save costs and reduce risks.
    /// </para>
    ///  
    /// <para>
    /// With recommendations, you can explore different target options and compare metrics,
    /// so you can make an informed decision when you choose the migration target.
    /// </para>
    /// </summary>
    public partial class Recommendation
    {
        private string _createdDate;
        private RecommendationData _data;
        private string _databaseId;
        private string _engineName;
        private bool? _preferred;
        private RecommendationSettings _settings;
        private string _status;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date when Fleet Advisor created the target engine recommendation.
        /// </para>
        /// </summary>
        public string CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate != null;
        }

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The recommendation of a target engine for the specified source database.
        /// </para>
        /// </summary>
        public RecommendationData Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseId. 
        /// <para>
        /// The identifier of the source database for which Fleet Advisor provided this recommendation.
        /// </para>
        /// </summary>
        public string DatabaseId
        {
            get { return this._databaseId; }
            set { this._databaseId = value; }
        }

        // Check to see if DatabaseId property is set
        internal bool IsSetDatabaseId()
        {
            return this._databaseId != null;
        }

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The name of the target engine. Valid values include <code>"rds-aurora-mysql"</code>,
        /// <code>"rds-aurora-postgresql"</code>, <code>"rds-mysql"</code>, <code>"rds-oracle"</code>,
        /// <code>"rds-sql-server"</code>, and <code>"rds-postgresql"</code>.
        /// </para>
        /// </summary>
        public string EngineName
        {
            get { return this._engineName; }
            set { this._engineName = value; }
        }

        // Check to see if EngineName property is set
        internal bool IsSetEngineName()
        {
            return this._engineName != null;
        }

        /// <summary>
        /// Gets and sets the property Preferred. 
        /// <para>
        /// Indicates that this target is the rightsized migration destination.
        /// </para>
        /// </summary>
        public bool Preferred
        {
            get { return this._preferred.GetValueOrDefault(); }
            set { this._preferred = value; }
        }

        // Check to see if Preferred property is set
        internal bool IsSetPreferred()
        {
            return this._preferred.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// The settings in JSON format for the preferred target engine parameters. These parameters
        /// include capacity, resource utilization, and the usage type (production, development,
        /// or testing).
        /// </para>
        /// </summary>
        public RecommendationSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the target engine recommendation. Valid values include <code>"alternate"</code>,
        /// <code>"in-progress"</code>, <code>"not-viable"</code>, and <code>"recommended"</code>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}