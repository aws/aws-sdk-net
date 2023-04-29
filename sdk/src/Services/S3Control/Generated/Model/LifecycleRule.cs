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
    /// The container for the Outposts bucket lifecycle rule.
    /// </summary>
    public partial class LifecycleRule
    {
        private AbortIncompleteMultipartUpload _abortIncompleteMultipartUpload;
        private LifecycleExpiration _expiration;
        private LifecycleRuleFilter _filter;
        private string _id;
        private NoncurrentVersionExpiration _noncurrentVersionExpiration;
        private List<NoncurrentVersionTransition> _noncurrentVersionTransitions = new List<NoncurrentVersionTransition>();
        private ExpirationStatus _status;
        private List<Transition> _transitions = new List<Transition>();

        /// <summary>
        /// Gets and sets the property AbortIncompleteMultipartUpload. 
        /// <para>
        /// Specifies the days since the initiation of an incomplete multipart upload that Amazon
        /// S3 waits before permanently removing all parts of the upload. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html#mpu-abort-incomplete-mpu-lifecycle-config">
        /// Aborting Incomplete Multipart Uploads Using a Bucket Lifecycle Configuration</a> in
        /// the <i>Amazon S3 User Guide</i>.
        /// </para>
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
        /// Specifies the expiration for the lifecycle of the object in the form of date, days
        /// and, whether the object has a delete marker.
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
        /// Gets and sets the property Filter. 
        /// <para>
        /// The container for the filter of lifecycle rule.
        /// </para>
        /// </summary>
        public LifecycleRuleFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property ID. 
        /// <para>
        /// Unique identifier for the rule. The value cannot be longer than 255 characters.
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
        /// <para>
        /// The noncurrent version expiration of the lifecycle rule.
        /// </para>
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
        /// Gets and sets the property NoncurrentVersionTransitions. 
        /// <para>
        ///  Specifies the transition rule for the lifecycle rule that describes when noncurrent
        /// objects transition to a specific storage class. If your bucket is versioning-enabled
        /// (or versioning is suspended), you can set this action to request that Amazon S3 transition
        /// noncurrent object versions to a specific storage class at a set period in the object's
        /// lifetime. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public List<NoncurrentVersionTransition> NoncurrentVersionTransitions
        {
            get { return this._noncurrentVersionTransitions; }
            set { this._noncurrentVersionTransitions = value; }
        }

        // Check to see if NoncurrentVersionTransitions property is set
        internal bool IsSetNoncurrentVersionTransitions()
        {
            return this._noncurrentVersionTransitions != null && this._noncurrentVersionTransitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// If 'Enabled', the rule is currently being applied. If 'Disabled', the rule is not
        /// currently being applied.
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
        /// Gets and sets the property Transitions. 
        /// <para>
        /// Specifies when an Amazon S3 object transitions to a specified storage class.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public List<Transition> Transitions
        {
            get { return this._transitions; }
            set { this._transitions = value; }
        }

        // Check to see if Transitions property is set
        internal bool IsSetTransitions()
        {
            return this._transitions != null && this._transitions.Count > 0; 
        }

    }
}