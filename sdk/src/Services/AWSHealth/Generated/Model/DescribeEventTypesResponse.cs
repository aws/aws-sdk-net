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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
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
namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// This is the response object from the DescribeEventTypes operation.
    /// </summary>
    public partial class DescribeEventTypesResponse : AmazonWebServiceResponse
    {
        private List<EventType> _eventTypes = AWSConfigs.InitializeCollections ? new List<EventType>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EventTypes. 
        /// <para>
        /// A list of event types that match the filter criteria. Event types have a category
        /// (<c>issue</c>, <c>accountNotification</c>, or <c>scheduledChange</c>), a service (for
        /// example, <c>EC2</c>, <c>RDS</c>, <c>DATAPIPELINE</c>, <c>BILLING</c>), and a code
        /// (in the format <c>AWS_<i>SERVICE</i>_<i>DESCRIPTION</i> </c>; for example, <c>AWS_EC2_SYSTEM_MAINTENANCE_EVENT</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EventType> EventTypes
        {
            get { return this._eventTypes; }
            set { this._eventTypes = value; }
        }

        // Check to see if EventTypes property is set
        internal bool IsSetEventTypes()
        {
            return this._eventTypes != null && (this._eventTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the results of a search are large, only a portion of the results are returned,
        /// and a <c>nextToken</c> pagination token is returned in the response. To retrieve the
        /// next batch of results, reissue the search request and include the returned token.
        /// When all results have been returned, the response does not contain a pagination token
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=10000)]
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