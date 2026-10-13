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
    /// Container for the parameters to the UpdateConnection operation. Updates settings for
    /// a connection.
    /// </summary>
    public partial class UpdateConnectionRequest : AmazonEventBridgeRequest
    {
        /// <summary>
        /// Gets and sets the property AuthParameters. 
        /// <para>
        /// The authorization parameters to use for the connection.
        /// </para>
        /// </summary>
        public UpdateConnectionAuthRequestParameters AuthParameters { get; set; }

        /// <summary>
        /// Checks to see if the AuthParameters property is set.
        /// </summary>
        internal bool IsSetAuthParameters() => this.AuthParameters != null;

        /// <summary>
        /// Gets and sets the property AuthorizationType. 
        /// <para>
        /// The type of authorization to use for the connection.
        /// </para>
        /// </summary>
        public ConnectionAuthorizationType AuthorizationType { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationType property is set.
        /// </summary>
        internal bool IsSetAuthorizationType() => this.AuthorizationType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the connection.
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
        /// For connections to private APIs, the parameters to use for invoking the API.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/connection-private.html">Connecting
        /// to private APIs</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </para>
        /// </summary>
        public ConnectivityResourceParameters InvocationConnectivityParameters { get; set; }

        /// <summary>
        /// Checks to see if the InvocationConnectivityParameters property is set.
        /// </summary>
        internal bool IsSetInvocationConnectivityParameters() => this.InvocationConnectivityParameters != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The identifier of the KMS customer managed key for EventBridge to use, if you choose
        /// to use a customer managed key to encrypt this connection. The identifier can be the
        /// key Amazon Resource Name (ARN), KeyId, key alias, or key alias ARN.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a customer managed key identifier, EventBridge uses an Amazon
        /// Web Services owned key to encrypt the connection.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/viewing-keys.html">Identify
        /// and view keys</a> in the <i>Key Management Service Developer Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connection to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
