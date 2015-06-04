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
    /// Container for the parameters to the DescribeDirectories operation.
    /// Obtains information about the directories that belong to this account.
    /// 
    ///  
    /// <para>
    /// You can retrieve information about specific directories by passing the directory identifiers
    /// in the <i>DirectoryIds</i> parameter. Otherwise, all directories that belong to the
    /// current account are returned.
    /// </para>
    ///  
    /// <para>
    /// This operation supports pagination with the use of the <i>NextToken</i> request and
    /// response parameters. If more results are available, the <i>DescribeDirectoriesResult.NextToken</i>
    /// member contains a token that you pass in the next call to <a>DescribeDirectories</a>
    /// to retrieve the next set of items.
    /// </para>
    ///  
    /// <para>
    /// You can also specify a maximum number of return results with the <i>Limit</i> parameter.
    /// </para>
    /// </summary>
    public partial class DescribeDirectoriesRequest : AmazonDirectoryServiceRequest
    {
        private List<string> _directoryIds = new List<string>();
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DirectoryIds. 
        /// <para>
        /// A list of identifiers of the directories to obtain the information for. If this member
        /// is null, all directories that belong to the current account are returned.
        /// </para>
        ///  
        /// <para>
        /// An empty list results in an <code>InvalidParameterException</code> being thrown.
        /// </para>
        /// </summary>
        public List<string> DirectoryIds
        {
            get { return this._directoryIds; }
            set { this._directoryIds = value; }
        }

        // Check to see if DirectoryIds property is set
        internal bool IsSetDirectoryIds()
        {
            return this._directoryIds != null && this._directoryIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items to return. If this value is zero, the maximum number of
        /// items is specified by the limitations of the operation.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <i>DescribeDirectoriesResult.NextToken</i> value from a previous call to <a>DescribeDirectories</a>.
        /// Pass null if this is the first call.
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

    }
}