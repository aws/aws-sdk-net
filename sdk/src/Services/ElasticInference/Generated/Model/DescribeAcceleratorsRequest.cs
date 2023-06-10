/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the elastic-inference-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticInference.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAccelerators operation.
    /// Describes information over a provided set of accelerators belonging to an account.
    /// 
    /// 
    ///  
    /// <para>
    ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
    /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
    /// to options that offer better price and performance. After April 15, 2023, new customers
    /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
    /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
    /// during the past 30-day period are considered current customers and will be able to
    /// continue using the service. 
    /// </para>
    /// </summary>
    public partial class DescribeAcceleratorsRequest : AmazonElasticInferenceRequest
    {
        private List<string> _acceleratorIds = new List<string>();
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AcceleratorIds. 
        /// <para>
        ///  The IDs of the accelerators to describe. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<string> AcceleratorIds
        {
            get { return this._acceleratorIds; }
            set { this._acceleratorIds = value; }
        }

        // Check to see if AcceleratorIds property is set
        internal bool IsSetAcceleratorIds()
        {
            return this._acceleratorIds != null && this._acceleratorIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  One or more filters. Filter names and values are case-sensitive. Valid filter names
        /// are: accelerator-types: can provide a list of accelerator type names to filter for.
        /// instance-id: can provide a list of EC2 instance ids to filter for. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The total number of items to return in the command's output. If the total number
        /// of items available is more than the value specified, a NextToken is provided in the
        /// command's output. To resume pagination, provide the NextToken value in the starting-token
        /// argument of a subsequent command. Do not use the NextToken response element directly
        /// outside of the AWS CLI. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A token to specify where to start paginating. This is the NextToken from a previously
        /// truncated response. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}