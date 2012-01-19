/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Returns the summary information for stacks whose status matches the specified StackStatusFilter. Summary information for stacks that
    /// have been deleted is kept for 90 days after the stack is deleted. If no StackStatusFilter is specified, summary information for all stacks
    /// is returned (including existing stacks and stacks that have been deleted). </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.ListStacks"/>
    public class ListStacksRequest : AmazonWebServiceRequest
    {
        private string nextToken;
        private List<string> stackStatusFilter = new List<string>();
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        public ListStacksRequest WithNextToken(string nextToken)
        {
            this.nextToken = nextToken;
            return this;
        }
            

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;       
        }
        public List<string> StackStatusFilter
        {
            get { return this.stackStatusFilter; }
            set { this.stackStatusFilter = value; }
        }
        /// <summary>
        /// Adds elements to the StackStatusFilter collection
        /// </summary>
        /// <param name="stackStatusFilter">The values to add to the StackStatusFilter collection </param>
        /// <returns>this instance</returns>
        public ListStacksRequest WithStackStatusFilter(params string[] stackStatusFilter)
        {
            foreach (string element in stackStatusFilter)
            {
                this.stackStatusFilter.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the StackStatusFilter collection
        /// </summary>
        /// <param name="stackStatusFilter">The values to add to the StackStatusFilter collection </param>
        /// <returns>this instance</returns>
        public ListStacksRequest WithStackStatusFilter(IEnumerable<string> stackStatusFilter)
        {
            foreach (string element in stackStatusFilter)
            {
                this.stackStatusFilter.Add(element);
            }

            return this;
        }

        // Check to see if StackStatusFilter property is set
        internal bool IsSetStackStatusFilter()
        {
            return this.stackStatusFilter.Count > 0;       
        }
    }
}
    
