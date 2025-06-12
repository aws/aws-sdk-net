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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// This is the response object from the GetFindingRecommendation operation.
    /// </summary>
    public partial class GetFindingRecommendationResponse : AmazonWebServiceResponse
    {
        private DateTime? _completedAt;
        private RecommendationError _error;
        private string _nextToken;
        private RecommendationType _recommendationType;
        private List<RecommendedStep> _recommendedSteps = AWSConfigs.InitializeCollections ? new List<RecommendedStep>() : null;
        private string _resourceArn;
        private DateTime? _startedAt;
        private Status _status;

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The time at which the retrieval of the finding recommendation was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt
        {
            get { return this._completedAt; }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Detailed information about the reason that the retrieval of a recommendation for the
        /// finding failed.
        /// </para>
        /// </summary>
        public RecommendationError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token used for pagination of results returned.
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

        /// <summary>
        /// Gets and sets the property RecommendationType. 
        /// <para>
        /// The type of recommendation for the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationType RecommendationType
        {
            get { return this._recommendationType; }
            set { this._recommendationType = value; }
        }

        // Check to see if RecommendationType property is set
        internal bool IsSetRecommendationType()
        {
            return this._recommendationType != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedSteps. 
        /// <para>
        /// A group of recommended steps for the finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendedStep> RecommendedSteps
        {
            get { return this._recommendedSteps; }
            set { this._recommendedSteps = value; }
        }

        // Check to see if RecommendedSteps property is set
        internal bool IsSetRecommendedSteps()
        {
            return this._recommendedSteps != null && (this._recommendedSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time at which the retrieval of the finding recommendation was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the retrieval of the finding recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}