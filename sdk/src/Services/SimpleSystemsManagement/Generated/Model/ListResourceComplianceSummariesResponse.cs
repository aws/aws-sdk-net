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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the ListResourceComplianceSummaries operation.
    /// </summary>
    public partial class ListResourceComplianceSummariesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResourceComplianceSummaryItem> _resourceComplianceSummaryItems = new List<ResourceComplianceSummaryItem>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. Use this token to get the next set
        /// of results.
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
        /// Gets and sets the property ResourceComplianceSummaryItems. 
        /// <para>
        /// A summary count for specified or targeted managed instances. Summary count includes
        /// information about compliant and non-compliant State Manager associations, patch status,
        /// or custom items according to the filter criteria that you specify. 
        /// </para>
        /// </summary>
        public List<ResourceComplianceSummaryItem> ResourceComplianceSummaryItems
        {
            get { return this._resourceComplianceSummaryItems; }
            set { this._resourceComplianceSummaryItems = value; }
        }

        // Check to see if ResourceComplianceSummaryItems property is set
        internal bool IsSetResourceComplianceSummaryItems()
        {
            return this._resourceComplianceSummaryItems != null && this._resourceComplianceSummaryItems.Count > 0; 
        }

    }
}