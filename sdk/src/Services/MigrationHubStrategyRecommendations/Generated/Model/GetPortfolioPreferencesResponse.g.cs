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

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// This is the response object from the GetPortfolioPreferences operation.
    /// </summary>
    public partial class GetPortfolioPreferencesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationMode. 
        /// <para>
        /// The classification for application component types.
        /// </para>
        /// </summary>
        public ApplicationMode ApplicationMode { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationMode property is set.
        /// </summary>
        internal bool IsSetApplicationMode() => this.ApplicationMode != null;

        /// <summary>
        /// Gets and sets the property ApplicationPreferences. 
        /// <para>
        ///  The transformation preferences for non-database applications. 
        /// </para>
        /// </summary>
        public ApplicationPreferences ApplicationPreferences { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationPreferences property is set.
        /// </summary>
        internal bool IsSetApplicationPreferences() => this.ApplicationPreferences != null;

        /// <summary>
        /// Gets and sets the property DatabasePreferences. 
        /// <para>
        ///  The transformation preferences for database applications. 
        /// </para>
        /// </summary>
        public DatabasePreferences DatabasePreferences { get; set; }

        /// <summary>
        /// Checks to see if the DatabasePreferences property is set.
        /// </summary>
        internal bool IsSetDatabasePreferences() => this.DatabasePreferences != null;

        /// <summary>
        /// Gets and sets the property PrioritizeBusinessGoals. 
        /// <para>
        ///  The rank of business goals based on priority. 
        /// </para>
        /// </summary>
        public PrioritizeBusinessGoals PrioritizeBusinessGoals { get; set; }

        /// <summary>
        /// Checks to see if the PrioritizeBusinessGoals property is set.
        /// </summary>
        internal bool IsSetPrioritizeBusinessGoals() => this.PrioritizeBusinessGoals != null;
    }
}
