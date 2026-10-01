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
    /// Contains information about a strategy recommendation for a server.
    /// </summary>
    public partial class ServerStrategy
    {
        /// <summary>
        /// Gets and sets the property IsPreferred. 
        /// <para>
        ///  Set to true if the recommendation is set as preferred. 
        /// </para>
        /// </summary>
        public bool? IsPreferred { get; set; }

        /// <summary>
        /// Checks to see if the IsPreferred property is set.
        /// </summary>
        internal bool IsSetIsPreferred() => this.IsPreferred.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfApplicationComponents. 
        /// <para>
        ///  The number of application components with this strategy recommendation running on
        /// the server. 
        /// </para>
        /// </summary>
        public int? NumberOfApplicationComponents { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfApplicationComponents property is set.
        /// </summary>
        internal bool IsSetNumberOfApplicationComponents() => this.NumberOfApplicationComponents.HasValue;

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        ///  Strategy recommendation for the server. 
        /// </para>
        /// </summary>
        public RecommendationSet Recommendation { get; set; }

        /// <summary>
        /// Checks to see if the Recommendation property is set.
        /// </summary>
        internal bool IsSetRecommendation() => this.Recommendation != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The recommendation status of the strategy for the server. 
        /// </para>
        /// </summary>
        public StrategyRecommendation Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
