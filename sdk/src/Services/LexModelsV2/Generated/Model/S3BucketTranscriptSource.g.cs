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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// The object representing the Amazon S3 bucket containing the transcript, as well as
    /// the associated metadata.
    /// </summary>
    public partial class S3BucketTranscriptSource
    {
        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the KMS key that customer use to encrypt their Amazon S3 bucket. Only use
        /// this field if your bucket is encrypted using a customer managed KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property PathFormat. 
        /// <para>
        /// The object that contains a path format that will be applied when Amazon Lex reads
        /// the transcript file in the bucket you provide. Specify this object if you only want
        /// Lex to read a subset of files in your Amazon S3 bucket.
        /// </para>
        /// </summary>
        public PathFormat PathFormat { get; set; }

        /// <summary>
        /// Checks to see if the PathFormat property is set.
        /// </summary>
        internal bool IsSetPathFormat() => this.PathFormat != null;

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the bucket containing the transcript and the associated metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string S3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketName property is set.
        /// </summary>
        internal bool IsSetS3BucketName() => this.S3BucketName != null;

        /// <summary>
        /// Gets and sets the property TranscriptFilter. 
        /// <para>
        /// The object that contains the filter which will be applied when Amazon Lex reads through
        /// the Amazon S3 bucket. Specify this object if you want Amazon Lex to read only a subset
        /// of the Amazon S3 bucket based on the filter you provide.
        /// </para>
        /// </summary>
        public TranscriptFilter TranscriptFilter { get; set; }

        /// <summary>
        /// Checks to see if the TranscriptFilter property is set.
        /// </summary>
        internal bool IsSetTranscriptFilter() => this.TranscriptFilter != null;

        /// <summary>
        /// Gets and sets the property TranscriptFormat. 
        /// <para>
        /// The format of the transcript content. Currently, Genie only supports the Amazon Lex
        /// transcript format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TranscriptFormat TranscriptFormat { get; set; }

        /// <summary>
        /// Checks to see if the TranscriptFormat property is set.
        /// </summary>
        internal bool IsSetTranscriptFormat() => this.TranscriptFormat != null;
    }
}
