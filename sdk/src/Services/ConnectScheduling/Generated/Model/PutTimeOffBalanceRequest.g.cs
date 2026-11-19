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
    /// Container for the parameters to the PutTimeOffBalance operation. Sets the time off
    /// balance for one user and shift activity. The value replaces the existing balance rather
    /// than adjusting it, so you can safely retry the call. This operation can't remove a
    /// balance. To remove one, upload a blank balance in the Connect Customer admin website.
    /// For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/upload-timeoff-balance.html">Import
    /// an agent's time off balance</a> in the <i>Connect Customer Administrator Guide</i>.
    /// </summary>
    public partial class PutTimeOffBalanceRequest : AmazonConnectSchedulingRequest
    {
        /// <summary>
        /// Gets and sets the property Balance. 
        /// <para>
        /// The new time off balance for the user and activity. It replaces the existing balance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Duration Balance { get; set; }

        /// <summary>
        /// Checks to see if the Balance property is set.
        /// </summary>
        internal bool IsSetBalance() => this.Balance != null;

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
        /// Gets and sets the property ShiftActivityId. 
        /// <para>
        /// The identifier of the shift activity that the balance applies to. This can be the
        /// ID or the ARN of the shift activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ShiftActivityId { get; set; }

        /// <summary>
        /// Checks to see if the ShiftActivityId property is set.
        /// </summary>
        internal bool IsSetShiftActivityId() => this.ShiftActivityId != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier of the user whose balance is being updated. This can be the ID or the
        /// ARN of the user.
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
