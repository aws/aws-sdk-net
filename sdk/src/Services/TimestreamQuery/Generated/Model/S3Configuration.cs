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
    /// Details on S3 location for error reports that result from running a query.
    /// </summary>
    public partial class S3Configuration
    {
        private string _bucketName;
        private S3EncryptionOption _encryptionOption;
        private string _objectKeyPrefix;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        ///  Name of the S3 bucket under which error reports will be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
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
        /// Gets and sets the property EncryptionOption. 
        /// <para>
        ///  Encryption at rest options for the error reports. If no encryption option is specified,
        /// Timestream will choose SSE_S3 as default. 
        /// </para>
        /// </summary>
        public S3EncryptionOption EncryptionOption
        {
            get { return this._encryptionOption; }
            set { this._encryptionOption = value; }
        }

        // Check to see if EncryptionOption property is set
        internal bool IsSetEncryptionOption()
        {
            return this._encryptionOption != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectKeyPrefix. 
        /// <para>
        ///  Prefix for the error report key. Timestream by default adds the following prefix
        /// to the error report path. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=896)]
        public string ObjectKeyPrefix
        {
            get { return this._objectKeyPrefix; }
            set { this._objectKeyPrefix = value; }
        }

        // Check to see if ObjectKeyPrefix property is set
        internal bool IsSetObjectKeyPrefix()
        {
            return this._objectKeyPrefix != null;
        }

    }
}