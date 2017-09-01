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
 * Do not modify this file. This file is generated from the mobile-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mobile.Model
{
    /// <summary>
    /// Result structure used for requests to list projects in AWS Mobile Hub.
    /// </summary>
    public partial class ListProjectsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProjectSummary> _projects = new List<ProjectSummary>();

        /// <summary>
        /// Gets and sets the property NextToken.
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
        /// Gets and sets the property Projects.
        /// </summary>
        public List<ProjectSummary> Projects
        {
            get { return this._projects; }
            set { this._projects = value; }
        }

        // Check to see if Projects property is set
        internal bool IsSetProjects()
        {
            return this._projects != null && this._projects.Count > 0; 
        }

    }
}