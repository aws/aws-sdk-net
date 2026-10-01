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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the AssociatePackage operation. Associates a package
    /// with an Amazon OpenSearch Service domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
    /// packages for Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class AssociatePackageRequest : AmazonOpenSearchServiceRequest
    {
        /// <summary>
        /// Gets and sets the property AssociationConfiguration. 
        /// <para>
        /// The configuration for associating a package with an Amazon OpenSearch Service domain.
        /// </para>
        /// </summary>
        public PackageAssociationConfiguration AssociationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AssociationConfiguration property is set.
        /// </summary>
        internal bool IsSetAssociationConfiguration() => this.AssociationConfiguration != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Name of the domain to associate the package with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property PackageID. 
        /// <para>
        /// Internal ID of the package to associate with a domain. Use <c>DescribePackages</c>
        /// to find this value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PackageID { get; set; }

        /// <summary>
        /// Checks to see if the PackageID property is set.
        /// </summary>
        internal bool IsSetPackageID() => this.PackageID != null;

        /// <summary>
        /// Gets and sets the property PrerequisitePackageIDList. 
        /// <para>
        /// A list of package IDs that must be associated with the domain before the package specified
        /// in the request can be associated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PrerequisitePackageIDList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PrerequisitePackageIDList property is set.
        /// </summary>
        internal bool IsSetPrerequisitePackageIDList() => this.PrerequisitePackageIDList != null && (this.PrerequisitePackageIDList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
