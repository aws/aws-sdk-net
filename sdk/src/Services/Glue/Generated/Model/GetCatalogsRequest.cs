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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the GetCatalogs operation.
    /// Retrieves all catalogs defined in a catalog in the Glue Data Catalog. For a Redshift-federated
    /// catalog use case, this operation returns the list of catalogs mapped to Redshift databases
    /// in the Redshift namespace catalog.
    /// </summary>
    public partial class GetCatalogsRequest : AmazonGlueRequest
    {
        private bool? _includeRoot;
        private int? _maxResults;
        private string _nextToken;
        private string _parentCatalogId;
        private bool? _recursive;

        /// <summary>
        /// Gets and sets the property IncludeRoot. 
        /// <para>
        /// Whether to list the default catalog in the account and region in the response. Defaults
        /// to <c>false</c>. When <c>true</c> and <c>ParentCatalogId = NULL | Amazon Web Services
        /// Account ID</c>, all catalogs and the default catalog are enumerated in the response.
        /// </para>
        ///  
        /// <para>
        /// When the <c>ParentCatalogId</c> is not equal to null, and this attribute is passed
        /// as <c>false</c> or <c>true</c>, an <c>InvalidInputException</c> is thrown.
        /// </para>
        /// </summary>
        public bool? IncludeRoot
        {
            get { return this._includeRoot; }
            set { this._includeRoot = value; }
        }

        // Check to see if IncludeRoot property is set
        internal bool IsSetIncludeRoot()
        {
            return this._includeRoot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of catalogs to return in one response.
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
        /// A continuation token, if this is a continuation call.
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
        /// Gets and sets the property ParentCatalogId. 
        /// <para>
        /// The ID of the parent catalog in which the catalog resides. If none is provided, the
        /// Amazon Web Services Account Number is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ParentCatalogId
        {
            get { return this._parentCatalogId; }
            set { this._parentCatalogId = value; }
        }

        // Check to see if ParentCatalogId property is set
        internal bool IsSetParentCatalogId()
        {
            return this._parentCatalogId != null;
        }

        /// <summary>
        /// Gets and sets the property Recursive. 
        /// <para>
        /// Whether to list all catalogs across the catalog hierarchy, starting from the <c>ParentCatalogId</c>.
        /// Defaults to <c>false</c> . When <c>true</c>, all catalog objects in the <c>ParentCatalogID</c>
        /// hierarchy are enumerated in the response.
        /// </para>
        /// </summary>
        public bool? Recursive
        {
            get { return this._recursive; }
            set { this._recursive = value; }
        }

        // Check to see if Recursive property is set
        internal bool IsSetRecursive()
        {
            return this._recursive.HasValue; 
        }

    }
}