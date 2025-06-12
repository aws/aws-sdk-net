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
    /// This is the response object from the GetServerStrategies operation.
    /// </summary>
    public partial class GetServerStrategiesResponse : AmazonWebServiceResponse
    {
        private List<ServerStrategy> _serverStrategies = AWSConfigs.InitializeCollections ? new List<ServerStrategy>() : null;

        /// <summary>
        /// Gets and sets the property ServerStrategies. 
        /// <para>
        ///  A list of strategy recommendations for the server. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServerStrategy> ServerStrategies
        {
            get { return this._serverStrategies; }
            set { this._serverStrategies = value; }
        }

        // Check to see if ServerStrategies property is set
        internal bool IsSetServerStrategies()
        {
            return this._serverStrategies != null && (this._serverStrategies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}