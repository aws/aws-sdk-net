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
    /// Additional tax information associated with your TRN in Belgium.
    /// </summary>
    public partial class BelgiumAdditionalInfo
    {
        /// <summary>
        /// Gets and sets the property IsMercuriusBoxEnabled. 
        /// <para>
        /// Indicates whether the Mercurius e-invoicing box is enabled for business-to-government
        /// (B2G) invoicing in Belgium.
        /// </para>
        /// </summary>
        public bool? IsMercuriusBoxEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsMercuriusBoxEnabled property is set.
        /// </summary>
        internal bool IsSetIsMercuriusBoxEnabled() => this.IsMercuriusBoxEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property PeppolId. 
        /// <para>
        /// The Peppol ID for electronic invoicing in Belgium.
        /// </para>
        /// </summary>
        public string PeppolId { get; set; }

        /// <summary>
        /// Checks to see if the PeppolId property is set.
        /// </summary>
        internal bool IsSetPeppolId() => this.PeppolId != null;
    }
}
