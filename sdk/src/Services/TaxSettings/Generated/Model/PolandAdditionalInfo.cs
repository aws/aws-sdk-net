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
    /// Additional tax information associated with your TRN in Poland.
    /// </summary>
    public partial class PolandAdditionalInfo
    {
        private string _individualRegistrationNumber;
        private bool? _isGroupVatEnabled;

        /// <summary>
        /// Gets and sets the property IndividualRegistrationNumber. 
        /// <para>
        ///  The individual tax registration number (NIP). Individual NIP is valid for other taxes
        /// excluding VAT purposes. 
        /// </para>
        /// </summary>
        public string IndividualRegistrationNumber
        {
            get { return this._individualRegistrationNumber; }
            set { this._individualRegistrationNumber = value; }
        }

        // Check to see if IndividualRegistrationNumber property is set
        internal bool IsSetIndividualRegistrationNumber()
        {
            return this._individualRegistrationNumber != null;
        }

        /// <summary>
        /// Gets and sets the property IsGroupVatEnabled. 
        /// <para>
        ///  True if your business is a member of a VAT group with a NIP active for VAT purposes.
        /// Otherwise, this is false. 
        /// </para>
        /// </summary>
        public bool? IsGroupVatEnabled
        {
            get { return this._isGroupVatEnabled; }
            set { this._isGroupVatEnabled = value; }
        }

        // Check to see if IsGroupVatEnabled property is set
        internal bool IsSetIsGroupVatEnabled()
        {
            return this._isGroupVatEnabled.HasValue; 
        }

    }
}