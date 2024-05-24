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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
    /// Container for the parameters to the CreateEventBus operation.
    /// Creates a new event bus within your account. This can be a custom event bus which
    /// you can use to receive events from your custom applications and services, or it can
    /// be a partner event bus which can be matched to a partner event source.
    /// </summary>
    public partial class CreateEventBusRequest : AmazonEventBridgeRequest
    {
        private DeadLetterConfig _deadLetterConfig;
        private string _description;
        private string _eventSourceName;
        private string _kmsKeyIdentifier;
        private string _name;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DeadLetterConfig.
        /// </summary>
        public DeadLetterConfig DeadLetterConfig
        {
            get { return this._deadLetterConfig; }
            set { this._deadLetterConfig = value; }
        }

        // Check to see if DeadLetterConfig property is set
        internal bool IsSetDeadLetterConfig()
        {
            return this._deadLetterConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The event bus description.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EventSourceName. 
        /// <para>
        /// If you are creating a partner event bus, this specifies the partner event source that
        /// the new event bus will be matched with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string EventSourceName
        {
            get { return this._eventSourceName; }
            set { this._eventSourceName = value; }
        }

        // Check to see if EventSourceName property is set
        internal bool IsSetEventSourceName()
        {
            return this._eventSourceName != null;
        }

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
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/getting-started.html">Managing
        /// keys</a> in the <i>Key Management Service Developer Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Archives and schema discovery are not supported for event buses encrypted using a
        /// customer managed key. EventBridge returns an error if:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You call <c> <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_CreateArchive.html">CreateArchive</a>
        /// </c> on an event bus set to use a customer managed key for encryption.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You call <c> <a href="https://docs.aws.amazon.com/eventbridge/latest/schema-reference/v1-discoverers.html#CreateDiscoverer">CreateDiscoverer</a>
        /// </c> on an event bus set to use a customer managed key for encryption.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You call <c> <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_UpdatedEventBus.html">UpdatedEventBus</a>
        /// </c> to set a customer managed key on an event bus with an archives or schema discovery
        /// enabled.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To enable archives or schema discovery on an event bus, choose to use an Amazon Web
        /// Services owned key. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-encryption.html">Data
        /// encryption in EventBridge</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string KmsKeyIdentifier
        {
            get { return this._kmsKeyIdentifier; }
            set { this._kmsKeyIdentifier = value; }
        }

        // Check to see if KmsKeyIdentifier property is set
        internal bool IsSetKmsKeyIdentifier()
        {
            return this._kmsKeyIdentifier != null;
        }

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
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the event bus.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}