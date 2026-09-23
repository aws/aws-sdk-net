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

namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterAppInstanceUserEndpoint operation. Registers
    /// an endpoint under an Amazon Chime <c>AppInstanceUser</c>. The endpoint receives messages
    /// for a user. For push notifications, the endpoint is a mobile device used to receive
    /// mobile push notifications for a user.
    /// </summary>
    public partial class RegisterAppInstanceUserEndpointRequest : AmazonChimeSDKIdentityRequest
    {
        /// <summary>
        /// Gets and sets the property AllowMessages. 
        /// <para>
        /// Boolean that controls whether the AppInstanceUserEndpoint is opted in to receive messages.
        /// <c>ALL</c> indicates the endpoint receives all messages. <c>NONE</c> indicates the
        /// endpoint receives no messages.
        /// </para>
        /// </summary>
        public AllowMessages AllowMessages { get; set; }

        /// <summary>
        /// Checks to see if the AllowMessages property is set.
        /// </summary>
        internal bool IsSetAllowMessages() => this.AllowMessages != null;

        /// <summary>
        /// Gets and sets the property AppInstanceUserArn. 
        /// <para>
        /// The ARN of the <c>AppInstanceUser</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 5, Max = 1600)]
        public string AppInstanceUserArn { get; set; }

        /// <summary>
        /// Checks to see if the AppInstanceUserArn property is set.
        /// </summary>
        internal bool IsSetAppInstanceUserArn() => this.AppInstanceUserArn != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique ID assigned to the request. Use different tokens to register other endpoints.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property EndpointAttributes. 
        /// <para>
        /// The attributes of an <c>Endpoint</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointAttributes EndpointAttributes { get; set; }

        /// <summary>
        /// Checks to see if the EndpointAttributes property is set.
        /// </summary>
        internal bool IsSetEndpointAttributes() => this.EndpointAttributes != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <c>AppInstanceUserEndpoint</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1600)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource to which the endpoint belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 1600)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the <c>AppInstanceUserEndpoint</c>. Supported types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>APNS</c>: The mobile notification service for an Apple device.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>APNS_SANDBOX</c>: The sandbox environment of the mobile notification service for
        /// an Apple device.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GCM</c>: The mobile notification service for an Android device.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Populate the <c>ResourceArn</c> value of each type as <c>PinpointAppArn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AppInstanceUserEndpointType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
