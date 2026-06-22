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
    /// Container for the parameters to the RunMicrovm operation.
    /// Runs a new MicroVM from the specified image. The MicroVM starts in PENDING state and
    /// transitions to RUNNING once provisioning completes. To connect, generate an authentication
    /// token using CreateMicrovmAuthToken.
    /// </summary>
    public partial class RunMicrovmRequest : AmazonLambdaMicrovmsRequest
    {
        private string _clientToken;
        private List<string> _egressNetworkConnectors = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _executionRoleArn;
        private IdlePolicy _idlePolicy;
        private string _imageIdentifier;
        private string _imageVersion;
        private List<string> _ingressNetworkConnectors = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Logging _logging;
        private int? _maximumDurationInSeconds;
        private string _runHookPayload;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EgressNetworkConnectors. 
        /// <para>
        /// The list of egress network connectors to configure for the MicroVM.
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
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role to be assumed by the MicroVM during execution.
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
        /// Configuration to control auto-suspend and auto-resume behavior.
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
        /// Gets and sets the property ImageIdentifier. 
        /// <para>
        /// The identifier (ARN or ID) of the MicroVM image to run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ImageIdentifier
        {
            get { return this._imageIdentifier; }
            set { this._imageIdentifier = value; }
        }

        // Check to see if ImageIdentifier property is set
        internal bool IsSetImageIdentifier()
        {
            return this._imageIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ImageVersion. 
        /// <para>
        /// The version of the MicroVM image to run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// The list of ingress network connectors to configure for the MicroVM.
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
        /// Gets and sets the property Logging. 
        /// <para>
        /// The logging configuration for this MicroVM instance. Specify {"cloudWatch": {"logGroup":
        /// "..."}} to stream application logs to a custom CloudWatch log group, or {"disabled":
        /// {}} to turn off logging.
        /// </para>
        /// </summary>
        public Logging Logging
        {
            get { return this._logging; }
            set { this._logging = value; }
        }

        // Check to see if Logging property is set
        internal bool IsSetLogging()
        {
            return this._logging != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumDurationInSeconds. 
        /// <para>
        /// The maximum duration in seconds that the MicroVM can exist before being terminated
        /// by the platform. Valid range: 1–28,800 (8 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=28800)]
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
        /// Gets and sets the property RunHookPayload. 
        /// <para>
        /// Per-MicroVM initialization data delivered as the request body of the /run lifecycle
        /// hook. Use to pass tenant-specific configuration such as session IDs or secret references.
        /// Maximum: 16,384 bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
        public string RunHookPayload
        {
            get { return this._runHookPayload; }
            set { this._runHookPayload = value; }
        }

        // Check to see if RunHookPayload property is set
        internal bool IsSetRunHookPayload()
        {
            return this._runHookPayload != null;
        }

    }
}