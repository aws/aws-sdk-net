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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Provides configuration parameters for the output of inference jobs.
    /// </summary>
    public partial class OutputDataConfig
    {
        private string _kmsKeyId;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// ID for the Amazon Web Services Key Management Service (KMS) key that Amazon Comprehend
        /// uses to encrypt the output results from an analysis job. Specify the Key Id of a symmetric
        /// key, because you cannot use an asymmetric key for uploading data to S3.
        /// </para>
        ///  
        /// <para>
        /// The KmsKeyId can be one of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// KMS Key ID: <c>"1234abcd-12ab-34cd-56ef-1234567890ab"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Resource Name (ARN) of a KMS Key: <c>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// KMS Key Alias: <c>"alias/ExampleAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN of a KMS Key Alias: <c>"arn:aws:kms:us-west-2:111122223333:alias/ExampleAlias"</c>
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
        /// When you use the <c>OutputDataConfig</c> object with asynchronous operations, you
        /// specify the Amazon S3 location where you want to write the output data. The URI must
        /// be in the same Region as the API endpoint that you are calling. The location is used
        /// as the prefix for the actual location of the output file.
        /// </para>
        ///  
        /// <para>
        /// When the topic detection job is finished, the service creates an output file in a
        /// directory specific to the job. The <c>S3Uri</c> field contains the location of the
        /// output file, called <c>output.tar.gz</c>. It is a compressed archive that contains
        /// the ouput of the operation.
        /// </para>
        ///  
        /// <para>
        ///  For a PII entity detection job, the output file is plain text, not a compressed archive.
        /// The output file name is the same as the input file, with <c>.out</c> appended at the
        /// end. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
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