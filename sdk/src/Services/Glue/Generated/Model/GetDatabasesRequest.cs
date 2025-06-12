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
    /// Container for the parameters to the GetDatabases operation.
    /// Retrieves all databases defined in a given Data Catalog.
    /// </summary>
    public partial class GetDatabasesRequest : AmazonGlueRequest
    {
        private List<string> _attributesToGet = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _catalogId;
        private int? _maxResults;
        private string _nextToken;
        private ResourceShareType _resourceShareType;

        /// <summary>
        /// Gets and sets the property AttributesToGet. 
        /// <para>
        /// Specifies the database fields returned by the <c>GetDatabases</c> call. This parameter
        /// doesn’t accept an empty list. The request must include the <c>NAME</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttributesToGet
        {
            get { return this._attributesToGet; }
            set { this._attributesToGet = value; }
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this._attributesToGet != null && (this._attributesToGet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog from which to retrieve <c>Databases</c>. If none is provided,
        /// the Amazon Web Services account ID is used by default.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of databases to return in one response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property ResourceShareType. 
        /// <para>
        /// Allows you to specify that you want to list the databases shared with your account.
        /// The allowable values are <c>FEDERATED</c>, <c>FOREIGN</c> or <c>ALL</c>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If set to <c>FEDERATED</c>, will list the federated databases (referencing an external
        /// entity) shared with your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If set to <c>FOREIGN</c>, will list the databases shared with your account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If set to <c>ALL</c>, will list the databases shared with your account, as well as
        /// the databases in yor local account. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceShareType ResourceShareType
        {
            get { return this._resourceShareType; }
            set { this._resourceShareType = value; }
        }

        // Check to see if ResourceShareType property is set
        internal bool IsSetResourceShareType()
        {
            return this._resourceShareType != null;
        }

    }
}