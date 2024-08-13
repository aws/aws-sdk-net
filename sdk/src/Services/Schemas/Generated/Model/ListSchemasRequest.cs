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
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
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
namespace Amazon.Schemas.Model
{
    /// <summary>
    /// Container for the parameters to the ListSchemas operation.
    /// List the schemas.
    /// </summary>
    public partial class ListSchemasRequest : AmazonSchemasRequest
    {
        private int? _limit;
        private string _nextToken;
        private string _registryName;
        private string _schemaNamePrefix;

        /// <summary>
        /// Gets and sets the property Limit.
        /// </summary>
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that specifies the next page of results to return. To request the first
        /// page, leave NextToken empty. The token will expire in 24 hours, and cannot be shared
        /// with other accounts.
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
        /// Gets and sets the property RegistryName. 
        /// <para>
        /// The name of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RegistryName
        {
            get { return this._registryName; }
            set { this._registryName = value; }
        }

        // Check to see if RegistryName property is set
        internal bool IsSetRegistryName()
        {
            return this._registryName != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaNamePrefix. 
        /// <para>
        /// Specifying this limits the results to only those schema names that start with the
        /// specified prefix.
        /// </para>
        /// </summary>
        public string SchemaNamePrefix
        {
            get { return this._schemaNamePrefix; }
            set { this._schemaNamePrefix = value; }
        }

        // Check to see if SchemaNamePrefix property is set
        internal bool IsSetSchemaNamePrefix()
        {
            return this._schemaNamePrefix != null;
        }

    }
}