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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the StartContactConversationalAnalyticsJob operation.
    /// Starts a Contact Lens post-call analytics job for the specified contact. This API
    /// runs Conversational Analytics post-contact analysis on a voice recording that is already
    /// attached to the contact, generating transcription, sentiment analysis, redaction,
    /// and summarization results based on the provided configuration.
    /// 
    ///  <important> 
    /// <para>
    /// A voice recording must already be attached to the contact before calling this API.
    /// Use <c>CreateAttachedFile</c> to attach a recording from an S3 source URI.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// For example, you can call <c>CreateContact</c>, then <c>CreateAttachedFile</c>, then
    /// <c>StartContactConversationalAnalyticsJob</c> to create a contact, attach a recording,
    /// and run post-call analytics.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class StartContactConversationalAnalyticsJobRequest : AmazonConnectRequest
    {
        private AnalyticsConfiguration _analyticsConfiguration;
        private List<string> _analyticsModes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientToken;
        private string _contactId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property AnalyticsConfiguration. 
        /// <para>
        /// The configuration for the conversational analytics job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalyticsConfiguration AnalyticsConfiguration
        {
            get { return this._analyticsConfiguration; }
            set { this._analyticsConfiguration = value; }
        }

        // Check to see if AnalyticsConfiguration property is set
        internal bool IsSetAnalyticsConfiguration()
        {
            return this._analyticsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AnalyticsModes. 
        /// <para>
        /// The analytics modes to run for the contact. Valid values: <c>PostContact</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AnalyticsModes
        {
            get { return this._analyticsModes; }
            set { this._analyticsModes = value; }
        }

        // Check to see if AnalyticsModes property is set
        internal bool IsSetAnalyticsModes()
        {
            return this._analyticsModes != null && (this._analyticsModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Connect Customer. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}