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
    /// Container for the parameters to the DescribeCapacityManagerDataExports operation.
    /// Describes one or more Capacity Manager data export configurations. Returns information
    /// about export settings, delivery status, and recent export activity.
    /// </summary>
    public partial class DescribeCapacityManagerDataExportsRequest : AmazonEC2Request
    {
        private List<string> _capacityManagerDataExportIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CapacityManagerDataExportIds. 
        /// <para>
        ///  The IDs of the data export configurations to describe. If not specified, all export
        /// configurations are returned. 
        /// </para>
        /// </summary>
        public List<string> CapacityManagerDataExportIds
        {
            get { return this._capacityManagerDataExportIds; }
            set { this._capacityManagerDataExportIds = value; }
        }

        // Check to see if CapacityManagerDataExportIds property is set
        internal bool IsSetCapacityManagerDataExportIds()
        {
            return this._capacityManagerDataExportIds != null && (this._capacityManagerDataExportIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        ///  One or more filters to narrow the results. Supported filters include export status,
        /// creation date, and S3 bucket name. 
        /// </para>
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
        ///  The maximum number of results to return in a single call. If not specified, up to
        /// 1000 results are returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        ///  The token for the next page of results. Use this value in a subsequent call to retrieve
        /// additional results. 
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