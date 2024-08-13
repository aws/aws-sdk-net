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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ListPermissions operation.
    /// Returns a list of the principal permissions on the resource, filtered by the permissions
    /// of the caller. For example, if you are granted an ALTER permission, you are able to
    /// see only the principal permissions for ALTER.
    /// 
    ///  
    /// <para>
    /// This operation returns only those permissions that have been explicitly granted.
    /// </para>
    ///  
    /// <para>
    /// For information about permissions, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/security-data-access.html">Security
    /// and Access Control to Metadata and Data</a>.
    /// </para>
    /// </summary>
    public partial class ListPermissionsRequest : AmazonLakeFormationRequest
    {
        private string _catalogId;
        private string _includeRelated;
        private int? _maxResults;
        private string _nextToken;
        private DataLakePrincipal _principal;
        private Resource _resource;
        private DataLakeResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The identifier for the Data Catalog. By default, the account ID. The Data Catalog
        /// is the persistent metadata store. It contains database definitions, table definitions,
        /// and other control information to manage your Lake Formation environment. 
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
        /// Gets and sets the property IncludeRelated. 
        /// <para>
        /// Indicates that related permissions should be included in the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string IncludeRelated
        {
            get { return this._includeRelated; }
            set { this._includeRelated = value; }
        }

        // Check to see if IncludeRelated property is set
        internal bool IsSetIncludeRelated()
        {
            return this._includeRelated != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, if this is not the first call to retrieve this list.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// Specifies a principal to filter the permissions returned.
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
        /// A resource where you will get a list of the principal permissions.
        /// </para>
        ///  
        /// <para>
        /// This operation does not support getting privileges on a table with columns. Instead,
        /// call this operation on the table, and the operation returns the table and the table
        /// w columns.
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

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies a resource type to filter the permissions returned.
        /// </para>
        /// </summary>
        public DataLakeResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}