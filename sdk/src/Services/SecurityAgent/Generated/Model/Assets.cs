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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Collection of assets to be tested or used during a pentest
    /// </summary>
    public partial class Assets
    {
        private List<Actor> _actors = AWSConfigs.InitializeCollections ? new List<Actor>() : null;
        private List<DocumentInfo> _documents = AWSConfigs.InitializeCollections ? new List<DocumentInfo>() : null;
        private List<Endpoint> _endpoints = AWSConfigs.InitializeCollections ? new List<Endpoint>() : null;
        private List<IntegratedRepository> _integratedRepositories = AWSConfigs.InitializeCollections ? new List<IntegratedRepository>() : null;
        private List<SourceCodeRepository> _sourceCode = AWSConfigs.InitializeCollections ? new List<SourceCodeRepository>() : null;

        /// <summary>
        /// Gets and sets the property Actors. 
        /// <para>
        /// List of actors that interact with the system
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Actor> Actors
        {
            get { return this._actors; }
            set { this._actors = value; }
        }

        // Check to see if Actors property is set
        internal bool IsSetActors()
        {
            return this._actors != null && (this._actors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// List of documents providing context for testing
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentInfo> Documents
        {
            get { return this._documents; }
            set { this._documents = value; }
        }

        // Check to see if Documents property is set
        internal bool IsSetDocuments()
        {
            return this._documents != null && (this._documents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// List of web application endpoints to test
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Endpoint> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null && (this._endpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntegratedRepositories. 
        /// <para>
        /// List of integrated code repositories
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IntegratedRepository> IntegratedRepositories
        {
            get { return this._integratedRepositories; }
            set { this._integratedRepositories = value; }
        }

        // Check to see if IntegratedRepositories property is set
        internal bool IsSetIntegratedRepositories()
        {
            return this._integratedRepositories != null && (this._integratedRepositories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceCode. 
        /// <para>
        /// List of source code repositories for static analysis
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceCodeRepository> SourceCode
        {
            get { return this._sourceCode; }
            set { this._sourceCode = value; }
        }

        // Check to see if SourceCode property is set
        internal bool IsSetSourceCode()
        {
            return this._sourceCode != null && (this._sourceCode.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}