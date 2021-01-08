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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// This is the response object from the ListTestGridProjects operation.
    /// </summary>
    public partial class ListTestGridProjectsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TestGridProject> _testGridProjects = new List<TestGridProject>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Used for pagination. Pass into <a>ListTestGridProjects</a> to get more results in
        /// a paginated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024)]
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
        /// Gets and sets the property TestGridProjects. 
        /// <para>
        /// The list of TestGridProjects, based on a <a>ListTestGridProjectsRequest</a>.
        /// </para>
        /// </summary>
        public List<TestGridProject> TestGridProjects
        {
            get { return this._testGridProjects; }
            set { this._testGridProjects = value; }
        }

        // Check to see if TestGridProjects property is set
        internal bool IsSetTestGridProjects()
        {
            return this._testGridProjects != null && this._testGridProjects.Count > 0; 
        }

    }
}