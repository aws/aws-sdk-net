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

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Provides details about the Amazon Security Lake account subscription. Subscribers
    /// are notified of new objects for a source as the data is written to your Amazon S3
    /// bucket for Security Lake.
    /// </summary>
    public partial class SubscriberResource
    {
        private List<string> _accessTypes = new List<string>();
        private string _accountId;
        private DateTime? _createdAt;
        private string _externalId;
        private string _roleArn;
        private string _s3BucketArn;
        private string _snsArn;
        private List<SourceType> _sourceTypes = new List<SourceType>();
        private string _subscriberDescription;
        private string _subscriberName;
        private string _subscriptionEndpoint;
        private string _subscriptionId;
        private EndpointProtocol _subscriptionProtocol;
        private SubscriptionStatus _subscriptionStatus;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AccessTypes. 
        /// <para>
        /// You can choose to notify subscribers of new objects with an Amazon Simple Queue Service
        /// (Amazon SQS) queue or through messaging to an HTTPS endpoint provided by the subscriber.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Subscribers can consume data by directly querying Lake Formation tables in your Amazon
        /// S3 bucket through services like Amazon Athena. This subscription type is defined as
        /// <code>LAKEFORMATION</code>. 
        /// </para>
        /// </summary>
        public List<string> AccessTypes
        {
            get { return this._accessTypes; }
            set { this._accessTypes = value; }
        }

        // Check to see if AccessTypes property is set
        internal bool IsSetAccessTypes()
        {
            return this._accessTypes != null && this._accessTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID you are using to create your Amazon Security Lake
        /// account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the subscription was created. 
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID of the subscriber. The external ID lets the user that is assuming
        /// the role assert the circumstances in which they are operating. It also provides a
        /// way for the account owner to permit the role to be assumed only under specific circumstances.
        /// </para>
        /// </summary>
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
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
        /// Gets and sets the property SnsArn. 
        /// <para>
        /// The ARN for the Amazon Simple Notification Service.
        /// </para>
        /// </summary>
        public string SnsArn
        {
            get { return this._snsArn; }
            set { this._snsArn = value; }
        }

        // Check to see if SnsArn property is set
        internal bool IsSetSnsArn()
        {
            return this._snsArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTypes. 
        /// <para>
        /// Amazon Security Lake supports log and event collection for natively supported Amazon
        /// Web Services. For more information, see the Amazon Security Lake User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SourceType> SourceTypes
        {
            get { return this._sourceTypes; }
            set { this._sourceTypes = value; }
        }

        // Check to see if SourceTypes property is set
        internal bool IsSetSourceTypes()
        {
            return this._sourceTypes != null && this._sourceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubscriberDescription. 
        /// <para>
        /// The subscriber descriptions for a subscriber account. The description for a subscriber
        /// includes <code>subscriberName</code>, <code>accountID</code>, <code>externalID</code>,
        /// and <code>subscriptionId</code>.
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
        /// Gets and sets the property SubscriberName. 
        /// <para>
        /// The name of your Amazon Security Lake subscriber account.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SubscriptionEndpoint. 
        /// <para>
        /// The subscription endpoint to which exception messages are posted. 
        /// </para>
        /// </summary>
        public string SubscriptionEndpoint
        {
            get { return this._subscriptionEndpoint; }
            set { this._subscriptionEndpoint = value; }
        }

        // Check to see if SubscriptionEndpoint property is set
        internal bool IsSetSubscriptionEndpoint()
        {
            return this._subscriptionEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The subscription ID of the Amazon Security Lake subscriber account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }

        // Check to see if SubscriptionId property is set
        internal bool IsSetSubscriptionId()
        {
            return this._subscriptionId != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionProtocol. 
        /// <para>
        /// The subscription protocol to which exception messages are posted. 
        /// </para>
        /// </summary>
        public EndpointProtocol SubscriptionProtocol
        {
            get { return this._subscriptionProtocol; }
            set { this._subscriptionProtocol = value; }
        }

        // Check to see if SubscriptionProtocol property is set
        internal bool IsSetSubscriptionProtocol()
        {
            return this._subscriptionProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionStatus. 
        /// <para>
        /// The subscription status of the Amazon Security Lake subscriber account.
        /// </para>
        /// </summary>
        public SubscriptionStatus SubscriptionStatus
        {
            get { return this._subscriptionStatus; }
            set { this._subscriptionStatus = value; }
        }

        // Check to see if SubscriptionStatus property is set
        internal bool IsSetSubscriptionStatus()
        {
            return this._subscriptionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the subscription was created. 
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}