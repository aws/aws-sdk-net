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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Indicates the setting of the location where the transcript is stored.
    /// </summary>
    public partial class TranscriptSourceSetting
    {
        private S3BucketTranscriptSource _s3BucketTranscriptSource;

        /// <summary>
        /// Gets and sets the property S3BucketTranscriptSource. 
        /// <para>
        /// Indicates the setting of the Amazon S3 bucket where the transcript is stored.
        /// </para>
        /// </summary>
        public S3BucketTranscriptSource S3BucketTranscriptSource
        {
            get { return this._s3BucketTranscriptSource; }
            set { this._s3BucketTranscriptSource = value; }
        }

        // Check to see if S3BucketTranscriptSource property is set
        internal bool IsSetS3BucketTranscriptSource()
        {
            return this._s3BucketTranscriptSource != null;
        }

    }
}