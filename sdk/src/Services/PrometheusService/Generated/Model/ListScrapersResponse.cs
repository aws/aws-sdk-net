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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Represents the output of a <c>ListScrapers</c> operation.
    /// </summary>
    public partial class ListScrapersResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ScraperSummary> _scrapers = AWSConfigs.InitializeCollections ? new List<ScraperSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token indicating that there are more results to retrieve. You can use this token
        /// as part of your next <c>ListScrapers</c> operation to retrieve those results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Scrapers. 
        /// <para>
        /// A list of <c>ScraperSummary</c> structures giving information about scrapers in the
        /// account that match the filters provided.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ScraperSummary> Scrapers
        {
            get { return this._scrapers; }
            set { this._scrapers = value; }
        }

        // Check to see if Scrapers property is set
        internal bool IsSetScrapers()
        {
            return this._scrapers != null && (this._scrapers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}