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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// This is the response object from the ListApplicationStates operation.
    /// </summary>
    public partial class ListApplicationStatesResponse : AmazonWebServiceResponse
    {
        private List<ApplicationState> _applicationStateList = new List<ApplicationState>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ApplicationStateList. 
        /// <para>
        /// A list of Applications that exist in Application Discovery Service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<ApplicationState> ApplicationStateList
        {
            get { return this._applicationStateList; }
            set { this._applicationStateList = value; }
        }

        // Check to see if ApplicationStateList property is set
        internal bool IsSetApplicationStateList()
        {
            return this._applicationStateList != null && this._applicationStateList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If a <code>NextToken</code> was returned by a previous call, there are more results
        /// available. To retrieve the next page of results, make the call again using the returned
        /// token in <code>NextToken</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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