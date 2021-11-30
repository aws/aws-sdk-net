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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// This is the response object from the ListExperiments operation.
    /// </summary>
    public partial class ListExperimentsResponse : AmazonWebServiceResponse
    {
        private List<Experiment> _experiments = new List<Experiment>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Experiments. 
        /// <para>
        /// An array of structures that contain the configuration details of the experiments in
        /// the specified project.
        /// </para>
        /// </summary>
        public List<Experiment> Experiments
        {
            get { return this._experiments; }
            set { this._experiments = value; }
        }

        // Check to see if Experiments property is set
        internal bool IsSetExperiments()
        {
            return this._experiments != null && this._experiments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use in a subsequent <code>ListExperiments</code> operation to return
        /// the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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