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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ListStacks operation.
    /// Returns the summary information for stacks whose status matches the specified StackStatusFilter.
    /// Summary information for stacks that have been deleted is kept for 90 days after the
    /// stack is deleted. If no StackStatusFilter is specified, summary information for all
    /// stacks is returned (including existing stacks and stacks that have been deleted).
    /// </summary>
    public partial class ListStacksRequest : AmazonCloudFormationRequest
    {
        private string _nextToken;
        private List<string> _stackStatusFilter = new List<string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// String that identifies the start of the next list of stacks, if there is one.
        /// </para>
        ///  
        /// <para>
        /// Default: There is no default value.
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
        /// Gets and sets the property StackStatusFilter. 
        /// <para>
        /// Stack status to use as a filter. Specify one or more stack status codes to list only
        /// stacks with the specified status codes. For a complete list of stack status codes,
        /// see the <code>StackStatus</code> parameter of the <a>Stack</a> data type.
        /// </para>
        /// </summary>
        public List<string> StackStatusFilter
        {
            get { return this._stackStatusFilter; }
            set { this._stackStatusFilter = value; }
        }

        // Check to see if StackStatusFilter property is set
        internal bool IsSetStackStatusFilter()
        {
            return this._stackStatusFilter != null && this._stackStatusFilter.Count > 0; 
        }

    }
}