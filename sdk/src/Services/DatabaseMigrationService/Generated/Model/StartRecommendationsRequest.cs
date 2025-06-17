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
    /// Container for the parameters to the StartRecommendations operation.
    /// <important> 
    /// <para>
    ///  End of support notice: On May 20, 2026, Amazon Web Services will end support for
    /// Amazon Web Services DMS Fleet Advisor;. After May 20, 2026, you will no longer be
    /// able to access the Amazon Web Services DMS Fleet Advisor; console or Amazon Web Services
    /// DMS Fleet Advisor; resources. For more information, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/dms_fleet.advisor-end-of-support.html">Amazon
    /// Web Services DMS Fleet Advisor end of support</a>. 
    /// </para>
    ///  </important> 
    /// <para>
    /// Starts the analysis of your source database to provide recommendations of target engines.
    /// </para>
    ///  
    /// <para>
    /// You can create recommendations for multiple source databases using <a href="https://docs.aws.amazon.com/dms/latest/APIReference/API_BatchStartRecommendations.html">BatchStartRecommendations</a>.
    /// </para>
    /// </summary>
    public partial class StartRecommendationsRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _databaseId;
        private RecommendationSettings _settings;

        /// <summary>
        /// Gets and sets the property DatabaseId. 
        /// <para>
        /// The identifier of the source database to analyze and provide recommendations for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Settings. 
        /// <para>
        /// The settings in JSON format that Fleet Advisor uses to determine target engine recommendations.
        /// These parameters include target instance sizing and availability and durability settings.
        /// For target instance sizing, Fleet Advisor supports the following two options: total
        /// capacity and resource utilization. For availability and durability, Fleet Advisor
        /// supports the following two options: production (Multi-AZ deployments) and Dev/Test
        /// (Single-AZ deployments).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}