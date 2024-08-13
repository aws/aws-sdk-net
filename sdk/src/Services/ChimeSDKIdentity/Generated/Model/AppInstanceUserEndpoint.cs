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
        private AllowMessages _allowMessages;
        private string _appInstanceUserArn;
        private DateTime? _createdTimestamp;
        private EndpointAttributes _endpointAttributes;
        private string _endpointId;
        private EndpointState _endpointState;
        private DateTime? _lastUpdatedTimestamp;
        private string _name;
        private string _resourceArn;
        private AppInstanceUserEndpointType _type;

        /// <summary>
        /// Gets and sets the property AllowMessages. 
        /// <para>
        /// Boolean that controls whether the <c>AppInstanceUserEndpoint</c> is opted in to receive
        /// messages. <c>ALL</c> indicates the endpoint will receive all messages. <c>NONE</c>
        /// indicates the endpoint will receive no messages.
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
        /// The ARN of the <c>AppInstanceUser</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1600)]
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
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which an <c>AppInstanceUserEndpoint</c> was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointAttributes. 
        /// <para>
        /// The attributes of an <c>Endpoint</c>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The unique identifier of the <c>AppInstanceUserEndpoint</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

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
        public EndpointState EndpointState
        {
            get { return this._endpointState; }
            set { this._endpointState = value; }
        }

        // Check to see if EndpointState property is set
        internal bool IsSetEndpointState()
        {
            return this._endpointState != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The time at which an <c>AppInstanceUserEndpoint</c> was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp; }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <c>AppInstanceUserEndpoint</c>.
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
        [AWSProperty(Min=5, Max=1600)]
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
        /// The type of the <c>AppInstanceUserEndpoint</c>.
        /// </para>
        /// </summary>
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