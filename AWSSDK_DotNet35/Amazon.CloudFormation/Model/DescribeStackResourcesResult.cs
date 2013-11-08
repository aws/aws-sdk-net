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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// <para>The output for a DescribeStackResources action.</para>
    /// </summary>
    public partial class DescribeStackResourcesResult : AmazonWebServiceResponse
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

        // Check to see if StackResources property is set
        internal bool IsSetStackResources()
        {
            return this.stackResources.Count > 0;
        }
    }
}
