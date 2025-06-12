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
    /// Required information to verify your TRN.
    /// </summary>
    public partial class VerificationDetails
    {
        private string _dateOfBirth;
        private List<TaxRegistrationDocument> _taxRegistrationDocuments = AWSConfigs.InitializeCollections ? new List<TaxRegistrationDocument>() : null;

        /// <summary>
        /// Gets and sets the property DateOfBirth. 
        /// <para>
        /// Date of birth to verify your submitted TRN. Use the <c>YYYY-MM-DD</c> format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string DateOfBirth
        {
            get { return this._dateOfBirth; }
            set { this._dateOfBirth = value; }
        }

        // Check to see if DateOfBirth property is set
        internal bool IsSetDateOfBirth()
        {
            return this._dateOfBirth != null;
        }

        /// <summary>
        /// Gets and sets the property TaxRegistrationDocuments. 
        /// <para>
        /// The tax registration document, which is required for specific countries such as Bangladesh,
        /// Kenya, South Korea and Spain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<TaxRegistrationDocument> TaxRegistrationDocuments
        {
            get { return this._taxRegistrationDocuments; }
            set { this._taxRegistrationDocuments = value; }
        }

        // Check to see if TaxRegistrationDocuments property is set
        internal bool IsSetTaxRegistrationDocuments()
        {
            return this._taxRegistrationDocuments != null && (this._taxRegistrationDocuments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}