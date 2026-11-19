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
    /// The delivery attributes that apply to your Amazon SES account in the current Amazon
    /// Web Services Region.
    /// </summary>
    public partial class DeliveryAttributes
    {
        /// <summary>
        /// Gets and sets the property SharedPoolDeliveryMode. 
        /// <para>
        /// The shared pool delivery mode for your Amazon SES account in the current Amazon Web
        /// Services Region. This mode applies to email that you send from shared IP addresses.
        /// Can be one of the following:
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
        ///  </li> </ul> 
        /// <para>
        /// Accounts that start sending in a Region on or after the launch of Global Shared Delivery
        /// use <c>GLOBAL</c> in that Region.
        /// </para>
        /// </summary>
        public AccountSharedPoolDeliveryMode SharedPoolDeliveryMode { get; set; }

        /// <summary>
        /// Checks to see if the SharedPoolDeliveryMode property is set.
        /// </summary>
        internal bool IsSetSharedPoolDeliveryMode() => this.SharedPoolDeliveryMode != null;
    }
}
