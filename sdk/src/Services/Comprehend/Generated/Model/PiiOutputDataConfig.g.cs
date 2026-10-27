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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Provides configuration parameters for the output of PII entity detection jobs.
    /// </summary>
    public partial class PiiOutputDataConfig
    {
        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// ID for the Amazon Web Services Key Management Service (KMS) key that Amazon Comprehend
        /// uses to encrypt the output results from an analysis job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// When you use the <c>PiiOutputDataConfig</c> object with asynchronous operations, you
        /// specify the Amazon S3 location where you want to write the output data. 
        /// </para>
        ///  
        /// <para>
        ///  For a PII entity detection job, the output file is plain text, not a compressed archive.
        /// The output file name is the same as the input file, with <c>.out</c> appended at the
        /// end. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string S3Uri { get; set; }

        /// <summary>
        /// Checks to see if the S3Uri property is set.
        /// </summary>
        internal bool IsSetS3Uri() => this.S3Uri != null;
    }
}
