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
    /// Container for the parameters to the DescribeEntity operation.
    /// Provides details regarding the entity used with the connection type, with a description
    /// of the data model for each field in the selected entity.
    /// 
    ///  
    /// <para>
    ///  The response includes all the fields which make up the entity.
    /// </para>
    /// </summary>
    public partial class DescribeEntityRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _connectionName;
        private string _dataStoreApiVersion;
        private string _entityName;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The catalog ID of the catalog that contains the connection. This can be null, By default,
        /// the Amazon Web Services Account ID is the catalog ID.
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
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection that contains the connection type credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ConnectionName
        {
            get { return this._connectionName; }
            set { this._connectionName = value; }
        }

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this._connectionName != null;
        }

        /// <summary>
        /// Gets and sets the property DataStoreApiVersion. 
        /// <para>
        /// The version of the API used for the data store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DataStoreApiVersion
        {
            get { return this._dataStoreApiVersion; }
            set { this._dataStoreApiVersion = value; }
        }

        // Check to see if DataStoreApiVersion property is set
        internal bool IsSetDataStoreApiVersion()
        {
            return this._dataStoreApiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property EntityName. 
        /// <para>
        /// The name of the entity that you want to describe from the connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EntityName
        {
            get { return this._entityName; }
            set { this._entityName = value; }
        }

        // Check to see if EntityName property is set
        internal bool IsSetEntityName()
        {
            return this._entityName != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, included if this is a continuation call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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

    }
}