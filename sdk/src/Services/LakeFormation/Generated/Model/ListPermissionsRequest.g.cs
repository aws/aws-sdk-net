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
    /// Container for the parameters to the ListPermissions operation. Returns a list of the
    /// principal permissions on the resource, filtered by the permissions of the caller.
    /// For example, if you are granted an ALTER permission, you are able to see only the
    /// principal permissions for ALTER. <para> This operation returns only those permissions
    /// that have been explicitly granted. If both <c>Principal</c> and <c>Resource</c> parameters
    /// are provided, the response returns effective permissions rather than the explicitly
    /// granted permissions. </para> <para> For information about permissions, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/security-data-access.html">Security
    /// and Access Control to Metadata and Data</a>. </para>
    /// </summary>
    public partial class ListPermissionsRequest : AmazonLakeFormationRequest
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
        /// Gets and sets the property IncludeRelated. 
        /// <para>
        /// Indicates that related permissions should be included in the results when listing
        /// permissions on a table resource.
        /// </para>
        ///  
        /// <para>
        /// Set the field to <c>TRUE</c> to show the cell filters on a table resource. Default
        /// is <c>FALSE</c>. The Principal parameter must not be specified when requesting cell
        /// filter information.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string IncludeRelated { get; set; }

        /// <summary>
        /// Checks to see if the IncludeRelated property is set.
        /// </summary>
        internal bool IsSetIncludeRelated() => this.IncludeRelated != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, if this is not the first call to retrieve this list.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// Specifies a principal to filter the permissions returned.
        /// </para>
        /// </summary>
        public DataLakePrincipal Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// A resource where you will get a list of the principal permissions.
        /// </para>
        ///  
        /// <para>
        /// This operation does not support getting privileges on a table with columns. Instead,
        /// call this operation on the table, and the operation returns the table and the table
        /// w columns.
        /// </para>
        /// </summary>
        public Resource Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies a resource type to filter the permissions returned.
        /// </para>
        /// </summary>
        public DataLakeResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
