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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Representation of a harness endpoint. An endpoint is a named, stable reference to
    /// a specific version of a harness that callers invoke, allowing the underlying version
    /// to be updated without changing how the agent is invoked.
    /// </summary>
    public partial class HarnessEndpoint
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _description;
        private string _endpointName;
        private string _failureReason;
        private string _harnessId;
        private string _harnessName;
        private string _liveVersion;
        private HarnessEndpointStatus _status;
        private string _targetVersion;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the endpoint was created.
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
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason the endpoint's last create or update operation failed.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property HarnessId. 
        /// <para>
        /// The ID of the harness that the endpoint belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HarnessId
        {
            get { return this._harnessId; }
            set { this._harnessId = value; }
        }

        // Check to see if HarnessId property is set
        internal bool IsSetHarnessId()
        {
            return this._harnessId != null;
        }

        /// <summary>
        /// Gets and sets the property HarnessName. 
        /// <para>
        /// The name of the harness that the endpoint belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HarnessName
        {
            get { return this._harnessName; }
            set { this._harnessName = value; }
        }

        // Check to see if HarnessName property is set
        internal bool IsSetHarnessName()
        {
            return this._harnessName != null;
        }

        /// <summary>
        /// Gets and sets the property LiveVersion. 
        /// <para>
        /// The harness version that the endpoint is currently serving.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string LiveVersion
        {
            get { return this._liveVersion; }
            set { this._liveVersion = value; }
        }

        // Check to see if LiveVersion property is set
        internal bool IsSetLiveVersion()
        {
            return this._liveVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HarnessEndpointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetVersion. 
        /// <para>
        /// The harness version that the endpoint points to. While an update is in progress, this
        /// can differ from the live version until the endpoint finishes transitioning.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string TargetVersion
        {
            get { return this._targetVersion; }
            set { this._targetVersion = value; }
        }

        // Check to see if TargetVersion property is set
        internal bool IsSetTargetVersion()
        {
            return this._targetVersion != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the endpoint was last updated.
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

    }
}