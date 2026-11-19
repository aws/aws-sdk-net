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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// The configuration of a medical coding dataset. Amazon Connect Health uses the coded
    /// examples that are in the input location when you create the dataset, and writes evaluation
    /// scores to the output location, with your permissions. Later changes to the input location
    /// don't change the dataset.
    /// </summary>
    public partial class MedicalCodingDatasetConfig
    {
        /// <summary>
        /// Gets and sets the property S3InputPath. 
        /// <para>
        /// The Amazon S3 location of your coded examples. You need s3:GetObject and s3:ListBucket
        /// permissions for it, and kms:Decrypt if you encrypt it with an AWS KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1024)]
        public string S3InputPath { get; set; }

        /// <summary>
        /// Checks to see if the S3InputPath property is set.
        /// </summary>
        internal bool IsSetS3InputPath() => this.S3InputPath != null;

        /// <summary>
        /// Gets and sets the property S3OutputPath. 
        /// <para>
        /// The Amazon S3 location where Amazon Connect Health writes the evaluation scores for
        /// the dataset. You need s3:PutObject permission for it, and kms:GenerateDataKey if you
        /// encrypt it with an AWS KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1024)]
        public string S3OutputPath { get; set; }

        /// <summary>
        /// Checks to see if the S3OutputPath property is set.
        /// </summary>
        internal bool IsSetS3OutputPath() => this.S3OutputPath != null;
    }
}
