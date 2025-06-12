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

#pragma warning disable CS0612,CS0618,CS1570
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
        private List<string> _providerTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _repositoryNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _states = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Type _type;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that are returned per call. The default is 100.
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
        /// If <c>nextToken</c> is returned, there are more results available. The value of <c>nextToken</c>
        /// is a unique pagination token for each page. Make the call again using the returned
        /// token to retrieve the next page. Keep all other arguments unchanged.
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
        /// result. For example, <c>providerTypes=[GitHub]</c> lists code reviews from GitHub.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._providerTypes != null && (this._providerTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RepositoryNames. 
        /// <para>
        /// List of repository names for filtering that needs to be applied before displaying
        /// the result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._repositoryNames != null && (this._repositoryNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property States. 
        /// <para>
        /// List of states for filtering that needs to be applied before displaying the result.
        /// For example, <c>states=[Pending]</c> lists code reviews in the Pending state.
        /// </para>
        ///  
        /// <para>
        /// The valid code review states are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Completed</c>: The code review is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Pending</c>: The code review started and has not completed or failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c>: The code review failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deleting</c>: The code review is being deleted.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._states != null && (this._states.Count > 0 || !AWSConfigs.InitializeCollections); 
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