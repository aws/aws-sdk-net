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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// This is the response object from the ListUpdates operation.
    /// </summary>
    public partial class ListUpdatesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _updateIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value returned from a previous paginated request, where <c>maxResults</c>
        /// was used and the results exceeded the value of that parameter. Pagination continues
        /// from the end of the previous results that returned the <c>nextToken</c> value. This
        /// value is null when there are no more results to return.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is used only to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property UpdateIds. 
        /// <para>
        /// A list of all the updates for the specified cluster and Region.
        /// </para>
        /// </summary>
        public List<string> UpdateIds
        {
            get { return this._updateIds; }
            set { this._updateIds = value; }
        }

        // Check to see if UpdateIds property is set
        internal bool IsSetUpdateIds()
        {
            return this._updateIds != null && (this._updateIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}