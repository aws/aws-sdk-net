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
    /// A read-only field that represents the state of an <c>AppInstanceUserEndpoint</c>.
    /// Supported values:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>ACTIVE</c>: The <c>AppInstanceUserEndpoint</c> is active and able to receive messages.
    /// When <c>ACTIVE</c>, the <c>EndpointStatusReason</c> remains empty.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>INACTIVE</c>: The <c>AppInstanceUserEndpoint</c> is inactive and can't receive
    /// message. When INACTIVE, the corresponding reason will be conveyed through EndpointStatusReason.
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
    public partial class EndpointState
    {
        private EndpointStatus _status;
        private EndpointStatusReason _statusReason;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Enum that indicates the Status of an <c>AppInstanceUserEndpoint</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EndpointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the <c>EndpointStatus</c>.
        /// </para>
        /// </summary>
        public EndpointStatusReason StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}