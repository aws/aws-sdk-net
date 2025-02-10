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
    /// This is the response object from the GetTaxExemptionTypes operation.
    /// </summary>
    public partial class GetTaxExemptionTypesResponse : AmazonWebServiceResponse
    {
        private List<TaxExemptionType> _taxExemptionTypes = AWSConfigs.InitializeCollections ? new List<TaxExemptionType>() : null;

        /// <summary>
        /// Gets and sets the property TaxExemptionTypes. 
        /// <para>
        /// The supported types of tax exemptions. 
        /// </para>
        /// </summary>
        public List<TaxExemptionType> TaxExemptionTypes
        {
            get { return this._taxExemptionTypes; }
            set { this._taxExemptionTypes = value; }
        }

        // Check to see if TaxExemptionTypes property is set
        internal bool IsSetTaxExemptionTypes()
        {
            return this._taxExemptionTypes != null && (this._taxExemptionTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}