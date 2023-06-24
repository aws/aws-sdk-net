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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Container for the parameters to the ListCodeReviews operation.
    /// Lists all the code reviews that the customer has created in the past 90 days.
    /// </summary>
    public partial class ListCodeReviewsRequest : AmazonCodeGuruReviewerRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _providerTypes = new List<string>();
        private List<string> _repositoryNames = new List<string>();
        private List<string> _states = new List<string>();
        private Type _type;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that are returned per call. The default is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// If <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property ProviderTypes. 
        /// <para>
        /// List of provider types for filtering that needs to be applied before displaying the
        /// result. For example, <code>providerTypes=[GitHub]</code> lists code reviews from GitHub.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<string> ProviderTypes
        {
            get { return this._providerTypes; }
            set { this._providerTypes = value; }
        }

        // Check to see if ProviderTypes property is set
        internal bool IsSetProviderTypes()
        {
            return this._providerTypes != null && this._providerTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RepositoryNames. 
        /// <para>
        /// List of repository names for filtering that needs to be applied before displaying
        /// the result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> RepositoryNames
        {
            get { return this._repositoryNames; }
            set { this._repositoryNames = value; }
        }

        // Check to see if RepositoryNames property is set
        internal bool IsSetRepositoryNames()
        {
            return this._repositoryNames != null && this._repositoryNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property States. 
        /// <para>
        /// List of states for filtering that needs to be applied before displaying the result.
        /// For example, <code>states=[Pending]</code> lists code reviews in the Pending state.
        /// </para>
        ///  
        /// <para>
        /// The valid code review states are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Completed</code>: The code review is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Pending</code>: The code review started and has not completed or failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Failed</code>: The code review failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Deleting</code>: The code review is being deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<string> States
        {
            get { return this._states; }
            set { this._states = value; }
        }

        // Check to see if States property is set
        internal bool IsSetStates()
        {
            return this._states != null && this._states.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of code reviews to list in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}