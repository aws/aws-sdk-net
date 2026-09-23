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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// A phone number for which an order has been placed.
    /// </summary>
    public partial class OrderedPhoneNumber
    {
        /// <summary>
        /// Gets and sets the property E164PhoneNumber. 
        /// <para>
        /// The phone number, in E.164 format.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string E164PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the E164PhoneNumber property is set.
        /// </summary>
        internal bool IsSetE164PhoneNumber() => this.E164PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The phone number status.
        /// </para>
        /// </summary>
        public OrderedPhoneNumberStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
