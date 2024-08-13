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
    /// Container for the parameters to the ListRegistries operation.
    /// List the registries.
    /// </summary>
    public partial class ListRegistriesRequest : AmazonSchemasRequest
    {
        private int? _limit;
        private string _nextToken;
        private string _registryNamePrefix;
        private string _scope;

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
        /// Gets and sets the property RegistryNamePrefix. 
        /// <para>
        /// Specifying this limits the results to only those registry names that start with the
        /// specified prefix.
        /// </para>
        /// </summary>
        public string RegistryNamePrefix
        {
            get { return this._registryNamePrefix; }
            set { this._registryNamePrefix = value; }
        }

        // Check to see if RegistryNamePrefix property is set
        internal bool IsSetRegistryNamePrefix()
        {
            return this._registryNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Can be set to Local or AWS to limit responses to your custom registries, or the ones
        /// provided by AWS.
        /// </para>
        /// </summary>
        public string Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}