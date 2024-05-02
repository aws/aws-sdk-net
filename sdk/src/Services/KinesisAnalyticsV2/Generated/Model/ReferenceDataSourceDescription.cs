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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// For a SQL-based Kinesis Data Analytics application, describes the reference data source
    /// configured for an application.
    /// </summary>
    public partial class ReferenceDataSourceDescription
    {
        private string _referenceId;
        private SourceSchema _referenceSchema;
        private S3ReferenceDataSourceDescription _s3ReferenceDataSourceDescription;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// The ID of the reference data source. This is the ID that Kinesis Data Analytics assigns
        /// when you add the reference data source to your application using the <a>CreateApplication</a>
        /// or <a>UpdateApplication</a> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string ReferenceId
        {
            get { return this._referenceId; }
            set { this._referenceId = value; }
        }

        // Check to see if ReferenceId property is set
        internal bool IsSetReferenceId()
        {
            return this._referenceId != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceSchema. 
        /// <para>
        /// Describes the format of the data in the streaming source, and how each data element
        /// maps to corresponding columns created in the in-application stream.
        /// </para>
        /// </summary>
        public SourceSchema ReferenceSchema
        {
            get { return this._referenceSchema; }
            set { this._referenceSchema = value; }
        }

        // Check to see if ReferenceSchema property is set
        internal bool IsSetReferenceSchema()
        {
            return this._referenceSchema != null;
        }

        /// <summary>
        /// Gets and sets the property S3ReferenceDataSourceDescription. 
        /// <para>
        /// Provides the Amazon S3 bucket name, the object key name that contains the reference
        /// data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3ReferenceDataSourceDescription S3ReferenceDataSourceDescription
        {
            get { return this._s3ReferenceDataSourceDescription; }
            set { this._s3ReferenceDataSourceDescription = value; }
        }

        // Check to see if S3ReferenceDataSourceDescription property is set
        internal bool IsSetS3ReferenceDataSourceDescription()
        {
            return this._s3ReferenceDataSourceDescription != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The in-application table name created by the specific reference data source configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}