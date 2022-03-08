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
    /// Container for the parameters to the DeletePermissionGroup operation.
    /// Deletes a permission group. This action is irreversible.
    /// </summary>
    public partial class DeletePermissionGroupRequest : AmazonFinSpaceDataRequest
    {
        private string _clientToken;
        private string _permissionGroupId;

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
        /// Gets and sets the property PermissionGroupId. 
        /// <para>
        /// The unique identifier for the permission group that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=26)]
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