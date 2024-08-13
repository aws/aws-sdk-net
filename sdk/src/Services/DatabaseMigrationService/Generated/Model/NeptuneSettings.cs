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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that defines an Amazon Neptune endpoint.
    /// </summary>
    public partial class NeptuneSettings
    {
        private int? _errorRetryDuration;
        private bool? _iamAuthEnabled;
        private int? _maxFileSize;
        private int? _maxRetryCount;
        private string _s3BucketFolder;
        private string _s3BucketName;
        private string _serviceAccessRoleArn;

        /// <summary>
        /// Gets and sets the property ErrorRetryDuration. 
        /// <para>
        /// The number of milliseconds for DMS to wait to retry a bulk-load of migrated graph
        /// data to the Neptune target database before raising an error. The default is 250.
        /// </para>
        /// </summary>
        public int? ErrorRetryDuration
        {
            get { return this._errorRetryDuration; }
            set { this._errorRetryDuration = value; }
        }

        // Check to see if ErrorRetryDuration property is set
        internal bool IsSetErrorRetryDuration()
        {
            return this._errorRetryDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamAuthEnabled. 
        /// <para>
        /// If you want Identity and Access Management (IAM) authorization enabled for this endpoint,
        /// set this parameter to <c>true</c>. Then attach the appropriate IAM policy document
        /// to your service role specified by <c>ServiceAccessRoleArn</c>. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IamAuthEnabled
        {
            get { return this._iamAuthEnabled; }
            set { this._iamAuthEnabled = value; }
        }

        // Check to see if IamAuthEnabled property is set
        internal bool IsSetIamAuthEnabled()
        {
            return this._iamAuthEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFileSize. 
        /// <para>
        /// The maximum size in kilobytes of migrated graph data stored in a .csv file before
        /// DMS bulk-loads the data to the Neptune target database. The default is 1,048,576 KB.
        /// If the bulk load is successful, DMS clears the bucket, ready to store the next batch
        /// of migrated graph data.
        /// </para>
        /// </summary>
        public int? MaxFileSize
        {
            get { return this._maxFileSize; }
            set { this._maxFileSize = value; }
        }

        // Check to see if MaxFileSize property is set
        internal bool IsSetMaxFileSize()
        {
            return this._maxFileSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRetryCount. 
        /// <para>
        /// The number of times for DMS to retry a bulk load of migrated graph data to the Neptune
        /// target database before raising an error. The default is 5.
        /// </para>
        /// </summary>
        public int? MaxRetryCount
        {
            get { return this._maxRetryCount; }
            set { this._maxRetryCount = value; }
        }

        // Check to see if MaxRetryCount property is set
        internal bool IsSetMaxRetryCount()
        {
            return this._maxRetryCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3BucketFolder. 
        /// <para>
        /// A folder path where you want DMS to store migrated graph data in the S3 bucket specified
        /// by <c>S3BucketName</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string S3BucketFolder
        {
            get { return this._s3BucketFolder; }
            set { this._s3BucketFolder = value; }
        }

        // Check to see if S3BucketFolder property is set
        internal bool IsSetS3BucketFolder()
        {
            return this._s3BucketFolder != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket where DMS can temporarily store migrated graph data
        /// in .csv files before bulk-loading it to the Neptune target database. DMS maps the
        /// SQL source data to graph data before storing it in these .csv files.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service role that you created for the Neptune
        /// target endpoint. The role must allow the <c>iam:PassRole</c> action. For more information,
        /// see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Target.Neptune.html#CHAP_Target.Neptune.ServiceRole">Creating
        /// an IAM Service Role for Accessing Amazon Neptune as a Target</a> in the <i>Database
        /// Migration Service User Guide. </i> 
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn
        {
            get { return this._serviceAccessRoleArn; }
            set { this._serviceAccessRoleArn = value; }
        }

        // Check to see if ServiceAccessRoleArn property is set
        internal bool IsSetServiceAccessRoleArn()
        {
            return this._serviceAccessRoleArn != null;
        }

    }
}