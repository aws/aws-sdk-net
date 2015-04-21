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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeWorkspaceDirectories operation.
    /// Retrieves information about the AWS Directory Service directories in the region that
    /// are registered with Amazon WorkSpaces and are available to your account.
    /// 
    ///  
    /// <para>
    /// This operation supports pagination with the use of the <code>NextToken</code> request
    /// and response parameters. If more results are available, the <code>NextToken</code>
    /// response member contains a token that you pass in the next call to this operation
    /// to retrieve the next set of items.
    /// </para>
    /// </summary>
    public partial class DescribeWorkspaceDirectoriesRequest : AmazonWorkSpacesRequest
    {
        private List<string> _directoryIds = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DirectoryIds. 
        /// <para>
        /// An array of strings that contains the directory identifiers to retrieve information
        /// for. If this member is null, all directories are retrieved.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>NextToken</code> value from a previous call to this operation. Pass null
        /// if this is the first call.
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