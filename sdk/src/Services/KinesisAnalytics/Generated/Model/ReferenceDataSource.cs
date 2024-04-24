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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
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
namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Describes the reference data source by providing the source information (S3 bucket
    /// name and object key name), the resulting in-application table name that is created,
    /// and the necessary schema to map the data elements in the Amazon S3 object to the in-application
    /// table.
    /// </summary>
    public partial class ReferenceDataSource
    {
        private SourceSchema _referenceSchema;
        private S3ReferenceDataSource _s3ReferenceDataSource;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property ReferenceSchema. 
        /// <para>
        /// Describes the format of the data in the streaming source, and how each data element
        /// maps to corresponding columns created in the in-application stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property S3ReferenceDataSource. 
        /// <para>
        /// Identifies the S3 bucket and object that contains the reference data. Also identifies
        /// the IAM role Amazon Kinesis Analytics can assume to read this object on your behalf.
        /// An Amazon Kinesis Analytics application loads reference data only once. If the data
        /// changes, you call the <c>UpdateApplication</c> operation to trigger reloading of data
        /// into your application. 
        /// </para>
        /// </summary>
        public S3ReferenceDataSource S3ReferenceDataSource
        {
            get { return this._s3ReferenceDataSource; }
            set { this._s3ReferenceDataSource = value; }
        }

        // Check to see if S3ReferenceDataSource property is set
        internal bool IsSetS3ReferenceDataSource()
        {
            return this._s3ReferenceDataSource != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// Name of the in-application table to create.
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