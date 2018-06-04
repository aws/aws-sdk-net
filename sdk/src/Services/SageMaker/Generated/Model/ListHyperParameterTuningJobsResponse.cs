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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the ListHyperParameterTuningJobs operation.
    /// </summary>
    public partial class ListHyperParameterTuningJobsResponse : AmazonWebServiceResponse
    {
        private List<HyperParameterTuningJobSummary> _hyperParameterTuningJobSummaries = new List<HyperParameterTuningJobSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobSummaries. 
        /// <para>
        /// A list of objects that describe the tuning jobs that the <code>ListHyperParameterTuningJobs</code>
        /// request returned.
        /// </para>
        /// </summary>
        public List<HyperParameterTuningJobSummary> HyperParameterTuningJobSummaries
        {
            get { return this._hyperParameterTuningJobSummaries; }
            set { this._hyperParameterTuningJobSummaries = value; }
        }

        // Check to see if HyperParameterTuningJobSummaries property is set
        internal bool IsSetHyperParameterTuningJobSummaries()
        {
            return this._hyperParameterTuningJobSummaries != null && this._hyperParameterTuningJobSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the result of this <code>ListHyperParameterTuningJobs</code> request was truncated,
        /// the response includes a <code>NextToken</code>. To retrieve the next set of tuning
        /// jobs, use the token in the next request.
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