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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the ListMembers operation.
    /// Lists details about all member accounts for the current GuardDuty master account.
    /// </summary>
    public partial class ListMembersRequest : AmazonGuardDutyRequest
    {
        private string _detectorId;
        private int? _maxResults;
        private string _nextToken;
        private string _onlyAssociated;

        /// <summary>
        /// Gets and sets the property DetectorId. The unique ID of the detector of the GuardDuty
        /// account whose members you want to list.
        /// </summary>
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. You can use this parameter to indicate the
        /// maximum number of items you want in the response. The default value is 1. The maximum
        /// value is 50.
        /// </summary>
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
        /// Gets and sets the property NextToken. You can use this parameter when paginating results.
        /// Set the value of this parameter to null on your first call to the ListMembers action.
        /// Subsequent calls to the action fill nextToken in the request with the value of NextToken
        /// from the previous response to continue listing data.
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
        /// Gets and sets the property OnlyAssociated. Specifies what member accounts the response
        /// is to include based on their relationship status with the master account. The default
        /// value is TRUE. If onlyAssociated is set to TRUE, the response will include member
        /// accounts whose relationship status with the master is set to Enabled, Disabled. If
        /// onlyAssociated is set to FALSE, the response will include all existing member accounts.
        /// </summary>
        public string OnlyAssociated
        {
            get { return this._onlyAssociated; }
            set { this._onlyAssociated = value; }
        }

        // Check to see if OnlyAssociated property is set
        internal bool IsSetOnlyAssociated()
        {
            return this._onlyAssociated != null;
        }

    }
}