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
    /// An object that contains minimal details for a schema.
    /// </summary>
    public partial class SchemaListItem
    {
        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time that a schema was created.
        /// </para>
        /// </summary>
        public string CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property RegistryName. 
        /// <para>
        /// the name of the registry where the schema resides.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RegistryName { get; set; }

        /// <summary>
        /// Checks to see if the RegistryName property is set.
        /// </summary>
        internal bool IsSetRegistryName() => this.RegistryName != null;

        /// <summary>
        /// Gets and sets the property SchemaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10240)]
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
        [AWSProperty(Min = 1, Max = 255)]
        public string SchemaName { get; set; }

        /// <summary>
        /// Checks to see if the SchemaName property is set.
        /// </summary>
        internal bool IsSetSchemaName() => this.SchemaName != null;

        /// <summary>
        /// Gets and sets the property SchemaStatus. 
        /// <para>
        /// The status of the schema.
        /// </para>
        /// </summary>
        public SchemaStatus SchemaStatus { get; set; }

        /// <summary>
        /// Checks to see if the SchemaStatus property is set.
        /// </summary>
        internal bool IsSetSchemaStatus() => this.SchemaStatus != null;

        /// <summary>
        /// Gets and sets the property UpdatedTime. 
        /// <para>
        /// The date and time that a schema was updated.
        /// </para>
        /// </summary>
        public string UpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTime property is set.
        /// </summary>
        internal bool IsSetUpdatedTime() => this.UpdatedTime != null;
    }
}
