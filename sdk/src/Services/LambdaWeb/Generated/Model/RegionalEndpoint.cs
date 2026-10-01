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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
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
namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// Represents the endpoint configuration and state in a specific Region.
    /// </summary>
    public partial class RegionalEndpoint
    {
        private AuthType _authType;
        private string _domainName;
        private List<RevisionWeight> _revisionWeights = AWSConfigs.InitializeCollections ? new List<RevisionWeight>() : null;
        private ScalingConfig _scalingConfig;
        private EndpointState _state;
        private string _stateReason;
        private ThrottleConfig _throttleConfig;
        private EndpointUpdateStatus _updateStatus;
        private string _updateStatusReason;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The authorization type for the regional endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthType AuthType
        {
            get { return this._authType; }
            set { this._authType = value; }
        }

        // Check to see if AuthType property is set
        internal bool IsSetAuthType()
        {
            return this._authType != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name of the regional endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=256)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionWeights. 
        /// <para>
        /// The revision weights for the regional endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<RevisionWeight> RevisionWeights
        {
            get { return this._revisionWeights; }
            set { this._revisionWeights = value; }
        }

        // Check to see if RevisionWeights property is set
        internal bool IsSetRevisionWeights()
        {
            return this._revisionWeights != null && (this._revisionWeights.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScalingConfig. 
        /// <para>
        /// The scaling configuration for the regional endpoint. This field is absent if the endpoint
        /// has no scaling configuration.
        /// </para>
        /// </summary>
        public ScalingConfig ScalingConfig
        {
            get { return this._scalingConfig; }
            set { this._scalingConfig = value; }
        }

        // Check to see if ScalingConfig property is set
        internal bool IsSetScalingConfig()
        {
            return this._scalingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the regional endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EndpointState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for the current state of the regional endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

        /// <summary>
        /// Gets and sets the property ThrottleConfig. 
        /// <para>
        /// The throttling configuration for the regional endpoint. This field is absent if the
        /// endpoint has no throttling configuration.
        /// </para>
        /// </summary>
        public ThrottleConfig ThrottleConfig
        {
            get { return this._throttleConfig; }
            set { this._throttleConfig = value; }
        }

        // Check to see if ThrottleConfig property is set
        internal bool IsSetThrottleConfig()
        {
            return this._throttleConfig != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        /// The status of the most recent update to the regional endpoint.
        /// </para>
        /// </summary>
        public EndpointUpdateStatus UpdateStatus
        {
            get { return this._updateStatus; }
            set { this._updateStatus = value; }
        }

        // Check to see if UpdateStatus property is set
        internal bool IsSetUpdateStatus()
        {
            return this._updateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateStatusReason. 
        /// <para>
        /// The reason for the current update status of the regional endpoint.
        /// </para>
        /// </summary>
        public string UpdateStatusReason
        {
            get { return this._updateStatusReason; }
            set { this._updateStatusReason = value; }
        }

        // Check to see if UpdateStatusReason property is set
        internal bool IsSetUpdateStatusReason()
        {
            return this._updateStatusReason != null;
        }

    }
}