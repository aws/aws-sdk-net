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

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// This is the response object from the DescribeConnection operation.
    /// </summary>
    public partial class DescribeConnectionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthParameters. 
        /// <para>
        /// The parameters to use for authorization for the connection.
        /// </para>
        /// </summary>
        public ConnectionAuthResponseParameters AuthParameters { get; set; }

        /// <summary>
        /// Checks to see if the AuthParameters property is set.
        /// </summary>
        internal bool IsSetAuthParameters() => this.AuthParameters != null;

        /// <summary>
        /// Gets and sets the property AuthorizationType. 
        /// <para>
        /// The type of authorization specified for the connection.
        /// </para>
        /// </summary>
        public ConnectionAuthorizationType AuthorizationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationType property is set.
        /// </summary>
        internal bool IsSetAuthorizationType() => this.AuthorizationType != null;

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The ARN of the connection retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string ConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionArn property is set.
        /// </summary>
        internal bool IsSetConnectionArn() => this.ConnectionArn != null;

        /// <summary>
        /// Gets and sets the property ConnectionState. 
        /// <para>
        /// The state of the connection retrieved.
        /// </para>
        /// </summary>
        public ConnectionState ConnectionState { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionState property is set.
        /// </summary>
        internal bool IsSetConnectionState() => this.ConnectionState != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp for the time that the connection was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the connection retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InvocationConnectivityParameters. 
        /// <para>
        /// For connections to private APIs The parameters EventBridge uses to invoke the resource
        /// endpoint.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/connection-private.html">Connecting
        /// to private APIs</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </para>
        /// </summary>
        public DescribeConnectionConnectivityParameters InvocationConnectivityParameters { get; set; }

        /// <summary>
        /// Checks to see if the InvocationConnectivityParameters property is set.
        /// </summary>
        internal bool IsSetInvocationConnectivityParameters() => this.InvocationConnectivityParameters != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The identifier of the KMS customer managed key for EventBridge to use to encrypt the
        /// connection, if one has been specified.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/encryption-connections.html">Encrypting
        /// connections</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property LastAuthorizedTime. 
        /// <para>
        /// A time stamp for the time that the connection was last authorized.
        /// </para>
        /// </summary>
        public DateTime? LastAuthorizedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastAuthorizedTime property is set.
        /// </summary>
        internal bool IsSetLastAuthorizedTime() => this.LastAuthorizedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A time stamp for the time that the connection was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connection retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The ARN of the secret created from the authorization parameters specified for the
        /// connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason that the connection is in the current connection state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;
    }
}
