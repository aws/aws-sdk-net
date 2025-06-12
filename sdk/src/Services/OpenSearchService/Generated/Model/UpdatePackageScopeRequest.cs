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
    /// Container for the parameters to the UpdatePackageScope operation.
    /// Updates the scope of a package. Scope of the package defines users who can view and
    /// associate a package.
    /// </summary>
    public partial class UpdatePackageScopeRequest : AmazonOpenSearchServiceRequest
    {
        private PackageScopeOperationEnum _operation;
        private string _packageID;
        private List<string> _packageUserList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        ///  The operation to perform on the package scope (e.g., add/remove/override users).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PackageScopeOperationEnum Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property PackageID. 
        /// <para>
        /// ID of the package whose scope is being updated.
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
        /// Gets and sets the property PackageUserList. 
        /// <para>
        ///  List of users to be added or removed from the package scope.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> PackageUserList
        {
            get { return this._packageUserList; }
            set { this._packageUserList = value; }
        }

        // Check to see if PackageUserList property is set
        internal bool IsSetPackageUserList()
        {
            return this._packageUserList != null && (this._packageUserList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}