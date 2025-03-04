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
    /// Additional tax information to specify for a TRN in Egypt.
    /// </summary>
    public partial class EgyptAdditionalInfo
    {
        private string _uniqueIdentificationNumber;
        private string _uniqueIdentificationNumberExpirationDate;

        /// <summary>
        /// Gets and sets the property UniqueIdentificationNumber. 
        /// <para>
        /// The unique identification number provided by the Egypt Tax Authority.
        /// </para>
        /// </summary>
        public string UniqueIdentificationNumber
        {
            get { return this._uniqueIdentificationNumber; }
            set { this._uniqueIdentificationNumber = value; }
        }

        // Check to see if UniqueIdentificationNumber property is set
        internal bool IsSetUniqueIdentificationNumber()
        {
            return this._uniqueIdentificationNumber != null;
        }

        /// <summary>
        /// Gets and sets the property UniqueIdentificationNumberExpirationDate. 
        /// <para>
        /// The expiration date of the unique identification number provided by the Egypt Tax
        /// Authority.
        /// </para>
        /// </summary>
        public string UniqueIdentificationNumberExpirationDate
        {
            get { return this._uniqueIdentificationNumberExpirationDate; }
            set { this._uniqueIdentificationNumberExpirationDate = value; }
        }

        // Check to see if UniqueIdentificationNumberExpirationDate property is set
        internal bool IsSetUniqueIdentificationNumberExpirationDate()
        {
            return this._uniqueIdentificationNumberExpirationDate != null;
        }

    }
}