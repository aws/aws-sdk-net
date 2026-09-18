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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// This is the response object from the CreateSchemaMapping operation.
    /// </summary>
    public partial class CreateSchemaMappingResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MappedInputFields. 
        /// <para>
        /// A list of <c>MappedInputFields</c>. Each <c>MappedInputField</c> corresponds to a
        /// column the source data table, and contains column name plus additional information
        /// that Entity Resolution uses for matching.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 60)]
        public List<SchemaInputAttribute> MappedInputFields { get; set; } = AWSConfigs.InitializeCollections ? new List<SchemaInputAttribute>() : null;

        /// <summary>
        /// Checks to see if the MappedInputFields property is set.
        /// </summary>
        internal bool IsSetMappedInputFields() => this.MappedInputFields != null && (this.MappedInputFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SchemaArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) that Entity Resolution generated for the <c>SchemaMapping</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SchemaArn { get; set; }

        /// <summary>
        /// Checks to see if the SchemaArn property is set.
        /// </summary>
        internal bool IsSetSchemaArn() => this.SchemaArn != null;

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The name of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string SchemaName { get; set; }

        /// <summary>
        /// Checks to see if the SchemaName property is set.
        /// </summary>
        internal bool IsSetSchemaName() => this.SchemaName != null;
    }
}
