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
using System;
using System.Collections.Generic;

namespace Amazon.S3.Model
{
    /// <summary>
    /// <para>
    /// A lifecycle rule for individual objects in an Amazon S3 bucket.
    /// </para>
    /// <para>
    /// For more information see, <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lifecycle-mgmt.html">Managing
    /// your storage lifecycle</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    /// </summary>
    public class LifecycleRule
    {
        private LifecycleRuleAbortIncompleteMultipartUpload abortIncompleteMultipartUpload;
        private LifecycleRuleExpiration expiration;
        private string id;
        private LifecycleRuleNoncurrentVersionExpiration noncurrentVersionExpiration;
        private List<LifecycleRuleNoncurrentVersionTransition> noncurrentVersionTransitions = AWSConfigs.InitializeCollections ? new List<LifecycleRuleNoncurrentVersionTransition>() : null;
        private LifecycleRuleStatus status = LifecycleRuleStatus.Disabled;
        private List<LifecycleTransition> transitions = AWSConfigs.InitializeCollections ? new List<LifecycleTransition>() : null;

        private LifecycleFilter filter;

        /// <summary>
        /// Specifies the days since the initiation of an Incomplete Multipart Upload
        /// that Lifecycle will wait before permanently removing all parts of the upload.
        /// </summary>
        public LifecycleRuleAbortIncompleteMultipartUpload AbortIncompleteMultipartUpload
        {
            get { return this.abortIncompleteMultipartUpload; }
            set { this.abortIncompleteMultipartUpload = value; }
        }

        // Check to see if AbortIncompleteMultipartUpload property is set
        internal bool IsSetAbortIncompleteMultipartUpload()
        {
            return this.abortIncompleteMultipartUpload != null;
        }

        /// <summary>
        /// Defines the length of time, in days, before objects expire.
        /// </summary>
        public LifecycleRuleExpiration Expiration
        {
            get { return this.expiration; }
            set { this.expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this.expiration != null;
        }

        /// <summary>
        /// Unique identifier for the rule. The value cannot be longer than 255 characters.
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        // Check to see if ID property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// Defines the length of time, in days, before noncurrent versions expire.
        /// </summary>
        public LifecycleRuleNoncurrentVersionExpiration NoncurrentVersionExpiration
        {
            get { return this.noncurrentVersionExpiration; }
            set { this.noncurrentVersionExpiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetNoncurrentVersionExpiration()
        {
            return this.noncurrentVersionExpiration != null;
        }

        /// <summary>
        /// Filter identifying one or more objects to which the rule applies.
        /// <para>
        /// The <c>Filter</c> is used to identify objects that a Lifecycle Rule applies to. A <c>Filter</c> must have exactly one of 
        /// <c>Prefix</c>, <c>Tag</c>, <c>ObjectSizeGreaterThan</c>, <c>ObjectSizeLessThan</c>, or <c>And</c> specified.
        /// <c>Filter</c> is required if the <c>LifecycleRule</c> does not contain a <c>Prefix</c> element.
        /// </para>
        /// <para>
        /// For more information about <c>Tag</c> filters, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/intro-lifecycle-filters.html">Adding
        /// filters to Lifecycle rules</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// <note>
        /// <para>
        /// <c>Tag</c> filters are not supported for directory buckets.
        /// </para> 
        /// </note>
        /// </summary>
        public LifecycleFilter Filter
        {
            get { return this.filter; }
            set { this.filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this.filter != null;
        }

        /// <summary>
        /// If 'Enabled', the rule is currently being applied. If 'Disabled', the rule is not currently being applied.
        ///  
        /// </summary>
        public LifecycleRuleStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The transition rules that describe when noncurrent versions transition to
        /// a different storage class.
        /// </summary>
        public List<LifecycleRuleNoncurrentVersionTransition> NoncurrentVersionTransitions
        {
            get { return this.noncurrentVersionTransitions; }
            set { this.noncurrentVersionTransitions = value; }
        }

        // Check to see if Transitions property is set
        internal bool IsSetNoncurrentVersionTransitions()
        {
            return this.noncurrentVersionTransitions != null && (this.noncurrentVersionTransitions.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// The transition rules that describe when objects transition to a different storage class.
        /// </summary>
        public List<LifecycleTransition> Transitions
        {
            get { return this.transitions; }
            set { this.transitions = value; }
        }

        // Check to see if Transitions property is set
        internal bool IsSetTransitions()
        {
            return this.transitions != null && (this.transitions.Count > 0 || !AWSConfigs.InitializeCollections);
        }
    }
}
