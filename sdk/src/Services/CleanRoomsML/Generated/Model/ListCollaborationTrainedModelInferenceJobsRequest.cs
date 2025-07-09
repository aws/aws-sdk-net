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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Container for the parameters to the ListCollaborationTrainedModelInferenceJobs operation.
    /// Returns a list of trained model inference jobs in a specified collaboration.
    /// </summary>
    public partial class ListCollaborationTrainedModelInferenceJobsRequest : AmazonCleanRoomsMLRequest
    {
        private string _collaborationIdentifier;
        private int? _maxResults;
        private string _nextToken;
        private string _trainedModelArn;
        private string _trainedModelVersionIdentifier;

        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// The collaboration ID of the collaboration that contains the trained model inference
        /// jobs that you are interested in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string CollaborationIdentifier
        {
            get { return this._collaborationIdentifier; }
            set { this._collaborationIdentifier = value; }
        }

        // Check to see if CollaborationIdentifier property is set
        internal bool IsSetCollaborationIdentifier()
        {
            return this._collaborationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum size of the results that is returned per call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token value retrieved from a previous call to access the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10240)]
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
        /// Gets and sets the property TrainedModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trained model that was used to create the trained
        /// model inference jobs that you are interested in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string TrainedModelArn
        {
            get { return this._trainedModelArn; }
            set { this._trainedModelArn = value; }
        }

        // Check to see if TrainedModelArn property is set
        internal bool IsSetTrainedModelArn()
        {
            return this._trainedModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrainedModelVersionIdentifier. 
        /// <para>
        /// The version identifier of the trained model to filter inference jobs by. When specified,
        /// only inference jobs that used this specific version of the trained model are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string TrainedModelVersionIdentifier
        {
            get { return this._trainedModelVersionIdentifier; }
            set { this._trainedModelVersionIdentifier = value; }
        }

        // Check to see if TrainedModelVersionIdentifier property is set
        internal bool IsSetTrainedModelVersionIdentifier()
        {
            return this._trainedModelVersionIdentifier != null;
        }

    }
}