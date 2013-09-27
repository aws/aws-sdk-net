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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeStacks operation.
    /// <para>Requests a description of one or more stacks.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DescribeStacks"/>
    public class DescribeStacksRequest : AmazonWebServiceRequest
    {
        private List<string> stackIds = new List<string>();

        /// <summary>
        /// An array of stack IDs that specify the stacks to be described. If you omit this parameter, <c>DescribeStacks</c> returns a description of
        /// every stack.
        ///  
        /// </summary>
        public List<string> StackIds
        {
            get { return this.stackIds; }
            set { this.stackIds = value; }
        }
        /// <summary>
        /// Adds elements to the StackIds collection
        /// </summary>
        /// <param name="stackIds">The values to add to the StackIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeStacksRequest WithStackIds(params string[] stackIds)
        {
            foreach (string element in stackIds)
            {
                this.stackIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the StackIds collection
        /// </summary>
        /// <param name="stackIds">The values to add to the StackIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeStacksRequest WithStackIds(IEnumerable<string> stackIds)
        {
            foreach (string element in stackIds)
            {
                this.stackIds.Add(element);
            }

            return this;
        }

        // Check to see if StackIds property is set
        internal bool IsSetStackIds()
        {
            return this.stackIds.Count > 0;
        }
    }
}
    
