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
    /// Contains information about a strategy recommendation for a server.
    /// </summary>
    public partial class ServerStrategy
    {
        private bool? _isPreferred;
        private int? _numberOfApplicationComponents;
        private RecommendationSet _recommendation;
        private StrategyRecommendation _status;

        /// <summary>
        /// Gets and sets the property IsPreferred. 
        /// <para>
        ///  Set to true if the recommendation is set as preferred. 
        /// </para>
        /// </summary>
        public bool? IsPreferred
        {
            get { return this._isPreferred; }
            set { this._isPreferred = value; }
        }

        // Check to see if IsPreferred property is set
        internal bool IsSetIsPreferred()
        {
            return this._isPreferred.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfApplicationComponents. 
        /// <para>
        ///  The number of application components with this strategy recommendation running on
        /// the server. 
        /// </para>
        /// </summary>
        public int? NumberOfApplicationComponents
        {
            get { return this._numberOfApplicationComponents; }
            set { this._numberOfApplicationComponents = value; }
        }

        // Check to see if NumberOfApplicationComponents property is set
        internal bool IsSetNumberOfApplicationComponents()
        {
            return this._numberOfApplicationComponents.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        ///  Strategy recommendation for the server. 
        /// </para>
        /// </summary>
        public RecommendationSet Recommendation
        {
            get { return this._recommendation; }
            set { this._recommendation = value; }
        }

        // Check to see if Recommendation property is set
        internal bool IsSetRecommendation()
        {
            return this._recommendation != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The recommendation status of the strategy for the server. 
        /// </para>
        /// </summary>
        public StrategyRecommendation Status
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