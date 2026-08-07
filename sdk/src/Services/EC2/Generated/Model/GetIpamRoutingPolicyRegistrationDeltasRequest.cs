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
    /// Container for the parameters to the GetIpamRoutingPolicyRegistrationDeltas operation.
    /// Retrieves the history of routing policy registration changes for an IPAM internet
    /// registry association. We recommend using pagination to ensure that the operation returns
    /// quickly and successfully.
    /// </summary>
    public partial class GetIpamRoutingPolicyRegistrationDeltasRequest : AmazonEC2Request
    {
        private ChronologicalOrder _chronologicalOrder;
        private string _deltaId;
        private bool? _dryRun;
        private DateTime? _endTime;
        private string _ipamInternetRegistryAssociationId;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property ChronologicalOrder. 
        /// <para>
        /// The chronological order to return results in. Valid values: <c>forward</c> | <c>reverse</c>.
        /// </para>
        /// </summary>
        public ChronologicalOrder ChronologicalOrder
        {
            get { return this._chronologicalOrder; }
            set { this._chronologicalOrder = value; }
        }

        // Check to see if ChronologicalOrder property is set
        internal bool IsSetChronologicalOrder()
        {
            return this._chronologicalOrder != null;
        }

        /// <summary>
        /// Gets and sets the property DeltaId. 
        /// <para>
        /// Filter results to a specific delta ID.
        /// </para>
        /// </summary>
        public string DeltaId
        {
            get { return this._deltaId; }
            set { this._deltaId = value; }
        }

        // Check to see if DeltaId property is set
        internal bool IsSetDeltaId()
        {
            return this._deltaId != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time range to filter deltas by.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpamInternetRegistryAssociationId. 
        /// <para>
        /// The ID of the IPAM internet registry association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamInternetRegistryAssociationId
        {
            get { return this._ipamInternetRegistryAssociationId; }
            set { this._ipamInternetRegistryAssociationId = value; }
        }

        // Check to see if IpamInternetRegistryAssociationId property is set
        internal bool IsSetIpamInternetRegistryAssociationId()
        {
            return this._ipamInternetRegistryAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. If not specified, all available
        /// results are returned. To retrieve the remaining results, make another call with the
        /// returned <c>nextToken</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
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
        /// The token for the next page of results.
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

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time range to filter deltas by.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}