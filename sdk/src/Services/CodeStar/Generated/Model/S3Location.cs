/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeStar.Model
{
    /// <summary>
    /// The Amazon S3 location where the source code files provided with the project request
    /// are stored.
    /// </summary>
    public partial class S3Location
    {
        private string _bucketKey;
        private string _bucketName;

        /// <summary>
        /// Gets and sets the property BucketKey. 
        /// <para>
        /// The Amazon S3 object key where the source code files provided with the project request
        /// are stored.
        /// </para>
        /// </summary>
        public string BucketKey
        {
            get { return this._bucketKey; }
            set { this._bucketKey = value; }
        }

        // Check to see if BucketKey property is set
        internal bool IsSetBucketKey()
        {
            return this._bucketKey != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The Amazon S3 bucket name where the source code files provided with the project request
        /// are stored.
        /// </para>
        /// </summary>
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

    }
}