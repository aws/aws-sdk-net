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
 * Do not modify this file. This file is generated from the lambda-core-2026-04-30.normal.json service model.
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
namespace Amazon.LambdaCore.Model
{
    /// <summary>
    /// This is the response object from the GetNetworkConnector operation.
    /// </summary>
    public partial class GetNetworkConnectorResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private NetworkConnectorConfiguration _configuration;
        private string _id;
        private DateTime? _lastModified;
        private NetworkConnectorLastUpdateStatus _lastUpdateStatus;
        private string _lastUpdateStatusReason;
        private NetworkConnectorLastUpdateStatusReasonCode _lastUpdateStatusReasonCode;
        private string _name;
        private string _operatorRole;
        private NetworkConnectorState _state;
        private string _stateReason;
        private NetworkConnectorStateReasonCode _stateReasonCode;
        private long? _version;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The network configuration of the connector, including VPC subnets and security groups.
        /// </para>
        /// </summary>
        public NetworkConnectorConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Id.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time when the connector configuration was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateStatus. 
        /// <para>
        /// The status of the most recent update operation (<c>Successful</c>, <c>Failed</c>,
        /// or <c>InProgress</c>).
        /// </para>
        /// </summary>
        public NetworkConnectorLastUpdateStatus LastUpdateStatus
        {
            get { return this._lastUpdateStatus; }
            set { this._lastUpdateStatus = value; }
        }

        // Check to see if LastUpdateStatus property is set
        internal bool IsSetLastUpdateStatus()
        {
            return this._lastUpdateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateStatusReason. 
        /// <para>
        /// A human-readable explanation of the last update status.
        /// </para>
        /// </summary>
        public string LastUpdateStatusReason
        {
            get { return this._lastUpdateStatusReason; }
            set { this._lastUpdateStatusReason = value; }
        }

        // Check to see if LastUpdateStatusReason property is set
        internal bool IsSetLastUpdateStatusReason()
        {
            return this._lastUpdateStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateStatusReasonCode. 
        /// <para>
        /// A machine-readable code indicating the reason for the last update status. Use this
        /// for programmatic error handling.
        /// </para>
        /// </summary>
        public NetworkConnectorLastUpdateStatusReasonCode LastUpdateStatusReasonCode
        {
            get { return this._lastUpdateStatusReasonCode; }
            set { this._lastUpdateStatusReasonCode = value; }
        }

        // Check to see if LastUpdateStatusReasonCode property is set
        internal bool IsSetLastUpdateStatusReasonCode()
        {
            return this._lastUpdateStatusReasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the network connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OperatorRole. 
        /// <para>
        /// The ARN of the IAM role that Lambda uses to manage the underlying ENI resources for
        /// this connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public string OperatorRole
        {
            get { return this._operatorRole; }
            set { this._operatorRole = value; }
        }

        // Check to see if OperatorRole property is set
        internal bool IsSetOperatorRole()
        {
            return this._operatorRole != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the network connector.
        /// </para>
        /// </summary>
        public NetworkConnectorState State
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
        /// A human-readable explanation of the current state, populated when the state is <c>FAILED</c>
        /// or <c>DELETE_FAILED</c>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StateReasonCode. 
        /// <para>
        /// A machine-readable code indicating the reason for the current state. Use this for
        /// programmatic error handling.
        /// </para>
        /// </summary>
        public NetworkConnectorStateReasonCode StateReasonCode
        {
            get { return this._stateReasonCode; }
            set { this._stateReasonCode = value; }
        }

        // Check to see if StateReasonCode property is set
        internal bool IsSetStateReasonCode()
        {
            return this._stateReasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the connector configuration, incremented on each update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}