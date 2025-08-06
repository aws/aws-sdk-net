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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the transition rule that describes when noncurrent objects transition
    /// to the <c>STANDARD_IA</c>, <c>ONEZONE_IA</c>, <c>INTELLIGENT_TIERING</c>, <c>GLACIER_IR</c>,
    /// <c>GLACIER</c>, or <c>DEEP_ARCHIVE</c> storage class. If your bucket is versioning-enabled
    /// (or versioning is suspended), you can set this action to request that Amazon S3 transition
    /// noncurrent object versions to the <c>STANDARD_IA</c>, <c>ONEZONE_IA</c>, <c>INTELLIGENT_TIERING</c>,
    /// <c>GLACIER_IR</c>, <c>GLACIER</c>, or <c>DEEP_ARCHIVE</c> storage class at a specific
    /// period in the object's lifetime.
    /// </summary>
    public partial class LifecycleRuleNoncurrentVersionTransition
    {
        private int? _newerNoncurrentVersions;
        private int? _noncurrentDays;
        private S3StorageClass _storageClass;

        /// <summary>
        /// Gets and sets the property NewerNoncurrentVersions. 
        /// <para>
        /// Specifies how many noncurrent versions Amazon S3 will retain in the same storage class
        /// before transitioning objects. You can specify up to 100 noncurrent versions to retain.
        /// Amazon S3 will transition any additional noncurrent versions beyond the specified
        /// number to retain. For more information about noncurrent versions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/intro-lifecycle-rules.html">Lifecycle
        /// configuration elements</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public int? NewerNoncurrentVersions
        {
            get { return this._newerNoncurrentVersions; }
            set { this._newerNoncurrentVersions = value; }
        }

        // Check to see if NewerNoncurrentVersions property is set
        internal bool IsSetNewerNoncurrentVersions()
        {
            return this._newerNoncurrentVersions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NoncurrentDays. 
        /// <para>
        /// Specifies the number of days an object is noncurrent before Amazon S3 can perform
        /// the associated action. For information about the noncurrent days calculations, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/intro-lifecycle-rules.html#non-current-days-calculations">How
        /// Amazon S3 Calculates How Long an Object Has Been Noncurrent</a> in the <i>Amazon S3
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public int? NoncurrentDays
        {
            get { return this._noncurrentDays; }
            set { this._noncurrentDays = value; }
        }

        // Check to see if NoncurrentDays property is set
        internal bool IsSetNoncurrentDays()
        {
            return this._noncurrentDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The class of storage used to store the object.
        /// </para>
        /// </summary>
        public S3StorageClass StorageClass
        {
            get { return this._storageClass; }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass != null;
        }

    }
}