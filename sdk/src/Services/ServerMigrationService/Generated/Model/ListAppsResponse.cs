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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// This is the response object from the ListApps operation.
    /// </summary>
    public partial class ListAppsResponse : AmazonWebServiceResponse
    {
        private List<AppSummary> _apps = new List<AppSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Apps. 
        /// <para>
        /// A list of application summaries.
        /// </para>
        /// </summary>
        public List<AppSummary> Apps
        {
            get { return this._apps; }
            set { this._apps = value; }
        }

        // Check to see if Apps property is set
        internal bool IsSetApps()
        {
            return this._apps != null && this._apps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token required to retrieve the next set of results. This value is null when there
        /// are no more results to return.
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

    }
}