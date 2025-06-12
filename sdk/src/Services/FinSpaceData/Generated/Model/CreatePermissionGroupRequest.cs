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
    /// Container for the parameters to the CreatePermissionGroup operation.
    /// Creates a group of permissions for various actions that a user can perform in FinSpace.
    /// </summary>
    public partial class CreatePermissionGroupRequest : AmazonFinSpaceDataRequest
    {
        private List<string> _applicationPermissions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientToken;
        private string _description;
        private string _name;

        /// <summary>
        /// Gets and sets the property ApplicationPermissions. 
        /// <para>
        /// The option to indicate FinSpace application permissions that are granted to a specific
        /// group.
        /// </para>
        ///  <important> 
        /// <para>
        /// When assigning application permissions, be aware that the permission <c>ManageUsersAndGroups</c>
        /// allows users to grant themselves or others access to any functionality in their FinSpace
        /// environment's application. It should only be granted to trusted users.
        /// </para>
        ///  </important> <ul> <li> 
        /// <para>
        ///  <c>CreateDataset</c> – Group members can create new datasets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ManageClusters</c> – Group members can manage Apache Spark clusters from FinSpace
        /// notebooks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ManageUsersAndGroups</c> – Group members can manage users and permission groups.
        /// This is a privileged permission that allows users to grant themselves or others access
        /// to any functionality in the application. It should only be granted to trusted users.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ManageAttributeSets</c> – Group members can manage attribute sets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ViewAuditData</c> – Group members can view audit data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccessNotebooks</c> – Group members will have access to FinSpace notebooks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GetTemporaryCredentials</c> – Group members can get temporary API credentials.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ApplicationPermissions
        {
            get { return this._applicationPermissions; }
            set { this._applicationPermissions = value; }
        }

        // Check to see if ApplicationPermissions property is set
        internal bool IsSetApplicationPermissions()
        {
            return this._applicationPermissions != null && (this._applicationPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures idempotency. This token expires in 10 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description for the permission group.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the permission group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}