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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The response object for <code>DescribeFileSystems</code> operation.
    /// </summary>
    public partial class DescribeFileSystemsResponse : AmazonWebServiceResponse
    {
        private List<FileSystem> _fileSystems = new List<FileSystem>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FileSystems. 
        /// <para>
        /// An array of file system descriptions.
        /// </para>
        /// </summary>
        public List<FileSystem> FileSystems
        {
            get { return this._fileSystems; }
            set { this._fileSystems = value; }
        }

        // Check to see if FileSystems property is set
        internal bool IsSetFileSystems()
        {
            return this._fileSystems != null && this._fileSystems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Present if there are more file systems than returned in the response (String). You
        /// can use the <code>NextToken</code> value in the later request to fetch the descriptions.
        /// 
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