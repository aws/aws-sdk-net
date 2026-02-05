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
    /// Configuration that defines HTTP request and response handling, validation endpoints,
    /// and entity configurations for REST API interactions.
    /// </summary>
    public partial class RestConfiguration
    {
        private Dictionary<string, EntityConfiguration> _entityConfigurations = AWSConfigs.InitializeCollections ? new Dictionary<string, EntityConfiguration>() : null;
        private SourceConfiguration _globalSourceConfiguration;
        private SourceConfiguration _validationEndpointConfiguration;

        /// <summary>
        /// Gets and sets the property EntityConfigurations. 
        /// <para>
        /// A map of entity configurations that define how to interact with different data entities
        /// available through the REST API, including their schemas and access patterns.
        /// </para>
        /// </summary>
        public Dictionary<string, EntityConfiguration> EntityConfigurations
        {
            get { return this._entityConfigurations; }
            set { this._entityConfigurations = value; }
        }

        // Check to see if EntityConfigurations property is set
        internal bool IsSetEntityConfigurations()
        {
            return this._entityConfigurations != null && (this._entityConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GlobalSourceConfiguration. 
        /// <para>
        /// Global configuration settings that apply to all REST API requests for this connection
        /// type, including common request methods, paths, and parameters.
        /// </para>
        /// </summary>
        public SourceConfiguration GlobalSourceConfiguration
        {
            get { return this._globalSourceConfiguration; }
            set { this._globalSourceConfiguration = value; }
        }

        // Check to see if GlobalSourceConfiguration property is set
        internal bool IsSetGlobalSourceConfiguration()
        {
            return this._globalSourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationEndpointConfiguration. 
        /// <para>
        /// Configuration for the endpoint used to validate connection credentials and test connectivity
        /// during connection creation.
        /// </para>
        /// </summary>
        public SourceConfiguration ValidationEndpointConfiguration
        {
            get { return this._validationEndpointConfiguration; }
            set { this._validationEndpointConfiguration = value; }
        }

        // Check to see if ValidationEndpointConfiguration property is set
        internal bool IsSetValidationEndpointConfiguration()
        {
            return this._validationEndpointConfiguration != null;
        }

    }
}