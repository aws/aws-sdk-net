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

namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePermissionGroup operation.
    /// Creates a group of permissions for various actions that a user can perform in FinSpace.
    /// </summary>
    public partial class CreatePermissionGroupRequest : AmazonFinSpaceDataRequest
    {
        private List<string> _applicationPermissions = new List<string>();
        private string _clientToken;
        private string _description;
        private string _name;

        /// <summary>
        /// Gets and sets the property ApplicationPermissions. 
        /// <para>
        /// The option to indicate FinSpace application permissions that are granted to a specific
        /// group.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreateDataset</code> – Group members can create new datasets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ManageClusters</code> – Group members can manage Apache Spark clusters from
        /// FinSpace notebooks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ManageUsersAndGroups</code> – Group members can manage users and permission
        /// groups.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ManageAttributeSets</code> – Group members can manage attribute sets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ViewAuditData</code> – Group members can view audit data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AccessNotebooks</code> – Group members will have access to FinSpace notebooks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GetTemporaryCredentials</code> – Group members can get temporary API credentials.
        /// </para>
        ///  </li> </ul>
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
            return this._applicationPermissions != null && this._applicationPermissions.Count > 0; 
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
        [AWSProperty(Min=1, Max=4000)]
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
        [AWSProperty(Required=true, Min=1, Max=255)]
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