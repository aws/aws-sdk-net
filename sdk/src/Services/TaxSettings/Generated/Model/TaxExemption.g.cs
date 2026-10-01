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
    /// The tax exemption.
    /// </summary>
    public partial class TaxExemption
    {
        /// <summary>
        /// Gets and sets the property Authority. 
        /// <para>
        /// The address domain associate with tax exemption. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Authority Authority { get; set; }

        /// <summary>
        /// Checks to see if the Authority property is set.
        /// </summary>
        internal bool IsSetAuthority() => this.Authority != null;

        /// <summary>
        /// Gets and sets the property EffectiveDate. 
        /// <para>
        /// The tax exemption effective date. 
        /// </para>
        /// </summary>
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveDate property is set.
        /// </summary>
        internal bool IsSetEffectiveDate() => this.EffectiveDate.HasValue;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The tax exemption expiration date. 
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The tax exemption status. 
        /// </para>
        /// </summary>
        public EntityExemptionAccountStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SystemEffectiveDate. 
        /// <para>
        /// The tax exemption recording time in the <c>TaxSettings</c> system. 
        /// </para>
        /// </summary>
        public DateTime? SystemEffectiveDate { get; set; }

        /// <summary>
        /// Checks to see if the SystemEffectiveDate property is set.
        /// </summary>
        internal bool IsSetSystemEffectiveDate() => this.SystemEffectiveDate.HasValue;

        /// <summary>
        /// Gets and sets the property TaxExemptionType. 
        /// <para>
        /// The tax exemption type. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TaxExemptionType TaxExemptionType { get; set; }

        /// <summary>
        /// Checks to see if the TaxExemptionType property is set.
        /// </summary>
        internal bool IsSetTaxExemptionType() => this.TaxExemptionType != null;
    }
}
