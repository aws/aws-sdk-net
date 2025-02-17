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
    /// This is the response object from the ListSupplementalTaxRegistrations operation.
    /// </summary>
    public partial class ListSupplementalTaxRegistrationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SupplementalTaxRegistration> _taxRegistrations = AWSConfigs.InitializeCollections ? new List<SupplementalTaxRegistration>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token to retrieve the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TaxRegistrations. 
        /// <para>
        ///  The list of supplemental tax registrations. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SupplementalTaxRegistration> TaxRegistrations
        {
            get { return this._taxRegistrations; }
            set { this._taxRegistrations = value; }
        }

        // Check to see if TaxRegistrations property is set
        internal bool IsSetTaxRegistrations()
        {
            return this._taxRegistrations != null && (this._taxRegistrations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}