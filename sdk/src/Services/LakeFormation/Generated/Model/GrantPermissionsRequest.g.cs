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
    /// Container for the parameters to the GrantPermissions operation. Grants permissions
    /// to the principal to access metadata in the Data Catalog and data organized in underlying
    /// data storage such as Amazon S3. <para> For information about permissions, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/security-data-access.html">Security
    /// and Access Control to Metadata and Data</a>. </para>
    /// </summary>
    public partial class GrantPermissionsRequest : AmazonLakeFormationRequest
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
        /// Gets and sets the property Condition.
        /// </summary>
        public Condition Condition { get; set; }

        /// <summary>
        /// Checks to see if the Condition property is set.
        /// </summary>
        internal bool IsSetCondition() => this.Condition != null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The permissions granted to the principal on the resource. Lake Formation defines privileges
        /// to grant and revoke access to metadata in the Data Catalog and data organized in underlying
        /// data storage such as Amazon S3. Lake Formation requires that each principal be authorized
        /// to perform a specific task on Lake Formation resources. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Permissions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null && (this.Permissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PermissionsWithGrantOption. 
        /// <para>
        /// Indicates a list of the granted permissions that the principal may pass to other users.
        /// These permissions may only be a subset of the permissions granted in the <c>Privileges</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PermissionsWithGrantOption { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PermissionsWithGrantOption property is set.
        /// </summary>
        internal bool IsSetPermissionsWithGrantOption() => this.PermissionsWithGrantOption != null && (this.PermissionsWithGrantOption.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true)]
        public DataLakePrincipal Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource to which permissions are to be granted. Resources in Lake Formation are
        /// the Data Catalog, databases, and tables.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Resource Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;
    }
}
