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
    /// Contains information about the phone configuration settings for a user.
    /// </summary>
    public partial class UserPhoneConfig
    {
        /// <summary>
        /// Gets and sets the property AfterContactWorkTimeLimit. 
        /// <para>
        /// The After Call Work (ACW) timeout setting, in seconds. This parameter has a minimum
        /// value of 0 and a maximum value of 2,000,000 seconds (24 days). Enter 0 if you don't
        /// want to allocate a specific amount of ACW time. It essentially means an indefinite
        /// amount of time. When the conversation ends, ACW starts; the agent must choose Close
        /// contact to end ACW. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When returned by a <c>SearchUsers</c> call, <c>AfterContactWorkTimeLimit</c> is returned
        /// in milliseconds. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AfterContactWorkTimeLimit { get; set; }

        /// <summary>
        /// Checks to see if the AfterContactWorkTimeLimit property is set.
        /// </summary>
        internal bool IsSetAfterContactWorkTimeLimit() => this.AfterContactWorkTimeLimit.HasValue;

        /// <summary>
        /// Gets and sets the property AutoAccept. 
        /// <para>
        /// The Auto accept setting.
        /// </para>
        /// </summary>
        public bool? AutoAccept { get; set; }

        /// <summary>
        /// Checks to see if the AutoAccept property is set.
        /// </summary>
        internal bool IsSetAutoAccept() => this.AutoAccept.HasValue;

        /// <summary>
        /// Gets and sets the property DeskPhoneNumber. 
        /// <para>
        /// The phone number for the user's desk phone.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string DeskPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the DeskPhoneNumber property is set.
        /// </summary>
        internal bool IsSetDeskPhoneNumber() => this.DeskPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property PersistentConnection. 
        /// <para>
        /// The persistent connection setting for the user.
        /// </para>
        /// </summary>
        public bool? PersistentConnection { get; set; }

        /// <summary>
        /// Checks to see if the PersistentConnection property is set.
        /// </summary>
        internal bool IsSetPersistentConnection() => this.PersistentConnection.HasValue;

        /// <summary>
        /// Gets and sets the property PhoneType. 
        /// <para>
        /// The phone type.
        /// </para>
        /// </summary>
        public PhoneType PhoneType { get; set; }

        /// <summary>
        /// Checks to see if the PhoneType property is set.
        /// </summary>
        internal bool IsSetPhoneType() => this.PhoneType != null;
    }
}
