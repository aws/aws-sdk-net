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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// An entry that appears when a <c>KeyRegistration</c> update to Quick Sight fails.
    /// </summary>
    public partial class FailedKeyRegistrationEntry
    {
        /// <summary>
        /// Gets and sets the property KeyArn. 
        /// <para>
        /// The ARN of the KMS key that failed to update.
        /// </para>
        /// </summary>
        public string KeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KeyArn property is set.
        /// </summary>
        internal bool IsSetKeyArn() => this.KeyArn != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that provides information about why a <c>FailedKeyRegistrationEntry</c>
        /// error occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property SenderFault. 
        /// <para>
        /// A boolean that indicates whether a <c>FailedKeyRegistrationEntry</c> resulted from
        /// user error. If the value of this property is <c>True</c>, the error was caused by
        /// user error. If the value of this property is <c>False</c>, the error occurred on the
        /// backend. If your job continues fail and with a <c>False</c> <c>SenderFault</c> value,
        /// contact Amazon Web Services Support.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? SenderFault { get; set; }

        /// <summary>
        /// Checks to see if the SenderFault property is set.
        /// </summary>
        internal bool IsSetSenderFault() => this.SenderFault.HasValue;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP status of a <c>FailedKeyRegistrationEntry</c> error.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode.HasValue;
    }
}
