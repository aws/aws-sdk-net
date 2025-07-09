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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAutoScalingGroups operation.
    /// Gets information about the Auto Scaling groups in the account and Region.
    /// 
    ///  
    /// <para>
    /// If you specify Auto Scaling group names, the output includes information for only
    /// the specified Auto Scaling groups. If you specify filters, the output includes information
    /// for only those Auto Scaling groups that meet the filter criteria. If you do not specify
    /// group names or filters, the output includes information for all Auto Scaling groups.
    /// 
    /// </para>
    ///  
    /// <para>
    /// This operation also returns information about instances in Auto Scaling groups. To
    /// retrieve information about the instances in a warm pool, you must call the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeWarmPool.html">DescribeWarmPool</a>
    /// API. 
    /// </para>
    /// </summary>
    public partial class DescribeAutoScalingGroupsRequest : AmazonAutoScalingRequest
    {
        private List<string> _autoScalingGroupNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private bool? _includeInstances;
        private int? _maxRecords;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupNames. 
        /// <para>
        /// The names of the Auto Scaling groups. By default, you can only specify up to 50 names.
        /// You can optionally increase this limit using the <c>MaxRecords</c> property.
        /// </para>
        ///  
        /// <para>
        /// If you omit this property, all Auto Scaling groups are described.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AutoScalingGroupNames
        {
            get { return this._autoScalingGroupNames; }
            set { this._autoScalingGroupNames = value; }
        }

        // Check to see if AutoScalingGroupNames property is set
        internal bool IsSetAutoScalingGroupNames()
        {
            return this._autoScalingGroupNames != null && (this._autoScalingGroupNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters to limit the results based on specific tags. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property IncludeInstances. 
        /// <para>
        ///  Specifies whether to include information about Amazon EC2 instances in the response.
        /// When set to <c>true</c> (default), the response includes instance details. 
        /// </para>
        /// </summary>
        public bool? IncludeInstances
        {
            get { return this._includeInstances; }
            set { this._includeInstances = value; }
        }

        // Check to see if IncludeInstances property is set
        internal bool IsSetIncludeInstances()
        {
            return this._includeInstances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of items to return with this call. The default value is <c>50</c>
        /// and the maximum value is <c>100</c>.
        /// </para>
        /// </summary>
        public int? MaxRecords
        {
            get { return this._maxRecords; }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
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