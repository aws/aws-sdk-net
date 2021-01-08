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
    /// Container for the parameters to the GrantPermissions operation.
    /// Grants permissions to the principal to access metadata in the Data Catalog and data
    /// organized in underlying data storage such as Amazon S3.
    /// 
    ///  
    /// <para>
    /// For information about permissions, see <a href="https://docs-aws.amazon.com/lake-formation/latest/dg/security-data-access.html">Security
    /// and Access Control to Metadata and Data</a>.
    /// </para>
    /// </summary>
    public partial class GrantPermissionsRequest : AmazonLakeFormationRequest
    {
        private string _catalogId;
        private List<string> _permissions = new List<string>();
        private List<string> _permissionsWithGrantOption = new List<string>();
        private DataLakePrincipal _principal;
        private Resource _resource;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The identifier for the Data Catalog. By default, the account ID. The Data Catalog
        /// is the persistent metadata store. It contains database definitions, table definitions,
        /// and other control information to manage your AWS Lake Formation environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The permissions granted to the principal on the resource. AWS Lake Formation defines
        /// privileges to grant and revoke access to metadata in the Data Catalog and data organized
        /// in underlying data storage such as Amazon S3. AWS Lake Formation requires that each
        /// principal be authorized to perform a specific task on AWS Lake Formation resources.
        /// 
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
        /// Gets and sets the property PermissionsWithGrantOption. 
        /// <para>
        /// Indicates a list of the granted permissions that the principal may pass to other users.
        /// These permissions may only be a subset of the permissions granted in the <code>Privileges</code>.
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
        /// The principal to be granted the permissions on the resource. Supported principals
        /// are IAM users or IAM roles, and they are defined by their principal type and their
        /// ARN.
        /// </para>
        ///  
        /// <para>
        /// Note that if you define a resource with a particular ARN, then later delete, and recreate
        /// a resource with that same ARN, the resource maintains the permissions already granted.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The resource to which permissions are to be granted. Resources in AWS Lake Formation
        /// are the Data Catalog, databases, and tables.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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