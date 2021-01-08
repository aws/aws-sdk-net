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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// This is the response object from the ListAppsLists operation.
    /// </summary>
    public partial class ListAppsListsResponse : AmazonWebServiceResponse
    {
        private List<AppsListDataSummary> _appsLists = new List<AppsListDataSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AppsLists. 
        /// <para>
        /// An array of <code>AppsListDataSummary</code> objects.
        /// </para>
        /// </summary>
        public List<AppsListDataSummary> AppsLists
        {
            get { return this._appsLists; }
            set { this._appsLists = value; }
        }

        // Check to see if AppsLists property is set
        internal bool IsSetAppsLists()
        {
            return this._appsLists != null && this._appsLists.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you specify a value for <code>MaxResults</code> in your list request, and you have
        /// more objects than the maximum, AWS Firewall Manager returns this token in the response.
        /// You can use this token in subsequent requests to retrieve the next batch of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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

    }
}