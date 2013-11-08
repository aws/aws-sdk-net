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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para> The <c>AutoScalingInstancesType</c> data type. </para>
    /// </summary>
    public partial class DescribeAutoScalingInstancesResult : AmazonWebServiceResponse
    {
        
        private List<AutoScalingInstanceDetails> autoScalingInstances = new List<AutoScalingInstanceDetails>();
        private string nextToken;

        /// <summary>
        /// A list of Auto Scaling instances.
        ///  
        /// </summary>
        public List<AutoScalingInstanceDetails> AutoScalingInstances
        {
            get { return this.autoScalingInstances; }
            set { this.autoScalingInstances = value; }
        }

        // Check to see if AutoScalingInstances property is set
        internal bool IsSetAutoScalingInstances()
        {
            return this.autoScalingInstances.Count > 0;
        }

        /// <summary>
        /// A string that marks the start of the next batch of returned results.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
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
    }
}
