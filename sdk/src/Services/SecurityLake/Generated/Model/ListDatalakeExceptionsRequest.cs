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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the ListDatalakeExceptions operation.
    /// List the Amazon Security Lake exceptions that you can use to find the source of problems
    /// and fix them.
    /// </summary>
    public partial class ListDatalakeExceptionsRequest : AmazonSecurityLakeRequest
    {
        private int? _maxFailures;
        private string _nextToken;
        private List<string> _regionSet = new List<string>();

        /// <summary>
        /// Gets and sets the property MaxFailures. 
        /// <para>
        /// List the maximum number of failures in Security Lake.
        /// </para>
        /// </summary>
        public int MaxFailures
        {
            get { return this._maxFailures.GetValueOrDefault(); }
            set { this._maxFailures = value; }
        }

        // Check to see if MaxFailures property is set
        internal bool IsSetMaxFailures()
        {
            return this._maxFailures.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// List if there are more results available. if nextToken is returned, You can make the
        /// call again using the returned token to retrieve the next page
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
        /// Gets and sets the property RegionSet. 
        /// <para>
        /// List the regions from which exceptions are retrieved.
        /// </para>
        /// </summary>
        public List<string> RegionSet
        {
            get { return this._regionSet; }
            set { this._regionSet = value; }
        }

        // Check to see if RegionSet property is set
        internal bool IsSetRegionSet()
        {
            return this._regionSet != null && this._regionSet.Count > 0; 
        }

    }
}