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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes an Amazon Lightsail bucket.
    /// </summary>
    public partial class Bucket
    {
        /// <summary>
        /// Gets and sets the property AbleToUpdateBundle. 
        /// <para>
        /// Indicates whether the bundle that is currently applied to a bucket can be changed
        /// to another bundle.
        /// </para>
        ///  
        /// <para>
        /// You can update a bucket's bundle only one time within a monthly Amazon Web Services
        /// billing cycle.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_UpdateBucketBundle.html">UpdateBucketBundle</a>
        /// action to change a bucket's bundle.
        /// </para>
        /// </summary>
        public bool? AbleToUpdateBundle { get; set; }

        /// <summary>
        /// Checks to see if the AbleToUpdateBundle property is set.
        /// </summary>
        internal bool IsSetAbleToUpdateBundle() => this.AbleToUpdateBundle.HasValue;

        /// <summary>
        /// Gets and sets the property AccessLogConfig. 
        /// <para>
        /// An object that describes the access log configuration for the bucket.
        /// </para>
        /// </summary>
        public BucketAccessLogConfig AccessLogConfig { get; set; }

        /// <summary>
        /// Checks to see if the AccessLogConfig property is set.
        /// </summary>
        internal bool IsSetAccessLogConfig() => this.AccessLogConfig != null;

        /// <summary>
        /// Gets and sets the property AccessRules. 
        /// <para>
        /// An object that describes the access rules of the bucket.
        /// </para>
        /// </summary>
        public AccessRules AccessRules { get; set; }

        /// <summary>
        /// Checks to see if the AccessRules property is set.
        /// </summary>
        internal bool IsSetAccessRules() => this.AccessRules != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bucket.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The ID of the bundle currently applied to the bucket.
        /// </para>
        ///  
        /// <para>
        /// A bucket bundle specifies the monthly cost, storage space, and data transfer quota
        /// for a bucket.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_UpdateBucketBundle.html">UpdateBucketBundle</a>
        /// action to change the bundle of a bucket.
        /// </para>
        /// </summary>
        public string BundleId { get; set; }

        /// <summary>
        /// Checks to see if the BundleId property is set.
        /// </summary>
        internal bool IsSetBundleId() => this.BundleId != null;

        /// <summary>
        /// Gets and sets the property Cors. 
        /// <para>
        /// An array of cross-origin resource sharing (CORS) rules that identify origins and the
        /// HTTP methods that can be executed on your bucket. This field is only included in the
        /// response when CORS configuration is requested or when updating CORS configuration.
        /// For more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/configure-cors.html">Configuring
        /// cross-origin resource sharing (CORS)</a>.
        /// </para>
        /// </summary>
        public BucketCorsConfig Cors { get; set; }

        /// <summary>
        /// Checks to see if the Cors property is set.
        /// </summary>
        internal bool IsSetCors() => this.Cors != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the distribution was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// An object that describes the location of the bucket, such as the Amazon Web Services
        /// Region and Availability Zone.
        /// </para>
        /// </summary>
        public ResourceLocation Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 54)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ObjectVersioning. 
        /// <para>
        /// Indicates whether object versioning is enabled for the bucket.
        /// </para>
        ///  
        /// <para>
        /// The following options can be configured:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Enabled</c> - Object versioning is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Suspended</c> - Object versioning was previously enabled but is currently suspended.
        /// Existing object versions are retained.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NeverEnabled</c> - Object versioning has never been enabled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ObjectVersioning { get; set; }

        /// <summary>
        /// Checks to see if the ObjectVersioning property is set.
        /// </summary>
        internal bool IsSetObjectVersioning() => this.ObjectVersioning != null;

        /// <summary>
        /// Gets and sets the property ReadonlyAccessAccounts. 
        /// <para>
        /// An array of strings that specify the Amazon Web Services account IDs that have read-only
        /// access to the bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> ReadonlyAccessAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReadonlyAccessAccounts property is set.
        /// </summary>
        internal bool IsSetReadonlyAccessAccounts() => this.ReadonlyAccessAccounts != null && (this.ReadonlyAccessAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type of the bucket.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property ResourcesReceivingAccess. 
        /// <para>
        /// An array of objects that describe Lightsail instances that have access to the bucket.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_SetResourceAccessForBucket.html">SetResourceAccessForBucket</a>
        /// action to update the instances that have access to a bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceReceivingAccess> ResourcesReceivingAccess { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceReceivingAccess>() : null;

        /// <summary>
        /// Checks to see if the ResourcesReceivingAccess property is set.
        /// </summary>
        internal bool IsSetResourcesReceivingAccess() => this.ResourcesReceivingAccess != null && (this.ResourcesReceivingAccess.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// An object that describes the state of the bucket.
        /// </para>
        /// </summary>
        public BucketState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code for a bucket. Include this code in your email to support when you
        /// have questions about a Lightsail bucket. This code enables our support team to look
        /// up your Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode { get; set; }

        /// <summary>
        /// Checks to see if the SupportCode property is set.
        /// </summary>
        internal bool IsSetSupportCode() => this.SupportCode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the bucket. For more information, see <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-tags">Tags
        /// in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the bucket.
        /// </para>
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
