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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// This is the response object from the ListDeploymentJobs operation.
    /// </summary>
    public partial class ListDeploymentJobsResponse : AmazonWebServiceResponse
    {
        private List<DeploymentJob> _deploymentJobs = new List<DeploymentJob>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DeploymentJobs. 
        /// <para>
        /// A list of deployment jobs that meet the criteria of the request.
        /// </para>
        /// </summary>
        public List<DeploymentJob> DeploymentJobs
        {
            get { return this._deploymentJobs; }
            set { this._deploymentJobs = value; }
        }

        // Check to see if DeploymentJobs property is set
        internal bool IsSetDeploymentJobs()
        {
            return this._deploymentJobs != null && this._deploymentJobs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value to include in a future <code>ListDeploymentJobs</code>
        /// request. When the results of a <code>ListDeploymentJobs</code> request exceed <code>maxResults</code>,
        /// this value can be used to retrieve the next page of results. This value is <code>null</code>
        /// when there are no more results to return. 
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