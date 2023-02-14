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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeVpcEndpointConnectionNotifications operation.
    /// Describes the connection notifications for VPC endpoints and VPC endpoint services.
    /// </summary>
    public partial class DescribeVpcEndpointConnectionNotificationsRequest : AmazonEC2Request
    {
        private string _connectionNotificationId;
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConnectionNotificationId. 
        /// <para>
        /// The ID of the notification.
        /// </para>
        /// </summary>
        public string ConnectionNotificationId
        {
            get { return this._connectionNotificationId; }
            set { this._connectionNotificationId = value; }
        }

        // Check to see if ConnectionNotificationId property is set
        internal bool IsSetConnectionNotificationId()
        {
            return this._connectionNotificationId != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>connection-notification-arn</code> - The ARN of the SNS topic for the notification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>connection-notification-id</code> - The ID of the notification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>connection-notification-state</code> - The state of the notification (<code>Enabled</code>
        /// | <code>Disabled</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>connection-notification-type</code> - The type of notification (<code>Topic</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>service-id</code> - The ID of the endpoint service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-endpoint-id</code> - The ID of the VPC endpoint.
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
        /// results, make another request with the returned <code>NextToken</code> value.
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