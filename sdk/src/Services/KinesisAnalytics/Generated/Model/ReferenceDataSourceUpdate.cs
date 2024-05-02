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
    /// When you update a reference data source configuration for an application, this object
    /// provides all the updated values (such as the source bucket name and object key name),
    /// the in-application table name that is created, and updated mapping information that
    /// maps the data in the Amazon S3 object to the in-application reference table that is
    /// created.
    /// </summary>
    public partial class ReferenceDataSourceUpdate
    {
        private string _referenceId;
        private SourceSchema _referenceSchemaUpdate;
        private S3ReferenceDataSourceUpdate _s3ReferenceDataSourceUpdate;
        private string _tableNameUpdate;

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// ID of the reference data source being updated. You can use the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_DescribeApplication.html">DescribeApplication</a>
        /// operation to get this value.
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
        /// Gets and sets the property ReferenceSchemaUpdate. 
        /// <para>
        /// Describes the format of the data in the streaming source, and how each data element
        /// maps to corresponding columns created in the in-application stream. 
        /// </para>
        /// </summary>
        public SourceSchema ReferenceSchemaUpdate
        {
            get { return this._referenceSchemaUpdate; }
            set { this._referenceSchemaUpdate = value; }
        }

        // Check to see if ReferenceSchemaUpdate property is set
        internal bool IsSetReferenceSchemaUpdate()
        {
            return this._referenceSchemaUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property S3ReferenceDataSourceUpdate. 
        /// <para>
        /// Describes the S3 bucket name, object key name, and IAM role that Amazon Kinesis Analytics
        /// can assume to read the Amazon S3 object on your behalf and populate the in-application
        /// reference table.
        /// </para>
        /// </summary>
        public S3ReferenceDataSourceUpdate S3ReferenceDataSourceUpdate
        {
            get { return this._s3ReferenceDataSourceUpdate; }
            set { this._s3ReferenceDataSourceUpdate = value; }
        }

        // Check to see if S3ReferenceDataSourceUpdate property is set
        internal bool IsSetS3ReferenceDataSourceUpdate()
        {
            return this._s3ReferenceDataSourceUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property TableNameUpdate. 
        /// <para>
        /// In-application table name that is created by this update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string TableNameUpdate
        {
            get { return this._tableNameUpdate; }
            set { this._tableNameUpdate = value; }
        }

        // Check to see if TableNameUpdate property is set
        internal bool IsSetTableNameUpdate()
        {
            return this._tableNameUpdate != null;
        }

    }
}