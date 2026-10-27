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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Specifies the unique Amazon Resource Name (ARN) for a server to be listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// Specifies the domain of the storage system that is used for file transfers. There
        /// are two domains available: Amazon Simple Storage Service (Amazon S3) and Amazon Elastic
        /// File System (Amazon EFS). The default value is S3.
        /// </para>
        /// </summary>
        public Domain Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// Specifies the type of VPC endpoint that your server is connected to. If your server
        /// is connected to a VPC endpoint, your server isn't accessible over the public internet.
        /// </para>
        /// </summary>
        public EndpointType EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

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
        public IdentityProviderType IdentityProviderType { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderType property is set.
        /// </summary>
        internal bool IsSetIdentityProviderType() => this.IdentityProviderType != null;

        /// <summary>
        /// Gets and sets the property LoggingRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role that
        /// allows a server to turn on Amazon CloudWatch logging for Amazon S3 or Amazon EFS events.
        /// When set, you can view user activity in your CloudWatch logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string LoggingRole { get; set; }

        /// <summary>
        /// Checks to see if the LoggingRole property is set.
        /// </summary>
        internal bool IsSetLoggingRole() => this.LoggingRole != null;

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// Specifies the unique system assigned identifier for the servers that were listed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string ServerId { get; set; }

        /// <summary>
        /// Checks to see if the ServerId property is set.
        /// </summary>
        internal bool IsSetServerId() => this.ServerId != null;

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
        public State State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UserCount. 
        /// <para>
        /// Specifies the number of users that are assigned to a server you specified with the
        /// <c>ServerId</c>.
        /// </para>
        /// </summary>
        public int? UserCount { get; set; }

        /// <summary>
        /// Checks to see if the UserCount property is set.
        /// </summary>
        internal bool IsSetUserCount() => this.UserCount.HasValue;
    }
}
