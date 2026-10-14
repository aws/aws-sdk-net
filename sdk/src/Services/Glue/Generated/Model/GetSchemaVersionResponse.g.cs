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
    /// This is the response object from the GetSchemaVersion operation.
    /// </summary>
    public partial class GetSchemaVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time the schema version was created.
        /// </para>
        /// </summary>
        public string CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime != null;

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// The data format of the schema definition. Currently <c>AVRO</c>, <c>JSON</c> and <c>PROTOBUF</c>
        /// are supported.
        /// </para>
        /// </summary>
        public DataFormat DataFormat { get; set; }

        /// <summary>
        /// Checks to see if the DataFormat property is set.
        /// </summary>
        internal bool IsSetDataFormat() => this.DataFormat != null;

        /// <summary>
        /// Gets and sets the property SchemaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10240)]
        public string SchemaArn { get; set; }

        /// <summary>
        /// Checks to see if the SchemaArn property is set.
        /// </summary>
        internal bool IsSetSchemaArn() => this.SchemaArn != null;

        /// <summary>
        /// Gets and sets the property SchemaDefinition. 
        /// <para>
        /// The schema definition for the schema ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 170000)]
        public string SchemaDefinition { get; set; }

        /// <summary>
        /// Checks to see if the SchemaDefinition property is set.
        /// </summary>
        internal bool IsSetSchemaDefinition() => this.SchemaDefinition != null;

        /// <summary>
        /// Gets and sets the property SchemaVersionId. 
        /// <para>
        /// The <c>SchemaVersionId</c> of the schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SchemaVersionId { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersionId property is set.
        /// </summary>
        internal bool IsSetSchemaVersionId() => this.SchemaVersionId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the schema version. 
        /// </para>
        /// </summary>
        public SchemaVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public long? VersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the VersionNumber property is set.
        /// </summary>
        internal bool IsSetVersionNumber() => this.VersionNumber.HasValue;
    }
}
