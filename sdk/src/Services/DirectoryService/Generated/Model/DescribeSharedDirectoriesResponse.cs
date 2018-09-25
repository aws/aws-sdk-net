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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// This is the response object from the DescribeSharedDirectories operation.
    /// </summary>
    public partial class DescribeSharedDirectoriesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SharedDirectory> _sharedDirectories = new List<SharedDirectory>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If not null, token that indicates that more results are available. Pass this value
        /// for the <code>NextToken</code> parameter in a subsequent call to <a>DescribeSharedDirectories</a>
        /// to retrieve the next set of items.
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
        /// Gets and sets the property SharedDirectories. 
        /// <para>
        /// A list of all shared directories in your account.
        /// </para>
        /// </summary>
        public List<SharedDirectory> SharedDirectories
        {
            get { return this._sharedDirectories; }
            set { this._sharedDirectories = value; }
        }

        // Check to see if SharedDirectories property is set
        internal bool IsSetSharedDirectories()
        {
            return this._sharedDirectories != null && this._sharedDirectories.Count > 0; 
        }

    }
}