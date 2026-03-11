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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
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
namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Container for the parameters to the StartMedicalScribeListeningSession operation.
    /// Starts a new Medical Scribe listening session for real-time audio transcription
    /// </summary>
    public partial class StartMedicalScribeListeningSessionRequest : AmazonConnectHealthRequest
    {
        private string _domainId;
        private MedicalScribeLanguageCode _languageCode;
        private MedicalScribeMediaEncoding _mediaEncoding;
        private int? _mediaSampleRateHertz;
        private string _sessionId;
        private string _subscriptionId;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The Domain identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=25)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property InputStreamPublisher.
        /// <para>
        /// The Func set for this property by the consumer of the SDK is used to stream events into the service. Consumers
        /// provide a Func that the SDK will continue to call to get events to send. When the consumer is done streaming
        /// events to the service the Func can return null to stop the SDK calling the Func for new events. The Func must
        /// return an event known by the service which can be identified by implementing the IMedicalScribeInputStreamEvent
        /// interface. The known implementatons in the SDK for this interface are:
        /// <list type="bullet">
        ///   <item><term><see cref="MedicalScribeAudioEvent"/></term></item>
        ///   <item><term><see cref="MedicalScribeConfigurationEvent"/></term></item>
        ///   <item><term><see cref="MedicalScribeSessionControlEvent"/></term></item>
        /// </list>
        /// </para>
        /// 
        /// </summary>
        public  Func<System.Threading.Tasks.Task<IMedicalScribeInputStreamEvent>> InputStreamPublisher { get; set; }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The Language Code for the audio in the session
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MedicalScribeLanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property MediaEncoding. 
        /// <para>
        /// The encoding for the input audio
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MedicalScribeMediaEncoding MediaEncoding
        {
            get { return this._mediaEncoding; }
            set { this._mediaEncoding = value; }
        }

        // Check to see if MediaEncoding property is set
        internal bool IsSetMediaEncoding()
        {
            return this._mediaEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property MediaSampleRateHertz. 
        /// <para>
        /// The sample rate of the input audio
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8000, Max=48000)]
        public int? MediaSampleRateHertz
        {
            get { return this._mediaSampleRateHertz; }
            set { this._mediaSampleRateHertz = value; }
        }

        // Check to see if MediaSampleRateHertz property is set
        internal bool IsSetMediaSampleRateHertz()
        {
            return this._mediaSampleRateHertz.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The Session identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The Subscription identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=25, Max=25)]
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

    }
}