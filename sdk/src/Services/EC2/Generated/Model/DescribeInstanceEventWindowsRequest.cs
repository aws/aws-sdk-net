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
    /// Container for the parameters to the DescribeInstanceEventWindows operation.
    /// Describes the specified event windows or all event windows.
    /// 
    ///  
    /// <para>
    /// If you specify event window IDs, the output includes information for only the specified
    /// event windows. If you specify filters, the output includes information for only those
    /// event windows that meet the filter criteria. If you do not specify event windows IDs
    /// or filters, the output includes information for all event windows, which can affect
    /// performance. We recommend that you use pagination to ensure that the operation returns
    /// quickly and successfully. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/event-windows.html">Define
    /// event windows for scheduled events</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeInstanceEventWindowsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _instanceEventWindowIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>dedicated-host-id</c> - The event windows associated with the specified Dedicated
        /// Host ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>event-window-name</c> - The event windows associated with the specified names.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-id</c> - The event windows associated with the specified instance ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-tag</c> - The event windows associated with the specified tag and value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-tag-key</c> - The event windows associated with the specified tag key,
        /// regardless of the value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-tag-value</c> - The event windows associated with the specified tag value,
        /// regardless of the key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag:&lt;key&gt;</c> - The key/value combination of a tag assigned to the event
        /// window. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <c>Owner</c> and the
        /// value <c>CMX</c>, specify <c>tag:Owner</c> for the filter name and <c>CMX</c> for
        /// the filter value. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The key of a tag assigned to the event window. Use this filter to
        /// find all event windows that have a tag with a specific key, regardless of the tag
        /// value. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-value</c> - The value of a tag assigned to the event window. Use this filter
        /// to find all event windows that have a tag with a specific value, regardless of the
        /// tag key. 
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property InstanceEventWindowIds. 
        /// <para>
        /// The IDs of the event windows.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceEventWindowIds
        {
            get { return this._instanceEventWindowIds; }
            set { this._instanceEventWindowIds = value; }
        }

        // Check to see if InstanceEventWindowIds property is set
        internal bool IsSetInstanceEventWindowIds()
        {
            return this._instanceEventWindowIds != null && (this._instanceEventWindowIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another call with the returned <c>NextToken</c> value. This value can
        /// be between 20 and 500. You cannot specify this parameter and the event window IDs
        /// parameter in the same call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=500)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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