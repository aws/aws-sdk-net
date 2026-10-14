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

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEventBus operation. Creates a new event
    /// bus within your account. This can be a custom event bus which you can use to receive
    /// events from your custom applications and services, or it can be a partner event bus
    /// which can be matched to a partner event source.
    /// </summary>
    public partial class CreateEventBusRequest : AmazonEventBridgeRequest
    {
        /// <summary>
        /// Gets and sets the property DeadLetterConfig.
        /// </summary>
        public DeadLetterConfig DeadLetterConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeadLetterConfig property is set.
        /// </summary>
        internal bool IsSetDeadLetterConfig() => this.DeadLetterConfig != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The event bus description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventSourceName. 
        /// <para>
        /// If you are creating a partner event bus, this specifies the partner event source that
        /// the new event bus will be matched with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string EventSourceName { get; set; }

        /// <summary>
        /// Checks to see if the EventSourceName property is set.
        /// </summary>
        internal bool IsSetEventSourceName() => this.EventSourceName != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The identifier of the KMS customer managed key for EventBridge to use, if you choose
        /// to use a customer managed key to encrypt events on this event bus. The identifier
        /// can be the key Amazon Resource Name (ARN), KeyId, key alias, or key alias ARN.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a customer managed key identifier, EventBridge uses an Amazon
        /// Web Services owned key to encrypt events on the event bus.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/viewing-keys.html">Identify
        /// and view keys</a> in the <i>Key Management Service Developer Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Schema discovery is not supported for event buses encrypted using a customer managed
        /// key. EventBridge returns an error if: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You call <c> <a href="https://docs.aws.amazon.com/eventbridge/latest/schema-reference/v1-discoverers.html#CreateDiscoverer">CreateDiscoverer</a>
        /// </c> on an event bus set to use a customer managed key for encryption.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You call <c> <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_UpdatedEventBus.html">UpdatedEventBus</a>
        /// </c> to set a customer managed key on an event bus with schema discovery enabled.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To enable schema discovery on an event bus, choose to use an Amazon Web Services owned
        /// key. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-encryption-event-bus-cmkey.html">Encrypting
        /// events</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// If you have specified that EventBridge use a customer managed key for encrypting the
        /// source event bus, we strongly recommend you also specify a customer managed key for
        /// any archives for the event bus as well. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/encryption-archives.html">Encrypting
        /// archives</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property LogConfig. 
        /// <para>
        /// The logging configuration settings for the event bus.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-event-bus-logs.html">Configuring
        /// logs for event buses</a> in the <i>EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        public LogConfig LogConfig { get; set; }

        /// <summary>
        /// Checks to see if the LogConfig property is set.
        /// </summary>
        internal bool IsSetLogConfig() => this.LogConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new event bus. 
        /// </para>
        ///  
        /// <para>
        /// Custom event bus names can't contain the <c>/</c> character, but you can use the <c>/</c>
        /// character in partner event bus names. In addition, for partner event buses, the name
        /// must exactly match the name of the partner event source that this event bus is matched
        /// to.
        /// </para>
        ///  
        /// <para>
        /// You can't use the name <c>default</c> for a custom event bus, as this name is already
        /// used for your account's default event bus.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the event bus.
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
    }
}
