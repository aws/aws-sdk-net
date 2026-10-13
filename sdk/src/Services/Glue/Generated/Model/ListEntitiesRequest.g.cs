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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the ListEntities operation. Returns the available
    /// entities supported by the connection type.
    /// </summary>
    public partial class ListEntitiesRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The catalog ID of the catalog that contains the connection. This can be null, By default,
        /// the Amazon Web Services Account ID is the catalog ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// A name for the connection that has required credentials to query any connection type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionName property is set.
        /// </summary>
        internal bool IsSetConnectionName() => this.ConnectionName != null;

        /// <summary>
        /// Gets and sets the property DataStoreApiVersion. 
        /// <para>
        /// The API version of the SaaS connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string DataStoreApiVersion { get; set; }

        /// <summary>
        /// Checks to see if the DataStoreApiVersion property is set.
        /// </summary>
        internal bool IsSetDataStoreApiVersion() => this.DataStoreApiVersion != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, included if this is a continuation call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ParentEntityName. 
        /// <para>
        /// Name of the parent entity for which you want to list the children. This parameter
        /// takes a fully-qualified path of the entity in order to list the child entities.
        /// </para>
        /// </summary>
        public string ParentEntityName { get; set; }

        /// <summary>
        /// Checks to see if the ParentEntityName property is set.
        /// </summary>
        internal bool IsSetParentEntityName() => this.ParentEntityName != null;
    }
}
