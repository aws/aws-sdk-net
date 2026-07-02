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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
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
namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// This is the response object from the RunMicrovm operation.
    /// </summary>
    public partial class RunMicrovmResponse : AmazonWebServiceResponse
    {
        private List<string> _egressNetworkConnectors = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _endpoint;
        private string _executionRoleArn;
        private IdlePolicy _idlePolicy;
        private string _imageArn;
        private string _imageVersion;
        private List<string> _ingressNetworkConnectors = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maximumDurationInSeconds;
        private string _microvmId;
        private DateTime? _startedAt;
        private MicrovmState _state;
        private string _stateReason;
        private DateTime? _terminatedAt;

        /// <summary>
        /// Gets and sets the property EgressNetworkConnectors. 
        /// <para>
        /// The list of egress network connectors configured for the MicroVM.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> EgressNetworkConnectors
        {
            get { return this._egressNetworkConnectors; }
            set { this._egressNetworkConnectors = value; }
        }

        // Check to see if EgressNetworkConnectors property is set
        internal bool IsSetEgressNetworkConnectors()
        {
            return this._egressNetworkConnectors != null && (this._egressNetworkConnectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The HTTPS endpoint URL for communicating with the MicroVM. Include a valid authentication
        /// token in the X-aws-proxy-auth header when sending requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM execution role assumed by the MicroVM.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdlePolicy. 
        /// <para>
        /// The idle policy configuration of the MicroVM.
        /// </para>
        /// </summary>
        public IdlePolicy IdlePolicy
        {
            get { return this._idlePolicy; }
            set { this._idlePolicy = value; }
        }

        // Check to see if IdlePolicy property is set
        internal bool IsSetIdlePolicy()
        {
            return this._idlePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The ARN of the MicroVM image used to run this MicroVM.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ImageArn
        {
            get { return this._imageArn; }
            set { this._imageArn = value; }
        }

        // Check to see if ImageArn property is set
        internal bool IsSetImageArn()
        {
            return this._imageArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageVersion. 
        /// <para>
        /// The version of the MicroVM image used to run this MicroVM.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ImageVersion
        {
            get { return this._imageVersion; }
            set { this._imageVersion = value; }
        }

        // Check to see if ImageVersion property is set
        internal bool IsSetImageVersion()
        {
            return this._imageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property IngressNetworkConnectors. 
        /// <para>
        /// The list of ingress network connectors configured for the MicroVM.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> IngressNetworkConnectors
        {
            get { return this._ingressNetworkConnectors; }
            set { this._ingressNetworkConnectors = value; }
        }

        // Check to see if IngressNetworkConnectors property is set
        internal bool IsSetIngressNetworkConnectors()
        {
            return this._ingressNetworkConnectors != null && (this._ingressNetworkConnectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaximumDurationInSeconds. 
        /// <para>
        /// The maximum duration in seconds that the MicroVM can exist.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MaximumDurationInSeconds
        {
            get { return this._maximumDurationInSeconds; }
            set { this._maximumDurationInSeconds = value; }
        }

        // Check to see if MaximumDurationInSeconds property is set
        internal bool IsSetMaximumDurationInSeconds()
        {
            return this._maximumDurationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MicrovmId. 
        /// <para>
        /// The unique identifier of the MicroVM.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string MicrovmId
        {
            get { return this._microvmId; }
            set { this._microvmId = value; }
        }

        // Check to see if MicrovmId property is set
        internal bool IsSetMicrovmId()
        {
            return this._microvmId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the MicroVM first started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current lifecycle state of the MicroVM.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MicrovmState State
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
        /// The reason for why the MicroVM is in the current state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property TerminatedAt. 
        /// <para>
        /// The timestamp when the MicroVM terminated.
        /// </para>
        /// </summary>
        public DateTime? TerminatedAt
        {
            get { return this._terminatedAt; }
            set { this._terminatedAt = value; }
        }

        // Check to see if TerminatedAt property is set
        internal bool IsSetTerminatedAt()
        {
            return this._terminatedAt.HasValue; 
        }

    }
}