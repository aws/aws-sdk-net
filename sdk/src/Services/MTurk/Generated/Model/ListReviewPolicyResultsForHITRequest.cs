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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the ListReviewPolicyResultsForHIT operation.
    /// The <c>ListReviewPolicyResultsForHIT</c> operation retrieves the computed results
    /// and the actions taken in the course of executing your Review Policies for a given
    /// HIT. For information about how to specify Review Policies when you call CreateHIT,
    /// see Review Policies. The ListReviewPolicyResultsForHIT operation can return results
    /// for both Assignment-level and HIT-level review results.
    /// </summary>
    public partial class ListReviewPolicyResultsForHITRequest : AmazonMTurkRequest
    {
        private string _hitId;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _policyLevels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _retrieveActions;
        private bool? _retrieveResults;

        /// <summary>
        /// Gets and sets the property HITId. 
        /// <para>
        /// The unique identifier of the HIT to retrieve review results for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string HITId
        {
            get { return this._hitId; }
            set { this._hitId = value; }
        }

        // Check to see if HITId property is set
        internal bool IsSetHITId()
        {
            return this._hitId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Limit the number of results returned.
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
        /// Pagination token
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property PolicyLevels. 
        /// <para>
        ///  The Policy Level(s) to retrieve review results for - HIT or Assignment. If omitted,
        /// the default behavior is to retrieve all data for both policy levels. For a list of
        /// all the described policies, see Review Policies. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PolicyLevels
        {
            get { return this._policyLevels; }
            set { this._policyLevels = value; }
        }

        // Check to see if PolicyLevels property is set
        internal bool IsSetPolicyLevels()
        {
            return this._policyLevels != null && (this._policyLevels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RetrieveActions. 
        /// <para>
        ///  Specify if the operation should retrieve a list of the actions taken executing the
        /// Review Policies and their outcomes. 
        /// </para>
        /// </summary>
        public bool? RetrieveActions
        {
            get { return this._retrieveActions; }
            set { this._retrieveActions = value; }
        }

        // Check to see if RetrieveActions property is set
        internal bool IsSetRetrieveActions()
        {
            return this._retrieveActions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetrieveResults. 
        /// <para>
        ///  Specify if the operation should retrieve a list of the results computed by the Review
        /// Policies. 
        /// </para>
        /// </summary>
        public bool? RetrieveResults
        {
            get { return this._retrieveResults; }
            set { this._retrieveResults = value; }
        }

        // Check to see if RetrieveResults property is set
        internal bool IsSetRetrieveResults()
        {
            return this._retrieveResults.HasValue; 
        }

    }
}