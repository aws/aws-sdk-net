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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// The operation that you want this job to perform on each object listed in the manifest.
    /// For more information about the available operations, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-operations.html">Operations</a>
    /// in the <i>Amazon Simple Storage Service Developer Guide</i>.
    /// </summary>
    public partial class JobOperation
    {
        private LambdaInvokeOperation _lambdaInvoke;
        private S3InitiateRestoreObjectOperation _s3InitiateRestoreObject;
        private S3SetObjectAclOperation _s3PutObjectAcl;
        private S3CopyObjectOperation _s3PutObjectCopy;
        private S3SetObjectLegalHoldOperation _s3PutObjectLegalHold;
        private S3SetObjectRetentionOperation _s3PutObjectRetention;
        private S3SetObjectTaggingOperation _s3PutObjectTagging;

        /// <summary>
        /// Gets and sets the property LambdaInvoke. 
        /// <para>
        /// Directs the specified job to invoke an AWS Lambda function on each object in the manifest.
        /// </para>
        /// </summary>
        public LambdaInvokeOperation LambdaInvoke
        {
            get { return this._lambdaInvoke; }
            set { this._lambdaInvoke = value; }
        }

        // Check to see if LambdaInvoke property is set
        internal bool IsSetLambdaInvoke()
        {
            return this._lambdaInvoke != null;
        }

        /// <summary>
        /// Gets and sets the property S3InitiateRestoreObject. 
        /// <para>
        /// Directs the specified job to run an Initiate Glacier Restore call on each object in
        /// the manifest.
        /// </para>
        /// </summary>
        public S3InitiateRestoreObjectOperation S3InitiateRestoreObject
        {
            get { return this._s3InitiateRestoreObject; }
            set { this._s3InitiateRestoreObject = value; }
        }

        // Check to see if S3InitiateRestoreObject property is set
        internal bool IsSetS3InitiateRestoreObject()
        {
            return this._s3InitiateRestoreObject != null;
        }

        /// <summary>
        /// Gets and sets the property S3PutObjectAcl. 
        /// <para>
        /// Directs the specified job to run a PUT Object acl call on each object in the manifest.
        /// </para>
        /// </summary>
        public S3SetObjectAclOperation S3PutObjectAcl
        {
            get { return this._s3PutObjectAcl; }
            set { this._s3PutObjectAcl = value; }
        }

        // Check to see if S3PutObjectAcl property is set
        internal bool IsSetS3PutObjectAcl()
        {
            return this._s3PutObjectAcl != null;
        }

        /// <summary>
        /// Gets and sets the property S3PutObjectCopy. 
        /// <para>
        /// Directs the specified job to run a PUT Copy object call on each object in the manifest.
        /// </para>
        /// </summary>
        public S3CopyObjectOperation S3PutObjectCopy
        {
            get { return this._s3PutObjectCopy; }
            set { this._s3PutObjectCopy = value; }
        }

        // Check to see if S3PutObjectCopy property is set
        internal bool IsSetS3PutObjectCopy()
        {
            return this._s3PutObjectCopy != null;
        }

        /// <summary>
        /// Gets and sets the property S3PutObjectLegalHold.
        /// </summary>
        public S3SetObjectLegalHoldOperation S3PutObjectLegalHold
        {
            get { return this._s3PutObjectLegalHold; }
            set { this._s3PutObjectLegalHold = value; }
        }

        // Check to see if S3PutObjectLegalHold property is set
        internal bool IsSetS3PutObjectLegalHold()
        {
            return this._s3PutObjectLegalHold != null;
        }

        /// <summary>
        /// Gets and sets the property S3PutObjectRetention.
        /// </summary>
        public S3SetObjectRetentionOperation S3PutObjectRetention
        {
            get { return this._s3PutObjectRetention; }
            set { this._s3PutObjectRetention = value; }
        }

        // Check to see if S3PutObjectRetention property is set
        internal bool IsSetS3PutObjectRetention()
        {
            return this._s3PutObjectRetention != null;
        }

        /// <summary>
        /// Gets and sets the property S3PutObjectTagging. 
        /// <para>
        /// Directs the specified job to run a PUT Object tagging call on each object in the manifest.
        /// </para>
        /// </summary>
        public S3SetObjectTaggingOperation S3PutObjectTagging
        {
            get { return this._s3PutObjectTagging; }
            set { this._s3PutObjectTagging = value; }
        }

        // Check to see if S3PutObjectTagging property is set
        internal bool IsSetS3PutObjectTagging()
        {
            return this._s3PutObjectTagging != null;
        }

    }
}