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
    /// Container for the parameters to the CancelTimeOff operation. Cancels a time off request.
    /// <para> Cancelling a <c>CANCELLED</c> request succeeds without a change. Returns <c>ConflictException</c>
    /// if the request is <c>PENDING</c>, which means Connect Customer is still processing
    /// the request asynchronously. Wait until <c>GetTimeOff</c> returns a status other than
    /// <c>PENDING</c>, and then retry. </para>
    /// </summary>
    public partial class CancelTimeOffRequest : AmazonConnectSchedulingRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description recorded with the cancellation. It replaces the description of the time
        /// off request. If you omit it, the request's description is removed.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. This can be the ID or the ARN of
        /// the instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 250)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property TimeOffId. 
        /// <para>
        /// The unique identifier of the time off request to cancel. If the time off request doesn't
        /// belong to <c>UserId</c>, the operation returns <c>ResourceNotFoundException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string TimeOffId { get; set; }

        /// <summary>
        /// Checks to see if the TimeOffId property is set.
        /// </summary>
        internal bool IsSetTimeOffId() => this.TimeOffId != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user who the time off request belongs to. This can be the ID
        /// or the ARN of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
