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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the response to a <c>DescribeStacks</c> request.</para>
    /// </summary>
    public class DescribeStacksResult
    {
        
        private List<Stack> stacks = new List<Stack>();

        /// <summary>
        /// An array of <c>Stack</c> objects that describe the stacks.
        ///  
        /// </summary>
        public List<Stack> Stacks
        {
            get { return this.stacks; }
            set { this.stacks = value; }
        }
        /// <summary>
        /// Adds elements to the Stacks collection
        /// </summary>
        /// <param name="stacks">The values to add to the Stacks collection </param>
        /// <returns>this instance</returns>
        public DescribeStacksResult WithStacks(params Stack[] stacks)
        {
            foreach (Stack element in stacks)
            {
                this.stacks.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Stacks collection
        /// </summary>
        /// <param name="stacks">The values to add to the Stacks collection </param>
        /// <returns>this instance</returns>
        public DescribeStacksResult WithStacks(IEnumerable<Stack> stacks)
        {
            foreach (Stack element in stacks)
            {
                this.stacks.Add(element);
            }

            return this;
        }

        // Check to see if Stacks property is set
        internal bool IsSetStacks()
        {
            return this.stacks.Count > 0;
        }
    }
}
