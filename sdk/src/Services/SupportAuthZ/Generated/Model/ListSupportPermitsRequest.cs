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
 * Do not modify this file. This file is generated from the supportauthz-2026-06-30.normal.json service model.
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
namespace Amazon.SupportAuthZ.Model
{
    /// <summary>
    /// Container for the parameters to the ListSupportPermits operation.
    /// Lists all support permits in the caller's account. Use pagination to ensure that the
    /// operation returns quickly and successfully.
    /// </summary>
    public partial class ListSupportPermitsRequest : AmazonSupportAuthZRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _supportPermitStatuses = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. Valid range is 1 to 100.
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
        /// The token for the next page of results.
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
        /// Gets and sets the property SupportPermitStatuses. 
        /// <para>
        /// Filters the results by support permit status. Valid values: ACTIVE, INACTIVE, DELETING.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> SupportPermitStatuses
        {
            get { return this._supportPermitStatuses; }
            set { this._supportPermitStatuses = value; }
        }

        // Check to see if SupportPermitStatuses property is set
        internal bool IsSetSupportPermitStatuses()
        {
            return this._supportPermitStatuses != null && (this._supportPermitStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}