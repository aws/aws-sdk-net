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

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Provides details about the Amazon Security Lake account subscription. Subscribers
    /// are notified of new objects for a source as the data is written to your Amazon S3
    /// bucket for Security Lake.
    /// </summary>
    public partial class SubscriberResource
    {
        /// <summary>
        /// Gets and sets the property AccessTypes. 
        /// <para>
        /// You can choose to notify subscribers of new objects with an Amazon Simple Queue Service
        /// (Amazon SQS) queue or through messaging to an HTTPS endpoint provided by the subscriber.
        /// </para>
        ///  
        /// <para>
        ///  Subscribers can consume data by directly querying Lake Formation tables in your Amazon
        /// S3 bucket through services like Amazon Athena. This subscription type is defined as
        /// <c>LAKEFORMATION</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AccessTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccessTypes property is set.
        /// </summary>
        internal bool IsSetAccessTypes() => this.AccessTypes != null && (this.AccessTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the subscriber was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceShareArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) which uniquely defines the Amazon Web Services RAM
        /// resource share. Before accepting the RAM resource share invitation, you can view details
        /// related to the RAM resource share.
        /// </para>
        ///  
        /// <para>
        /// This field is available only for Lake Formation subscribers created after March 8,
        /// 2023.
        /// </para>
        /// </summary>
        public string ResourceShareArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceShareArn property is set.
        /// </summary>
        internal bool IsSetResourceShareArn() => this.ResourceShareArn != null;

        /// <summary>
        /// Gets and sets the property ResourceShareName. 
        /// <para>
        /// The name of the resource share.
        /// </para>
        /// </summary>
        public string ResourceShareName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceShareName property is set.
        /// </summary>
        internal bool IsSetResourceShareName() => this.ResourceShareName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) specifying the role of the subscriber.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// The ARN for the Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string S3BucketArn { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketArn property is set.
        /// </summary>
        internal bool IsSetS3BucketArn() => this.S3BucketArn != null;

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// Amazon Security Lake supports log and event collection for natively supported Amazon
        /// Web Services services. For more information, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/source-management.html">Amazon
        /// Security Lake User Guide</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<LogSourceResource> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<LogSourceResource>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubscriberArn. 
        /// <para>
        /// The subscriber ARN of the Amazon Security Lake subscriber account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string SubscriberArn { get; set; }

        /// <summary>
        /// Checks to see if the SubscriberArn property is set.
        /// </summary>
        internal bool IsSetSubscriberArn() => this.SubscriberArn != null;

        /// <summary>
        /// Gets and sets the property SubscriberDescription. 
        /// <para>
        /// The subscriber descriptions for a subscriber account. The description for a subscriber
        /// includes <c>subscriberName</c>, <c>accountID</c>, <c>externalID</c>, and <c>subscriberId</c>.
        /// </para>
        /// </summary>
        public string SubscriberDescription { get; set; }

        /// <summary>
        /// Checks to see if the SubscriberDescription property is set.
        /// </summary>
        internal bool IsSetSubscriberDescription() => this.SubscriberDescription != null;

        /// <summary>
        /// Gets and sets the property SubscriberEndpoint. 
        /// <para>
        /// The subscriber endpoint to which exception messages are posted.
        /// </para>
        /// </summary>
        public string SubscriberEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the SubscriberEndpoint property is set.
        /// </summary>
        internal bool IsSetSubscriberEndpoint() => this.SubscriberEndpoint != null;

        /// <summary>
        /// Gets and sets the property SubscriberId. 
        /// <para>
        /// The subscriber ID of the Amazon Security Lake subscriber account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubscriberId { get; set; }

        /// <summary>
        /// Checks to see if the SubscriberId property is set.
        /// </summary>
        internal bool IsSetSubscriberId() => this.SubscriberId != null;

        /// <summary>
        /// Gets and sets the property SubscriberIdentity. 
        /// <para>
        /// The Amazon Web Services identity used to access your data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AwsIdentity SubscriberIdentity { get; set; }

        /// <summary>
        /// Checks to see if the SubscriberIdentity property is set.
        /// </summary>
        internal bool IsSetSubscriberIdentity() => this.SubscriberIdentity != null;

        /// <summary>
        /// Gets and sets the property SubscriberName. 
        /// <para>
        /// The name of your Amazon Security Lake subscriber account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubscriberName { get; set; }

        /// <summary>
        /// Checks to see if the SubscriberName property is set.
        /// </summary>
        internal bool IsSetSubscriberName() => this.SubscriberName != null;

        /// <summary>
        /// Gets and sets the property SubscriberStatus. 
        /// <para>
        /// The subscriber status of the Amazon Security Lake subscriber account.
        /// </para>
        /// </summary>
        public SubscriberStatus SubscriberStatus { get; set; }

        /// <summary>
        /// Checks to see if the SubscriberStatus property is set.
        /// </summary>
        internal bool IsSetSubscriberStatus() => this.SubscriberStatus != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the subscriber was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
