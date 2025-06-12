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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.LexRuntimeV2.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// The initial event sent from the application to Amazon Lex V2 to configure the conversation,
    /// including session and request attributes and the response content type.
    /// </summary>
    public partial class ConfigurationEvent
        : IEventStreamEvent
    {
        private long? _clientTimestampMillis;
        private bool? _disablePlayback;
        private string _eventId;
        private Dictionary<string, string> _requestAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _responseContentType;
        private SessionState _sessionStateValue;
        private List<Message> _welcomeMessages = AWSConfigs.InitializeCollections ? new List<Message>() : null;

        /// <summary>
        /// Gets and sets the property ClientTimestampMillis. 
        /// <para>
        /// A timestamp set by the client of the date and time that the event was sent to Amazon
        /// Lex V2.
        /// </para>
        /// </summary>
        public long? ClientTimestampMillis
        {
            get { return this._clientTimestampMillis; }
            set { this._clientTimestampMillis = value; }
        }

        // Check to see if ClientTimestampMillis property is set
        internal bool IsSetClientTimestampMillis()
        {
            return this._clientTimestampMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisablePlayback. 
        /// <para>
        /// Determines whether Amazon Lex V2 should send audio responses to the client application.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Set this field to false when the client is operating in a playback mode where audio
        /// responses are played to the user. If the client isn't operating in playback mode,
        /// such as a text chat application, set this to true so that Amazon Lex V2 doesn't wait
        /// for the prompt to finish playing on the client.
        /// </para>
        /// </summary>
        public bool? DisablePlayback
        {
            get { return this._disablePlayback; }
            set { this._disablePlayback = value; }
        }

        // Check to see if DisablePlayback property is set
        internal bool IsSetDisablePlayback()
        {
            return this._disablePlayback.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// A unique identifier that your application assigns to the event. You can use this to
        /// identify events in logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestAttributes. 
        /// <para>
        /// Request-specific information passed between the client application and Amazon Lex
        /// V2.
        /// </para>
        ///  
        /// <para>
        /// The namespace <c>x-amz-lex:</c> is reserved for special attributes. Don't create any
        /// request attributes for prefix <c>x-amz-lex:</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequestAttributes
        {
            get { return this._requestAttributes; }
            set { this._requestAttributes = value; }
        }

        // Check to see if RequestAttributes property is set
        internal bool IsSetRequestAttributes()
        {
            return this._requestAttributes != null && (this._requestAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResponseContentType. 
        /// <para>
        /// The message that Amazon Lex V2 returns in the response can be either text or speech
        /// based on the <c>responseContentType</c> value.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the value is <c>text/plain;charset=utf-8</c>, Amazon Lex V2 returns text in the
        /// response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value begins with <c>audio/</c>, Amazon Lex V2 returns speech in the response.
        /// Amazon Lex V2 uses Amazon Polly to generate the speech using the configuration that
        /// you specified in the <c>requestContentType</c> parameter. For example, if you specify
        /// <c>audio/mpeg</c> as the value, Amazon Lex V2 returns speech in the MPEG format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value is <c>audio/pcm</c>, the speech returned is audio/pcm in 16-bit, little-endian
        /// format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The following are the accepted values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// audio/mpeg
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// audio/ogg
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// audio/pcm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// audio/* (defaults to mpeg)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// text/plain; charset=utf-8
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ResponseContentType
        {
            get { return this._responseContentType; }
            set { this._responseContentType = value; }
        }

        // Check to see if ResponseContentType property is set
        internal bool IsSetResponseContentType()
        {
            return this._responseContentType != null;
        }

        /// <summary>
        /// Gets and sets the property SessionStateValue.
        /// </summary>
        public SessionState SessionStateValue
        {
            get { return this._sessionStateValue; }
            set { this._sessionStateValue = value; }
        }

        // Check to see if SessionStateValue property is set
        internal bool IsSetSessionStateValue()
        {
            return this._sessionStateValue != null;
        }

        /// <summary>
        /// Gets and sets the property WelcomeMessages. 
        /// <para>
        /// A list of messages to send to the user.
        /// </para>
        ///  
        /// <para>
        /// If you set the <c>welcomeMessage</c> field, you must also set the <a href="https://docs.aws.amazon.com/lexv2/latest/dg/API_runtime_DialogAction.html">
        /// <c>DialogAction</c> </a> structure's <a href="https://docs.aws.amazon.com/lexv2/latest/dg/API_runtime_DialogAction.html#lexv2-Type-runtime_DialogAction-type">
        /// <c>type</c> </a> field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<Message> WelcomeMessages
        {
            get { return this._welcomeMessages; }
            set { this._welcomeMessages = value; }
        }

        // Check to see if WelcomeMessages property is set
        internal bool IsSetWelcomeMessages()
        {
            return this._welcomeMessages != null && (this._welcomeMessages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}