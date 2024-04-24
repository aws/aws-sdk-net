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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// S3 report location for the scheduled query run.
    /// </summary>
    public partial class S3ReportLocation
    {
        private string _bucketName;
        private string _objectKey;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        ///  S3 bucket name. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectKey. 
        /// <para>
        /// S3 key. 
        /// </para>
        /// </summary>
        public string ObjectKey
        {
            get { return this._objectKey; }
            set { this._objectKey = value; }
        }

        // Check to see if ObjectKey property is set
        internal bool IsSetObjectKey()
        {
            return this._objectKey != null;
        }

    }
}