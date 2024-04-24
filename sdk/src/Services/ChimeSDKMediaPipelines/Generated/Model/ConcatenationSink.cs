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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
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
namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// The data sink of the configuration object.
    /// </summary>
    public partial class ConcatenationSink
    {
        private S3BucketSinkConfiguration _s3BucketSinkConfiguration;
        private ConcatenationSinkType _type;

        /// <summary>
        /// Gets and sets the property S3BucketSinkConfiguration. 
        /// <para>
        /// The configuration settings for an Amazon S3 bucket sink.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3BucketSinkConfiguration S3BucketSinkConfiguration
        {
            get { return this._s3BucketSinkConfiguration; }
            set { this._s3BucketSinkConfiguration = value; }
        }

        // Check to see if S3BucketSinkConfiguration property is set
        internal bool IsSetS3BucketSinkConfiguration()
        {
            return this._s3BucketSinkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of data sink in the configuration object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConcatenationSinkType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}