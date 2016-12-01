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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeStacks operation.
    /// Describes the stack. If a stack name is provided, this operation describes that environment.
    /// If name is not provided, this operation describes all the stacks for the AWS account.
    /// This operation returns a paginated list of results; use the <code>nextToken</code>
    /// to get the next page.
    /// </summary>
    public partial class DescribeStacksRequest : AmazonAppStreamRequest
    {
        private List<string> _names = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// The stack names to describe. Use null to describe all the stacks for the AWS account.
        /// </para>
        /// </summary>
        public List<string> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && this._names.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token to iterate the list. If a name is specified in the request or the request
        /// is for the first page, this value should be null.
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