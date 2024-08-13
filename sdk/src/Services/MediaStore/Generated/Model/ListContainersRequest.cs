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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
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
namespace Amazon.MediaStore.Model
{
    /// <summary>
    /// Container for the parameters to the ListContainers operation.
    /// Lists the properties of all containers in AWS Elemental MediaStore. 
    /// 
    ///  
    /// <para>
    /// You can query to receive all the containers in one response. Or you can include the
    /// <c>MaxResults</c> parameter to receive a limited number of containers in each response.
    /// In this case, the response includes a token. To get the next set of containers, send
    /// the command again, this time with the <c>NextToken</c> parameter (with the returned
    /// token as its value). The next set of responses appears, with a token if there are
    /// still more containers to receive. 
    /// </para>
    ///  
    /// <para>
    /// See also <a>DescribeContainer</a>, which gets the properties of one container. 
    /// </para>
    /// </summary>
    public partial class ListContainersRequest : AmazonMediaStoreRequest
    {
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Enter the maximum number of containers in the response. Use from 1 to 255 characters.
        /// 
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
        /// Only if you used <c>MaxResults</c> in the first command, enter the token (which was
        /// included in the previous response) to obtain the next set of containers. This token
        /// is included in a response only if there actually are more containers to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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

    }
}