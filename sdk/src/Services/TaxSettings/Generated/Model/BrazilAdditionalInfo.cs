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
    /// Additional tax information associated with your TRN in Brazil.
    /// </summary>
    public partial class BrazilAdditionalInfo
    {
        private string _ccmCode;
        private string _legalNatureCode;

        /// <summary>
        /// Gets and sets the property CcmCode. 
        /// <para>
        /// The Cadastro de Contribuintes Mobiliários (CCM) code for your TRN in Brazil. This
        /// only applies for a CNPJ tax type for the São Paulo municipality.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CcmCode
        {
            get { return this._ccmCode; }
            set { this._ccmCode = value; }
        }

        // Check to see if CcmCode property is set
        internal bool IsSetCcmCode()
        {
            return this._ccmCode != null;
        }

        /// <summary>
        /// Gets and sets the property LegalNatureCode. 
        /// <para>
        /// Legal nature of business, based on your TRN in Brazil. This only applies for a CNPJ
        /// tax type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string LegalNatureCode
        {
            get { return this._legalNatureCode; }
            set { this._legalNatureCode = value; }
        }

        // Check to see if LegalNatureCode property is set
        internal bool IsSetLegalNatureCode()
        {
            return this._legalNatureCode != null;
        }

    }
}