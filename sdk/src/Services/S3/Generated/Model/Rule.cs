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
    /// Specifies lifecycle rules for an Amazon S3 bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketPUTlifecycle.html">Put
    /// Bucket Lifecycle Configuration</a> in the <i>Amazon S3 API Reference</i>. For examples,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketLifecycleConfiguration.html#API_PutBucketLifecycleConfiguration_Examples">Put
    /// Bucket Lifecycle Configuration Examples</a>.
    /// </summary>
    public partial class Rule
    {
        private AbortIncompleteMultipartUpload _abortIncompleteMultipartUpload;
        private LifecycleExpiration _expiration;
        private string _id;
        private NoncurrentVersionExpiration _noncurrentVersionExpiration;
        private NoncurrentVersionTransition _noncurrentVersionTransition;
        private string _prefix;
        private ExpirationStatus _status;
        private Transition _transition;

        /// <summary>
        /// Gets and sets the property AbortIncompleteMultipartUpload.
        /// </summary>
        public AbortIncompleteMultipartUpload AbortIncompleteMultipartUpload
        {
            get { return this._abortIncompleteMultipartUpload; }
            set { this._abortIncompleteMultipartUpload = value; }
        }

        // Check to see if AbortIncompleteMultipartUpload property is set
        internal bool IsSetAbortIncompleteMultipartUpload()
        {
            return this._abortIncompleteMultipartUpload != null;
        }

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// Specifies the expiration for the lifecycle of the object.
        /// </para>
        /// </summary>
        public LifecycleExpiration Expiration
        {
            get { return this._expiration; }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration != null;
        }

        /// <summary>
        /// Gets and sets the property ID. 
        /// <para>
        /// Unique identifier for the rule. The value can't be longer than 255 characters.
        /// </para>
        /// </summary>
        public string ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if ID property is set
        internal bool IsSetID()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property NoncurrentVersionExpiration.
        /// </summary>
        public NoncurrentVersionExpiration NoncurrentVersionExpiration
        {
            get { return this._noncurrentVersionExpiration; }
            set { this._noncurrentVersionExpiration = value; }
        }

        // Check to see if NoncurrentVersionExpiration property is set
        internal bool IsSetNoncurrentVersionExpiration()
        {
            return this._noncurrentVersionExpiration != null;
        }

        /// <summary>
        /// Gets and sets the property NoncurrentVersionTransition.
        /// </summary>
        public NoncurrentVersionTransition NoncurrentVersionTransition
        {
            get { return this._noncurrentVersionTransition; }
            set { this._noncurrentVersionTransition = value; }
        }

        // Check to see if NoncurrentVersionTransition property is set
        internal bool IsSetNoncurrentVersionTransition()
        {
            return this._noncurrentVersionTransition != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Object key prefix that identifies one or more objects to which this rule applies.
        /// </para>
        ///  <important> 
        /// <para>
        /// Replacement must be made for object keys containing special characters (such as carriage
        /// returns) when using XML requests. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html#object-key-xml-related-constraints">
        /// XML related object key constraints</a>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// If <c>Enabled</c>, the rule is currently being applied. If <c>Disabled</c>, the rule
        /// is not currently being applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExpirationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Transition. 
        /// <para>
        /// Specifies when an object transitions to a specified storage class. For more information
        /// about Amazon S3 lifecycle configuration rules, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/lifecycle-transition-general-considerations.html">Transitioning
        /// Objects Using Amazon S3 Lifecycle</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public Transition Transition
        {
            get { return this._transition; }
            set { this._transition = value; }
        }

        // Check to see if Transition property is set
        internal bool IsSetTransition()
        {
            return this._transition != null;
        }

    }
}