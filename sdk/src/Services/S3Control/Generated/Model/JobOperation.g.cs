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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// The operation that you want this job to perform on every object listed in the manifest.
    /// For more information about the available operations, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-operations.html">Operations</a>
    /// in the <i>Amazon S3 User Guide</i>.
    /// </summary>
    public partial class JobOperation
    {
        /// <summary>
        /// Gets and sets the property LambdaInvoke. 
        /// <para>
        /// Directs the specified job to invoke an Lambda function on every object in the manifest.
        /// </para>
        /// </summary>
        public LambdaInvokeOperation LambdaInvoke { get; set; }

        /// <summary>
        /// Checks to see if the LambdaInvoke property is set.
        /// </summary>
        internal bool IsSetLambdaInvoke() => this.LambdaInvoke != null;

        /// <summary>
        /// Gets and sets the property S3ComputeObjectChecksum. 
        /// <para>
        /// Directs the specified job to compute checksum values for every object in the manifest.
        /// </para>
        /// </summary>
        public S3ComputeObjectChecksumOperation S3ComputeObjectChecksum { get; set; }

        /// <summary>
        /// Checks to see if the S3ComputeObjectChecksum property is set.
        /// </summary>
        internal bool IsSetS3ComputeObjectChecksum() => this.S3ComputeObjectChecksum != null;

        /// <summary>
        /// Gets and sets the property S3DeleteObjectTagging. 
        /// <para>
        /// Directs the specified job to execute a DELETE Object tagging call on every object
        /// in the manifest.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public S3DeleteObjectTaggingOperation S3DeleteObjectTagging { get; set; }

        /// <summary>
        /// Checks to see if the S3DeleteObjectTagging property is set.
        /// </summary>
        internal bool IsSetS3DeleteObjectTagging() => this.S3DeleteObjectTagging != null;

        /// <summary>
        /// Gets and sets the property S3InitiateRestoreObject. 
        /// <para>
        /// Directs the specified job to initiate restore requests for every archived object in
        /// the manifest.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public S3InitiateRestoreObjectOperation S3InitiateRestoreObject { get; set; }

        /// <summary>
        /// Checks to see if the S3InitiateRestoreObject property is set.
        /// </summary>
        internal bool IsSetS3InitiateRestoreObject() => this.S3InitiateRestoreObject != null;

        /// <summary>
        /// Gets and sets the property S3PutObjectAcl. 
        /// <para>
        /// Directs the specified job to run a <c>PutObjectAcl</c> call on every object in the
        /// manifest.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public S3SetObjectAclOperation S3PutObjectAcl { get; set; }

        /// <summary>
        /// Checks to see if the S3PutObjectAcl property is set.
        /// </summary>
        internal bool IsSetS3PutObjectAcl() => this.S3PutObjectAcl != null;

        /// <summary>
        /// Gets and sets the property S3PutObjectCopy. 
        /// <para>
        /// Directs the specified job to run a PUT Copy object call on every object in the manifest.
        /// </para>
        /// </summary>
        public S3CopyObjectOperation S3PutObjectCopy { get; set; }

        /// <summary>
        /// Checks to see if the S3PutObjectCopy property is set.
        /// </summary>
        internal bool IsSetS3PutObjectCopy() => this.S3PutObjectCopy != null;

        /// <summary>
        /// Gets and sets the property S3PutObjectLegalHold.
        /// </summary>
        public S3SetObjectLegalHoldOperation S3PutObjectLegalHold { get; set; }

        /// <summary>
        /// Checks to see if the S3PutObjectLegalHold property is set.
        /// </summary>
        internal bool IsSetS3PutObjectLegalHold() => this.S3PutObjectLegalHold != null;

        /// <summary>
        /// Gets and sets the property S3PutObjectRetention.
        /// </summary>
        public S3SetObjectRetentionOperation S3PutObjectRetention { get; set; }

        /// <summary>
        /// Checks to see if the S3PutObjectRetention property is set.
        /// </summary>
        internal bool IsSetS3PutObjectRetention() => this.S3PutObjectRetention != null;

        /// <summary>
        /// Gets and sets the property S3PutObjectTagging. 
        /// <para>
        /// Directs the specified job to run a PUT Object tagging call on every object in the
        /// manifest.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public S3SetObjectTaggingOperation S3PutObjectTagging { get; set; }

        /// <summary>
        /// Checks to see if the S3PutObjectTagging property is set.
        /// </summary>
        internal bool IsSetS3PutObjectTagging() => this.S3PutObjectTagging != null;

        /// <summary>
        /// Gets and sets the property S3ReplicateObject. 
        /// <para>
        /// Directs the specified job to invoke <c>ReplicateObject</c> on every object in the
        /// job's manifest.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public S3ReplicateObjectOperation S3ReplicateObject { get; set; }

        /// <summary>
        /// Checks to see if the S3ReplicateObject property is set.
        /// </summary>
        internal bool IsSetS3ReplicateObject() => this.S3ReplicateObject != null;

        /// <summary>
        /// Gets and sets the property S3UpdateObjectEncryption. 
        /// <para>
        /// Updates the server-side encryption type of an existing encrypted object in a general
        /// purpose bucket. You can use the <c>UpdateObjectEncryption</c> operation to change
        /// encrypted objects from server-side encryption with Amazon S3 managed keys (SSE-S3)
        /// to server-side encryption with Key Management Service (KMS) keys (SSE-KMS), or to
        /// apply S3 Bucket Keys. You can also use the <c>UpdateObjectEncryption</c> operation
        /// to change the customer-managed KMS key used to encrypt your data so that you can comply
        /// with custom key-rotation standards.
        /// </para>
        /// </summary>
        public S3UpdateObjectEncryptionOperation S3UpdateObjectEncryption { get; set; }

        /// <summary>
        /// Checks to see if the S3UpdateObjectEncryption property is set.
        /// </summary>
        internal bool IsSetS3UpdateObjectEncryption() => this.S3UpdateObjectEncryption != null;
    }
}
