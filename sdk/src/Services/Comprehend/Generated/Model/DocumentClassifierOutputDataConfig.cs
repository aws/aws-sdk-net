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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Provides output results configuration parameters for custom classifier jobs.
    /// </summary>
    public partial class DocumentClassifierOutputDataConfig
    {
        private string _flywheelStatsS3Prefix;
        private string _kmsKeyId;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property FlywheelStatsS3Prefix. 
        /// <para>
        /// The Amazon S3 prefix for the data lake location of the flywheel statistics.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string FlywheelStatsS3Prefix
        {
            get { return this._flywheelStatsS3Prefix; }
            set { this._flywheelStatsS3Prefix = value; }
        }

        // Check to see if FlywheelStatsS3Prefix property is set
        internal bool IsSetFlywheelStatsS3Prefix()
        {
            return this._flywheelStatsS3Prefix != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// ID for the Amazon Web Services Key Management Service (KMS) key that Amazon Comprehend
        /// uses to encrypt the output results from an analysis job. The KmsKeyId can be one of
        /// the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// KMS Key ID: <code>"1234abcd-12ab-34cd-56ef-1234567890ab"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Resource Name (ARN) of a KMS Key: <code>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// KMS Key Alias: <code>"alias/ExampleAlias"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN of a KMS Key Alias: <code>"arn:aws:kms:us-west-2:111122223333:alias/ExampleAlias"</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// When you use the <code>OutputDataConfig</code> object while creating a custom classifier,
        /// you specify the Amazon S3 location where you want to write the confusion matrix. The
        /// URI must be in the same Region as the API endpoint that you are calling. The location
        /// is used as the prefix for the actual location of this output file.
        /// </para>
        ///  
        /// <para>
        /// When the custom classifier job is finished, the service creates the output file in
        /// a directory specific to the job. The <code>S3Uri</code> field contains the location
        /// of the output file, called <code>output.tar.gz</code>. It is a compressed archive
        /// that contains the confusion matrix.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}