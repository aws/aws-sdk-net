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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
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
        private Authority _authority;
        private DateTime? _effectiveDate;
        private DateTime? _expirationDate;
        private EntityExemptionAccountStatus _status;
        private DateTime? _systemEffectiveDate;
        private TaxExemptionType _taxExemptionType;

        /// <summary>
        /// Gets and sets the property Authority. 
        /// <para>
        /// The address domain associate with tax exemption. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Authority Authority
        {
            get { return this._authority; }
            set { this._authority = value; }
        }

        // Check to see if Authority property is set
        internal bool IsSetAuthority()
        {
            return this._authority != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveDate. 
        /// <para>
        /// The tax exemption effective date. 
        /// </para>
        /// </summary>
        public DateTime? EffectiveDate
        {
            get { return this._effectiveDate; }
            set { this._effectiveDate = value; }
        }

        // Check to see if EffectiveDate property is set
        internal bool IsSetEffectiveDate()
        {
            return this._effectiveDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The tax exemption expiration date. 
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate
        {
            get { return this._expirationDate; }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The tax exemption status. 
        /// </para>
        /// </summary>
        public EntityExemptionAccountStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SystemEffectiveDate. 
        /// <para>
        /// The tax exemption recording time in the <c>TaxSettings</c> system. 
        /// </para>
        /// </summary>
        public DateTime? SystemEffectiveDate
        {
            get { return this._systemEffectiveDate; }
            set { this._systemEffectiveDate = value; }
        }

        // Check to see if SystemEffectiveDate property is set
        internal bool IsSetSystemEffectiveDate()
        {
            return this._systemEffectiveDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaxExemptionType. 
        /// <para>
        /// The tax exemption type. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TaxExemptionType TaxExemptionType
        {
            get { return this._taxExemptionType; }
            set { this._taxExemptionType = value; }
        }

        // Check to see if TaxExemptionType property is set
        internal bool IsSetTaxExemptionType()
        {
            return this._taxExemptionType != null;
        }

    }
}