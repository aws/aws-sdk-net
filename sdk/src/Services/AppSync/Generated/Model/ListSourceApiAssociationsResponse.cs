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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// This is the response object from the ListSourceApiAssociations operation.
    /// </summary>
    public partial class ListSourceApiAssociationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SourceApiAssociationSummary> _sourceApiAssociationSummaries = new List<SourceApiAssociationSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which you
        /// can use to return the next set of items in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
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
        /// Gets and sets the property SourceApiAssociationSummaries. 
        /// <para>
        /// The <code>SourceApiAssociationSummary</code> object data.
        /// </para>
        /// </summary>
        public List<SourceApiAssociationSummary> SourceApiAssociationSummaries
        {
            get { return this._sourceApiAssociationSummaries; }
            set { this._sourceApiAssociationSummaries = value; }
        }

        // Check to see if SourceApiAssociationSummaries property is set
        internal bool IsSetSourceApiAssociationSummaries()
        {
            return this._sourceApiAssociationSummaries != null && this._sourceApiAssociationSummaries.Count > 0; 
        }

    }
}