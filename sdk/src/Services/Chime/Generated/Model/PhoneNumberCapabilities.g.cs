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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The phone number capabilities for Amazon Chime Business Calling phone numbers, such
    /// as enabled inbound and outbound calling and text messaging.
    /// </summary>
    public partial class PhoneNumberCapabilities
    {
        /// <summary>
        /// Gets and sets the property InboundCall. 
        /// <para>
        /// Allows or denies inbound calling for the specified phone number.
        /// </para>
        /// </summary>
        public bool? InboundCall { get; set; }

        /// <summary>
        /// Checks to see if the InboundCall property is set.
        /// </summary>
        internal bool IsSetInboundCall() => this.InboundCall.HasValue;

        /// <summary>
        /// Gets and sets the property InboundMMS. 
        /// <para>
        /// Allows or denies inbound MMS messaging for the specified phone number.
        /// </para>
        /// </summary>
        public bool? InboundMMS { get; set; }

        /// <summary>
        /// Checks to see if the InboundMMS property is set.
        /// </summary>
        internal bool IsSetInboundMMS() => this.InboundMMS.HasValue;

        /// <summary>
        /// Gets and sets the property InboundSMS. 
        /// <para>
        /// Allows or denies inbound SMS messaging for the specified phone number.
        /// </para>
        /// </summary>
        public bool? InboundSMS { get; set; }

        /// <summary>
        /// Checks to see if the InboundSMS property is set.
        /// </summary>
        internal bool IsSetInboundSMS() => this.InboundSMS.HasValue;

        /// <summary>
        /// Gets and sets the property OutboundCall. 
        /// <para>
        /// Allows or denies outbound calling for the specified phone number.
        /// </para>
        /// </summary>
        public bool? OutboundCall { get; set; }

        /// <summary>
        /// Checks to see if the OutboundCall property is set.
        /// </summary>
        internal bool IsSetOutboundCall() => this.OutboundCall.HasValue;

        /// <summary>
        /// Gets and sets the property OutboundMMS. 
        /// <para>
        /// Allows or denies outbound MMS messaging for the specified phone number.
        /// </para>
        /// </summary>
        public bool? OutboundMMS { get; set; }

        /// <summary>
        /// Checks to see if the OutboundMMS property is set.
        /// </summary>
        internal bool IsSetOutboundMMS() => this.OutboundMMS.HasValue;

        /// <summary>
        /// Gets and sets the property OutboundSMS. 
        /// <para>
        /// Allows or denies outbound SMS messaging for the specified phone number.
        /// </para>
        /// </summary>
        public bool? OutboundSMS { get; set; }

        /// <summary>
        /// Checks to see if the OutboundSMS property is set.
        /// </summary>
        internal bool IsSetOutboundSMS() => this.OutboundSMS.HasValue;
    }
}
