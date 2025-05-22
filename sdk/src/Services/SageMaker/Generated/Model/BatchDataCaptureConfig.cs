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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration to control how SageMaker captures inference data for batch transform
    /// jobs.
    /// </summary>
    public partial class BatchDataCaptureConfig
    {
        private string _destinationS3Uri;
        private bool? _generateInferenceId;
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property DestinationS3Uri. 
        /// <para>
        /// The Amazon S3 location being used to capture the data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string DestinationS3Uri
        {
            get { return this._destinationS3Uri; }
            set { this._destinationS3Uri = value; }
        }

        // Check to see if DestinationS3Uri property is set
        internal bool IsSetDestinationS3Uri()
        {
            return this._destinationS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property GenerateInferenceId. 
        /// <para>
        /// Flag that indicates whether to append inference id to the output.
        /// </para>
        /// </summary>
        public bool? GenerateInferenceId
        {
            get { return this._generateInferenceId; }
            set { this._generateInferenceId = value; }
        }

        // Check to see if GenerateInferenceId property is set
        internal bool IsSetGenerateInferenceId()
        {
            return this._generateInferenceId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Amazon Web Services Key Management Service key
        /// that SageMaker uses to encrypt data on the storage volume attached to the ML compute
        /// instance that hosts the batch transform job.
        /// </para>
        ///  
        /// <para>
        /// The KmsKeyId can be any of the following formats: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <c>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <c>alias/ExampleAlias</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name ARN: <c>arn:aws:kms:us-west-2:111122223333:alias/ExampleAlias</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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

    }
}