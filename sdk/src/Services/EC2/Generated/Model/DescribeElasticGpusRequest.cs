/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeElasticGpus operation.
    /// Describes the Elastic GPUs associated with your instances. For more information about
    /// Elastic GPUs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/elastic-gpus.html">Amazon
    /// EC2 Elastic GPUs</a>.
    /// </summary>
    public partial class DescribeElasticGpusRequest : AmazonEC2Request
    {
        private List<string> _elasticGpuIds = new List<string>();
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ElasticGpuIds. 
        /// <para>
        /// One or more Elastic GPU IDs.
        /// </para>
        /// </summary>
        public List<string> ElasticGpuIds
        {
            get { return this._elasticGpuIds; }
            set { this._elasticGpuIds = value; }
        }

        // Check to see if ElasticGpuIds property is set
        internal bool IsSetElasticGpuIds()
        {
            return this._elasticGpuIds != null && this._elasticGpuIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>availability-zone</code> - The Availability Zone in which the Elastic GPU resides.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>elastic-gpu-health</code> - The status of the Elastic GPU (<code>OK</code>
        /// | <code>IMPAIRED</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>elastic-gpu-state</code> - The state of the Elastic GPU (<code>ATTACHED</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>elastic-gpu-type</code> - The type of Elastic GPU; for example, <code>eg1.medium</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-id</code> - The ID of the instance to which the Elastic GPU is associated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another call with the returned <code>NextToken</code> value. This value
        /// can be between 5 and 1000.
        /// </para>
        /// </summary>
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
        /// The token to request the next page of results.
        /// </para>
        /// </summary>
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