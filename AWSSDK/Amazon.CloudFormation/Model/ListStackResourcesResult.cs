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
    /// <para>The output for a ListStackResources action.</para>
    /// </summary>
    public class ListStackResourcesResult
    {
        
        private List<StackResourceSummary> stackResourceSummaries = new List<StackResourceSummary>();
        private string nextToken;

        /// <summary>
        /// A list of <c>StackResourceSummary</c> structures.
        ///  
        /// </summary>
        public List<StackResourceSummary> StackResourceSummaries
        {
            get { return this.stackResourceSummaries; }
            set { this.stackResourceSummaries = value; }
        }
        /// <summary>
        /// Adds elements to the StackResourceSummaries collection
        /// </summary>
        /// <param name="stackResourceSummaries">The values to add to the StackResourceSummaries collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListStackResourcesResult WithStackResourceSummaries(params StackResourceSummary[] stackResourceSummaries)
        {
            foreach (StackResourceSummary element in stackResourceSummaries)
            {
                this.stackResourceSummaries.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the StackResourceSummaries collection
        /// </summary>
        /// <param name="stackResourceSummaries">The values to add to the StackResourceSummaries collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListStackResourcesResult WithStackResourceSummaries(IEnumerable<StackResourceSummary> stackResourceSummaries)
        {
            foreach (StackResourceSummary element in stackResourceSummaries)
            {
                this.stackResourceSummaries.Add(element);
            }

            return this;
        }

        // Check to see if StackResourceSummaries property is set
        internal bool IsSetStackResourceSummaries()
        {
            return this.stackResourceSummaries.Count > 0;
        }

        /// <summary>
        /// String that identifies the start of the next list of events, if there is one.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListStackResourcesResult WithNextToken(string nextToken)
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
