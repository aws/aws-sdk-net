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

namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// The initial event sent from the application to Amazon Lex V2 to configure the conversation,
    /// including session and request attributes and the response content type.
    /// </summary>
    public partial class ConfigurationEvent : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property ClientTimestampMillis. 
        /// <para>
        /// A timestamp set by the client of the date and time that the event was sent to Amazon
        /// Lex V2.
        /// </para>
        /// </summary>
        public long? ClientTimestampMillis { get; set; }

        /// <summary>
        /// Checks to see if the ClientTimestampMillis property is set.
        /// </summary>
        internal bool IsSetClientTimestampMillis() => this.ClientTimestampMillis.HasValue;

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
        public bool? DisablePlayback { get; set; }

        /// <summary>
        /// Checks to see if the DisablePlayback property is set.
        /// </summary>
        internal bool IsSetDisablePlayback() => this.DisablePlayback.HasValue;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// A unique identifier that your application assigns to the event. You can use this to
        /// identify events in logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 100)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> RequestAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RequestAttributes property is set.
        /// </summary>
        internal bool IsSetRequestAttributes() => this.RequestAttributes != null && (this.RequestAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true, Min = 1)]
        public string ResponseContentType { get; set; }

        /// <summary>
        /// Checks to see if the ResponseContentType property is set.
        /// </summary>
        internal bool IsSetResponseContentType() => this.ResponseContentType != null;

        /// <summary>
        /// Gets and sets the property SessionStateValue.
        /// </summary>
        public SessionState SessionStateValue { get; set; }

        /// <summary>
        /// Checks to see if the SessionStateValue property is set.
        /// </summary>
        internal bool IsSetSessionStateValue() => this.SessionStateValue != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<Message> WelcomeMessages { get; set; } = AWSConfigs.InitializeCollections ? new List<Message>() : null;

        /// <summary>
        /// Checks to see if the WelcomeMessages property is set.
        /// </summary>
        internal bool IsSetWelcomeMessages() => this.WelcomeMessages != null && (this.WelcomeMessages.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
