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
    /// Contains details about the updated endpoint.
    /// </summary>
    public partial class UpdateWebFunctionEndpointResponse : AmazonWebServiceResponse
    {
        private AuthType _authType;
        private AutoDeploymentMode _autoDeploymentMode;
        private DateTime? _createdAt;
        private string _description;
        private string _domainName;
        private string _endpointArn;
        private string _endpointName;
        private EndpointType _endpointType;
        private string _functionArn;
        private Dictionary<string, RegionalEndpoint> _regionalEndpoints = AWSConfigs.InitializeCollections ? new Dictionary<string, RegionalEndpoint>() : null;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<RevisionWeight> _revisionWeights = AWSConfigs.InitializeCollections ? new List<RevisionWeight>() : null;
        private ScalingConfig _scalingConfig;
        private EndpointState _state;
        private string _stateReason;
        private ThrottleConfig _throttleConfig;
        private DateTime? _updatedAt;
        private EndpointUpdateStatus _updateStatus;
        private string _updateStatusReason;

        /// <summary>
        /// Gets and sets the property AuthType.
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
        /// Gets and sets the property AutoDeploymentMode.
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoDeploymentMode AutoDeploymentMode
        {
            get { return this._autoDeploymentMode; }
            set { this._autoDeploymentMode = value; }
        }

        // Check to see if AutoDeploymentMode property is set
        internal bool IsSetAutoDeploymentMode()
        {
            return this._autoDeploymentMode != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the endpoint was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name assigned to the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=256)]
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
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string EndpointArn
        {
            get { return this._endpointArn; }
            set { this._endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this._endpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointType.
        /// </summary>
        [AWSProperty(Required=true)]
        public EndpointType EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the web function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string FunctionArn
        {
            get { return this._functionArn; }
            set { this._functionArn = value; }
        }

        // Check to see if FunctionArn property is set
        internal bool IsSetFunctionArn()
        {
            return this._functionArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegionalEndpoints. 
        /// <para>
        /// The list of regional endpoint configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, RegionalEndpoint> RegionalEndpoints
        {
            get { return this._regionalEndpoints; }
            set { this._regionalEndpoints = value; }
        }

        // Check to see if RegionalEndpoints property is set
        internal bool IsSetRegionalEndpoints()
        {
            return this._regionalEndpoints != null && (this._regionalEndpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The Regions configured for the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RevisionWeights. 
        /// <para>
        /// The traffic distribution across revisions for the endpoint. Each entry maps a revision
        /// to a weight from 1 to 100.
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
        /// The current state of the endpoint.
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
        /// The reason for the current state of the endpoint.
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the endpoint was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdateStatus.
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
        /// The reason for the endpoint's most recent update status.
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