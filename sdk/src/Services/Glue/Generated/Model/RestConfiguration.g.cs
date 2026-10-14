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
    /// Configuration that defines HTTP request and response handling, validation endpoints,
    /// and entity configurations for REST API interactions.
    /// </summary>
    public partial class RestConfiguration
    {
        /// <summary>
        /// Gets and sets the property EntityConfigurations. 
        /// <para>
        /// A map of entity configurations that define how to interact with different data entities
        /// available through the REST API, including their schemas and access patterns.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, EntityConfiguration> EntityConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, EntityConfiguration>() : null;

        /// <summary>
        /// Checks to see if the EntityConfigurations property is set.
        /// </summary>
        internal bool IsSetEntityConfigurations() => this.EntityConfigurations != null && (this.EntityConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GlobalSourceConfiguration. 
        /// <para>
        /// Global configuration settings that apply to all REST API requests for this connection
        /// type, including common request methods, paths, and parameters.
        /// </para>
        /// </summary>
        public SourceConfiguration GlobalSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GlobalSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetGlobalSourceConfiguration() => this.GlobalSourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property ValidationEndpointConfiguration. 
        /// <para>
        /// Configuration for the endpoint used to validate connection credentials and test connectivity
        /// during connection creation.
        /// </para>
        /// </summary>
        public SourceConfiguration ValidationEndpointConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ValidationEndpointConfiguration property is set.
        /// </summary>
        internal bool IsSetValidationEndpointConfiguration() => this.ValidationEndpointConfiguration != null;
    }
}
