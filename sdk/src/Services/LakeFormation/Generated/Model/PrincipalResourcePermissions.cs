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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// The permissions granted or revoked on a resource.
    /// </summary>
    public partial class PrincipalResourcePermissions
    {
        private DetailsMap _additionalDetails;
        private List<string> _permissions = new List<string>();
        private List<string> _permissionsWithGrantOption = new List<string>();
        private DataLakePrincipal _principal;
        private Resource _resource;

        /// <summary>
        /// Gets and sets the property AdditionalDetails. 
        /// <para>
        /// This attribute can be used to return any additional details of <code>PrincipalResourcePermissions</code>.
        /// Currently returns only as a RAM share resource ARN.
        /// </para>
        /// </summary>
        public DetailsMap AdditionalDetails
        {
            get { return this._additionalDetails; }
            set { this._additionalDetails = value; }
        }

        // Check to see if AdditionalDetails property is set
        internal bool IsSetAdditionalDetails()
        {
            return this._additionalDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The permissions to be granted or revoked on the resource.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PermissionsWithGrantOption. 
        /// <para>
        /// Indicates whether to grant the ability to grant permissions (as a subset of permissions
        /// granted).
        /// </para>
        /// </summary>
        public List<string> PermissionsWithGrantOption
        {
            get { return this._permissionsWithGrantOption; }
            set { this._permissionsWithGrantOption = value; }
        }

        // Check to see if PermissionsWithGrantOption property is set
        internal bool IsSetPermissionsWithGrantOption()
        {
            return this._permissionsWithGrantOption != null && this._permissionsWithGrantOption.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The Data Lake principal to be granted or revoked permissions.
        /// </para>
        /// </summary>
        public DataLakePrincipal Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource where permissions are to be granted or revoked.
        /// </para>
        /// </summary>
        public Resource Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

    }
}