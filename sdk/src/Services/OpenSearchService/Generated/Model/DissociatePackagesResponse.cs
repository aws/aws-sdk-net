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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// This is the response object from the DissociatePackages operation.
    /// </summary>
    public partial class DissociatePackagesResponse : AmazonWebServiceResponse
    {
        private List<DomainPackageDetails> _domainPackageDetailsList = AWSConfigs.InitializeCollections ? new List<DomainPackageDetails>() : null;

        /// <summary>
        /// Gets and sets the property DomainPackageDetailsList. 
        /// <para>
        /// A list of package details for the packages that were dissociated from the domain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DomainPackageDetails> DomainPackageDetailsList
        {
            get { return this._domainPackageDetailsList; }
            set { this._domainPackageDetailsList = value; }
        }

        // Check to see if DomainPackageDetailsList property is set
        internal bool IsSetDomainPackageDetailsList()
        {
            return this._domainPackageDetailsList != null && (this._domainPackageDetailsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}