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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSubscriber operation. Updates a subscriber.
    /// Fields omitted from the request are left unchanged. Changing an Amazon MSK subscriber's
    /// connectivity can re-provision it; when it does, the subscriber resumes delivering
    /// once its ConnectivityState returns to ACTIVE (see the MskSubscriberActive waiter).
    /// </summary>
    public partial class UpdateSubscriberRequest : AmazonEventBridgeV2Request
    {
        /// <summary>
        /// Gets and sets the property BatchConfiguration. 
        /// <para>
        /// Batching configuration for a subscriber.
        /// </para>
        /// </summary>
        public BatchConfiguration BatchConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BatchConfiguration property is set.
        /// </summary>
        internal bool IsSetBatchConfiguration() => this.BatchConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Free-text description. Used by every resource type that has one: event buses, subscribers,
        /// and event sources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FilterConfiguration. 
        /// <para>
        /// Configuration for filtering events delivered to a subscriber. On CreateSubscriber,
        /// Filters is required and must contain at least one Filter with a non-empty Pattern.
        /// On UpdateSubscriber, an empty <c>FilterConfiguration:{}</c> clears the existing filter.
        /// Any non-empty shape (including <c>{Language:X}</c> without Filters) must contain a
        /// valid Filters list — same contract as CreateSubscriber. A non-empty Filters list overwrites;
        /// an omitted FilterConfiguration preserves existing state. All Filters are implicitly
        /// ANDed — an event must match every Filter to be delivered.
        /// </para>
        /// </summary>
        public FilterConfiguration FilterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FilterConfiguration property is set.
        /// </summary>
        internal bool IsSetFilterConfiguration() => this.FilterConfiguration != null;

        /// <summary>
        /// Gets and sets the property InvokeConfiguration. 
        /// <para>
        /// Update-able configuration for how the subscriber invokes its target.
        /// </para>
        /// </summary>
        public UpdateInvokeConfiguration InvokeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InvokeConfiguration property is set.
        /// </summary>
        internal bool IsSetInvokeConfiguration() => this.InvokeConfiguration != null;

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// Log configuration for a subscriber.
        /// </para>
        /// </summary>
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property OnFailureConfiguration. 
        /// <para>
        /// On-failure configuration: where a failed delivery is sent. Shared by the subscriber
        /// and the EventSource.
        /// </para>
        /// </summary>
        public OnFailureConfiguration OnFailureConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OnFailureConfiguration property is set.
        /// </summary>
        internal bool IsSetOnFailureConfiguration() => this.OnFailureConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResumePosition. 
        /// <para>
        /// Position from which delivery resumes when a subscriber is unpaused. Honored only on
        /// an UpdateSubscriber call that transitions State from STOPPED to RUNNING (unpause);
        /// ignored on any other call and not accepted on Create. Defaults to LAST_PROCESSED when
        /// omitted.
        /// </para>
        /// </summary>
        public ResumePosition ResumePosition { get; set; }

        /// <summary>
        /// Checks to see if the ResumePosition property is set.
        /// </summary>
        internal bool IsSetResumePosition() => this.ResumePosition != null;

        /// <summary>
        /// Gets and sets the property RetryPolicy. 
        /// <para>
        /// Retry policy for a subscriber.
        /// </para>
        /// </summary>
        public RetryPolicy RetryPolicy { get; set; }

        /// <summary>
        /// Checks to see if the RetryPolicy property is set.
        /// </summary>
        internal bool IsSetRetryPolicy() => this.RetryPolicy != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Customer-controlled run state of a subscriber, set on create or update. Distinct from
        /// the bus lifecycle vocabulary, where ACTIVE means "provisioned and healthy". Delivery
        /// requires State RUNNING on a subscriber that is not revoked.
        /// </para>
        /// </summary>
        public SubscriberState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SubscriberArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies a subscriber.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string SubscriberArn { get; set; }

        /// <summary>
        /// Checks to see if the SubscriberArn property is set.
        /// </summary>
        internal bool IsSetSubscriberArn() => this.SubscriberArn != null;

        /// <summary>
        /// Gets and sets the property Transformer. 
        /// <para>
        /// Transformer configuration for a subscriber.
        /// </para>
        /// </summary>
        public Transformer Transformer { get; set; }

        /// <summary>
        /// Checks to see if the Transformer property is set.
        /// </summary>
        internal bool IsSetTransformer() => this.Transformer != null;
    }
}
