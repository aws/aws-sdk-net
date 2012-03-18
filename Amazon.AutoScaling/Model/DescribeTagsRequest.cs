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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTags operation.
    /// 
    /// </summary>
    /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.DescribeTags"/>
    public class DescribeTagsRequest : AmazonWebServiceRequest
    {
        private List<Filter> filters = new List<Filter>();
        private string nextToken;
        private int? maxRecords;
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }
        /// <summary>
        /// Adds elements to the Filters collection
        /// </summary>
        /// <param name="filters">The values to add to the Filters collection </param>
        /// <returns>this instance</returns>
        public DescribeTagsRequest WithFilters(params Filter[] filters)
        {
            foreach (Filter element in filters)
            {
                this.filters.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Filters collection
        /// </summary>
        /// <param name="filters">The values to add to the Filters collection </param>
        /// <returns>this instance</returns>
        public DescribeTagsRequest WithFilters(IEnumerable<Filter> filters)
        {
            foreach (Filter element in filters)
            {
                this.filters.Add(element);
            }

            return this;
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;       
        }
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
        public DescribeTagsRequest WithNextToken(string nextToken)
        {
            this.nextToken = nextToken;
            return this;
        }
            

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;       
        }
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
        public DescribeTagsRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;       
        }
    }
}
    
