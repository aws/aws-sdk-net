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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAutoScalingGroups operation.
    /// <para> Returns a full description of each Auto Scaling group in the given list. This includes all Amazon EC2 instances that are members of
    /// the group. If a list of names is not provided, the service returns the full details of all Auto Scaling groups. </para> <para> This action
    /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
    /// token as the <c>NextToken</c> parameter. </para>
    /// </summary>
    public partial class DescribeAutoScalingGroupsRequest : AmazonAutoScalingRequest
    {
        private List<string> autoScalingGroupNames = new List<string>();
        private string nextToken;
        private int? maxRecords;


        /// <summary>
        /// A list of Auto Scaling group names.
        ///  
        /// </summary>
        public List<string> AutoScalingGroupNames
        {
            get { return this.autoScalingGroupNames; }
            set { this.autoScalingGroupNames = value; }
        }

        // Check to see if AutoScalingGroupNames property is set
        internal bool IsSetAutoScalingGroupNames()
        {
            return this.autoScalingGroupNames.Count > 0;
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

        /// <summary>
        /// The maximum number of records to return.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 50</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;
        }

    }
}
    
