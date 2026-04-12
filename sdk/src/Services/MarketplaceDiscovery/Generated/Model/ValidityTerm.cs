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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Defines a validity term that specifies the duration or date range of an agreement.
    /// </summary>
    public partial class ValidityTerm
    {
        private string _agreementDuration;
        private DateTime? _agreementEndDate;
        private DateTime? _agreementStartDate;
        private string _id;
        private TermType _type;

        /// <summary>
        /// Gets and sets the property AgreementDuration. 
        /// <para>
        /// The duration of the agreement, in ISO 8601 format.
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
        /// The date when the agreement ends.
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
        /// The date when the agreement starts.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the term.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The category of the term.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TermType Type
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