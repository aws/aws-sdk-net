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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
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
namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Permission group parameters for Dataset permissions.
    /// 
    ///  
    /// <para>
    /// Here is an example of how you could specify the <c>PermissionGroupParams</c>:
    /// </para>
    ///  
    /// <para>
    ///  <c> { "permissionGroupId": "0r6fCRtSTUk4XPfXQe3M0g", "datasetPermissions": [ {"permission":
    /// "ViewDatasetDetails"}, {"permission": "AddDatasetData"}, {"permission": "EditDatasetMetadata"},
    /// {"permission": "DeleteDataset"} ] } </c> 
    /// </para>
    /// </summary>
    public partial class PermissionGroupParams
    {
        private List<ResourcePermission> _datasetPermissions = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;
        private string _permissionGroupId;

        /// <summary>
        /// Gets and sets the property DatasetPermissions. 
        /// <para>
        /// List of resource permissions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourcePermission> DatasetPermissions
        {
            get { return this._datasetPermissions; }
            set { this._datasetPermissions = value; }
        }

        // Check to see if DatasetPermissions property is set
        internal bool IsSetDatasetPermissions()
        {
            return this._datasetPermissions != null && (this._datasetPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PermissionGroupId. 
        /// <para>
        /// The unique identifier for the <c>PermissionGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string PermissionGroupId
        {
            get { return this._permissionGroupId; }
            set { this._permissionGroupId = value; }
        }

        // Check to see if PermissionGroupId property is set
        internal bool IsSetPermissionGroupId()
        {
            return this._permissionGroupId != null;
        }

    }
}