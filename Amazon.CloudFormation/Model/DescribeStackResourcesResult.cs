/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> The output for a DescribeStackResources action. </para>
    /// </summary>
    public class DescribeStackResourcesResult  
    {
        
        private List<StackResource> stackResources = new List<StackResource>();

        /// <summary>
        /// A list of <c>StackResource</c> structures.
        ///  
        /// </summary>
        public List<StackResource> StackResources
        {
            get { return this.stackResources; }
            set { this.stackResources = value; }
        }
        /// <summary>
        /// Adds elements to the StackResources collection
        /// </summary>
        /// <param name="stackResources">The values to add to the StackResources collection </param>
        /// <returns>this instance</returns>
        public DescribeStackResourcesResult WithStackResources(params StackResource[] stackResources)
        {
            foreach (StackResource element in stackResources)
            {
                this.stackResources.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the StackResources collection
        /// </summary>
        /// <param name="stackResources">The values to add to the StackResources collection </param>
        /// <returns>this instance</returns>
        public DescribeStackResourcesResult WithStackResources(IEnumerable<StackResource> stackResources)
        {
            foreach (StackResource element in stackResources)
            {
                this.stackResources.Add(element);
            }

            return this;
        }

        // Check to see if StackResources property is set
        internal bool IsSetStackResources()
        {
            return this.stackResources.Count > 0;       
        }
    }
}
