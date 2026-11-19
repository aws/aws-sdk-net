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

namespace Amazon.OpenSearchMemory.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetEvent operation. Gets up to 10 events
    /// by ID, each as <c>GetEvent</c> returns it, including its payload. <para> If you supply
    /// <c>actorId</c> or <c>sessionId</c>, every requested event must match it. Each event
    /// has its own outcome. The operation reports an event that it can't return in <c>errors</c>
    /// instead of failing, with an error code named for the exception that <c>GetEvent</c>
    /// would return for it. The operation reports both an event that doesn't exist and an
    /// event outside the supplied scope as <c>RESOURCE_NOT_FOUND</c>. </para> <para> The
    /// exception is the space's customer managed AWS KMS key: if it is disabled, pending
    /// deletion, can't be used for decryption, or was deleted, the whole call fails with
    /// <c>ValidationException</c>, as <c>GetEvent</c> does. </para>
    /// </summary>
    public partial class BatchGetEventRequest : AmazonOpenSearchMemoryRequest
    {
        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The actor that every requested event must belong to. Omit it to skip this check. The
        /// operation reports an event that doesn't match in <c>errors</c> as <c>RESOURCE_NOT_FOUND</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ActorId { get; set; }

        /// <summary>
        /// Checks to see if the ActorId property is set.
        /// </summary>
        internal bool IsSetActorId() => this.ActorId != null;

        /// <summary>
        /// Gets and sets the property EventIds. 
        /// <para>
        /// The IDs of the events to get: 1 to 10, without duplicates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> EventIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EventIds property is set.
        /// </summary>
        internal bool IsSetEventIds() => this.EventIds != null && (this.EventIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session that every requested event must belong to. Omit it to skip this check.
        /// The operation reports an event that doesn't match in <c>errors</c> as <c>RESOURCE_NOT_FOUND</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The ID of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;
    }
}
