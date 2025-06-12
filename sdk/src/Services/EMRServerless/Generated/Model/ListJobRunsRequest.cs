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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// Container for the parameters to the ListJobRuns operation.
    /// Lists job runs based on a set of parameters.
    /// </summary>
    public partial class ListJobRunsRequest : AmazonEMRServerlessRequest
    {
        private string _applicationId;
        private DateTime? _createdAtAfter;
        private DateTime? _createdAtBefore;
        private int? _maxResults;
        private JobRunMode _mode;
        private string _nextToken;
        private List<string> _states = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application for which to list the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAtAfter. 
        /// <para>
        /// The lower bound of the option to filter by creation date and time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAtAfter
        {
            get { return this._createdAtAfter; }
            set { this._createdAtAfter = value; }
        }

        // Check to see if CreatedAtAfter property is set
        internal bool IsSetCreatedAtAfter()
        {
            return this._createdAtAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAtBefore. 
        /// <para>
        /// The upper bound of the option to filter by creation date and time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAtBefore
        {
            get { return this._createdAtBefore; }
            set { this._createdAtBefore = value; }
        }

        // Check to see if CreatedAtBefore property is set
        internal bool IsSetCreatedAtBefore()
        {
            return this._createdAtBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of job runs that can be listed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the job runs to list.
        /// </para>
        /// </summary>
        public JobRunMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of job run results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property States. 
        /// <para>
        /// An optional filter for job run states. Note that if this filter contains multiple
        /// states, the resulting list will be grouped by the state.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=8)]
        public List<string> States
        {
            get { return this._states; }
            set { this._states = value; }
        }

        // Check to see if States property is set
        internal bool IsSetStates()
        {
            return this._states != null && (this._states.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}