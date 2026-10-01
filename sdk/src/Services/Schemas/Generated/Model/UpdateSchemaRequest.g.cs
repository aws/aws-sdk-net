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

namespace Amazon.Schemas.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSchema operation. Updates the schema definition
    /// <note> <para> Inactive schemas will be deleted after two years. </para> </note>
    /// </summary>
    public partial class UpdateSchemaRequest : AmazonSchemasRequest
    {
        /// <summary>
        /// Gets and sets the property ClientTokenId. 
        /// <para>
        /// The ID of the client token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 36)]
        public string ClientTokenId { get; set; }

        /// <summary>
        /// Checks to see if the ClientTokenId property is set.
        /// </summary>
        internal bool IsSetClientTokenId() => this.ClientTokenId != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The source of the schema definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property RegistryName. 
        /// <para>
        /// The name of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegistryName { get; set; }

        /// <summary>
        /// Checks to see if the RegistryName property is set.
        /// </summary>
        internal bool IsSetRegistryName() => this.RegistryName != null;

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The name of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SchemaName { get; set; }

        /// <summary>
        /// Checks to see if the SchemaName property is set.
        /// </summary>
        internal bool IsSetSchemaName() => this.SchemaName != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The schema type for the events schema.
        /// </para>
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
