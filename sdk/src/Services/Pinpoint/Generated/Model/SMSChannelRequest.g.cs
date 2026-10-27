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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the status and settings of the SMS channel for an application.
    /// </summary>
    public partial class SMSChannelRequest
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether to enable the SMS channel for the application.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property SenderId. 
        /// <para>
        /// The identity that you want to display on recipients' devices when they receive messages
        /// from the SMS channel.
        /// </para>
        /// </summary>
        public string SenderId { get; set; }

        /// <summary>
        /// Checks to see if the SenderId property is set.
        /// </summary>
        internal bool IsSetSenderId() => this.SenderId != null;

        /// <summary>
        /// Gets and sets the property ShortCode. 
        /// <para>
        /// The registered short code that you want to use when you send messages through the
        /// SMS channel.
        /// </para>
        /// </summary>
        public string ShortCode { get; set; }

        /// <summary>
        /// Checks to see if the ShortCode property is set.
        /// </summary>
        internal bool IsSetShortCode() => this.ShortCode != null;
    }
}
