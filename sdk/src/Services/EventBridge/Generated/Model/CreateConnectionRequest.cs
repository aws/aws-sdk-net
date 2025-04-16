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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
    /// Container for the parameters to the CreateConnection operation.
    /// Creates a connection. A connection defines the authorization type and credentials
    /// to use for authorization with an API destination HTTP endpoint.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-target-connection.html">Connections
    /// for endpoint targets</a> in the <i>Amazon EventBridge User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateConnectionRequest : AmazonEventBridgeRequest
    {
        private ConnectionAuthorizationType _authorizationType;
        private CreateConnectionAuthRequestParameters _authParameters;
        private string _description;
        private ConnectivityResourceParameters _invocationConnectivityParameters;
        private string _kmsKeyIdentifier;
        private string _name;

        /// <summary>
        /// Gets and sets the property AuthorizationType. 
        /// <para>
        /// The type of authorization to use for the connection.
        /// </para>
        ///  <note> 
        /// <para>
        /// OAUTH tokens are refreshed when a 401 or 407 response is returned.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionAuthorizationType AuthorizationType
        {
            get { return this._authorizationType; }
            set { this._authorizationType = value; }
        }

        // Check to see if AuthorizationType property is set
        internal bool IsSetAuthorizationType()
        {
            return this._authorizationType != null;
        }

        /// <summary>
        /// Gets and sets the property AuthParameters. 
        /// <para>
        /// The authorization parameters to use to authorize with the endpoint. 
        /// </para>
        ///  
        /// <para>
        /// You must include only authorization parameters for the <c>AuthorizationType</c> you
        /// specify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CreateConnectionAuthRequestParameters AuthParameters
        {
            get { return this._authParameters; }
            set { this._authParameters = value; }
        }

        // Check to see if AuthParameters property is set
        internal bool IsSetAuthParameters()
        {
            return this._authParameters != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the connection to create.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
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
        public ConnectivityResourceParameters InvocationConnectivityParameters
        {
            get { return this._invocationConnectivityParameters; }
            set { this._invocationConnectivityParameters = value; }
        }

        // Check to see if InvocationConnectivityParameters property is set
        internal bool IsSetInvocationConnectivityParameters()
        {
            return this._invocationConnectivityParameters != null;
        }

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
        [AWSProperty(Max=2048)]
        public string KmsKeyIdentifier
        {
            get { return this._kmsKeyIdentifier; }
            set { this._kmsKeyIdentifier = value; }
        }

        // Check to see if KmsKeyIdentifier property is set
        internal bool IsSetKmsKeyIdentifier()
        {
            return this._kmsKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the connection to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

    }
}