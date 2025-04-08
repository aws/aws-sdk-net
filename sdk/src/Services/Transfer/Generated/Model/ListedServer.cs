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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Returns properties of a file transfer protocol-enabled server that was specified.
    /// </summary>
    public partial class ListedServer
    {
        private string _arn;
        private Domain _domain;
        private EndpointType _endpointType;
        private IdentityProviderType _identityProviderType;
        private string _loggingRole;
        private string _serverId;
        private State _state;
        private int? _userCount;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Specifies the unique Amazon Resource Name (ARN) for a server to be listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
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
        /// Gets and sets the property Domain. 
        /// <para>
        /// Specifies the domain of the storage system that is used for file transfers. There
        /// are two domains available: Amazon Simple Storage Service (Amazon S3) and Amazon Elastic
        /// File System (Amazon EFS). The default value is S3.
        /// </para>
        /// </summary>
        public Domain Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// Specifies the type of VPC endpoint that your server is connected to. If your server
        /// is connected to a VPC endpoint, your server isn't accessible over the public internet.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IdentityProviderType. 
        /// <para>
        /// The mode of authentication for a server. The default value is <c>SERVICE_MANAGED</c>,
        /// which allows you to store and access user credentials within the Transfer Family service.
        /// </para>
        ///  
        /// <para>
        /// Use <c>AWS_DIRECTORY_SERVICE</c> to provide access to Active Directory groups in Directory
        /// Service for Microsoft Active Directory or Microsoft Active Directory in your on-premises
        /// environment or in Amazon Web Services using AD Connector. This option also requires
        /// you to provide a Directory ID by using the <c>IdentityProviderDetails</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>API_GATEWAY</c> value to integrate with an identity provider of your choosing.
        /// The <c>API_GATEWAY</c> setting requires you to provide an Amazon API Gateway endpoint
        /// URL to call for authentication by using the <c>IdentityProviderDetails</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>AWS_LAMBDA</c> value to directly use an Lambda function as your identity
        /// provider. If you choose this value, you must specify the ARN for the Lambda function
        /// in the <c>Function</c> parameter for the <c>IdentityProviderDetails</c> data type.
        /// </para>
        /// </summary>
        public IdentityProviderType IdentityProviderType
        {
            get { return this._identityProviderType; }
            set { this._identityProviderType = value; }
        }

        // Check to see if IdentityProviderType property is set
        internal bool IsSetIdentityProviderType()
        {
            return this._identityProviderType != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role that
        /// allows a server to turn on Amazon CloudWatch logging for Amazon S3 or Amazon EFS events.
        /// When set, you can view user activity in your CloudWatch logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string LoggingRole
        {
            get { return this._loggingRole; }
            set { this._loggingRole = value; }
        }

        // Check to see if LoggingRole property is set
        internal bool IsSetLoggingRole()
        {
            return this._loggingRole != null;
        }

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// Specifies the unique system assigned identifier for the servers that were listed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }

        // Check to see if ServerId property is set
        internal bool IsSetServerId()
        {
            return this._serverId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The condition of the server that was described. A value of <c>ONLINE</c> indicates
        /// that the server can accept jobs and transfer files. A <c>State</c> value of <c>OFFLINE</c>
        /// means that the server cannot perform file transfer operations.
        /// </para>
        ///  
        /// <para>
        /// The states of <c>STARTING</c> and <c>STOPPING</c> indicate that the server is in an
        /// intermediate state, either not fully able to respond, or not fully offline. The values
        /// of <c>START_FAILED</c> or <c>STOP_FAILED</c> can indicate an error condition.
        /// </para>
        /// </summary>
        public State State
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
        /// Gets and sets the property UserCount. 
        /// <para>
        /// Specifies the number of users that are assigned to a server you specified with the
        /// <c>ServerId</c>.
        /// </para>
        /// </summary>
        public int? UserCount
        {
            get { return this._userCount; }
            set { this._userCount = value; }
        }

        // Check to see if UserCount property is set
        internal bool IsSetUserCount()
        {
            return this._userCount.HasValue; 
        }

    }
}