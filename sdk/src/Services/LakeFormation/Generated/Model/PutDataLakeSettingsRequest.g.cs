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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the PutDataLakeSettings operation. Sets the list of
    /// data lake administrators who have admin privileges on all resources managed by Lake
    /// Formation. For more information on admin privileges, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/lake-formation-permissions.html">Granting
    /// Lake Formation Permissions</a>. <para> This API replaces the current list of data
    /// lake admins with the new list being passed. To add an admin, fetch the current list
    /// and add the new admin to that list and pass that list in this API. </para>
    /// </summary>
    public partial class PutDataLakeSettingsRequest : AmazonLakeFormationRequest
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The identifier for the Data Catalog. By default, the account ID. The Data Catalog
        /// is the persistent metadata store. It contains database definitions, table definitions,
        /// and other control information to manage your Lake Formation environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property DataLakeSettings. 
        /// <para>
        /// A structure representing a list of Lake Formation principals designated as data lake
        /// administrators.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataLakeSettings DataLakeSettings { get; set; }

        /// <summary>
        /// Checks to see if the DataLakeSettings property is set.
        /// </summary>
        internal bool IsSetDataLakeSettings() => this.DataLakeSettings != null;
    }
}
