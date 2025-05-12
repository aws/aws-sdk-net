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
    /// Describes the results of a transform job.
    /// </summary>
    public partial class TransformOutput
    {
        private string _accept;
        private AssemblyType _assembleWith;
        private string _kmsKeyId;
        private string _s3OutputPath;

        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        /// The MIME type used to specify the output data. Amazon SageMaker uses the MIME type
        /// with each http call to transfer data from the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Accept
        {
            get { return this._accept; }
            set { this._accept = value; }
        }

        // Check to see if Accept property is set
        internal bool IsSetAccept()
        {
            return this._accept != null;
        }

        /// <summary>
        /// Gets and sets the property AssembleWith. 
        /// <para>
        /// Defines how to assemble the results of the transform job as a single S3 object. Choose
        /// a format that is most convenient to you. To concatenate the results in binary format,
        /// specify <c>None</c>. To add a newline character at the end of every transformed record,
        /// specify <c>Line</c>.
        /// </para>
        /// </summary>
        public AssemblyType AssembleWith
        {
            get { return this._assembleWith; }
            set { this._assembleWith = value; }
        }

        // Check to see if AssembleWith property is set
        internal bool IsSetAssembleWith()
        {
            return this._assembleWith != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that
        /// Amazon SageMaker uses to encrypt the model artifacts at rest using Amazon S3 server-side
        /// encryption. The <c>KmsKeyId</c> can be any of the following formats: 
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
        /// <para>
        /// If you don't provide a KMS key ID, Amazon SageMaker uses the default KMS key for Amazon
        /// S3 for your role's account. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">KMS-Managed
        /// Encryption Keys</a> in the <i>Amazon Simple Storage Service Developer Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// The KMS key policy must grant permission to the IAM role that you specify in your
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateModel.html">CreateModel</a>
        /// request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Using
        /// Key Policies in Amazon Web Services KMS</a> in the <i>Amazon Web Services Key Management
        /// Service Developer Guide</i>.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property S3OutputPath. 
        /// <para>
        /// The Amazon S3 path where you want Amazon SageMaker to store the results of the transform
        /// job. For example, <c>s3://bucket-name/key-name-prefix</c>.
        /// </para>
        ///  
        /// <para>
        /// For every S3 object used as input for the transform job, batch transform stores the
        /// transformed data with an .<c>out</c> suffix in a corresponding subfolder in the location
        /// in the output prefix. For example, for the input data stored at <c>s3://bucket-name/input-name-prefix/dataset01/data.csv</c>,
        /// batch transform stores the transformed data at <c>s3://bucket-name/output-name-prefix/input-name-prefix/data.csv.out</c>.
        /// Batch transform doesn't upload partially processed objects. For an input S3 object
        /// that contains multiple records, it creates an .<c>out</c> file only if the transform
        /// job succeeds on the entire file. When the input contains multiple S3 objects, the
        /// batch transform job processes the listed S3 objects and uploads only the output for
        /// successfully processed objects. If any object fails in the transform job batch transform
        /// marks the job as failed to prompt investigation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string S3OutputPath
        {
            get { return this._s3OutputPath; }
            set { this._s3OutputPath = value; }
        }

        // Check to see if S3OutputPath property is set
        internal bool IsSetS3OutputPath()
        {
            return this._s3OutputPath != null;
        }

    }
}