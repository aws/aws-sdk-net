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

namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// Contains additional tax information associated with your Tax Registration Number (TRN)
    /// in New Zealand, such as the Peppol ID used for electronic invoicing (e-invoicing).
    /// </summary>
    public partial class NewZealandAdditionalInfo
    {
        /// <summary>
        /// Gets and sets the property PeppolId. 
        /// <para>
        /// The Peppol ID used for electronic invoicing (e-invoicing) in New Zealand. Must be
        /// your 13-digit New Zealand Business Number (NZBN), without the <c>0088</c> scheme prefix.
        /// Only accepted when the <c>sector</c> is <c>Government</c>.
        /// </para>
        /// </summary>
        public string PeppolId { get; set; }

        /// <summary>
        /// Checks to see if the PeppolId property is set.
        /// </summary>
        internal bool IsSetPeppolId() => this.PeppolId != null;
    }
}
