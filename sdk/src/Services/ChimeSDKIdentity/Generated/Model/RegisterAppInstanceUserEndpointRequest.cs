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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterAppInstanceUserEndpoint operation.
    /// Registers an endpoint under an Amazon Chime <code>AppInstanceUser</code>. The endpoint
    /// receives messages for a user. For push notifications, the endpoint is a mobile device
    /// used to receive mobile push notifications for a user.
    /// </summary>
    public partial class RegisterAppInstanceUserEndpointRequest : AmazonChimeSDKIdentityRequest
    {
        private AllowMessages _allowMessages;
        private string _appInstanceUserArn;
        private string _clientRequestToken;
        private EndpointAttributes _endpointAttributes;
        private string _name;
        private string _resourceArn;
        private AppInstanceUserEndpointType _type;

        /// <summary>
        /// Gets and sets the property AllowMessages. 
        /// <para>
        /// Boolean that controls whether the AppInstanceUserEndpoint is opted in to receive messages.
        /// <code>ALL</code> indicates the endpoint receives all messages. <code>NONE</code> indicates
        /// the endpoint receives no messages.
        /// </para>
        /// </summary>
        public AllowMessages AllowMessages
        {
            get { return this._allowMessages; }
            set { this._allowMessages = value; }
        }

        // Check to see if AllowMessages property is set
        internal bool IsSetAllowMessages()
        {
            return this._allowMessages != null;
        }

        /// <summary>
        /// Gets and sets the property AppInstanceUserArn. 
        /// <para>
        /// The ARN of the <code>AppInstanceUser</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=5, Max=1600)]
        public string AppInstanceUserArn
        {
            get { return this._appInstanceUserArn; }
            set { this._appInstanceUserArn = value; }
        }

        // Check to see if AppInstanceUserArn property is set
        internal bool IsSetAppInstanceUserArn()
        {
            return this._appInstanceUserArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique ID assigned to the request. Use different tokens to register other endpoints.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointAttributes. 
        /// <para>
        /// The attributes of an <code>Endpoint</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EndpointAttributes EndpointAttributes
        {
            get { return this._endpointAttributes; }
            set { this._endpointAttributes = value; }
        }

        // Check to see if EndpointAttributes property is set
        internal bool IsSetEndpointAttributes()
        {
            return this._endpointAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <code>AppInstanceUserEndpoint</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1600)]
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource to which the endpoint belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=1600)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the <code>AppInstanceUserEndpoint</code>. Supported types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>APNS</code>: The mobile notification service for an Apple device.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>APNS_SANDBOX</code>: The sandbox environment of the mobile notification service
        /// for an Apple device.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GCM</code>: The mobile notification service for an Android device.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Populate the <code>ResourceArn</code> value of each type as <code>PinpointAppArn</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AppInstanceUserEndpointType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}