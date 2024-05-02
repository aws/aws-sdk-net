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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// S3 configuration for storing log data.
    /// </summary>
    public partial class S3Config
    {
        private string _bucketName;
        private string _keyPrefix;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// S3 bucket name.
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
        /// Gets and sets the property KeyPrefix. 
        /// <para>
        /// S3 prefix. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string KeyPrefix
        {
            get { return this._keyPrefix; }
            set { this._keyPrefix = value; }
        }

        // Check to see if KeyPrefix property is set
        internal bool IsSetKeyPrefix()
        {
            return this._keyPrefix != null;
        }

    }
}