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
    /// Container for the parameters to the PutSupplementalTaxRegistration operation.
    /// Stores supplemental tax registration for a single account.
    /// </summary>
    public partial class PutSupplementalTaxRegistrationRequest : AmazonTaxSettingsRequest
    {
        private SupplementalTaxRegistrationEntry _taxRegistrationEntry;

        /// <summary>
        /// Gets and sets the property TaxRegistrationEntry. 
        /// <para>
        ///  The supplemental TRN information that will be stored for the caller account ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public SupplementalTaxRegistrationEntry TaxRegistrationEntry
        {
            get { return this._taxRegistrationEntry; }
            set { this._taxRegistrationEntry = value; }
        }

        // Check to see if TaxRegistrationEntry property is set
        internal bool IsSetTaxRegistrationEntry()
        {
            return this._taxRegistrationEntry != null;
        }

    }
}