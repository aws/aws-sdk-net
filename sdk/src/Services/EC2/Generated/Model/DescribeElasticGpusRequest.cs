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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeElasticGpus operation.
    /// <note> 
    /// <para>
    /// Amazon Elastic Graphics reached end of life on January 8, 2024.
    /// </para>
    ///  </note> 
    /// <para>
    /// Describes the Elastic Graphics accelerator associated with your instances.
    /// </para>
    /// </summary>
    public partial class DescribeElasticGpusRequest : AmazonEC2Request
    {
        private List<string> _elasticGpuIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ElasticGpuIds. 
        /// <para>
        /// The Elastic Graphics accelerator IDs.
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
            return this._elasticGpuIds != null && (this._elasticGpuIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>availability-zone</c> - The Availability Zone in which the Elastic Graphics accelerator
        /// resides.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>elastic-gpu-health</c> - The status of the Elastic Graphics accelerator (<c>OK</c>
        /// | <c>IMPAIRED</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>elastic-gpu-state</c> - The state of the Elastic Graphics accelerator (<c>ATTACHED</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>elastic-gpu-type</c> - The type of Elastic Graphics accelerator; for example,
        /// <c>eg1.medium</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-id</c> - The ID of the instance to which the Elastic Graphics accelerator
        /// is associated.
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
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another call with the returned <c>NextToken</c> value. This value can
        /// be between 5 and 1000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1000)]
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