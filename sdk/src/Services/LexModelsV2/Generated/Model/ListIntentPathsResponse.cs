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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// This is the response object from the ListIntentPaths operation.
    /// </summary>
    public partial class ListIntentPathsResponse : AmazonWebServiceResponse
    {
        private List<AnalyticsIntentNodeSummary> _nodeSummaries = AWSConfigs.InitializeCollections ? new List<AnalyticsIntentNodeSummary>() : null;

        /// <summary>
        /// Gets and sets the property NodeSummaries. 
        /// <para>
        /// A list of objects, each of which contains information about a node in the intent path
        /// for which you requested metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<AnalyticsIntentNodeSummary> NodeSummaries
        {
            get { return this._nodeSummaries; }
            set { this._nodeSummaries = value; }
        }

        // Check to see if NodeSummaries property is set
        internal bool IsSetNodeSummaries()
        {
            return this._nodeSummaries != null && (this._nodeSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}