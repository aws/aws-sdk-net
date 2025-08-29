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
    /// A lifecycle rule for individual objects in an Amazon S3 bucket.
    /// 
    ///  
    /// <para>
    /// For more information see, <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lifecycle-mgmt.html">Managing
    /// your storage lifecycle</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class LifecycleRule
    {
        private LifecycleRuleAbortIncompleteMultipartUpload _abortIncompleteMultipartUpload;
        private LifecycleRuleExpiration _expiration;
        private LifecycleFilter _filter;
        private string _id;
        private LifecycleRuleNoncurrentVersionExpiration _noncurrentVersionExpiration;
        private List<LifecycleRuleNoncurrentVersionTransition> _noncurrentVersionTransitions = AWSConfigs.InitializeCollections ? new List<LifecycleRuleNoncurrentVersionTransition>() : null;
        private string _prefix;
        private LifecycleRuleStatus _status = LifecycleRuleStatus.Disabled;
        private List<LifecycleTransition> _transitions = AWSConfigs.InitializeCollections ? new List<LifecycleTransition>() : null;

        /// <summary>
        /// Gets and sets the property AbortIncompleteMultipartUpload.
        /// </summary>
        public LifecycleRuleAbortIncompleteMultipartUpload AbortIncompleteMultipartUpload
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
        public LifecycleRuleExpiration Expiration
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
        /// The <c>Filter</c> is used to identify objects that a Lifecycle Rule applies to. A
        /// <c>Filter</c> must have exactly one of <c>Prefix</c>, <c>Tag</c>, <c>ObjectSizeGreaterThan</c>,
        /// <c>ObjectSizeLessThan</c>, or <c>And</c> specified. <c>Filter</c> is required if the
        /// <c>LifecycleRule</c> does not contain a <c>Prefix</c> element.
        /// </para>
        ///  
        /// <para>
        /// For more information about <c>Tag</c> filters, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/intro-lifecycle-filters.html">Adding
        /// filters to Lifecycle rules</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Tag</c> filters are not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public LifecycleFilter Filter
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
        /// Gets and sets the property Id. 
        /// <para>
        /// Unique identifier for the rule. The value cannot be longer than 255 characters.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property NoncurrentVersionExpiration.
        /// </summary>
        public LifecycleRuleNoncurrentVersionExpiration NoncurrentVersionExpiration
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
        /// Specifies the transition rule for the lifecycle rule that describes when noncurrent
        /// objects transition to a specific storage class. If your bucket is versioning-enabled
        /// (or versioning is suspended), you can set this action to request that Amazon S3 transition
        /// noncurrent object versions to a specific storage class at a set period in the object's
        /// lifetime.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter applies to general purpose buckets only. It is not supported for directory
        /// bucket lifecycle configurations.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LifecycleRuleNoncurrentVersionTransition> NoncurrentVersionTransitions
        {
            get { return this._noncurrentVersionTransitions; }
            set { this._noncurrentVersionTransitions = value; }
        }

        // Check to see if NoncurrentVersionTransitions property is set
        internal bool IsSetNoncurrentVersionTransitions()
        {
            return this._noncurrentVersionTransitions != null && (this._noncurrentVersionTransitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Prefix identifying one or more objects to which the rule applies. This is no longer
        /// used; use <c>Filter</c> instead.
        /// </para>
        ///  <important> 
        /// <para>
        /// Replacement must be made for object keys containing special characters (such as carriage
        /// returns) when using XML requests. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-keys.html#object-key-xml-related-constraints">
        /// XML related object key constraints</a>.
        /// </para>
        ///  </important>
        /// </summary>
        [Obsolete("This property is deprecated. Use Filter instead.")]
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
        /// If 'Enabled', the rule is currently being applied. If 'Disabled', the rule is not
        /// currently being applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LifecycleRuleStatus Status
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
        /// This parameter applies to general purpose buckets only. It is not supported for directory
        /// bucket lifecycle configurations.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LifecycleTransition> Transitions
        {
            get { return this._transitions; }
            set { this._transitions = value; }
        }

        // Check to see if Transitions property is set
        internal bool IsSetTransitions()
        {
            return this._transitions != null && (this._transitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}