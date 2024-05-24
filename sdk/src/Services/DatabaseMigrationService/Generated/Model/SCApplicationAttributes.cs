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
    /// Provides information that defines a schema conversion application.
    /// </summary>
    public partial class SCApplicationAttributes
    {
        private string _s3BucketPath;
        private string _s3BucketRoleArn;

        /// <summary>
        /// Gets and sets the property S3BucketPath. 
        /// <para>
        /// The path for the Amazon S3 bucket that the application uses for exporting assessment
        /// reports.
        /// </para>
        /// </summary>
        public string S3BucketPath
        {
            get { return this._s3BucketPath; }
            set { this._s3BucketPath = value; }
        }

        // Check to see if S3BucketPath property is set
        internal bool IsSetS3BucketPath()
        {
            return this._s3BucketPath != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketRoleArn. 
        /// <para>
        /// The ARN for the role the application uses to access its Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string S3BucketRoleArn
        {
            get { return this._s3BucketRoleArn; }
            set { this._s3BucketRoleArn = value; }
        }

        // Check to see if S3BucketRoleArn property is set
        internal bool IsSetS3BucketRoleArn()
        {
            return this._s3BucketRoleArn != null;
        }

    }
}