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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimSpaceWeaver.Model
{
    /// <summary>
    /// Container for the parameters to the ListApps operation.
    /// Lists all custom apps or service apps for the given simulation and domain.
    /// </summary>
    public partial class ListAppsRequest : AmazonSimSpaceWeaverRequest
    {
        private string _domain;
        private int? _maxResults;
        private string _nextToken;
        private string _simulation;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain that you want to list apps for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of apps to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If SimSpace Weaver returns <code>nextToken</code>, there are more results available.
        /// The value of <code>nextToken</code> is a unique pagination token for each page. To
        /// retrieve the next page, call the operation again using the returned token. Keep all
        /// other arguments unchanged. If no results remain, <code>nextToken</code> is set to
        /// <code>null</code>. Each pagination token expires after 24 hours. If you provide a
        /// token that isn't valid, you receive an <i>HTTP 400 ValidationException</i> error.
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
        /// Gets and sets the property Simulation. 
        /// <para>
        /// The name of the simulation that you want to list apps for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Simulation
        {
            get { return this._simulation; }
            set { this._simulation = value; }
        }

        // Check to see if Simulation property is set
        internal bool IsSetSimulation()
        {
            return this._simulation != null;
        }

    }
}