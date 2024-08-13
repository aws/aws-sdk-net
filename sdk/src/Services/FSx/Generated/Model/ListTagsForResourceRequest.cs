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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// Lists tags for Amazon FSx resources.
    /// 
    ///  
    /// <para>
    /// When retrieving all tags, you can optionally specify the <c>MaxResults</c> parameter
    /// to limit the number of tags in a response. If more tags remain, Amazon FSx returns
    /// a <c>NextToken</c> value in the response. In this case, send a later request with
    /// the <c>NextToken</c> request parameter set to the value of <c>NextToken</c> from the
    /// last response.
    /// </para>
    ///  
    /// <para>
    /// This action is used in an iterative process to retrieve a list of your tags. <c>ListTagsForResource</c>
    /// is called first without a <c>NextToken</c>value. Then the action continues to be called
    /// with the <c>NextToken</c> parameter set to the value of the last <c>NextToken</c>
    /// value until a response has no <c>NextToken</c>.
    /// </para>
    ///  
    /// <para>
    /// When using this action, keep the following in mind:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The implementation might return fewer than <c>MaxResults</c> file system descriptions
    /// while still including a <c>NextToken</c> value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The order of tags returned in the response of one <c>ListTagsForResource</c> call
    /// and the order of tags returned across the responses of a multi-call iteration is unspecified.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonFSxRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _resourceARN;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of tags to return in the response (integer). This parameter value must
        /// be greater than 0. The number of items that Amazon FSx returns is the minimum of the
        /// <c>MaxResults</c> parameter specified in the request and the service's internal maximum
        /// number of items per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
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
        /// Opaque pagination token returned from a previous <c>ListTagsForResource</c> operation
        /// (String). If a token present, the action continues the list from where the returning
        /// call left off.
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
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The ARN of the Amazon FSx resource that will have its tags listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=512)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

    }
}