/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Returns the summary information for stacks whose status matches the specified StackStatusFilter. Summary information for stacks that
    /// have been deleted is kept for 90 days after the stack is deleted. If no StackStatusFilter is specified, summary information for all stacks
    /// is returned (including existing stacks and stacks that have been deleted).</para>
    /// </summary>
    public partial class ListStacksRequest : AmazonCloudFormationRequest
    {
        private string nextToken;
        private List<string> stackStatusFilter = new List<string>();


        /// <summary>
        /// String that identifies the start of the next list of stacks, if there is one. Default: There is no default value.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }

        /// <summary>
        /// Stack status to use as a filter. Specify one or more stack status codes to list only stacks with the specified status codes. For a complete
        /// list of stack status codes, see the <c>StackStatus</c> parameter of the <a>Stack</a> data type.
        ///  
        /// </summary>
        public List<string> StackStatusFilter
        {
            get { return this.stackStatusFilter; }
            set { this.stackStatusFilter = value; }
        }

        // Check to see if StackStatusFilter property is set
        internal bool IsSetStackStatusFilter()
        {
            return this.stackStatusFilter.Count > 0;
        }

    }
}
    
