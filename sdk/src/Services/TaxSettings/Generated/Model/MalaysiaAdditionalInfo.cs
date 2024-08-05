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
    /// Additional tax information associated with your TRN in Malaysia.
    /// </summary>
    public partial class MalaysiaAdditionalInfo
    {
        private List<string> _serviceTaxCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ServiceTaxCodes. 
        /// <para>
        /// List of service tax codes for your TRN in Malaysia.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public List<string> ServiceTaxCodes
        {
            get { return this._serviceTaxCodes; }
            set { this._serviceTaxCodes = value; }
        }

        // Check to see if ServiceTaxCodes property is set
        internal bool IsSetServiceTaxCodes()
        {
            return this._serviceTaxCodes != null && (this._serviceTaxCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}