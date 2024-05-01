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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
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
namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Container for the parameters to the GetManagedEndpointSessionCredentials operation.
    /// Generate a session token to connect to a managed endpoint.
    /// </summary>
    public partial class GetManagedEndpointSessionCredentialsRequest : AmazonEMRContainersRequest
    {
        private string _clientToken;
        private string _credentialType;
        private int? _durationInSeconds;
        private string _endpointIdentifier;
        private string _executionRoleArn;
        private string _logContext;
        private string _virtualClusterIdentifier;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client idempotency token of the job run request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property CredentialType. 
        /// <para>
        /// Type of the token requested. Currently supported and default value of this field is
        /// “TOKEN.”
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string CredentialType
        {
            get { return this._credentialType; }
            set { this._credentialType = value; }
        }

        // Check to see if CredentialType property is set
        internal bool IsSetCredentialType()
        {
            return this._credentialType != null;
        }

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// Duration in seconds for which the session token is valid. The default duration is
        /// 15 minutes and the maximum is 12 hours.
        /// </para>
        /// </summary>
        public int? DurationInSeconds
        {
            get { return this._durationInSeconds; }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointIdentifier. 
        /// <para>
        /// The ARN of the managed endpoint for which the request is submitted. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string EndpointIdentifier
        {
            get { return this._endpointIdentifier; }
            set { this._endpointIdentifier = value; }
        }

        // Check to see if EndpointIdentifier property is set
        internal bool IsSetEndpointIdentifier()
        {
            return this._endpointIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The IAM Execution Role ARN that will be used by the job run. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property LogContext. 
        /// <para>
        /// String identifier used to separate sections of the execution logs uploaded to S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string LogContext
        {
            get { return this._logContext; }
            set { this._logContext = value; }
        }

        // Check to see if LogContext property is set
        internal bool IsSetLogContext()
        {
            return this._logContext != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualClusterIdentifier. 
        /// <para>
        /// The ARN of the Virtual Cluster which the Managed Endpoint belongs to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string VirtualClusterIdentifier
        {
            get { return this._virtualClusterIdentifier; }
            set { this._virtualClusterIdentifier = value; }
        }

        // Check to see if VirtualClusterIdentifier property is set
        internal bool IsSetVirtualClusterIdentifier()
        {
            return this._virtualClusterIdentifier != null;
        }

    }
}