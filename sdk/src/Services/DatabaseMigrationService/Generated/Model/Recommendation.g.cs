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
        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date when Fleet Advisor created the target engine recommendation.
        /// </para>
        /// </summary>
        public string CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate != null;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The recommendation of a target engine for the specified source database.
        /// </para>
        /// </summary>
        public RecommendationData Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;

        /// <summary>
        /// Gets and sets the property DatabaseId. 
        /// <para>
        /// The identifier of the source database for which Fleet Advisor provided this recommendation.
        /// </para>
        /// </summary>
        public string DatabaseId { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseId property is set.
        /// </summary>
        internal bool IsSetDatabaseId() => this.DatabaseId != null;

        /// <summary>
        /// Gets and sets the property EngineName. 
        /// <para>
        /// The name of the target engine. Valid values include <c>"rds-aurora-mysql"</c>, <c>"rds-aurora-postgresql"</c>,
        /// <c>"rds-mysql"</c>, <c>"rds-oracle"</c>, <c>"rds-sql-server"</c>, and <c>"rds-postgresql"</c>.
        /// </para>
        /// </summary>
        public string EngineName { get; set; }

        /// <summary>
        /// Checks to see if the EngineName property is set.
        /// </summary>
        internal bool IsSetEngineName() => this.EngineName != null;

        /// <summary>
        /// Gets and sets the property Preferred. 
        /// <para>
        /// Indicates that this target is the rightsized migration destination.
        /// </para>
        /// </summary>
        public bool? Preferred { get; set; }

        /// <summary>
        /// Checks to see if the Preferred property is set.
        /// </summary>
        internal bool IsSetPreferred() => this.Preferred.HasValue;

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// The settings in JSON format for the preferred target engine parameters. These parameters
        /// include capacity, resource utilization, and the usage type (production, development,
        /// or testing).
        /// </para>
        /// </summary>
        public RecommendationSettings Settings { get; set; }

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the target engine recommendation. Valid values include <c>"alternate"</c>,
        /// <c>"in-progress"</c>, <c>"not-viable"</c>, and <c>"recommended"</c>.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
