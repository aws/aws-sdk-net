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

namespace Amazon.Ivschat.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRoom operation. Updates a room’s configuration.
    /// </summary>
    public partial class UpdateRoomRequest : AmazonIvschatRequest
    {
        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Identifier of the room to be updated. Currently this must be an ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property LoggingConfigurationIdentifiers. 
        /// <para>
        /// Array of logging-configuration identifiers attached to the room.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> LoggingConfigurationIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LoggingConfigurationIdentifiers property is set.
        /// </summary>
        internal bool IsSetLoggingConfigurationIdentifiers() => this.LoggingConfigurationIdentifiers != null && (this.LoggingConfigurationIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaximumMessageLength. 
        /// <para>
        /// The maximum number of characters in a single message. Messages are expected to be
        /// UTF-8 encoded and this limit applies specifically to rune/code-point count, not number
        /// of bytes. Default: 500.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaximumMessageLength { get; set; }

        /// <summary>
        /// Checks to see if the MaximumMessageLength property is set.
        /// </summary>
        internal bool IsSetMaximumMessageLength() => this.MaximumMessageLength.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumMessageRatePerSecond. 
        /// <para>
        /// Maximum number of messages per second that can be sent to the room (by all clients).
        /// Default: 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaximumMessageRatePerSecond { get; set; }

        /// <summary>
        /// Checks to see if the MaximumMessageRatePerSecond property is set.
        /// </summary>
        internal bool IsSetMaximumMessageRatePerSecond() => this.MaximumMessageRatePerSecond.HasValue;

        /// <summary>
        /// Gets and sets the property MessageReviewHandler. 
        /// <para>
        /// Configuration information for optional review of messages. Specify an empty <c>uri</c>
        /// string to disassociate a message review handler from the specified room.
        /// </para>
        /// </summary>
        public MessageReviewHandler MessageReviewHandler { get; set; }

        /// <summary>
        /// Checks to see if the MessageReviewHandler property is set.
        /// </summary>
        internal bool IsSetMessageReviewHandler() => this.MessageReviewHandler != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Room name. The value does not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
