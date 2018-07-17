/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Describes the results of a transform job output.
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
        /// Defines how to assemble the results of the transform job as a single S3 object. You
        /// should select a format that is most convienant to you. To concatenate the results
        /// in binary format, specify <code>None</code>. To add a newline character at the end
        /// of every transformed record, specify <code>Line</code>. To assemble the output in
        /// RecordIO format, specify <code>RecordIO</code>. The default value is <code>None</code>.
        /// </para>
        ///  
        /// <para>
        /// For information about the <code>RecordIO</code> format, see <a href="http://mxnet.io/architecture/note_data_loading.html#data-format">Data
        /// Format</a>.
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
        /// The AWS Key Management Service (AWS KMS) key for Amazon S3 server-side encryption
        /// that Amazon SageMaker uses to encrypt the transformed data.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide a KMS key ID, Amazon SageMaker uses the default KMS key for Amazon
        /// S3 for your role's account. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">KMS-Managed
        /// Encryption Keys</a> in the <i>Amazon Simple Storage Service Developer Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// The KMS key policy must grant permission to the IAM role that you specify in your
        /// <code>CreateTramsformJob</code> request. For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Using
        /// Key Policies in AWS KMS</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
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
        /// job. For example, <code>s3://bucket-name/key-name-prefix</code>.
        /// </para>
        ///  
        /// <para>
        /// For every S3 object used as input for the transform job, the transformed data is stored
        /// in a corresponding subfolder in the location under the output prefix.For example,
        /// the input data <code>s3://bucket-name/input-name-prefix/dataset01/data.csv</code>
        /// will have the transformed data stored at <code>s3://bucket-name/key-name-prefix/dataset01/</code>,
        /// based on the original name, as a series of .part files (.part0001, part0002, etc).
        /// </para>
        /// </summary>
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