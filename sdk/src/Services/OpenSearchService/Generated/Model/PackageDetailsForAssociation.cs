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
    /// Details of a package that is associated with a domain.
    /// </summary>
    public partial class PackageDetailsForAssociation
    {
        private PackageAssociationConfiguration _associationConfiguration;
        private string _packageID;
        private List<string> _prerequisitePackageIDList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AssociationConfiguration. 
        /// <para>
        /// The configuration parameters for associating the package with a domain.
        /// </para>
        /// </summary>
        public PackageAssociationConfiguration AssociationConfiguration
        {
            get { return this._associationConfiguration; }
            set { this._associationConfiguration = value; }
        }

        // Check to see if AssociationConfiguration property is set
        internal bool IsSetAssociationConfiguration()
        {
            return this._associationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PackageID. 
        /// <para>
        /// Internal ID of the package that you want to associate with a domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PackageID
        {
            get { return this._packageID; }
            set { this._packageID = value; }
        }

        // Check to see if PackageID property is set
        internal bool IsSetPackageID()
        {
            return this._packageID != null;
        }

        /// <summary>
        /// Gets and sets the property PrerequisitePackageIDList. 
        /// <para>
        /// List of package IDs that must be linked to the domain before or simultaneously with
        /// the package association.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PrerequisitePackageIDList
        {
            get { return this._prerequisitePackageIDList; }
            set { this._prerequisitePackageIDList = value; }
        }

        // Check to see if PrerequisitePackageIDList property is set
        internal bool IsSetPrerequisitePackageIDList()
        {
            return this._prerequisitePackageIDList != null && (this._prerequisitePackageIDList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}