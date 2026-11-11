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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateUserPhoneConfig operation. Updates the phone
    /// configuration settings for the specified user. <note> <para> We recommend using the
    /// <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_UpdateUserConfig.html">UpdateUserConfig</a>
    /// API, which supports additional functionality that is not available in the UpdateUserPhoneConfig
    /// API, such as voice enhancement settings and per-channel configuration for auto-accept
    /// and After Contact Work (ACW) timeouts. In comparison, the UpdateUserPhoneConfig API
    /// will always set the same ACW timeouts to all channels the user handles. </para> </note>
    /// </summary>
    public partial class UpdateUserPhoneConfigRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property PhoneConfig. 
        /// <para>
        /// Information about phone configuration settings for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UserPhoneConfig PhoneConfig { get; set; }

        /// <summary>
        /// Checks to see if the PhoneConfig property is set.
        /// </summary>
        internal bool IsSetPhoneConfig() => this.PhoneConfig != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
