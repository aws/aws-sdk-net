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
    /// This is the response object from the BatchGetTaxExemptions operation.
    /// </summary>
    public partial class BatchGetTaxExemptionsResponse : AmazonWebServiceResponse
    {
        private List<string> _failedAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, TaxExemptionDetails> _taxExemptionDetailsMap = AWSConfigs.InitializeCollections ? new Dictionary<string, TaxExemptionDetails>() : null;

        /// <summary>
        /// Gets and sets the property FailedAccounts. 
        /// <para>
        /// The list of accounts that failed to get tax exemptions. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailedAccounts
        {
            get { return this._failedAccounts; }
            set { this._failedAccounts = value; }
        }

        // Check to see if FailedAccounts property is set
        internal bool IsSetFailedAccounts()
        {
            return this._failedAccounts != null && (this._failedAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaxExemptionDetailsMap. 
        /// <para>
        /// The tax exemption details map of accountId and tax exemption details. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, TaxExemptionDetails> TaxExemptionDetailsMap
        {
            get { return this._taxExemptionDetailsMap; }
            set { this._taxExemptionDetailsMap = value; }
        }

        // Check to see if TaxExemptionDetailsMap property is set
        internal bool IsSetTaxExemptionDetailsMap()
        {
            return this._taxExemptionDetailsMap != null && (this._taxExemptionDetailsMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}