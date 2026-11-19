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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Used to associate a configuration set with a dedicated IP pool.
    /// </summary>
    public partial class DeliveryOptions
    {
        /// <summary>
        /// Gets and sets the property MaxDeliverySeconds. 
        /// <para>
        /// The maximum amount of time, in seconds, that Amazon SES API v2 will attempt delivery
        /// of email. If specified, the value must greater than or equal to 300 seconds (5 minutes)
        /// and less than or equal to 50400 seconds (840 minutes). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 300, Max = 50400)]
        public long? MaxDeliverySeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaxDeliverySeconds property is set.
        /// </summary>
        internal bool IsSetMaxDeliverySeconds() => this.MaxDeliverySeconds.HasValue;

        /// <summary>
        /// Gets and sets the property SendingPoolName. 
        /// <para>
        /// The name of the dedicated IP pool to associate with the configuration set.
        /// </para>
        /// </summary>
        public string SendingPoolName { get; set; }

        /// <summary>
        /// Checks to see if the SendingPoolName property is set.
        /// </summary>
        internal bool IsSetSendingPoolName() => this.SendingPoolName != null;

        /// <summary>
        /// Gets and sets the property SharedPoolDeliveryMode. 
        /// <para>
        /// The shared pool delivery mode for email that you send with the configuration set from
        /// shared IP addresses. This setting overrides the shared pool delivery mode of your
        /// account. Can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>GLOBAL</c> – Amazon SES delivers from your sending Region first and, when it improves
        /// your deliverability, also uses Amazon SES shared IP addresses with established sending
        /// history in other Amazon Web Services Regions within the same Amazon Web Services partition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGIONAL</c> – Amazon SES delivers your email only from shared IP addresses in
        /// your sending Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCOUNT</c> – The configuration set uses the shared pool delivery mode of your
        /// account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a value, the configuration set uses the shared pool delivery
        /// mode of your account.
        /// </para>
        /// </summary>
        public SharedPoolDeliveryMode SharedPoolDeliveryMode { get; set; }

        /// <summary>
        /// Checks to see if the SharedPoolDeliveryMode property is set.
        /// </summary>
        internal bool IsSetSharedPoolDeliveryMode() => this.SharedPoolDeliveryMode != null;

        /// <summary>
        /// Gets and sets the property TlsPolicy. 
        /// <para>
        /// Specifies whether messages that use the configuration set are required to use Transport
        /// Layer Security (TLS). If the value is <c>REQUIRE</c>, messages are only delivered
        /// if a TLS connection can be established. If the value is <c>OPTIONAL</c>, messages
        /// can be delivered in plain text if a TLS connection can't be established.
        /// </para>
        /// </summary>
        public TlsPolicy TlsPolicy { get; set; }

        /// <summary>
        /// Checks to see if the TlsPolicy property is set.
        /// </summary>
        internal bool IsSetTlsPolicy() => this.TlsPolicy != null;
    }
}
