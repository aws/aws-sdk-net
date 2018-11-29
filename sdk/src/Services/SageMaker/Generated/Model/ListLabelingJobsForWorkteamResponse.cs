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
    /// This is the response object from the ListLabelingJobsForWorkteam operation.
    /// </summary>
    public partial class ListLabelingJobsForWorkteamResponse : AmazonWebServiceResponse
    {
        private List<LabelingJobForWorkteamSummary> _labelingJobSummaryList = new List<LabelingJobForWorkteamSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LabelingJobSummaryList. 
        /// <para>
        /// An array of <code>LabelingJobSummary</code> objects, each describing a labeling job.
        /// </para>
        /// </summary>
        public List<LabelingJobForWorkteamSummary> LabelingJobSummaryList
        {
            get { return this._labelingJobSummaryList; }
            set { this._labelingJobSummaryList = value; }
        }

        // Check to see if LabelingJobSummaryList property is set
        internal bool IsSetLabelingJobSummaryList()
        {
            return this._labelingJobSummaryList != null && this._labelingJobSummaryList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, Amazon SageMaker returns this token. To retrieve the
        /// next set of labeling jobs, use it in the subsequent request.
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