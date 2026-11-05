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
    /// The status of the phone number.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>CLAIMED</c> means the previous <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ClaimPhoneNumber.html">ClaimPhoneNumber</a>
    /// or <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_UpdatePhoneNumber.html">UpdatePhoneNumber</a>
    /// operation succeeded.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>IN_PROGRESS</c> means a <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ClaimPhoneNumber.html">ClaimPhoneNumber</a>,
    /// <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_UpdatePhoneNumber.html">UpdatePhoneNumber</a>,
    /// or <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_UpdatePhoneNumberMetadata.html">UpdatePhoneNumberMetadata</a>
    /// operation is still in progress and has not yet completed. You can call <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribePhoneNumber.html">DescribePhoneNumber</a>
    /// at a later time to verify if the previous operation has completed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>FAILED</c> indicates that the previous <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ClaimPhoneNumber.html">ClaimPhoneNumber</a>
    /// or <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_UpdatePhoneNumber.html">UpdatePhoneNumber</a>
    /// operation has failed. It will include a message indicating the failure reason. A common
    /// reason for a failure may be that the <c>TargetArn</c> value you are claiming or updating
    /// a phone number to has reached its limit of total claimed numbers. If you received
    /// a <c>FAILED</c> status from a <c>ClaimPhoneNumber</c> API call, you have one day to
    /// retry claiming the phone number before the number is released back to the inventory
    /// for other customers to claim.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PhoneNumberStatus
    {
        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The status message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public PhoneNumberWorkflowStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
