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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Part of the X12 message structure. These are the functional group headers for the
    /// X12 EDI object.
    /// </summary>
    public partial class X12FunctionalGroupHeaders
    {
        /// <summary>
        /// Gets and sets the property ApplicationReceiverCode. 
        /// <para>
        /// A value representing the code used to identify the party receiving a message, at position
        /// GS-03.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 15)]
        public string ApplicationReceiverCode { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationReceiverCode property is set.
        /// </summary>
        internal bool IsSetApplicationReceiverCode() => this.ApplicationReceiverCode != null;

        /// <summary>
        /// Gets and sets the property ApplicationSenderCode. 
        /// <para>
        /// A value representing the code used to identify the party transmitting a message, at
        /// position GS-02.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 15)]
        public string ApplicationSenderCode { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationSenderCode property is set.
        /// </summary>
        internal bool IsSetApplicationSenderCode() => this.ApplicationSenderCode != null;

        /// <summary>
        /// Gets and sets the property ResponsibleAgencyCode. 
        /// <para>
        /// A code that identifies the issuer of the standard, at position GS-07.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public string ResponsibleAgencyCode { get; set; }

        /// <summary>
        /// Checks to see if the ResponsibleAgencyCode property is set.
        /// </summary>
        internal bool IsSetResponsibleAgencyCode() => this.ResponsibleAgencyCode != null;
    }
}
