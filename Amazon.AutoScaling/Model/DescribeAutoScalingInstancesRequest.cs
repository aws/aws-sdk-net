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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAutoScalingInstances operation.
    /// <para> Returns a description of each Auto Scaling instance in the
    /// InstanceIds list. If a list is not provided, the service returns the
    /// full details of all instances up to a maximum of fifty. </para> <para>
    /// This action supports pagination by returning a token if there are more
    /// pages to retrieve. To get the next page, call this action again with
    /// the returned token as the NextToken parameter. </para>
    /// </summary>
    /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeAutoScalingInstances"/>
    public class DescribeAutoScalingInstancesRequest : AmazonWebServiceRequest
    {
        private List<string> instanceIds = new List<string>();
        private int? maxRecords;
        private string nextToken;

        /// <summary>
        /// The list of Auto Scaling instances to describe. If this list is
        /// omitted, all auto scaling instances are described. The list of
        /// requested instances cannot contain more than 50 items. If unknown
        /// instances are requested, they are ignored with no error.
        ///  
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this.instanceIds; }
            set { this.instanceIds = value; }
        }
        /// <summary>
        /// Adds elements to the InstanceIds collection
        /// </summary>
        /// <param name="instanceIds">The values to add to the InstanceIds collection </param>
        /// <returns>this instance</returns>
        public DescribeAutoScalingInstancesRequest WithInstanceIds(params string[] instanceIds)
        {
            foreach (string element in instanceIds)
            {
                this.instanceIds.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the InstanceIds collection
        /// </summary>
        /// <param name="instanceIds">The values to add to the InstanceIds collection </param>
        /// <returns>this instance</returns>
        public DescribeAutoScalingInstancesRequest WithInstanceIds(IEnumerable<string> instanceIds)
        {
            foreach (string element in instanceIds)
            {
                this.instanceIds.Add(element);
            }

            return this;
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this.instanceIds.Count > 0;       
        }

        /// <summary>
        /// The maximum number of Auto Scaling instances to be described with each
        /// call.
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

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        public DescribeAutoScalingInstancesRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;       
        }

        /// <summary>
        /// The token returned by a previous call to indicate that there is more
        /// data available.
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

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        public DescribeAutoScalingInstancesRequest WithNextToken(string nextToken)
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
    
