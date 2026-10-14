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
    /// Container for the parameters to the CreateArchive operation. Creates an archive of
    /// events with the specified settings. When you create an archive, incoming events might
    /// not immediately start being sent to the archive. Allow a short period of time for
    /// changes to take effect. If you do not specify a pattern to filter events sent to the
    /// archive, all events are sent to the archive except replayed events. Replayed events
    /// are not sent to an archive. <important> <para> If you have specified that EventBridge
    /// use a customer managed key for encrypting the source event bus, we strongly recommend
    /// you also specify a customer managed key for any archives for the event bus as well.
    /// </para> <para> For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/encryption-archives.html">Encrypting
    /// archives</a> in the <i>Amazon EventBridge User Guide</i>. </para> </important>
    /// </summary>
    public partial class CreateArchiveRequest : AmazonEventBridgeRequest
    {
        /// <summary>
        /// Gets and sets the property ArchiveName. 
        /// <para>
        /// The name for the archive to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string ArchiveName { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveName property is set.
        /// </summary>
        internal bool IsSetArchiveName() => this.ArchiveName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventPattern. 
        /// <para>
        /// An event pattern to use to filter events sent to the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string EventPattern { get; set; }

        /// <summary>
        /// Checks to see if the EventPattern property is set.
        /// </summary>
        internal bool IsSetEventPattern() => this.EventPattern != null;

        /// <summary>
        /// Gets and sets the property EventSourceArn. 
        /// <para>
        /// The ARN of the event bus that sends events to the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string EventSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the EventSourceArn property is set.
        /// </summary>
        internal bool IsSetEventSourceArn() => this.EventSourceArn != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The identifier of the KMS customer managed key for EventBridge to use, if you choose
        /// to use a customer managed key to encrypt this archive. The identifier can be the key
        /// Amazon Resource Name (ARN), KeyId, key alias, or key alias ARN.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a customer managed key identifier, EventBridge uses an Amazon
        /// Web Services owned key to encrypt the archive.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/viewing-keys.html">Identify
        /// and view keys</a> in the <i>Key Management Service Developer Guide</i>. 
        /// </para>
        ///  <important> 
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
        /// Gets and sets the property RetentionDays. 
        /// <para>
        /// The number of days to retain events for. Default value is 0. If set to 0, events are
        /// retained indefinitely
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// Checks to see if the RetentionDays property is set.
        /// </summary>
        internal bool IsSetRetentionDays() => this.RetentionDays.HasValue;
    }
}
