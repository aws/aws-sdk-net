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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Configuration for a lifecycle rule.
    /// </summary>
    public partial class AwsS3BucketBucketLifecycleConfigurationRulesDetails
    {
        /// <summary>
        /// Gets and sets the property AbortIncompleteMultipartUpload. 
        /// <para>
        /// How Amazon S3 responds when a multipart upload is incomplete. Specifically, provides
        /// a number of days before Amazon S3 cancels the entire upload.
        /// </para>
        /// </summary>
        public AwsS3BucketBucketLifecycleConfigurationRulesAbortIncompleteMultipartUploadDetails AbortIncompleteMultipartUpload { get; set; }

        /// <summary>
        /// Checks to see if the AbortIncompleteMultipartUpload property is set.
        /// </summary>
        internal bool IsSetAbortIncompleteMultipartUpload() => this.AbortIncompleteMultipartUpload != null;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date when objects are moved or deleted.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate != null;

        /// <summary>
        /// Gets and sets the property ExpirationInDays. 
        /// <para>
        /// The length in days of the lifetime for objects that are subject to the rule.
        /// </para>
        /// </summary>
        public int? ExpirationInDays { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationInDays property is set.
        /// </summary>
        internal bool IsSetExpirationInDays() => this.ExpirationInDays.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiredObjectDeleteMarker. 
        /// <para>
        /// Whether Amazon S3 removes a delete marker that has no noncurrent versions. If set
        /// to <c>true</c>, the delete marker is expired. If set to <c>false</c>, the policy takes
        /// no action.
        /// </para>
        ///  
        /// <para>
        /// If you provide <c>ExpiredObjectDeleteMarker</c>, you cannot provide <c>ExpirationInDays</c>
        /// or <c>ExpirationDate</c>.
        /// </para>
        /// </summary>
        public bool? ExpiredObjectDeleteMarker { get; set; }

        /// <summary>
        /// Checks to see if the ExpiredObjectDeleteMarker property is set.
        /// </summary>
        internal bool IsSetExpiredObjectDeleteMarker() => this.ExpiredObjectDeleteMarker.HasValue;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Identifies the objects that a rule applies to.
        /// </para>
        /// </summary>
        public AwsS3BucketBucketLifecycleConfigurationRulesFilterDetails Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property ID. 
        /// <para>
        /// The unique identifier of the rule.
        /// </para>
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Checks to see if the ID property is set.
        /// </summary>
        internal bool IsSetID() => this.ID != null;

        /// <summary>
        /// Gets and sets the property NoncurrentVersionExpirationInDays. 
        /// <para>
        /// The number of days that an object is noncurrent before Amazon S3 can perform the associated
        /// action.
        /// </para>
        /// </summary>
        public int? NoncurrentVersionExpirationInDays { get; set; }

        /// <summary>
        /// Checks to see if the NoncurrentVersionExpirationInDays property is set.
        /// </summary>
        internal bool IsSetNoncurrentVersionExpirationInDays() => this.NoncurrentVersionExpirationInDays.HasValue;

        /// <summary>
        /// Gets and sets the property NoncurrentVersionTransitions. 
        /// <para>
        /// Transition rules that describe when noncurrent objects transition to a specified storage
        /// class.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsS3BucketBucketLifecycleConfigurationRulesNoncurrentVersionTransitionsDetails> NoncurrentVersionTransitions { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsS3BucketBucketLifecycleConfigurationRulesNoncurrentVersionTransitionsDetails>() : null;

        /// <summary>
        /// Checks to see if the NoncurrentVersionTransitions property is set.
        /// </summary>
        internal bool IsSetNoncurrentVersionTransitions() => this.NoncurrentVersionTransitions != null && (this.NoncurrentVersionTransitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// A prefix that identifies one or more objects that the rule applies to.
        /// </para>
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the rule. Indicates whether the rule is currently being applied.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Transitions. 
        /// <para>
        /// Transition rules that indicate when objects transition to a specified storage class.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsS3BucketBucketLifecycleConfigurationRulesTransitionsDetails> Transitions { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsS3BucketBucketLifecycleConfigurationRulesTransitionsDetails>() : null;

        /// <summary>
        /// Checks to see if the Transitions property is set.
        /// </summary>
        internal bool IsSetTransitions() => this.Transitions != null && (this.Transitions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
