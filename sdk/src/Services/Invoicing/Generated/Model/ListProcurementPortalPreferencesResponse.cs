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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// This is the response object from the ListProcurementPortalPreferences operation.
    /// </summary>
    public partial class ListProcurementPortalPreferencesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProcurementPortalPreferenceSummary> _procurementPortalPreferences = AWSConfigs.InitializeCollections ? new List<ProcurementPortalPreferenceSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next set of results, or null if there are no more
        /// results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property ProcurementPortalPreferences. 
        /// <para>
        /// The list of procurement portal preferences associated with the Amazon Web Services
        /// account.
        /// </para>
        /// </summary>
        public List<ProcurementPortalPreferenceSummary> ProcurementPortalPreferences
        {
            get { return this._procurementPortalPreferences; }
            set { this._procurementPortalPreferences = value; }
        }

        // Check to see if ProcurementPortalPreferences property is set
        internal bool IsSetProcurementPortalPreferences()
        {
            return this._procurementPortalPreferences != null && (this._procurementPortalPreferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}