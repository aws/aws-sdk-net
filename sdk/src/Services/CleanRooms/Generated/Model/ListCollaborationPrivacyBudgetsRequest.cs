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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the ListCollaborationPrivacyBudgets operation.
    /// Returns an array that summarizes each privacy budget in a specified collaboration.
    /// The summary includes the collaboration ARN, creation time, creating account, and privacy
    /// budget details.
    /// </summary>
    public partial class ListCollaborationPrivacyBudgetsRequest : AmazonCleanRoomsRequest
    {
        private string _collaborationIdentifier;
        private int? _maxResults;
        private string _nextToken;
        private PrivacyBudgetType _privacyBudgetType;

        /// <summary>
        /// Gets and sets the property CollaborationIdentifier. 
        /// <para>
        /// A unique identifier for one of your collaborations.
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
        /// The maximum number of results that are returned for an API request call. The service
        /// chooses a default number if you don't set one. The service might return a `nextToken`
        /// even if the `maxResults` value has not been met.
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
        /// The pagination token that's used to fetch the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10240)]
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
        /// Gets and sets the property PrivacyBudgetType. 
        /// <para>
        /// Specifies the type of the privacy budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivacyBudgetType PrivacyBudgetType
        {
            get { return this._privacyBudgetType; }
            set { this._privacyBudgetType = value; }
        }

        // Check to see if PrivacyBudgetType property is set
        internal bool IsSetPrivacyBudgetType()
        {
            return this._privacyBudgetType != null;
        }

    }
}