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
    /// An endpoint under an Amazon Chime <c>AppInstanceUser</c> that receives messages for
    /// a user. For push notifications, the endpoint is a mobile device used to receive mobile
    /// push notifications for a user.
    /// </summary>
    public partial class AppInstanceUserEndpoint
    {
        /// <summary>
        /// Gets and sets the property AllowMessages. 
        /// <para>
        /// Boolean that controls whether the <c>AppInstanceUserEndpoint</c> is opted in to receive
        /// messages. <c>ALL</c> indicates the endpoint will receive all messages. <c>NONE</c>
        /// indicates the endpoint will receive no messages.
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
        [AWSProperty(Min = 5, Max = 1600)]
        public string AppInstanceUserArn { get; set; }

        /// <summary>
        /// Checks to see if the AppInstanceUserArn property is set.
        /// </summary>
        internal bool IsSetAppInstanceUserArn() => this.AppInstanceUserArn != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which an <c>AppInstanceUserEndpoint</c> was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointAttributes. 
        /// <para>
        /// The attributes of an <c>Endpoint</c>.
        /// </para>
        /// </summary>
        public EndpointAttributes EndpointAttributes { get; set; }

        /// <summary>
        /// Checks to see if the EndpointAttributes property is set.
        /// </summary>
        internal bool IsSetEndpointAttributes() => this.EndpointAttributes != null;

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The unique identifier of the <c>AppInstanceUserEndpoint</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string EndpointId { get; set; }

        /// <summary>
        /// Checks to see if the EndpointId property is set.
        /// </summary>
        internal bool IsSetEndpointId() => this.EndpointId != null;

        /// <summary>
        /// Gets and sets the property EndpointState. 
        /// <para>
        /// A read-only field that represents the state of an <c>AppInstanceUserEndpoint</c>.
        /// Supported values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c>: The <c>AppInstanceUserEndpoint</c> is active and able to receive messages.
        /// When <c>ACTIVE</c>, the <c>EndpointStatusReason</c> remains empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c>: The <c>AppInstanceUserEndpoint</c> is inactive and can't receive
        /// message. When <c>INACTIVE</c>, the corresponding reason will be conveyed through <c>EndpointStatusReason</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_DEVICE_TOKEN</c> indicates that an <c>AppInstanceUserEndpoint</c> is <c>INACTIVE</c>
        /// due to invalid device token
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_PINPOINT_ARN</c> indicates that an <c>AppInstanceUserEndpoint</c> is <c>INACTIVE</c>
        /// due to an invalid pinpoint ARN that was input through the <c>ResourceArn</c> field.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EndpointState EndpointState { get; set; }

        /// <summary>
        /// Checks to see if the EndpointState property is set.
        /// </summary>
        internal bool IsSetEndpointState() => this.EndpointState != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The time at which an <c>AppInstanceUserEndpoint</c> was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;

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
        [AWSProperty(Min = 5, Max = 1600)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the <c>AppInstanceUserEndpoint</c>.
        /// </para>
        /// </summary>
        public AppInstanceUserEndpointType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
