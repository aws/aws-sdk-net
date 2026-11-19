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
    /// The container for the Outposts bucket lifecycle rule.
    /// </summary>
    public partial class LifecycleRule
    {
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
        public AbortIncompleteMultipartUpload AbortIncompleteMultipartUpload { get; set; }

        /// <summary>
        /// Checks to see if the AbortIncompleteMultipartUpload property is set.
        /// </summary>
        internal bool IsSetAbortIncompleteMultipartUpload() => this.AbortIncompleteMultipartUpload != null;

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// Specifies the expiration for the lifecycle of the object in the form of date, days
        /// and, whether the object has a delete marker.
        /// </para>
        /// </summary>
        public LifecycleExpiration Expiration { get; set; }

        /// <summary>
        /// Checks to see if the Expiration property is set.
        /// </summary>
        internal bool IsSetExpiration() => this.Expiration != null;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The container for the filter of lifecycle rule.
        /// </para>
        /// </summary>
        public LifecycleRuleFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property ID. 
        /// <para>
        /// Unique identifier for the rule. The value cannot be longer than 255 characters.
        /// </para>
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Checks to see if the ID property is set.
        /// </summary>
        internal bool IsSetID() => this.ID != null;

        /// <summary>
        /// Gets and sets the property NoncurrentVersionExpiration. 
        /// <para>
        /// The noncurrent version expiration of the lifecycle rule.
        /// </para>
        /// </summary>
        public NoncurrentVersionExpiration NoncurrentVersionExpiration { get; set; }

        /// <summary>
        /// Checks to see if the NoncurrentVersionExpiration property is set.
        /// </summary>
        internal bool IsSetNoncurrentVersionExpiration() => this.NoncurrentVersionExpiration != null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NoncurrentVersionTransition> NoncurrentVersionTransitions { get; set; } = AWSConfigs.InitializeCollections ? new List<NoncurrentVersionTransition>() : null;

        /// <summary>
        /// Checks to see if the NoncurrentVersionTransitions property is set.
        /// </summary>
        internal bool IsSetNoncurrentVersionTransitions() => this.NoncurrentVersionTransitions != null && (this.NoncurrentVersionTransitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// If 'Enabled', the rule is currently being applied. If 'Disabled', the rule is not
        /// currently being applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExpirationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Transition> Transitions { get; set; } = AWSConfigs.InitializeCollections ? new List<Transition>() : null;

        /// <summary>
        /// Checks to see if the Transitions property is set.
        /// </summary>
        internal bool IsSetTransitions() => this.Transitions != null && (this.Transitions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
