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
    /// An object containing <c>schemaName</c>, <c>schemaArn</c>, <c>createdAt</c>, <c>updatedAt</c>,
    /// and <c>hasWorkflows</c>.
    /// </summary>
    public partial class SchemaMappingSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the <c>SchemaMapping</c> was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property HasWorkflows. 
        /// <para>
        /// Specifies whether the schema mapping has been applied to a workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? HasWorkflows { get; set; }

        /// <summary>
        /// Checks to see if the HasWorkflows property is set.
        /// </summary>
        internal bool IsSetHasWorkflows() => this.HasWorkflows.HasValue;

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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the <c>SchemaMapping</c> was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
