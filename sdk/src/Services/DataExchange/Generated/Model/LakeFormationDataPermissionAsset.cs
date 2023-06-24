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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// The AWS Lake Formation data permission asset.
    /// </summary>
    public partial class LakeFormationDataPermissionAsset
    {
        private LakeFormationDataPermissionDetails _lakeFormationDataPermissionDetails;
        private LakeFormationDataPermissionType _lakeFormationDataPermissionType;
        private List<string> _permissions = new List<string>();
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property LakeFormationDataPermissionDetails. 
        /// <para>
        /// Details about the AWS Lake Formation data permission.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LakeFormationDataPermissionDetails LakeFormationDataPermissionDetails
        {
            get { return this._lakeFormationDataPermissionDetails; }
            set { this._lakeFormationDataPermissionDetails = value; }
        }

        // Check to see if LakeFormationDataPermissionDetails property is set
        internal bool IsSetLakeFormationDataPermissionDetails()
        {
            return this._lakeFormationDataPermissionDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LakeFormationDataPermissionType. 
        /// <para>
        /// The data permission type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LakeFormationDataPermissionType LakeFormationDataPermissionType
        {
            get { return this._lakeFormationDataPermissionType; }
            set { this._lakeFormationDataPermissionType = value; }
        }

        // Check to see if LakeFormationDataPermissionType property is set
        internal bool IsSetLakeFormationDataPermissionType()
        {
            return this._lakeFormationDataPermissionType != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The permissions granted to the subscribers on the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && this._permissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role's ARN that allows AWS Data Exchange to assume the role and grant and
        /// revoke permissions to AWS Lake Formation data permissions.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}