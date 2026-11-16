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

namespace Amazon.ConnectScheduling.Model
{
    /// <summary>
    /// Information about the identity that performed an action on a time off request: a Connect
    /// Customer user or an IAM or AWS STS identity. Exactly one member is set.
    /// </summary>
    public partial class ActorInfo
    {
        /// <summary>
        /// Gets and sets the property AWSIdentityArn. 
        /// <para>
        /// The IAM or AWS STS ARN of the identity that performed the action. Present when that
        /// identity is not a Connect Customer user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string AWSIdentityArn { get; set; }

        /// <summary>
        /// Checks to see if the AWSIdentityArn property is set.
        /// </summary>
        internal bool IsSetAWSIdentityArn() => this.AWSIdentityArn != null;

        /// <summary>
        /// Gets and sets the property ConnectUserArn. 
        /// <para>
        /// The ARN of the Connect Customer user who performed the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string ConnectUserArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectUserArn property is set.
        /// </summary>
        internal bool IsSetConnectUserArn() => this.ConnectUserArn != null;
    }
}
