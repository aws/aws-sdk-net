/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot1click-projects-2018-05-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT1ClickProjects.Model
{
    /// <summary>
    /// This is the response object from the ListPlacements operation.
    /// </summary>
    public partial class ListPlacementsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PlacementSummary> _placements = new List<PlacementSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used to retrieve the next set of results - will be effectively empty if
        /// there are no further results.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Placements. 
        /// <para>
        /// An object listing the requested placements.
        /// </para>
        /// </summary>
        public List<PlacementSummary> Placements
        {
            get { return this._placements; }
            set { this._placements = value; }
        }

        // Check to see if Placements property is set
        internal bool IsSetPlacements()
        {
            return this._placements != null && this._placements.Count > 0; 
        }

    }
}