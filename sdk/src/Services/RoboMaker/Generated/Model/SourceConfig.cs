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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about a source configuration.
    /// </summary>
    public partial class SourceConfig
    {
        private Architecture _architecture;
        private string _s3Bucket;
        private string _s3Key;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The target processor architecture for the application.
        /// </para>
        /// </summary>
        public Architecture Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The Amazon S3 bucket name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3Key. 
        /// <para>
        /// The s3 object key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string S3Key
        {
            get { return this._s3Key; }
            set { this._s3Key = value; }
        }

        // Check to see if S3Key property is set
        internal bool IsSetS3Key()
        {
            return this._s3Key != null;
        }

    }
}