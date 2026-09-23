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
    /// Settings that allow management of telephony permissions for an Amazon Chime user,
    /// such as inbound and outbound calling and text messaging.
    /// </summary>
    public partial class TelephonySettings
    {
        /// <summary>
        /// Gets and sets the property InboundCalling. 
        /// <para>
        /// Allows or denies inbound calling.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? InboundCalling { get; set; }

        /// <summary>
        /// Checks to see if the InboundCalling property is set.
        /// </summary>
        internal bool IsSetInboundCalling() => this.InboundCalling.HasValue;

        /// <summary>
        /// Gets and sets the property OutboundCalling. 
        /// <para>
        /// Allows or denies outbound calling.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? OutboundCalling { get; set; }

        /// <summary>
        /// Checks to see if the OutboundCalling property is set.
        /// </summary>
        internal bool IsSetOutboundCalling() => this.OutboundCalling.HasValue;

        /// <summary>
        /// Gets and sets the property SMS. 
        /// <para>
        /// Allows or denies SMS messaging.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? SMS { get; set; }

        /// <summary>
        /// Checks to see if the SMS property is set.
        /// </summary>
        internal bool IsSetSMS() => this.SMS.HasValue;
    }
}
