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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
        private List<string> _accessTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdAt;
        private string _resourceShareArn;
        private string _resourceShareName;
        private string _roleArn;
        private string _s3BucketArn;
        private List<LogSourceResource> _sources = AWSConfigs.InitializeCollections ? new List<LogSourceResource>() : null;
        private string _subscriberArn;
        private string _subscriberDescription;
        private string _subscriberEndpoint;
        private string _subscriberId;
        private AwsIdentity _subscriberIdentity;
        private string _subscriberName;
        private SubscriberStatus _subscriberStatus;
        private DateTime? _updatedAt;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AccessTypes
        {
            get { return this._accessTypes; }
            set { this._accessTypes = value; }
        }

        // Check to see if AccessTypes property is set
        internal bool IsSetAccessTypes()
        {
            return this._accessTypes != null && (this._accessTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the subscriber was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

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
        public string ResourceShareArn
        {
            get { return this._resourceShareArn; }
            set { this._resourceShareArn = value; }
        }

        // Check to see if ResourceShareArn property is set
        internal bool IsSetResourceShareArn()
        {
            return this._resourceShareArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceShareName. 
        /// <para>
        /// The name of the resource share.
        /// </para>
        /// </summary>
        public string ResourceShareName
        {
            get { return this._resourceShareName; }
            set { this._resourceShareName = value; }
        }

        // Check to see if ResourceShareName property is set
        internal bool IsSetResourceShareName()
        {
            return this._resourceShareName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) specifying the role of the subscriber.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// The ARN for the Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string S3BucketArn
        {
            get { return this._s3BucketArn; }
            set { this._s3BucketArn = value; }
        }

        // Check to see if S3BucketArn property is set
        internal bool IsSetS3BucketArn()
        {
            return this._s3BucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// Amazon Security Lake supports log and event collection for natively supported Amazon
        /// Web Services services. For more information, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/source-management.html">Amazon
        /// Security Lake User Guide</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<LogSourceResource> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubscriberArn. 
        /// <para>
        /// The subscriber ARN of the Amazon Security Lake subscriber account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string SubscriberArn
        {
            get { return this._subscriberArn; }
            set { this._subscriberArn = value; }
        }

        // Check to see if SubscriberArn property is set
        internal bool IsSetSubscriberArn()
        {
            return this._subscriberArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriberDescription. 
        /// <para>
        /// The subscriber descriptions for a subscriber account. The description for a subscriber
        /// includes <c>subscriberName</c>, <c>accountID</c>, <c>externalID</c>, and <c>subscriberId</c>.
        /// </para>
        /// </summary>
        public string SubscriberDescription
        {
            get { return this._subscriberDescription; }
            set { this._subscriberDescription = value; }
        }

        // Check to see if SubscriberDescription property is set
        internal bool IsSetSubscriberDescription()
        {
            return this._subscriberDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriberEndpoint. 
        /// <para>
        /// The subscriber endpoint to which exception messages are posted.
        /// </para>
        /// </summary>
        public string SubscriberEndpoint
        {
            get { return this._subscriberEndpoint; }
            set { this._subscriberEndpoint = value; }
        }

        // Check to see if SubscriberEndpoint property is set
        internal bool IsSetSubscriberEndpoint()
        {
            return this._subscriberEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriberId. 
        /// <para>
        /// The subscriber ID of the Amazon Security Lake subscriber account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubscriberId
        {
            get { return this._subscriberId; }
            set { this._subscriberId = value; }
        }

        // Check to see if SubscriberId property is set
        internal bool IsSetSubscriberId()
        {
            return this._subscriberId != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriberIdentity. 
        /// <para>
        /// The Amazon Web Services identity used to access your data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AwsIdentity SubscriberIdentity
        {
            get { return this._subscriberIdentity; }
            set { this._subscriberIdentity = value; }
        }

        // Check to see if SubscriberIdentity property is set
        internal bool IsSetSubscriberIdentity()
        {
            return this._subscriberIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriberName. 
        /// <para>
        /// The name of your Amazon Security Lake subscriber account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubscriberName
        {
            get { return this._subscriberName; }
            set { this._subscriberName = value; }
        }

        // Check to see if SubscriberName property is set
        internal bool IsSetSubscriberName()
        {
            return this._subscriberName != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriberStatus. 
        /// <para>
        /// The subscriber status of the Amazon Security Lake subscriber account.
        /// </para>
        /// </summary>
        public SubscriberStatus SubscriberStatus
        {
            get { return this._subscriberStatus; }
            set { this._subscriberStatus = value; }
        }

        // Check to see if SubscriberStatus property is set
        internal bool IsSetSubscriberStatus()
        {
            return this._subscriberStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the subscriber was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}