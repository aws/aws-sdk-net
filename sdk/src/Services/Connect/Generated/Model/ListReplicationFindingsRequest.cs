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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the ListReplicationFindings operation.
    /// Lists replication findings for resources of a specified resource type in a specified
    /// Connect Customer instance. A replication finding describes a single resource whose
    /// replication to one or more Regions is incomplete or has encountered an error. Results
    /// are returned in pages. This operation is available only for instances that are set
    /// up for Global Resiliency.
    /// </summary>
    public partial class ListReplicationFindingsRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private int? _maxResults;
        private string _nextToken;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can provide either the instance
        /// ID or the full instance ARN. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=250)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
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

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource to list replication findings for. The following values are currently
        /// supported: <c>AGENT</c>, <c>AGENT_GROUP</c>, <c>AGENT_GROUP_LEVEL</c>, <c>AGENT_STATE</c>,
        /// <c>ATTRIBUTE</c>, <c>CONTACT_FLOW</c>, <c>DATA_TABLE</c>, <c>DATA_TABLE_ATTRIBUTE</c>,
        /// <c>DATA_TABLE_RECORD</c>, <c>DATA_TABLE_VALUE</c>, <c>FLOW_MODULE</c>, <c>FLOW_MODULE_ALIAS</c>,
        /// <c>FLOW_MODULE_VERSION</c>, <c>METRIC</c>, <c>NOTIFICATION</c>, <c>OPERATING_HOURS</c>,
        /// <c>PHONE_NUMBER</c>, <c>PROMPT</c>, <c>QUEUE</c>, <c>REPORT</c>, <c>ROUTING_PROFILE</c>,
        /// <c>SECURITY_PROFILE</c>, <c>TASK_TEMPLATE</c>, <c>TEST_CASE</c>, <c>TRANSFER_DESTINATION</c>,
        /// <c>VIEW</c>, and <c>WORKSPACE</c>. Additional resource types can be supported over
        /// time. Specifying a value that is not currently supported returns an <c>InvalidRequestException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}