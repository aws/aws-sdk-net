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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Configuration information required to create a custom plugin.
    /// </summary>
    public partial class CustomPluginConfiguration
    {
        /// <summary>
        /// Gets and sets the property ApiSchema. 
        /// <para>
        /// Contains either details about the S3 object containing the OpenAPI schema for the
        /// action group or the JSON or YAML-formatted payload defining the schema.
        /// </para>
        /// </summary>
        public APISchema ApiSchema { get; set; }

        /// <summary>
        /// Checks to see if the ApiSchema property is set.
        /// </summary>
        internal bool IsSetApiSchema() => this.ApiSchema != null;

        /// <summary>
        /// Gets and sets the property ApiSchemaType. 
        /// <para>
        /// The type of OpenAPI schema to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public APISchemaType ApiSchemaType { get; set; }

        /// <summary>
        /// Checks to see if the ApiSchemaType property is set.
        /// </summary>
        internal bool IsSetApiSchemaType() => this.ApiSchemaType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for your custom plugin configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;
    }
}
