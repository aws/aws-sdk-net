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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Defines the conditions that will keep an agreement created from this offer valid.
    /// </summary>
    public partial class ValidityTerm
    {
        private string _agreementDuration;
        private DateTime? _agreementEndDate;
        private DateTime? _agreementStartDate;
        private string _type;

        /// <summary>
        /// Gets and sets the property AgreementDuration. 
        /// <para>
        /// Defines the duration that the agreement remains active. If <c>AgreementStartDate</c>
        /// isn’t provided, the agreement duration is relative to the agreement signature time.
        /// The duration is represented in the ISO_8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string AgreementDuration
        {
            get { return this._agreementDuration; }
            set { this._agreementDuration = value; }
        }

        // Check to see if AgreementDuration property is set
        internal bool IsSetAgreementDuration()
        {
            return this._agreementDuration != null;
        }

        /// <summary>
        /// Gets and sets the property AgreementEndDate. 
        /// <para>
        /// Defines the date when the agreement ends. The agreement ends at 23:59:59.999 UTC on
        /// the date provided. If <c>AgreementEndDate</c> isn’t provided, the agreement end date
        /// is determined by the validity of individual terms.
        /// </para>
        /// </summary>
        public DateTime? AgreementEndDate
        {
            get { return this._agreementEndDate; }
            set { this._agreementEndDate = value; }
        }

        // Check to see if AgreementEndDate property is set
        internal bool IsSetAgreementEndDate()
        {
            return this._agreementEndDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AgreementStartDate. 
        /// <para>
        /// Defines the date when agreement starts. The agreement starts at 00:00:00.000 UTC on
        /// the date provided. If <c>AgreementStartDate</c> isn’t provided, the agreement start
        /// date is determined based on agreement signature time.
        /// </para>
        /// </summary>
        public DateTime? AgreementStartDate
        {
            get { return this._agreementStartDate; }
            set { this._agreementStartDate = value; }
        }

        // Check to see if AgreementStartDate property is set
        internal bool IsSetAgreementStartDate()
        {
            return this._agreementStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Category of the term being updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}