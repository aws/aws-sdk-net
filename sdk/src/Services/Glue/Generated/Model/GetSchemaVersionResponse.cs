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
    /// This is the response object from the GetSchemaVersion operation.
    /// </summary>
    public partial class GetSchemaVersionResponse : AmazonWebServiceResponse
    {
        private string _createdTime;
        private DataFormat _dataFormat;
        private string _schemaArn;
        private string _schemaDefinition;
        private string _schemaVersionId;
        private SchemaVersionStatus _status;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time the schema version was created.
        /// </para>
        /// </summary>
        public string CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime != null;
        }

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// The data format of the schema definition. Currently <c>AVRO</c>, <c>JSON</c> and <c>PROTOBUF</c>
        /// are supported.
        /// </para>
        /// </summary>
        public DataFormat DataFormat
        {
            get { return this._dataFormat; }
            set { this._dataFormat = value; }
        }

        // Check to see if DataFormat property is set
        internal bool IsSetDataFormat()
        {
            return this._dataFormat != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10240)]
        public string SchemaArn
        {
            get { return this._schemaArn; }
            set { this._schemaArn = value; }
        }

        // Check to see if SchemaArn property is set
        internal bool IsSetSchemaArn()
        {
            return this._schemaArn != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaDefinition. 
        /// <para>
        /// The schema definition for the schema ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=170000)]
        public string SchemaDefinition
        {
            get { return this._schemaDefinition; }
            set { this._schemaDefinition = value; }
        }

        // Check to see if SchemaDefinition property is set
        internal bool IsSetSchemaDefinition()
        {
            return this._schemaDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaVersionId. 
        /// <para>
        /// The <c>SchemaVersionId</c> of the schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SchemaVersionId
        {
            get { return this._schemaVersionId; }
            set { this._schemaVersionId = value; }
        }

        // Check to see if SchemaVersionId property is set
        internal bool IsSetSchemaVersionId()
        {
            return this._schemaVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the schema version. 
        /// </para>
        /// </summary>
        public SchemaVersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number of the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public long? VersionNumber
        {
            get { return this._versionNumber; }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}