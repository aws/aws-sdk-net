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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// <para>The output for ListStacks action.</para>
    /// </summary>
    public class ListStacksResult
    {
        
        private List<StackSummary> stackSummaries = new List<StackSummary>();
        private string nextToken;

        /// <summary>
        /// A list of <c>StackSummary</c> structures containing information about the specified stacks.
        ///  
        /// </summary>
        public List<StackSummary> StackSummaries
        {
            get { return this.stackSummaries; }
            set { this.stackSummaries = value; }
        }
        /// <summary>
        /// Adds elements to the StackSummaries collection
        /// </summary>
        /// <param name="stackSummaries">The values to add to the StackSummaries collection </param>
        /// <returns>this instance</returns>
        public ListStacksResult WithStackSummaries(params StackSummary[] stackSummaries)
        {
            foreach (StackSummary element in stackSummaries)
            {
                this.stackSummaries.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the StackSummaries collection
        /// </summary>
        /// <param name="stackSummaries">The values to add to the StackSummaries collection </param>
        /// <returns>this instance</returns>
        public ListStacksResult WithStackSummaries(IEnumerable<StackSummary> stackSummaries)
        {
            foreach (StackSummary element in stackSummaries)
            {
                this.stackSummaries.Add(element);
            }

            return this;
        }

        // Check to see if StackSummaries property is set
        internal bool IsSetStackSummaries()
        {
            return this.stackSummaries.Count > 0;
        }

        /// <summary>
        /// String that identifies the start of the next list of stacks, if there is one.
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

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        public ListStacksResult WithNextToken(string nextToken)
        {
            this.nextToken = nextToken;
            return this;
        }
            

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }
    }
}
