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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the API configuration for a code generation job.
    /// </summary>
    public partial class ApiConfiguration
    {
        private DataStoreRenderConfig _dataStoreConfig;
        private GraphQLRenderConfig _graphqlConfig;
        private NoApiRenderConfig _noApiConfig;

        /// <summary>
        /// Gets and sets the property DataStoreConfig. 
        /// <para>
        /// The configuration for an application using DataStore APIs.
        /// </para>
        /// </summary>
        public DataStoreRenderConfig DataStoreConfig
        {
            get { return this._dataStoreConfig; }
            set { this._dataStoreConfig = value; }
        }

        // Check to see if DataStoreConfig property is set
        internal bool IsSetDataStoreConfig()
        {
            return this._dataStoreConfig != null;
        }

        /// <summary>
        /// Gets and sets the property GraphQLConfig. 
        /// <para>
        /// The configuration for an application using GraphQL APIs.
        /// </para>
        /// </summary>
        public GraphQLRenderConfig GraphQLConfig
        {
            get { return this._graphqlConfig; }
            set { this._graphqlConfig = value; }
        }

        // Check to see if GraphQLConfig property is set
        internal bool IsSetGraphQLConfig()
        {
            return this._graphqlConfig != null;
        }

        /// <summary>
        /// Gets and sets the property NoApiConfig. 
        /// <para>
        /// The configuration for an application with no API being used.
        /// </para>
        /// </summary>
        public NoApiRenderConfig NoApiConfig
        {
            get { return this._noApiConfig; }
            set { this._noApiConfig = value; }
        }

        // Check to see if NoApiConfig property is set
        internal bool IsSetNoApiConfig()
        {
            return this._noApiConfig != null;
        }

    }
}